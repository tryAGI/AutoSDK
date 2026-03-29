//HintName: G.Models.MessagesRequestSystemOneOf1ItemsCacheControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestSystemOneOf1ItemsCacheControlType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestSystemOneOf1ItemsCacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestSystemOneOf1ItemsCacheControlType value)
        {
            return value switch
            {
                MessagesRequestSystemOneOf1ItemsCacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestSystemOneOf1ItemsCacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => MessagesRequestSystemOneOf1ItemsCacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}