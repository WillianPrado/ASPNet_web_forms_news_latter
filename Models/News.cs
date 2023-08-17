using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sucesso_e_motivacao.Models
{
    public class News
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? CaptureDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? NumPeople { get; set; }
        public int? StatesId { get; set; }
        public int? AgeRangesId { get; set; }
        public long? GendersId { get; set; }
        public long? EthnicitiesId { get; set; }
        public long? CaseTypesId { get; set; }
        public long? CapitalsId { get; set; }
        public long? ImagesId { get; set; }
    }
}