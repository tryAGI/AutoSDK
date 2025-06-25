//HintName: G.Models.StopwordConfigPreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// pre-existing list of common words by language<br/>
    /// Default Value: en
    /// </summary>
    public enum StopwordConfigPreset
    {
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopwordConfigPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopwordConfigPreset value)
        {
            return value switch
            {
                StopwordConfigPreset.En => "en",
                StopwordConfigPreset.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopwordConfigPreset? ToEnum(string value)
        {
            return value switch
            {
                "en" => StopwordConfigPreset.En,
                "none" => StopwordConfigPreset.None,
                _ => null,
            };
        }
    }
}