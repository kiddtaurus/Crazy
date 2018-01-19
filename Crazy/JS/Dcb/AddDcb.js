var Item = function () {
    this.R1 = "1";
    this.R2 = "2";
    this.R3 = "3";
    this.R4 = "4";
    this.R5 = "5";
    this.R6 = "6";
    this.B = "7";
};

var AddDcbViewModel = function () {
    var self = this;

    self.item = ko.observable(new Item());
    self.itemStr = ko.observable("22");

    self.addDcb = function () {
        alert("C " + self.item.R1 + " |" + self.item.R2);
//        return;
        var data = self.item;

        $.ajax({
            url: "/Dcb/Insert",
            type: "POST",
            data: data,
            cache: false,
            async: false,
            success: function (data) {
                //            alert(JSON.stringify(data));
                alert(data);
            },
            error: function (err) {
                document.write(err.responseText);
            },
            complete: function () {
                var a = 1;
            }
        });
    };


    self.addDcbStr = function () {
        alert("Create a new profile" + self.item.L1 + "|");
    };
};

ko.applyBindings(new AddDcbViewModel());
