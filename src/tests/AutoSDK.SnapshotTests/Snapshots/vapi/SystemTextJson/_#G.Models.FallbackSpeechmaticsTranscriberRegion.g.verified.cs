//HintName: G.Models.FallbackSpeechmaticsTranscriberRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the region for the Speechmatics API. Choose between EU (Europe) and US (United States) regions for lower latency and data sovereignty compliance.<br/>
    /// @default 'eu'<br/>
    /// Default Value: eu<br/>
    /// Example: us
    /// </summary>
    public enum FallbackSpeechmaticsTranscriberRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackSpeechmaticsTranscriberRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSpeechmaticsTranscriberRegion value)
        {
            return value switch
            {
                FallbackSpeechmaticsTranscriberRegion.Eu => "eu",
                FallbackSpeechmaticsTranscriberRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSpeechmaticsTranscriberRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => FallbackSpeechmaticsTranscriberRegion.Eu,
                "us" => FallbackSpeechmaticsTranscriberRegion.Us,
                _ => null,
            };
        }
    }
}