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
                _ => null,
            };
        }
    }
}