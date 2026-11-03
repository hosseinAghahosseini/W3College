using System.ComponentModel.DataAnnotations;

namespace RealProject.Entities
{
    public abstract class Base
    {
        [Key]
        public int Id { set; get; }
        public DateTime CreationDate { set; get; }
    }
}
