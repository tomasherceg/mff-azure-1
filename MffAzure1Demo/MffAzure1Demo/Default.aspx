<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MffAzure1Demo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hello from Azure!!!</h1>
        <p><%= ConfigurationManager.AppSettings["MySettingValue"] %></p>
        
        <p>New awesome feature!!!</p>
        
        <p>Stage first!!!</p>
    </div>
    </form>
</body>
</html>
