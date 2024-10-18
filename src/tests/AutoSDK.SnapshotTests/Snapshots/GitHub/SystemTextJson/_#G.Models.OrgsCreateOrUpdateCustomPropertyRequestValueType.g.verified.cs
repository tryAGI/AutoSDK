//HintName: G.Models.OrgsCreateOrUpdateCustomPropertyRequestValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the value for the property<br/>
    /// Example: single_select
    /// </summary>
    public enum OrgsCreateOrUpdateCustomPropertyRequestValueType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        SingleSelect,
        /// <summary>
        /// 
        /// </summary>
        MultiSelect,
        /// <summary>
        /// 
        /// </summary>
        TrueFalse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsCreateOrUpdateCustomPropertyRequestValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsCreateOrUpdateCustomPropertyRequestValueType value)
        {
            return value switch
            {
                OrgsCreateOrUpdateCustomPropertyRequestValueType.String => "string",
                OrgsCreateOrUpdateCustomPropertyRequestValueType.SingleSelect => "single_select",
                OrgsCreateOrUpdateCustomPropertyRequestValueType.MultiSelect => "multi_select",
                OrgsCreateOrUpdateCustomPropertyRequestValueType.TrueFalse => "true_false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsCreateOrUpdateCustomPropertyRequestValueType? ToEnum(string value)
        {
            return value switch
            {
                "string" => OrgsCreateOrUpdateCustomPropertyRequestValueType.String,
                "single_select" => OrgsCreateOrUpdateCustomPropertyRequestValueType.SingleSelect,
                "multi_select" => OrgsCreateOrUpdateCustomPropertyRequestValueType.MultiSelect,
                "true_false" => OrgsCreateOrUpdateCustomPropertyRequestValueType.TrueFalse,
                _ => null,
            };
        }
    }
}