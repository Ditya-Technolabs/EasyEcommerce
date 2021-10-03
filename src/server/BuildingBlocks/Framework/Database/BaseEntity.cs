using System;
using System.ComponentModel.DataAnnotations;

namespace Framework.Database
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
