using System.ComponentModel.DataAnnotations;

namespace CalisanTakipCommon
{
    public class BaseVM
    {
        [Key]
        public int Id { get; set; }
    }
}
