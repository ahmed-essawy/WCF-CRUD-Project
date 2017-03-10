<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Project_Client_ASP.NET.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WCF Project</title>
    <link href="css/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employees</h2>
            <asp:GridView ID=EmployeeTable runat="server" AutoGenerateColumns="False" AllowSorting="True" ShowFooter="True" ShowHeaderWhenEmpty="True" OnRowEditing="EmployeeTable_RowEditing" OnRowUpdating="EmployeeTable_RowUpdating" OnRowDeleting="EmployeeTable_RowDeleting" OnRowCancelingEdit="EmployeeTable_RowCancelingEdit">
                <Columns>
                    <asp:TemplateField HeaderText="SSN" FooterText="dsfds">
                        <FooterTemplate>
                            <asp:Label ID="Label1" runat="server" Text="<%# LastSSN() %>"></asp:Label>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text="<%# Bind('SSN') %>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text="<%# Bind('Name') %>"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text="<%# Bind('Name') %>"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text="<%# Bind('Name') %>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Salary">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text="<%# Bind('Salary') %>"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text="<%# Bind('Salary') %>"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text="<%# Bind('Salary') %>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Phone">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text="<%# Bind('Phone') %>"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text="<%# Bind('Phone') %>"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text="<%# Bind('Phone') %>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Department">
                        <EditItemTemplate>
                            <asp:DropDownList ID=DropDownList1 runat="server" DataTextField="Name" DataValueField="ID" OnInit="DropDownList1_Init"></asp:DropDownList>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:DropDownList ID=DropDownList1 runat="server" DataTextField="Name" DataValueField="ID" OnInit="DropDownList1_Init"></asp:DropDownList>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# DeptName(Eval("Department").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" ButtonType="Button" InsertVisible="False" />
                    <asp:TemplateField>
                        <FooterTemplate>
                            <asp:Button runat="server" Text="Add" Width=120px OnClick="Add_Emp" />
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle CssClass="new" />
            </asp:GridView>
        </div>
        <div>
            <h2>Departments</h2>
            <asp:GridView ID=DepartmentTable runat="server" AutoGenerateColumns="False" AllowSorting="True" ShowFooter="True" ShowHeaderWhenEmpty="True" OnRowCancelingEdit="DepartmentTable_RowCancelingEdit" OnRowDeleting="DepartmentTable_RowDeleting" OnRowEditing="DepartmentTable_RowEditing" OnRowUpdating="DepartmentTable_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="Name">
                        <EditItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text="<%# Bind('ID') %>" Visible="false"></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server" Text="<%# Bind('Name') %>"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:Label ID="Label1" runat="server" Text="<%# LastID() %>" Visible="false"></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text="<%# Bind('ID') %>" Visible="false"></asp:Label>
                            <asp:Label ID="Label2" runat="server" Text="<%# Bind('Name') %>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" ButtonType="Button" />
                    <asp:TemplateField>
                        <FooterTemplate>
                            <asp:Button runat="server" Text="Add" Width=120px OnClick="Add_Dept" />
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle CssClass="new" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>