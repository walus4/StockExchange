$(document).ready(function() {
    Stock();
    setInterval(Stock, 10000);

});

function Stock() {
    $.ajax({
        type: "GET",
        url: "/ActionRates/Index",
        success: function (result) {
            $("#StockResults").html("");
            $("#StockResults").append(result);
        },
        error: function(result) {
            $("#StockResults").append("Brak danych");
        }
    });
}

function UserWallet() {
    $.ajax({
        type: "GET",
        url: "Url",
        success: function (result) {
            $("#WalletResults").html("");
            $("#WalletResults").append(result);
        },
        error: function (result) {
            $("#WalletResults").append("Brak danych");
        }
    });
}