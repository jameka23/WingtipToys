﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wingtipToysCsharp.Models;

namespace wingtipToysCsharp
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new wingtipToysCsharp.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }
    }
}