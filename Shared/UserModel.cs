using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizaDjuret.Shared
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public int Score { get; set; }
    }
}
