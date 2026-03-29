//HintName: G.Models.ProviderEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProviderEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderEnum value)
        {
            return value switch
            {
                ProviderEnum.Custom => "CUSTOM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderEnum? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM" => ProviderEnum.Custom,
                _ => null,
            };
        }
    }
}