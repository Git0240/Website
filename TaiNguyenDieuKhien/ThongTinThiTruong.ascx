<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThongTinThiTruong.ascx.cs" Inherits="TaiNguyenDieuKhien_ThongTinThiTruong" %>
<script type="text/javascript">
    function
showWeather() { window.open('http://hn.24h.com.vn/ttcb/thoitiet/thoitiet.php', 'my_new_window', 'scrollbars=no, resizable=no, width=134, height=140'); } function
showStock() { window.open('http://chungkhoan.24h.com.vn/', 'my_new_window', 'scrollbars=yes, resizable=no, width=800, height=800'); } function
showGoldPrice() { window.open('http://hcm.24h.com.vn/ttcb/giavang/giavang.php', 'my_new_window', 'scrollbars=no, resizable=no, width=800, height=800'); } function
showMoneyRate() { window.open('http://hn.24h.com.vn/ttcb/tygia/tygia.php', 'my_new_window', 'scrollbars=no, resizable=no, width=800, height=500'); } function
showBigInfo() { window.open('http://ketquaxoso.24h.com.vn', 'my_new_window', 'scrollbars=yes, resizable=no, width=508, height=623'); } function

showBigInfo() { window.open('http://www.thanhnien.com.vn/_layouts/Xoso.aspx', 'my_new_window', 'scrollbars=yes, resizable=no, width=513, height=510'); }
</script>

<table style="border: 1px solid rgb(238, 238, 238);" cellpadding="2" cellspacing="0" width="100%">
    <tbody>
        <tr style="vertical-align:central">
            <td style="height:25px; width:30px; text-align:center;">
                <img src="images/uw_weather_icon.png" style="width:20px; height:20px; padding-left:5px; margin:0px;"/>
            </td>
            <td style="height:25px" >
                <a href="javascript:showWeather();" title="Tỉ giá ngoại tệ">Thời Tiết</a>
            </td>
        </tr>
        <tr style="vertical-align:central">
            <td style="height:25px; width:30px; text-align:center;">
                <img alt="" src="images/icon_dollar.gif" style="width:20px; height:20px; padding-left:5px; margin:0px;"/>
            </td>
            <td style="height:25px">
                <a href="javascript:showMoneyRate();" title="Tỉ giá ngoại tệ">Tỉ giá ngoại tệ</a>
            </td>
        </tr>
        <tr style="vertical-align:central">
            <td style="height:25px; width:30px; text-align:center;">
                <img alt="" src="images/goldIcon.gif" style="width:20px; height:20px; padding-left:5px; margin:0px;" />
            </td>
            <td style="height:25px">
                <a href="javascript:showGoldPrice();" title="Giá vàng">Giá vàng</a>
            </td>
        </tr>
        <tr style="vertical-align:central">
            <td style="height:25px; width:30px; text-align:center;">
                <img alt="" src="images/icon_stock.gif" style="width:20px; height:20px; padding-left:5px; margin:0px;" />
            </td>
            <td style="height:25px">
                <a href="javascript:showStock();" title="Chứng khoán">Chứng khoán</a>
            </td>
        </tr>
        <tr style="vertical-align:central">
            <td style="height:25px; width:30px; text-align:center;">
                <img alt="" src="images/icon_loto.gif" style="width:20px; height:20px; padding-left:5px; margin:0px;" />
            </td>
            <td style="height:25px">
                <a href="javascript:showBigInfo('kqxs')" title="Kết quả xổ số kiến thiết">KQ xổ số kiến thiết</a>
            </td>
        </tr>
    </tbody>
</table>