using System;
using System.ComponentModel.DataAnnotations;

namespace Energy.Models
{
    public class Tips
    {
        public Guid Id { get; set;} = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        public Tips(Guid id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}