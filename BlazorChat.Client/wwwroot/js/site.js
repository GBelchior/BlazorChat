var Site = (function () {

    function init() {
        Blazor.registerFunction("Alert", message => {
            alert(message);
            return true;
        });
    }

    return {
        init: init
    };
}());

(function () {
    Site.init();
}());
