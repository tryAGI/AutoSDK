//HintName: G.Models.FallbackMinimaxVoiceRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The region for Minimax API. Defaults to "worldwide".<br/>
    /// Default Value: worldwide
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackMinimaxVoiceRegion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="china")]
        China,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="worldwide")]
        Worldwide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackMinimaxVoiceRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackMinimaxVoiceRegion value)
        {
            return value switch
            {
                FallbackMinimaxVoiceRegion.China => "china",
                FallbackMinimaxVoiceRegion.Worldwide => "worldwide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackMinimaxVoiceRegion? ToEnum(string value)
        {
            return value switch
            {
                "china" => FallbackMinimaxVoiceRegion.China,
                "worldwide" => FallbackMinimaxVoiceRegion.Worldwide,
                _ => null,
            };
        }
    }
}