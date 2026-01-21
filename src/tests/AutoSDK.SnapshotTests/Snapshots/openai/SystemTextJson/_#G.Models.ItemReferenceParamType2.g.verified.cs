//HintName: G.Models.ItemReferenceParamType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of item to reference. Always `item_reference`.<br/>
    /// Default Value: item_reference
    /// </summary>
    public enum ItemReferenceParamType2
    {
        /// <summary>
        /// 
        /// </summary>
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ItemReferenceParamType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemReferenceParamType2 value)
        {
            return value switch
            {
                ItemReferenceParamType2.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemReferenceParamType2? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => ItemReferenceParamType2.ItemReference,
                _ => null,
            };
        }
    }
}