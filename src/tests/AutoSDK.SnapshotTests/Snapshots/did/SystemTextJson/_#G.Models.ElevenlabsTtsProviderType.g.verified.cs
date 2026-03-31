//HintName: G.Models.ElevenlabsTtsProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ElevenlabsTtsProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenlabsTtsProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenlabsTtsProviderType value)
        {
            return value switch
            {
                ElevenlabsTtsProviderType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenlabsTtsProviderType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ElevenlabsTtsProviderType.Elevenlabs,
                _ => null,
            };
        }
    }
}