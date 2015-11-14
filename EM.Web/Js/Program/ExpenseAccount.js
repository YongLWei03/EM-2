var ToPublic = {}
ToPublic.OldValue = "";
ToPublic.GetPublicId = function ($this) {
    var $EANumber = $("#EANumber")
    if ($this.is(":checked")) {
        ToPublic.OldValue = $EANumber.val();
        $EANumber.attr("readOnly", "readOnly")
        $.ajax({
            url: "/expenseaccount/GetNewPublicId",
            success: function (a) {
                if (a.code) {
                    $EANumber.val(a.EANumber);
                }
            }
        })
    }
    else {
        $EANumber.removeAttr("readOnly");
        $EANumber.val(ToPublic.OldValue);
    }
};
ToPublic.Init = function () {UploadEAFile

    $("#IsPublic").change(function () {
        ToPublic.GetPublicId($(this));
    })
}

var UploadEAFile = {};
UploadEAFile.Selector = "#FileList"
UploadEAFile.TrHtml = "<tr data-id=\"{Id}\"><td class=\"taL\">{FileName}</td><td class=\"taL\">{CreateDate}</td><td class=\"taL\">  <a href=\"javascript:;\" onclick=\"UploadEAFile.DeleteFile({Id})\">删除</a> &nbsp;<a href=\"ExpenseAccount/ViewFile/{Id}\" target=\"_blank\">查看</a></td></tr>";
UploadEAFile.UploaderHtml = "<form target=\"if\" enctype=\"multipart/form-data\" id=\"AddFile\" name=\"AddFile\" method=\"post\" action=\"../../Upload/PostExpenseAccountFile/{Id}\"><input type=\"file\" name=\"file\" id=\"file\" class=\"wp100 hp100 pAbs \" style=\"top:0px;opacity:0\" /></form>";

UploadEAFile.DeleteFile = function (id) {
    $.ajax({
        url: "/expenseaccount/DeleteFile",
        data: { Id: id },
        success: function (a) {
            if(a.code)
            {
                $("tr[data-id=" + id + "] ", $(UploadEAFile.Selector)).remove();
            }
        }
    })
};
UploadEAFile.Show = function () {
    layer.open({
        type: 1,
        title: "上传附件",
        closeBtn: 1,
        area: '516px',
        shadeClose: true,
        content: $('#FileField')
    });
}
UploadEAFile.Init = function () {
    //$("#AddFileForm").append(UploadEAFile.UploaderHtml.format({ Id: $("#Id").val() }));
    var oFrm = document.getElementById('if');
    oFrm.onload = oFrm.onreadystatechange = function () {
        if (this.readyState && this.readyState != 'complete') return;
        else {
            var json = eval("(" + oFrm.contentWindow.document.body.innerText + ")");
            if (json.code) {
                alert("上传成功")
                {
                    $("#NoRow").remove();
                    $("#AddRow").before(UploadEAFile.TrHtml.format(json.model))
                }
            }
            else {
                alert(jsob.message)
            }
        }
    }
}

var EADetail = {};
EADetail.Selector = "#DetailList"
EADetail.TrHtml = "<tr data-id=\"{Id}\"><td class=\"taL\">{DetailName}</td><td class=\"taL\">{CreateDate}</td><td class=\"taL\">  <a href=\"javascript:;\" onclick=\"EADetail.DeleteDetail({Id})\">删除</a> &nbsp;<a href=\"ExpenseAccount/ViewDetail/{Id}\" target=\"_blank\">查看</a></td></tr>";

EADetail.DeleteDetail = function (id) {
    $.ajax({
        url: "/expenseaccount/DeleteDetail",
        data: { Id: id },
        success: function (a) {
            if (a.code) {
                $("tr[data-id=" + id + "] ", $(EADetail.Selector)).remove();
            }
        }
    })
};
EADetail.Show = function (id) {
    $('#DetailField').remove();
    id = id == undefined ? 0 : id;
    var title = id == 0 ? "新增明细" : "编辑明细";
    var url = "/expenseaccount/GetDetail";
    $.ajax({
        title:title,
        url: url,
        data: { Id: id },
        success: function (a) {
            $("body").append(a);
            layer.open({
                type: 1,
                title: this.title,
                closeBtn: 1,
                area: '516px',
                shadeClose: true,
                content: $('#DetailField')
            });
        }
    })
  
}
EADetail.Init = function () {
    //$("#AddDetailForm").append(EADetail.UploaderHtml.format({ Id: $("#Id").val() }));
    var oFrm = document.getElementById('if');
    oFrm.onload = oFrm.onreadystatechange = function () {
        if (this.readyState && this.readyState != 'complete') return;
        else {
            var json = eval("(" + oFrm.contentWindow.document.body.innerText + ")");
            if (json.code) {
                alert("上传成功")
                {
                    $("#NoRow").remove();
                    $("#AddRow").before(EADetail.TrHtml.format(json.model))
                }
            }
            else {
                alert(jsob.message)
            }
        }
    }
}

var BeforeSave = function ()
{
    if($("#IsPublic").is(":checked")&&$("tr[data-id] ", $(UploadEAFile.Selector)).length==0)
    {
        alert("对公报销必须上传附件！")
        return false;
    }
    return true;
}
var SuccessFunction = function () {
    if (location.href.indexOf("add") != -1) {
        if (confirm("是否继续新增报销单？"))
            location.href = location.href;
        else {
            Global.Form.NewIframe("报销单列表", "expenseaccount_index", "expenseaccount/index");
            Global.Form.CloseIframe("expenseaccount_add");
        }
    }
    else {
        Global.Form.NewIframe("报销单列表", "expenseaccount_index", "expenseaccount/index");
        Global.Form.CloseIframe("EditExpenseAccount_" + ob.model.Id);
    }
    return false
}

$(function () {
    ToPublic.Init();
    UploadEAFile.Init();
})
