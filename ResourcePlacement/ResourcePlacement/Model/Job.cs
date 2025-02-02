﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResourcePlacement.Model
{
    [Table("tb_m_jobs")]
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Characters are not allowed.")]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int CompanyId { get; set; }

        [JsonIgnore]
        public virtual Company Company { get; set; }

        [JsonIgnore]
        public virtual ICollection<JobEmployee> JobEmployees { get; set; }

        [JsonIgnore]
        public virtual ICollection<JobHistory> JobHistories { get; set; }
    }
}
