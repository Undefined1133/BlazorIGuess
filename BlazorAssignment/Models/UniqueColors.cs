namespace BlazorAssignment.Models
{

    public class UniqueColors
    {
        public string color { get; set; }
        public int numberOfColors { get; set; } = 0;

        public string getUniqueColor()
        {

            return color;
        }

       
    }
}

