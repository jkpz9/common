DecimalLocation Convert(DmsLocation dmsLocation)
{
    if (dmsLocation == null)
    {
        return null;
    }
 
    return new DecimalLocation
        {
            Latitude = CalculateDecimal(dmsLocation.Latitude),
            Longitude = CalculateDecimal(dmsLocation.Longitude)
        };
}
 
decimal CalculateDecimal(DmsPoint point)
{
    if (point == null)
    {
        return default(decimal);
    }
    return point.Degrees + (decimal)point.Minutes/60 + (decimal)point.Seconds/3600;
}
///
