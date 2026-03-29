//HintName: G.Models.GladiaTranscriberRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Region for processing audio (us-west or eu-west)<br/>
    /// Example: us-west
    /// </summary>
    public enum GladiaTranscriberRegion
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
    public static class GladiaTranscriberRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GladiaTranscriberRegion value)
        {
            return value switch
            {
                GladiaTranscriberRegion.EuWest => "eu-west",
                GladiaTranscriberRegion.UsWest => "us-west",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GladiaTranscriberRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu-west" => GladiaTranscriberRegion.EuWest,
                "us-west" => GladiaTranscriberRegion.UsWest,
                _ => null,
            };
        }
    }
}