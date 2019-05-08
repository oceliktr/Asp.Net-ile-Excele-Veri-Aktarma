<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Export Data to Excel</title>
    <style>
        table {
            border-collapse: collapse;
            width: 500px;
        }

        th, td {
            text-align: left;
            padding: 8px;
        }
        .td {
            text-align: center;
            padding: 18px;
            font-size: 25px;
            font-weight: bold;
        }
        tr:nth-child(even){background-color: #f2f2f2}

        th {
            background-color: #4CAF50;
            color: white;
        }

        .button {
            color: #FFFFFF;
            background-color: #4CAF50;
            display: inline-block;
            padding: 10px 16px;
            border: 0;
            margin-top: 20px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <table>
        <tr>
            <td colspan="5" class="td">KURTULUŞ ORTAOKULU</td>
        </tr><tr>
            <th>Adı</th>
            <th>Soyadı</th>
            <th>Cinsiyet</th>
            <th>Sınıfı</th>
            <th>No</th>
        </tr>
        <asp:Repeater runat="server" ID="rptOgrenciler">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Adi") %></td>
                    <td><%#Eval("Soyadi") %></td>
                    <td><%#Eval("Cinsiyeti") %></td>
                    <td><%#Eval("Sinifi") %></td>
                    <td><%#Eval("Numarasi") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <asp:Button ID="btnExportDatatoExcel" runat="server" Text="Excele Aktar" CssClass="button" OnClick="btnExportDatatoExcel_OnClick"/>
</form>
</body>
</html>
