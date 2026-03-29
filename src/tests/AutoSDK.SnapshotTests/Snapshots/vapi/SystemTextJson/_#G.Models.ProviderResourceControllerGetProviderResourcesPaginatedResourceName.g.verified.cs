//HintName: G.Models.ProviderResourceControllerGetProviderResourcesPaginatedResourceName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProviderResourceControllerGetProviderResourcesPaginatedResourceName
    {
        /// <summary>
        /// 
        /// </summary>
        PronunciationDictionary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResourceControllerGetProviderResourcesPaginatedResourceNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerGetProviderResourcesPaginatedResourceName value)
        {
            return value switch
            {
                ProviderResourceControllerGetProviderResourcesPaginatedResourceName.PronunciationDictionary => "pronunciation-dictionary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerGetProviderResourcesPaginatedResourceName? ToEnum(string value)
        {
            return value switch
            {
                "pronunciation-dictionary" => ProviderResourceControllerGetProviderResourcesPaginatedResourceName.PronunciationDictionary,
                _ => null,
            };
        }
    }
}