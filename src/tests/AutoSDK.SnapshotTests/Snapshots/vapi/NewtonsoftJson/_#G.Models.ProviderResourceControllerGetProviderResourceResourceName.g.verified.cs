//HintName: G.Models.ProviderResourceControllerGetProviderResourceResourceName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderResourceControllerGetProviderResourceResourceName
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
    public static class ProviderResourceControllerGetProviderResourceResourceNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerGetProviderResourceResourceName value)
        {
            return value switch
            {
                ProviderResourceControllerGetProviderResourceResourceName.PronunciationDictionary => "pronunciation-dictionary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerGetProviderResourceResourceName? ToEnum(string value)
        {
            return value switch
            {
                "pronunciation-dictionary" => ProviderResourceControllerGetProviderResourceResourceName.PronunciationDictionary,
                _ => null,
            };
        }
    }
}