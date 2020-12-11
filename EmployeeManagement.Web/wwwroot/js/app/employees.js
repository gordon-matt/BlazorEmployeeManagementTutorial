export function init() {
    $("#grid").kendoGrid({
        data: null,
        dataSource: {
            type: 'odata-v4',
            transport: {
                read: "http://localhost:56024/odata/EmployeeApi"
            },
            schema: {
                model: {
                    fields: {
                        FamilyName: { type: "string" },
                        GivenNames: { type: "string" },
                        DateOfBirth: { type: "date" }
                    }
                }
            },
            pageSize: 10,
            serverPaging: true,
            serverFiltering: true,
            serverSorting: true,
            sort: [
                { field: "FamilyName", dir: "asc" },
                { field: "GivenNames", dir: "asc" }
            ]
        },
        //dataBound: function (e) {
        //    var body = this.element.find("tbody")[0];
        //    if (body) {
        //        ko.cleanNode(body);
        //        ko.applyBindings(ko.dataFor(body), body);
        //    }
        //},
        filterable: true,
        sortable: {
            allowUnsort: false
        },
        pageable: {
            refresh: true
        },
        scrollable: false,
        columns: [{
            field: "FamilyName",
            title: "Family Name"
        }, {
            field: "GivenNames",
            title: "Given Name/s"
        }, {
            field: "DateOfBirth",
            title: "Date of Birth",
            type: "date",
            format: "{0:yyyy-MM-dd}",
            filterable: false,
            width: 200
        }, {
            field: "Id",
            title: "&nbsp;",
            template:
                '<div class="btn-group">' +
                //'<button type="button" data-bind="click: edit.bind($data,\'#=Id#\')" class="btn btn-default btn-sm" title="Edit"><i class="fa fa-edit"></i></button>' +
                //'<button type="button" data-bind="click: remove.bind($data,\'#=Id#\')" class="btn btn-danger btn-sm" title="Delete"><i class="fa fa-remove"></i></button>' +
                '</div>',
            attributes: { "class": "text-center" },
            filterable: false,
            width: 100
        }]
    });
}