'Declare variables
Dim objRequest
Dim URL

Set objRequest = CreateObject("Microsoft.XMLHTTP")

'Put together the URL link appending the Variables.
URL = "http://localhost/AltioStarHR/NotificationHandler.ashx"

'Open the HTTP request and pass the URL to the objRequest object
objRequest.open "POST", URL , false

'Send the HTML Request
objRequest.Send

'Set the object to nothing
Set objRequest = Nothing