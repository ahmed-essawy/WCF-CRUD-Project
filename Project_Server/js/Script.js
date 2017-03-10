// JavaScript source code
$('document').ready(function () {
    GetEmployees();
    GetDepartments();
});

// Employees
function GetEmployees() {
    $.ajax({
        method: "GET",
        url: "/Proj.svc/Proj/REST/Employees",
        dataType: "json"
    }).then(function (response) {
        var last_index = 0;
        for (var i = 0; i < response.length; i++) {
            $("#EmployeeTable tbody").append("<tr id='" + response[i].SSN + "'>\
                <th><input type='text' value='" + response[i].SSN + "' readonly></th><th><input type='text' value='" + response[i].Name + "' readonly></th>\
                <th><input type='text' value='" + response[i].Salary + "' readonly></th>\
                <th><input type='text' value='" + response[i].Phone + "' readonly></th>\
                <th><select disabled></select></th><th><select class='country'></select></th> <th><input type='text' disabled></th>\
                <th><button onclick='EditEmployeeFields(" + response[i].SSN + ",this)'>Edit</button></th>\
                <th><button onclick='DeleteEmployee(" + response[i].SSN + ")'>Delete</button></th></tr>");
            GetDepartmentsofEmp(response[i].Department, response[i].SSN);
            GetCountry(response[i].SSN);
            last_index = response[i].SSN;
        }
        EmployeeEmptyRow(last_index + 1);
    })
}
function GetDepartmentsofEmp(ID, index) {
    $.ajax({
        method: "GET",
        url: "/Proj.svc/Proj/REST/Departments",
        dataType: "json"
    }).then(function (response) {
        for (var i = 0; i < response.length; i++) {
            if (ID == response[i].ID)
                $("#EmployeeTable tbody tr#" + index + " th:nth-child(5) select").append("<option selected value='" + response[i].ID + "'>" + response[i].Name + "</option>");
            else
                $("#EmployeeTable tbody tr#" + index + " th:nth-child(5) select").append("<option value='" + response[i].ID + "'>" + response[i].Name + "</option>");
        }
    })
}
function DeleteEmployee(SSN) {
    $.ajax({
        method: "DELETE",
        url: "/Proj.svc/Proj/REST/Employee/" + SSN
    }).then(function (response) {
        $("#EmployeeTable #" + SSN).remove();
    })
}
function UpdateEmployee(SSN) {
    emp = {
        "SSN": $("#EmployeeTable #" + SSN + " > th:nth-child(1) > input[type='text']").val(),
        "Name": $("#EmployeeTable #" + SSN + " > th:nth-child(2) > input[type='text']").val(),
        "Salary": $("#EmployeeTable #" + SSN + " > th:nth-child(3) > input[type='text']").val(),
        "Phone": $("#EmployeeTable #" + SSN + " > th:nth-child(4) > input[type='text']").val(),
        "Department": $("#EmployeeTable #" + SSN + " > th:nth-child(5) > select option:selected").val()
    };
    $.ajax({
        method: "PUT",
        url: "/Proj.svc/Proj/REST/Employee/" + SSN,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(emp)
    }).then(function (response) {
        $("#EmployeeTable #" + SSN + " > th:nth-child(8) > button").text('Edit').attr('onclick', 'EditEmployeeFields(' + SSN + ',this)');
        $("#EmployeeTable #" + SSN + " input[type=text]").attr('readonly', true);
        $("#EmployeeTable #" + SSN + " th:nth-child(5) select").attr('disabled', 'disabled');
    })
}
function InsertEmployee(SSN) {
    var emp = {
        "SSN": SSN,
        "Name": $("#EmployeeTable #" + SSN + " > th:nth-child(2) > input[type='text']").val(),
        "Salary": $("#EmployeeTable #" + SSN + " > th:nth-child(3) > input[type='text']").val(),
        "Phone": $("#EmployeeTable #" + SSN + " > th:nth-child(4) > input[type='text']").val(),
        "Department": $("#EmployeeTable #" + SSN + " > th:nth-child(5) > select option:selected").val()
    };
    $.ajax({
        method: "POST",
        url: "/Proj.svc/Proj/REST/Employee",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(emp)
    }).then(function (response) {
        $("#EmployeeTable #" + SSN + " input[type=text]").attr('readonly', true);
        $("#EmployeeTable #" + SSN + " th:nth-child(5) select").attr('disabled', 'disabled');
        $("#EmployeeTable #" + SSN + " > th:nth-child(8)").removeAttr('colspan').html("<button onclick='EditEmployeeFields(" + SSN + ", this)'>Edit</button>");
        $("#EmployeeTable #" + SSN).append("<th><button onclick='DeleteEmployee(" + SSN + ")'>Delete</button></th>").removeAttr("class");
        EmployeeEmptyRow(SSN + 1);
    })
}
function EditEmployeeFields(index, clicker) {
    var SSN = $("#EmployeeTable #" + index + " > th:nth-child(1) > input[type='text']").val();
    $(clicker).text('Save').attr('onclick', 'UpdateEmployee("' + SSN + '")');
    $("#EmployeeTable #" + index).find('input[type=text]').removeAttr('readonly');
    $("#EmployeeTable #" + index + " > th:nth-child(1) > input[type='text']").attr('readonly', true);
    $("#EmployeeTable #" + SSN).find('select').removeAttr('disabled');
}
function EmployeeEmptyRow(len) {
    $("#EmployeeTable tbody").append("<tr id='" + len + "' class='new'>\
                <th><input type='text' value='" + len + "' readonly></th><th><input type='text'></th>\
                <th><input type='text'></th><th><input type='text'></th>\
                <th><select></select></th><th><select class='country'></select></th><th><input type='text'></th>\
                <th colspan='2'><button onclick='InsertEmployee("+ len + ")' style='width:100%'>Add</button></th></tr>");
    GetDepartmentsofEmp(0, len);
    GetCountry(len);
    $(".country").change(function () {
        var index = $(this).parent().parent().attr('id');
        $("#EmployeeTable tbody tr#" + index + " th:nth-child(7) input[type='text']").val($(this).val());
    });
}

