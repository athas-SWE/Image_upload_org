using System;
using System.Collections.Generic;

namespace Image_upload.Models
{
    public partial class Profile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
    }
}
