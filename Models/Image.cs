using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sucesso_e_motivacao.Models
{
    public class Image
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime? CaptureDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}