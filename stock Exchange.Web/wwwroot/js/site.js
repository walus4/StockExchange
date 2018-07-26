$(document).ready(function() {
    Stock();
    setInterval(Stock, 10000);
    if ($("#IsAuth").val) {
        UserWallet();
        setInterval(UserWallet,10000);
    }
});

function Stock() {
    $.ajax({
        type: "GET",
        url: "/ActionRates/Index",
        success: function (result) {
            $("#StockResults").html("");
            $("#StockResults").append(result);
        },
        error: function (result) {
            $("#StockResults").html("");
            $("#StockResults").append("Brak danych");
        }
    });
}

function UserWallet() {
    $.ajax({
        type: "GET",
        url: "/UserWallet/GetUserWallet",
        success: function (result) {
            $("#WalletResults").html("");
            $("#WalletResults").append(result);
        },
        error: function (result) {
            $("#WalletResults").html("");
            $("#WalletResults").append("Brak danych");
        }
    });
}