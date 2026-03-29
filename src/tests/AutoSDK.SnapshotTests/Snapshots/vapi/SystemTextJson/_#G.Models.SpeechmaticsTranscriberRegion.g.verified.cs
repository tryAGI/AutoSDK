//HintName: G.Models.SpeechmaticsTranscriberRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the region for the Speechmatics API. Choose between EU (Europe) and US (United States) regions for lower latency and data sovereignty compliance.<br/>
    /// @default 'eu'<br/>
    /// Default Value: eu<br/>
    /// Example: us
    /// </summary>
    public enum SpeechmaticsTranscriberRegion
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
    public static class SpeechmaticsTranscriberRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechmaticsTranscriberRegion value)
        {
            return value switch
            {
                SpeechmaticsTranscriberRegion.Eu => "eu",
                SpeechmaticsTranscriberRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechmaticsTranscriberRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => SpeechmaticsTranscriberRegion.Eu,
                "us" => SpeechmaticsTranscriberRegion.Us,
                _ => null,
            };
        }
    }
}