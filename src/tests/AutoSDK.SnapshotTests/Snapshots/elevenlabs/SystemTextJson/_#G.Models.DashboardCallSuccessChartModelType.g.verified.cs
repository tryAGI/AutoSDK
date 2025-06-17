//HintName: G.Models.DashboardCallSuccessChartModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: call_success
    /// </summary>
    public enum DashboardCallSuccessChartModelType
    {
        /// <summary>
        /// 
        /// </summary>
        CallSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DashboardCallSuccessChartModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DashboardCallSuccessChartModelType value)
        {
            return value switch
            {
                DashboardCallSuccessChartModelType.CallSuccess => "call_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DashboardCallSuccessChartModelType? ToEnum(string value)
        {
            return value switch
            {
                "call_success" => DashboardCallSuccessChartModelType.CallSuccess,
                _ => null,
            };
        }
    }
}