/*
 * using Google JS Style Code
 * adding wrapper function();
 * 01. added declarations with var 
 * 02. changing "string" with 'string'
 * 03. renaming  functions, example: PopTip(); with functionNamesLikeThis();
 * 04. adding ';' where's needed
 * 05. changing "==" with "==="
 * 06. removing eval(); because it should be use only for serelazation
 * 07. replacing document.layers and document.all as they are obsolut
 *	we use document.getElementById(); instead
*/
function doSomething() {
	"use strict";
	var browserName = navigator.appName;
	var addScroll = false;

	if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
		addScroll = true;
	}

	var pointX = 0;
	var pointY = 0;

	document.onmousemove = mouseMove;
	if (browserName === 'Netscape') {
		document.captureEvents(Event.MOUSEMOVE);
	}

	function mouseMove(evn) {
		if (browserName === 'Netscape') {
			pointX = evn.pageX - 5;
			pointY = evn.pageY;
		} else {
			pointX = event.x - 5;
			pointY = event.y;
		}
		if (browserName === 'Netscape') {
			if (document.getElementById('ToolTip').visibility === 'show') {
				popTip();
			}
		} else {
			if (document.getElementById('ToolTip').style.visibility === 'visible') {
				popTip();
			}
		}
	}
	function popTip() {
		if (browserName === 'Netscape') {
			theLayer = document.getElementById('ToolTip');
			if ((pointX + 120) > window.innerWidth) {
				pointX = window.innerWidth - 150;
			}
			theLayer.left = pointX + 10;
			theLayer.top = pointY + 15;
			theLayer.visibility = 'show';
		} else {
			theLayer = document.getElementById('ToolTip');
			if (theLayer) {
				pointX = event.x - 5;
				pointY = event.y;
				if (addScroll) {
					pointX = pointX + document.body.scrollLeft;
					pointY = pointY + document.body.scrollTop;
				}
				if ((pointX + 120) > document.body.clientWidth) {
					pointX = pointX - 150;
				}
				theLayer.style.pixelLeft = pointX + 10;
				theLayer.style.pixelTop = pointY + 15;
				theLayer.style.visibility = 'visible';
			}
		}
	}
	function hideTip() {
		args = hideTip.arguments;
		if (browserName === 'Netscape') {
			document.getElementById('ToolTip').visibility = 'hide';
		} else {
			document.getElementById('ToolTip').style.visibility = 'hidden';
		}
	}
	function hideMenu1() {
		if (browserName === 'Netscape') {
			document.getElementById('menu1').visibility = 'hide';
		} else {
			document.getElementById('menu1').style.visibility = 'hidden';
		}
	}

	function showMenu1() {
		if (browserName === 'Netscape') {
			theLayer = document.getElementById('menu1');
			theLayer.visibility = 'show';
		} else {
			theLayer = document.getElementById('menu1');
			theLayer.style.visibility = 'visible';
		}
	} 

	function hideMenu2() {
		if (browserName === 'Netscape') {
			document.getElementById('menu2').visibility = 'hide';
		} else {
			document.getElementById('menu2').style.visibility = 'hidden';
		}
	}
	function showMenu2() {
		if (browserName === 'Netscape') {
			theLayer = document.getElementById('menu2');
			theLayer.visibility = 'show';
		} else {
			theLayer = document.getElementById('menu2');
			theLayer.style.visibility = 'visible';
		}
	} // izvAnostata :D
}