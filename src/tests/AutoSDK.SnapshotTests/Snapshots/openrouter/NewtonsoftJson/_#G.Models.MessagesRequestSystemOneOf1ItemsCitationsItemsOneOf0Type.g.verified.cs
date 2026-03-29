//HintName: G.Models.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="char_location")]
        CharLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf0Type value)
        {
            return value switch
            {
                MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf0Type.CharLocation => "char_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf0Type.CharLocation,
                _ => null,
            };
        }
    }
}