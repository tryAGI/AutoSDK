//HintName: G.Models.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConvAIDashboardSettingsResponseModelChartDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call_success")]
        CallSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="criteria")]
        Criteria,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="data_collection")]
        DataCollection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConvAIDashboardSettingsResponseModelChartDiscriminatorType value)
        {
            return value switch
            {
                GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.CallSuccess => "call_success",
                GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.Criteria => "criteria",
                GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.DataCollection => "data_collection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConvAIDashboardSettingsResponseModelChartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "call_success" => GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.CallSuccess,
                "criteria" => GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.Criteria,
                "data_collection" => GetConvAIDashboardSettingsResponseModelChartDiscriminatorType.DataCollection,
                _ => null,
            };
        }
    }
}