//HintName: G.Models.ProviderResourceControllerDeleteProviderResourceResourceName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderResourceControllerDeleteProviderResourceResourceName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pronunciation-dictionary")]
        PronunciationDictionary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResourceControllerDeleteProviderResourceResourceNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerDeleteProviderResourceResourceName value)
        {
            return value switch
            {
                ProviderResourceControllerDeleteProviderResourceResourceName.PronunciationDictionary => "pronunciation-dictionary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerDeleteProviderResourceResourceName? ToEnum(string value)
        {
            return value switch
            {
                "pronunciation-dictionary" => ProviderResourceControllerDeleteProviderResourceResourceName.PronunciationDictionary,
                _ => null,
            };
        }
    }
}