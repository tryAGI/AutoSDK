//HintName: G.Models.MinimaxVoiceRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The region for Minimax API. Defaults to "worldwide".<br/>
    /// Default Value: worldwide
    /// </summary>
    public enum MinimaxVoiceRegion
    {
        /// <summary>
        /// 
        /// </summary>
        China,
        /// <summary>
        /// 
        /// </summary>
        Worldwide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MinimaxVoiceRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinimaxVoiceRegion value)
        {
            return value switch
            {
                MinimaxVoiceRegion.China => "china",
                MinimaxVoiceRegion.Worldwide => "worldwide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinimaxVoiceRegion? ToEnum(string value)
        {
            return value switch
            {
                "china" => MinimaxVoiceRegion.China,
                "worldwide" => MinimaxVoiceRegion.Worldwide,
                _ => null,
            };
        }
    }
}