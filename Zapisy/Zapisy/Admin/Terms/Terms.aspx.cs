﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>   Admin terms page class. </summary>
///
/// <remarks>   Mat, 2011-01-25. </remarks>

public partial class Admin_Terms_Terms : System.Web.UI.Page
{
    /// <summary>   Event handler. Called by Page for load events. </summary>
    ///
    /// <remarks>   Mat, 2011-01-25. </remarks>
    ///
    /// <param name="sender">   Source of the event. </param>
    /// <param name="e">        Event information. </param>

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString.Keys.Count > 0 && !IsPostBack)
        {
            String courseID = Request.QueryString["courseID"];
            course.SelectedValue = courseID;
        }              
    }

    /// <summary>   Event handler. Called by Button1 for click events. </summary>
    ///
    /// <remarks>   Mat, 2011-01-25. </remarks>
    ///
    /// <param name="sender">   Source of the event. </param>
    /// <param name="e">        Event information. </param>

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Terms/CreateTerm.aspx");
    }

    /// <summary>   Event handler. Called by GridView1 for row editing events. </summary>
    ///
    /// <remarks>   Mat, 2011-01-25. </remarks>
    ///
    /// <param name="sender">   Source of the event. </param>
    /// <param name="e">        Grid view edit event information. </param>

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        String par = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
        String urlString = String.Format("~/Admin/Terms/ChangeTerm.aspx?termID={0}", par);
        Response.Redirect(urlString);
    }
}