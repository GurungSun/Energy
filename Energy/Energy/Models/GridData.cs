namespace Energy.Models;

public class GridData
{
    public DateTime time { get; set; }

    public double ccgt { get; set; }
    public double nuclear { get; set; }
    public double wind { get; set; }
    public double hydro { get; set; }
    public double biomass { get; set; }

    public double price { get; set; }
    public double emissions { get; set; }
}