//HintName: G.Models.FallbackGladiaTranscriberRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Region for processing audio (us-west or eu-west)<br/>
    /// Example: us-west
    /// </summary>
    public enum FallbackGladiaTranscriberRegion
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
    public static class FallbackGladiaTranscriberRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackGladiaTranscriberRegion value)
        {
            return value switch
            {
                FallbackGladiaTranscriberRegion.EuWest => "eu-west",
                FallbackGladiaTranscriberRegion.UsWest => "us-west",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackGladiaTranscriberRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu-west" => FallbackGladiaTranscriberRegion.EuWest,
                "us-west" => FallbackGladiaTranscriberRegion.UsWest,
                _ => null,
            };
        }
    }
}