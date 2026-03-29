//HintName: G.Models.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf1Type value)
        {
            return value switch
            {
                MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf1Type.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "page_location" => MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf1Type.PageLocation,
                _ => null,
            };
        }
    }
}