//HintName: G.Models.ProviderResourceResourceName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the name/type of the resource.
    /// </summary>
    public enum ProviderResourceResourceName
    {
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResourceResourceNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceResourceName value)
        {
            return value switch
            {
                ProviderResourceResourceName.PronunciationDictionary => "pronunciation-dictionary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceResourceName? ToEnum(string value)
        {
            return value switch
            {
                "pronunciation-dictionary" => ProviderResourceResourceName.PronunciationDictionary,
                _ => null,
            };
        }
    }
}