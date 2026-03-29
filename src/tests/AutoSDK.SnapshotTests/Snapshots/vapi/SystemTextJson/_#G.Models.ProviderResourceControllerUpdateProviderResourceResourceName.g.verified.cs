//HintName: G.Models.ProviderResourceControllerUpdateProviderResourceResourceName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProviderResourceControllerUpdateProviderResourceResourceName
    {
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResourceControllerUpdateProviderResourceResourceNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerUpdateProviderResourceResourceName value)
        {
            return value switch
            {
                ProviderResourceControllerUpdateProviderResourceResourceName.PronunciationDictionary => "pronunciation-dictionary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerUpdateProviderResourceResourceName? ToEnum(string value)
        {
            return value switch
            {
                "pronunciation-dictionary" => ProviderResourceControllerUpdateProviderResourceResourceName.PronunciationDictionary,
                _ => null,
            };
        }
    }
}