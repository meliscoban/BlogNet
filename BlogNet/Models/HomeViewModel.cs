using BlogNet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogNet.Models
{
    public class HomeViewModel
    {
        public List<Post> Posts { get; set; }

        public PaginationViewModel PaginationInfo { get; set; }
    }
}
