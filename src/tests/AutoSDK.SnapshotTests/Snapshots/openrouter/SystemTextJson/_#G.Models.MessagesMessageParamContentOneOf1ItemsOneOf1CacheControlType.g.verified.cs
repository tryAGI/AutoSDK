//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlType value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}