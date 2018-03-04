using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegisterApplication.Models
{
    public partial class TaskModelContext
    {
        [HiddenInput]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public string UserName { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}