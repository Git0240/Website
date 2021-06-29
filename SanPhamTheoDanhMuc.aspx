<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/mainchinh.master" AutoEventWireup="true" CodeFile="SanPhamTheoDanhMuc.aspx.cs" Inherits="SanPhamTheoDanhMuc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:DataList ID="dtlSanPhamDM" runat="server" RepeatColumns="3" Width="730px" CaptionAlign="Top" HorizontalAlign="Center">
        <ItemTemplate>
            <asp:Panel ID="Panel1" runat="server" Width="170px" Height="270px">
                <table cellpadding="0" cellspacing="0" style="width:170px" class="product-item">
                    <tr class="img-fluid">
                        <td>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("IdHinhSanPham","HienThiHinhSanPham.ashx?IdHinhSanPham={0}") %>' Width="100%"/>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 175px; height: 22px;" align="center">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenSanPham") %>' Font-Bold="True" ForeColor="#330000"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 175px; align-content: center">
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("GiaSanPham", "{0:##,###,###} VND") %>' ForeColor="#330000"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 175px; text-align: center;" align="center">
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("IdSanPham","ChiTietSanPham.aspx?IdSanpham={0}") %>' ImageUrl="~/images/button_detail.jpg" Width="63px">Chi tiết sản phẩm</asp:HyperLink><asp:HyperLink ID="HyperLink2" runat="server" ImageUrl="~/images/button_buy.gif" Width="100px" NavigateUrl='<%# Eval("IdSanPham","ThemGioHang.aspx?IDSanpham={0}") %>'>Thêm vào giỏ hàng</asp:HyperLink></td>
                    </tr>
                </table>
            </asp:Panel>
        </ItemTemplate>        
    </asp:DataList>
</asp:Content>

