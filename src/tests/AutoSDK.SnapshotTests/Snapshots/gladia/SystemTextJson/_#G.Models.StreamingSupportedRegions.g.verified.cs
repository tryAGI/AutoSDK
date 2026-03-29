//HintName: G.Models.StreamingSupportedRegions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamingSupportedRegions
    {
        /// <summary>
        /// 
        /// </summary>
        EuWest,
        /// <summary>
        /// 
        /// </summary>
        UsWest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingSupportedRegionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingSupportedRegions value)
        {
            return value switch
            {
                StreamingSupportedRegions.EuWest => "eu-west",
                StreamingSupportedRegions.UsWest => "us-west",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingSupportedRegions? ToEnum(string value)
        {
            return value switch
            {
                "eu-west" => StreamingSupportedRegions.EuWest,
                "us-west" => StreamingSupportedRegions.UsWest,
                _ => null,
            };
        }
    }
}