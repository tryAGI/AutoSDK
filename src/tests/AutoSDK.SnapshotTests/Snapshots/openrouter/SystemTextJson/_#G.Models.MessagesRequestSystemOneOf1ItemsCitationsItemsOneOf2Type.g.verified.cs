//HintName: G.Models.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ContentBlockLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2Type value)
        {
            return value switch
            {
                MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2Type.ContentBlockLocation => "content_block_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "content_block_location" => MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2Type.ContentBlockLocation,
                _ => null,
            };
        }
    }
}