//HintName: G.Models.CustomPropertyValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the value for the property<br/>
    /// Example: single_select
    /// </summary>
    public enum CustomPropertyValueType
    {
        /// <summary>
        /// 
        /// </summary>
        MultiSelect,
        /// <summary>
        /// 
        /// </summary>
        SingleSelect,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        TrueFalse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomPropertyValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomPropertyValueType value)
        {
            return value switch
            {
                CustomPropertyValueType.MultiSelect => "multi_select",
                CustomPropertyValueType.SingleSelect => "single_select",
                CustomPropertyValueType.String => "string",
                CustomPropertyValueType.TrueFalse => "true_false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomPropertyValueType? ToEnum(string value)
        {
            return value switch
            {
                "multi_select" => CustomPropertyValueType.MultiSelect,
                "single_select" => CustomPropertyValueType.SingleSelect,
                "string" => CustomPropertyValueType.String,
                "true_false" => CustomPropertyValueType.TrueFalse,
                _ => null,
            };
        }
    }
}