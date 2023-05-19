<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="saml_test.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <label for="RelayState">Relay State:</label><br/>
          <input type="text" id="RelayState" name="RelayState"/><br/>
          <label for="SAMLResponse">SAML Reponse:</label><br/>
          <textarea type="text" id="SAMLResponse" name="SAMLResponse" rows="25" cols="80"></textarea> <br/><br/>
          <input type="submit" value="Submit"/>
    </form>
</body>
</html>
