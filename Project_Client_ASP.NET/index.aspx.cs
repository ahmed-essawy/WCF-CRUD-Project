using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    private WebClient client;
    0

    protected void Page_Load(object sender, EventArgs e)
    {
        client = new WebClient();
        string response = client.DownloadString(new Uri("http://localhost:83/Proj.svc/Proj/REST/Employees"));
        emplist = JsonConvert.DeserializeObject<Employee[]>(response);
        foreach (Employee emp in emplist)
            comboBox_Emp.Items.Add(emp.Name);
        FillForm(0);
    }
}