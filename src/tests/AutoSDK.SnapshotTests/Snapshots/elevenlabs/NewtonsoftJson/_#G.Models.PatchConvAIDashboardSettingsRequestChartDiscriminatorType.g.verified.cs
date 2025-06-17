//HintName: G.Models.PatchConvAIDashboardSettingsRequestChartDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchConvAIDashboardSettingsRequestChartDiscriminatorType
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
    public static class PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchConvAIDashboardSettingsRequestChartDiscriminatorType value)
        {
            return value switch
            {
                PatchConvAIDashboardSettingsRequestChartDiscriminatorType.CallSuccess => "call_success",
                PatchConvAIDashboardSettingsRequestChartDiscriminatorType.Criteria => "criteria",
                PatchConvAIDashboardSettingsRequestChartDiscriminatorType.DataCollection => "data_collection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchConvAIDashboardSettingsRequestChartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "call_success" => PatchConvAIDashboardSettingsRequestChartDiscriminatorType.CallSuccess,
                "criteria" => PatchConvAIDashboardSettingsRequestChartDiscriminatorType.Criteria,
                "data_collection" => PatchConvAIDashboardSettingsRequestChartDiscriminatorType.DataCollection,
                _ => null,
            };
        }
    }
}