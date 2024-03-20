namespace ASP_Data_Visualization.Models;

public class JimmyModel
{
    public int Id { get; set; }
    public DateTime BirthDate { get; set; }
    public int BrainCells { get; set; }

    public JimmyModel()
    {
        var rnd = new Random();
        Id = rnd.Next(1000, 9999);
        BirthDate = DateTime.Now.AddDays(-rnd.Next(1000, 3000));
        BrainCells = rnd.Next(0, 100);
    }
}