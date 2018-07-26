/*URL MANAGER TO CHANGE BETWEEN LOCALHOST AND SERVER DOMAIN TO ALL AJAX REQUEST.
CUSTOM SCRIPT TO SalesSys Project

LIST OF VIEWS WITH AJAX REQUEST MUST BE ALWAYS UPDATED:
==================================================================================
Controller Name -------- View Name

Product --------------- Index.cshtml
===================================================================================

*/


function getURL()
{
	//Production URL
	//return "http://www.myshop.com.br/SalesSys";
	//Developmente URL
	return "localhost:49990"; 
}