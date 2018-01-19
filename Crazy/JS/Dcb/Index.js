var Item = function (profile) {
    //    this.L1 = ko.observable(profile ? profile.L1 : "L11");
    //    this.L2 = ko.observable(profile ? profile.L2 : "L22");

    this.L1 = ko.observable("123");
    this.L2 = ko.observable("444");
};

var Name = function (profile) {
    this.Name = profile;//ko.observable(profile ? profile : "Name");
};
var User = function (id, name) {

    this.id = ko.observable(id);
    this.name = ko.observable(name);
    this.editing = ko.observable(false);
    this.edit = function () { //这里的this是当前调用的对象，而不是UserList，而self才是UserList对象，这也是为什么要使用var self = this语句的原因
        this.editing(true);
    };
};

var ProfilesViewModel2 = function () {
    var self = this;
    //    var refresh = function () {
    //        //self.Profiles(DummyProfile);
    //    };

    //    // Public data properties
    //    var profile = false;
    //    self.ProfileId = ko.observable(profile ? profile.ProfileId : 0);
    //    self.FirstName = ko.observable(profile ? profile.FirstName : 'FirstName');
    //    self.LastName = ko.observable(profile ? profile.LastName : 'LastName');
    //    self.Email = ko.observable(profile ? profile.Email : 'Email');
    //    //    refresh();

    //    self.item = new Item();
    self.item = ko.observable(new Item());

    self.al = function () {
        alert("a");
    };
    self.createProfile = function () {
        alert("Create a new profile" + self.item.L1 + "|");
    };


    //    self.names = ko.observableArray([{ Name: "Name1" }, { Name: "Name2" }]);

    self.names = ko.observableArray();
    for (var i = 0; i < 10; i++) {
        self.names.push(new Name("zzl" + i));
    }

    //    self.users = ko.observableArray();
    //    for (var ii = 0; ii < 10; ii++) {
    //        self.users.push(new User(ii, "zzl"+ii));
    //    }
    self.users = ko.observableArray([new User(0, "u0"), new User(1, "u10"), new User(2, "u20")]);

    // Behavior Remove
    self.removePerson = function () { //data-bind="click:$parent.removePerson"//这句为调用当前对象的父对象上的方法
        self.users.remove(this);
    };
    self.save = function () {
        var t = self.users;
        alert(self.users()[0].name());
    };
};

ko.applyBindings(new ProfilesViewModel2());
