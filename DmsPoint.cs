public int Degrees { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public PointType Type { get; set; }
 
    public override string ToString()
    {
        return string.Format("{0} {1} {2} {3}",
            Math.Abs(Degrees),
            Minutes,
            Seconds,
            Type == PointType.Lat
                ? Degrees < 0 ? "S" : "N"
                : Degrees < 0 ? "W" : "E");
    }