 public DmsPoint Latitude { get; set; }
    public DmsPoint Longitude { get; set; }
 
    public override string ToString()
    {
        return string.Format("{0}, {1}",
            Latitude, Longitude);
    }