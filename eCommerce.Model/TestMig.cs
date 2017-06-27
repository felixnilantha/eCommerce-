using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace eCommerce.Model
{
    public class TestMig
    {
        [Key]
        public int testId { get; set; }
        public string testDescription { get; set; }
        public string secondDescription { get; set; }

    }
}
