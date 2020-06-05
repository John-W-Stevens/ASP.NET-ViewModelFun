using ViewModelFun.Models;

namespace ViewModelsFun.Models
{
    public class Wrapper
    {
        public User User { get; set; }

        public Wrapper(User user)
        {
            User = user;

        }
    }
}