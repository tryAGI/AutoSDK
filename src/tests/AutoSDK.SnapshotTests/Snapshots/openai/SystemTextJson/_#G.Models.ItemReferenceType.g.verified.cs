//HintName: G.Models.ItemReferenceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of item to reference. Always `item_reference`.
    /// </summary>
    public enum ItemReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ItemReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemReferenceType value)
        {
            return value switch
            {
                ItemReferenceType.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => ItemReferenceType.ItemReference,
                _ => null,
            };
        }
    }
}