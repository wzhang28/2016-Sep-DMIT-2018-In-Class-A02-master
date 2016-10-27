<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="NorthwindsCustomers.aspx.cs" Inherits="NorthwindsCustomers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Northwind Customers</h1>
    <asp:GridView ID="CustomerGridView" runat="server" AutoGenerateColumns="False" DataSourceID="CustomerListDataSource" AllowPaging="True" OnSelectedIndexChanged="CustomerGridView_SelectedIndexChanged" DataKeyNames="CustomerId">
        <Columns>
            <asp:CommandField ShowSelectButton="True"></asp:CommandField>
            <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" SortExpression="CustomerId"></asp:BoundField>
            <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName"></asp:BoundField>
            <asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName"></asp:BoundField>
            <asp:BoundField DataField="ContactTitle" HeaderText="ContactTitle" SortExpression="ContactTitle"></asp:BoundField>
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address"></asp:BoundField>
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City"></asp:BoundField>
            <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region"></asp:BoundField>
            <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="CustomerListDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListCustomers" TypeName="Northwind.Application.BLL.SalesController"></asp:ObjectDataSource>
    <asp:Label ID="MessageLabel" runat="server" />
    <hr />
    <asp:Repeater ID="SelectedCustomerOrders" runat="server" ItemType="Northwind.Application.DataModels.CustomerOrder">
        <ItemTemplate>
            <asp:Label ID="OrderDate" runat="server" Visible="<%# Item.OrderedOn.HasValue %>">Ordered on <b><%# Item.OrderedOn.Value.ToShortDateString() %></b></asp:Label>
            <asp:Label ID="RequiredDate" runat="server" Visible="<%# Item.RequiredBy.HasValue %>">Required by <b><%# Item.RequiredBy.Value.ToShortDateString() %></b></asp:Label>
            <img src='<%# @"data:image/gif;base64," + Convert.ToBase64String(Item.SalesRep.CleanPhoto) %>' width="48" height="56" />
            <asp:Label ID="ShippedDate" runat="server" Visible="<%# Item.Shipping.ShippedOn.HasValue %>">Shipped on <b><%# Item.Shipping.ShippedOn.Value.ToShortDateString() %></b> by <%# Item.Shipping.Shipper %></asp:Label>
            <%# Item.Shipping.ShipTo %>
            <details>
                <summary>Order Items</summary>
                <asp:Repeater ID="Details" runat="server" ItemType="Northwind.Application.DataModels.CustomerOrderDetail" DataSource="<%# Item.OrderDetails %>">
                    <ItemTemplate>
                        <%# Item.OrderQuantity %> - <%# Item.Item %> (<%# Item.UnitPrice.ToString("C") %> - <%# Item.Unit %>)
                    </ItemTemplate>
                    <SeparatorTemplate><br /></SeparatorTemplate>
                </asp:Repeater>
            </details>
        </ItemTemplate>
        <SeparatorTemplate><hr /></SeparatorTemplate>
    </asp:Repeater>
</asp:Content>

