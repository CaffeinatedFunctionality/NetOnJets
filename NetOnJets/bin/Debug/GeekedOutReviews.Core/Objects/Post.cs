﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekedOutReviews.Core.Objects
{
    public class Post
    {
        public virtual int Id
        { get; set; }

        public virtual string Title
        { get; set; }

        public virtual string ShortDescription
        { get; set; }

        public virtual string Description
        { get; set; }

        public virtual string Meta
        { get; set; }

        public virtual string UrlSlug
        { get; set; }

        public virtual bool Published
        { get; set; }

        public virtual DateTime PostedOn
        { get; set; }

        public virtual DateTime? Modified
        { get; set; }

        public virtual IList<Category> Category
        { get; set; }

        public virtual IList<Tag> Tags
        { get; set; }
    }
}
