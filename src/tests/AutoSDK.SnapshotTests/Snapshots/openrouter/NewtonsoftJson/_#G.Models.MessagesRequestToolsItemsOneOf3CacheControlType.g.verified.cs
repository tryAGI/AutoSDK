//HintName: G.Models.MessagesRequestToolsItemsOneOf3CacheControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestToolsItemsOneOf3CacheControlType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ephemeral")]
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf3CacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf3CacheControlType value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf3CacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf3CacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => MessagesRequestToolsItemsOneOf3CacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}