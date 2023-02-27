using irshad.clone.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irshad.clone.entities.Concrete
{
    public class Comment : IEntity
    {
        public Comment()
        {
            Status = false;
        }
        public int CommentId { get; set; }
        public int ProductId { get; set; }
        public string Review { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte Rating { get; set; }
        public bool Status { get; set; }
    }
}
