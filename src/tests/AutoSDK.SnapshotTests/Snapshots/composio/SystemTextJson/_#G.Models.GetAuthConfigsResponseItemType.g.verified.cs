//HintName: G.Models.GetAuthConfigsResponseItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the authentication configuration (custom or default)
    /// </summary>
    public enum GetAuthConfigsResponseItemType
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
    public static class GetAuthConfigsResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAuthConfigsResponseItemType value)
        {
            return value switch
            {
                GetAuthConfigsResponseItemType.Custom => "custom",
                GetAuthConfigsResponseItemType.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAuthConfigsResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetAuthConfigsResponseItemType.Custom,
                "default" => GetAuthConfigsResponseItemType.Default,
                _ => null,
            };
        }
    }
}