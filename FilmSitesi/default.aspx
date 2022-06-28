<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FilmSitesi._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="color:#555;">
        &nbsp;</p>
    <p style="color:#fff;text-align:center;">
        &nbsp; Üzgünsen aşağıya tıkla ve izlerken mutlu olacağın filmi gör...</p>
    &nbsp;
    <p style="text-align:center;">    
&nbsp;<asp:ImageButton ID="ImageButton2" ImageAlign="Middle" runat="server"  ImageUrl="~/images/üzgün.jpg" OnClick="ImageButton2_Click" Height="242px" Width="322px" />
    &nbsp;</p>
    <p style="color:#fff; text-align:center;">
        &nbsp;</p>
    <p style="color:#fff; text-align:center;">
        &nbsp; Korkmak istiyorsan aşağıya tıkla ve izleyeceğin filmi gör...</p>
    <p style="color:#fff; text-align:center;">
        &nbsp;</p>
    <p style="text-align:center;">
        &nbsp;<asp:ImageButton ID="ImageButton3" ImageAlign="Middle" runat="server"  ImageUrl="~/images/korku.jpg" OnClick="ImageButton3_Click" Height="242px" Width="322px" />
    &nbsp;</p>
    <p>
        &nbsp;</p>
    <p style="color:#fff; text-align:center;">
        &nbsp; Sinirliysen izle ve sakinleş hemen...</p>
    <p style="color:#fff; text-align:center;">
        &nbsp;</p>
    <p style="text-align:center;">
        &nbsp;<asp:ImageButton ID="ImageButton4" ImageAlign="Middle" runat="server"  ImageUrl="~/images/sinirli.jpg" OnClick="ImageButton4_Click" Height="242px" Width="322px" />
    </p>
    <p>
        &nbsp;</p>
    <p style="color:#fff; text-align:center;">
        &nbsp;Şaşırmak istersen aşağıya tıkla...</p>
    <p>
        &nbsp;</p>
    <p style="text-align:center;">
        &nbsp;<asp:ImageButton ID="ImageButton5"  ImageAlign="Middle"  runat="server"  ImageUrl="~/images/şok.jpg" OnClick="ImageButton5_Click" Height="242px" Width="322px" />
    &nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
