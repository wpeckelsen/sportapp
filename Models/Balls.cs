namespace SportApp.Models
{

    public class Ball
    {
        public int BallId { get; set; }           // Primary key
        public string Name { get; set; }      // E.g., Tennis ball, Football
        public string Type { get; set; }      // E.g., Sport type (e.g., tennis, football, etc.)
        public double Diameter { get; set; }  // Diameter in cm
    }    

}