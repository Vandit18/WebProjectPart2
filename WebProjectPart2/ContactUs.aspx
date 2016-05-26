<%@ Page Title="ContactUs" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="WebProjectPart2.ContactUs" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1>Contact Us
        </h1>
        </div>
    <div class="container">
        <div class="form-group">
            <label class="control-label" for="FirstNameTextBox">First Name</label>
            <asp:TextBox runat="server" cssclass="form-control" ID="FirstNameTextBox" placeholder="FirstName" required="true" aria-describedby="basic-addon1"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="control-label" for="LastNameTextBox">Last Name</label>
            <asp:TextBox runat="server" cssclass="form-control" ID="LastNameTextBox" placeholder="LastName" required="true"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="control-label" for="EmailTextBox">Email</label>
            <asp:TextBox runat="server" TextMode="Email" cssclass="form-control" ID="EmailTextBox" placeholder="Email" required="true"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="control-label" for="ContactTextBox">Contact Number</label>
            <asp:TextBox runat="server" TextMode="Phone" cssclass="form-control" ID="ContactTextBox" placeholder="ContactNumber" required="true"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="control-label" for="CommentTextBox">Commnet</label>
            <asp:TextBox runat="server" cssclass="form-control" ID="CommentTextBox" placeholder="Comment" TextMode="MultiLine"></asp:TextBox>
        </div>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" CssClass="btn btn-primary" />
    </div>
</asp:Content>
