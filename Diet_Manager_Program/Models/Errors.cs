
using System.Linq;

namespace TempManager.Models
{
    public class Errors
    {

        //shows if the delete error must show
        public int checkedEmpty { get; set; }

        //shows if the full error must show
        public int checkedfull { get; set; }
    }
}
