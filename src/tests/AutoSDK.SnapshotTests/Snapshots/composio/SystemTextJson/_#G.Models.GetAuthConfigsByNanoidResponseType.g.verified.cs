//HintName: G.Models.GetAuthConfigsByNanoidResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the authentication configuration (custom or default)
    /// </summary>
    public enum GetAuthConfigsByNanoidResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAuthConfigsByNanoidResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAuthConfigsByNanoidResponseType value)
        {
            return value switch
            {
                GetAuthConfigsByNanoidResponseType.Custom => "custom",
                GetAuthConfigsByNanoidResponseType.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAuthConfigsByNanoidResponseType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetAuthConfigsByNanoidResponseType.Custom,
                "default" => GetAuthConfigsByNanoidResponseType.Default,
                _ => null,
            };
        }
    }
}