//HintName: G.Models.SessionRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The region where the Session is running.
    /// </summary>
    public enum SessionRegion
    {
        /// <summary>
        /// 
        /// </summary>
        ApSoutheast1,
        /// <summary>
        /// 
        /// </summary>
        EuCentral1,
        /// <summary>
        /// 
        /// </summary>
        UsEast1,
        /// <summary>
        /// 
        /// </summary>
        UsWest2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionRegion value)
        {
            return value switch
            {
                SessionRegion.ApSoutheast1 => "ap-southeast-1",
                SessionRegion.EuCentral1 => "eu-central-1",
                SessionRegion.UsEast1 => "us-east-1",
                SessionRegion.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionRegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-southeast-1" => SessionRegion.ApSoutheast1,
                "eu-central-1" => SessionRegion.EuCentral1,
                "us-east-1" => SessionRegion.UsEast1,
                "us-west-2" => SessionRegion.UsWest2,
                _ => null,
            };
        }
    }
}