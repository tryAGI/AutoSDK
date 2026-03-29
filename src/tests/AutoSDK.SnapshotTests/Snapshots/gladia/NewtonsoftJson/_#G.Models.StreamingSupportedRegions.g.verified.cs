//HintName: G.Models.StreamingSupportedRegions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamingSupportedRegions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eu-west")]
        EuWest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us-west")]
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