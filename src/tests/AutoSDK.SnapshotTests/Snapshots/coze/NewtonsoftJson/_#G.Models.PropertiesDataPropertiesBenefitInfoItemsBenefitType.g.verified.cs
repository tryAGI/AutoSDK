//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsBenefitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesDataPropertiesBenefitInfoItemsBenefitType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_run_qps")]
        ApiRunQps,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call_tool_limit")]
        CallToolLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesDataPropertiesBenefitInfoItemsBenefitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesDataPropertiesBenefitInfoItemsBenefitType value)
        {
            return value switch
            {
                PropertiesDataPropertiesBenefitInfoItemsBenefitType.ApiRunQps => "api_run_qps",
                PropertiesDataPropertiesBenefitInfoItemsBenefitType.CallToolLimit => "call_tool_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesDataPropertiesBenefitInfoItemsBenefitType? ToEnum(string value)
        {
            return value switch
            {
                "api_run_qps" => PropertiesDataPropertiesBenefitInfoItemsBenefitType.ApiRunQps,
                "call_tool_limit" => PropertiesDataPropertiesBenefitInfoItemsBenefitType.CallToolLimit,
                _ => null,
            };
        }
    }
}