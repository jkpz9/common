 public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
 
    public override string ToString()
    {
        return string.Format("{0:f5}, {1:f5}",
            Latitude, Longitude);
    }