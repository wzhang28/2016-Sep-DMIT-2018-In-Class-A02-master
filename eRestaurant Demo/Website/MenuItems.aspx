<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MenuItems.aspx.cs" Inherits="MenuItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Our Menu</h1>
    <asp:GridView ID="MenuGridview" runat="server"></asp:GridView>
    <hr />
    <asp:Repeater ID="MenuRepeater" runat="server"
         ItemType="eRestaurant.Entities.DTOs.CategoryWithItems">
        <ItemTemplate>
            <div>
                <h3><%# Item.Description %></h3>
                <blockquote>
                    <asp:Repeater ID="MenuItemRepeater" runat="server"
                         ItemType="eRestaurant.Entities.Pocos.MenuItem"
                         DataSource="<%# Item.MenuItems %>">
                        <ItemTemplate>
                            <b><%# Item.Description %></b> &ndash;
                            <%# Item.Price.ToString("C") %> &ndash;
                            <%# Item.Calories %> Calories
                            <br />
                        </ItemTemplate>
                    </asp:Repeater>
                </blockquote>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

