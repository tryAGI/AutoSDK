//HintName: G.Models.MessagesRequestToolsItemsOneOf0CacheControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolsItemsOneOf0CacheControlType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf0CacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf0CacheControlType value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf0CacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf0CacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => MessagesRequestToolsItemsOneOf0CacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}