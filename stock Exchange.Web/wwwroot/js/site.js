// Write your JavaScript code.
//window.setInterval(location.reload(true), 10000);
$("#buyButton").click(function(e) {
    e.preventDefault();
    var invitationID = $("#buyButton").data("code");
});

$("#okbuy").click(function (e) {
    e.preventDefault();
    var actionCode = $(this).data("code");
    var actionUnitview = $(this).data("unit");
    var actionPriceview = $(this).data("price");

    $.ajax({
        type: "POST",
        url: "/Transaction/BuyAction/",
        //contentType: "application/json; charset=utf-8",
        data: {
            actionCode: actionCode
            , actionUnit:parseInt(actionUnitview)
            , actionPrice:parseFloat(actionPriceview)

        },
        success: function (response) {
            if (response.success) {
                alert(response.responseText);
            } else {
                // DoSomethingElse()
                alert(response.responseText);
            }
        },
        error: function (response) {
            alert("error!"); // 
        }
    });
});
$("#okSell").click(function (e) {
    e.preventDefault();
    var actionCode = $("#sellButton").data("code");
    var actionUnitview = $("#sellButton").data("unit");
    var actionPriceview = $("#sellButton").data("price");

    $.ajax({
        type: "POST",
        url: "/Transaction/SellAction/",
        //contentType: "application/json; charset=utf-8",
        data: {
            actionCode: actionCode
            , actionUnit:parseInt(actionUnitview)
            , actionPrice:parseFloat(actionPriceview)

        },
        success: function (response) {
            if (response.success) {
                alert(response.responseText);
            } else {
                // DoSomethingElse()
                alert(response.responseText);
            }
        },
        error: function (response) {
            alert("error!"); // 
        }
    });
}); 