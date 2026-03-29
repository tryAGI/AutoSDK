//HintName: G.Models.ResponseItemReferenceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of item to reference. Always `item_reference`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseItemReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="item_reference")]
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemReferenceType value)
        {
            return value switch
            {
                ResponseItemReferenceType.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => ResponseItemReferenceType.ItemReference,
                _ => null,
            };
        }
    }
}