// Departments

function GetDepartments() {
    $.ajax({
        method: "GET",
        url: "/Proj.svc/Proj/REST/Departments",
        dataType: "json"
    }).then(function (response) {
        var last_index = 0;
        for (var i = 0; i < response.length; i++) {
            $("#DepartmentTable tbody").append("<tr id='" + response[i].ID + "'>\
                <th><input type='hidden' value='" + response[i].ID + "'><input type='text' value='" + response[i].Name + "' readonly></th>\
                <th><button onclick='EditDepartmentFields(" + response[i].ID + ",this)'>Edit</button></th>\
                <th><button onclick='DeleteDepartment(" + response[i].ID + ")'>Delete</button></th></tr>");
            last_index = response[i].ID;
        }
        DepartmentEmptyRow(last_index + 1);
    })
}
function DeleteDepartment(ID) {
    $.ajax({
        method: "DELETE",
        url: "/Proj.svc/Proj/REST/Department/" + ID
    }).then(function (response) {
        $("#DepartmentTable #" + ID).remove();
    })
}
function UpdateDepartment(ID) {
    var name = $("#DepartmentTable #" + ID + " > th:nth-child(1) > input[type='text']").val();
    $.ajax({
        method: "PUT",
        url: "/Proj.svc/Proj/REST/Department/" + ID,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(name)
    }).then(function (response) {
        $("#DepartmentTable #" + ID + " input[type=text]").attr('readonly', true);
        $("#DepartmentTable #" + ID + " > th:nth-child(2) > button").text('Edit').attr('onclick', 'EditDepartmentFields(' + ID + ',this)');
    })
}
function InsertDepartment(ID) {
    var dept = {
        "ID": ID,
        "Name": $("#DepartmentTable #" + ID + " > th:nth-child(1) > input[type='text']").val()
    };
    $.ajax({
        method: "POST",
        url: "/Proj.svc/Proj/REST/Department",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(dept)
    }).then(function (response) {
        $("#DepartmentTable #" + ID + " input[type=text]").attr('readonly', true);
        $("#DepartmentTable #" + ID + " > th:nth-child(2)").removeAttr('colspan').html("<button onclick='EditDepartmentFields(" + ID + ", this)'>Edit</button>");
        $("#DepartmentTable #" + ID).append("<th><button onclick='DeleteDepartment(" + ID + ")'>Delete</button></th>").removeAttr("class");
        DepartmentEmptyRow(ID + 1);
    });
}
function EditDepartmentFields(index, clicker) {
    var ID = $("#DepartmentTable #" + index + " > th:nth-child(1) > input[type='hidden']").val();
    $(clicker).text('Save').attr('onclick', 'UpdateDepartment("' + ID + '")');
    $("#DepartmentTable #" + ID).find('input[type=text]').removeAttr('readonly');
}
function DepartmentEmptyRow(len) {
    $("#DepartmentTable tbody").append("<tr id='" + len + "' class='new'>\
                <th><input type='hidden' value='" + len + "'><input type='text'></th>\
                <th colspan='2'><button onclick='InsertDepartment("+ len + ")' style='width:100%'>Add</button></th></tr>");
}

// Country
function GetCountry(index) {
    $.get("https://restcountries.eu/rest/v2/all?fields=name;capital", function (info) {
        for (var i = 0; i < info.length; i++)
            $("#EmployeeTable tbody tr#" + index + " th:nth-child(6) select").append("<option value='" + info[i].capital + "'>" + info[i].name + "</option>");
        $("#EmployeeTable tbody tr#" + index + " th:nth-child(7) input[type='text']").val(info[0].capital);
    });
}