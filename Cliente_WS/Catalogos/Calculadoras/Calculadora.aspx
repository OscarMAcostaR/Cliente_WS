<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Cliente_WS.Catalogos.Calculadoras.Calculadora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div  class="container">
        <div class="row text-center">
            <div class="col-4">
                <asp:Label ID="lbla" runat="server" Text="Numero 1"></asp:Label>
                <asp:TextBox ID="txta" runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <br />
            <div class="col-4">
                <asp:TextBox ID="txtb" runat="server" TextMode="Number"></asp:TextBox>

            </div>

            <dic class="row text-center">
                <asp:Button ID="btnSumar" runat="server" Text="+" OnClick="btnSumar_Click" />

                <asp:Button ID="btnRestar" runat="server" Text="-" OnClick="btnRestar_Click" />

                <asp:Button ID="btnMUltiplcar" runat="server" Text="+" OnClick="btnMUltiplcar_Click" />
                <asp:Button ID="btnDividir" runat="server" Text="+" OnClick="btnDividir_Click" />
            </dic>
            
            <div class="row">
                <div class="text-center">
                    <asp:Label ID="lblresultado" runat="server" Text=""></asp:Label>
                </div>
            </div>
            
        </div>
    </div>


</asp:Content>
