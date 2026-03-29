//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlType
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
    public static class MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlType value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}