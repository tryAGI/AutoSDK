//HintName: G.Models.ItemReferenceParamType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of item to reference. Always `item_reference`.<br/>
    /// Default Value: item_reference
    /// </summary>
    public enum ItemReferenceParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ItemReferenceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemReferenceParamType value)
        {
            return value switch
            {
                ItemReferenceParamType.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemReferenceParamType? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => ItemReferenceParamType.ItemReference,
                _ => null,
            };
        }
    }
}