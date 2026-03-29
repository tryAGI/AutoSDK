//HintName: G.Models.ProviderResourceControllerCreateProviderResourceResourceName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProviderResourceControllerCreateProviderResourceResourceName
    {
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResourceControllerCreateProviderResourceResourceNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerCreateProviderResourceResourceName value)
        {
            return value switch
            {
                ProviderResourceControllerCreateProviderResourceResourceName.PronunciationDictionary => "pronunciation-dictionary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerCreateProviderResourceResourceName? ToEnum(string value)
        {
            return value switch
            {
                "pronunciation-dictionary" => ProviderResourceControllerCreateProviderResourceResourceName.PronunciationDictionary,
                _ => null,
            };
        }
    }
}