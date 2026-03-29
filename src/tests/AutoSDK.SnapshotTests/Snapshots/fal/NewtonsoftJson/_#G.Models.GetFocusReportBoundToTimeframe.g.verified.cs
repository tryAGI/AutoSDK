//HintName: G.Models.GetFocusReportBoundToTimeframe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to adjust start/end dates to align with timeframe boundaries and use exclusive end. Defaults to true. When true, dates are aligned to the start of the timeframe period (e.g., start of day) and end is made exclusive (e.g., start of next day). When false, uses exact dates provided.<br/>
    /// Default Value: true<br/>
    /// Example: true
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetFocusReportBoundToTimeframe
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="false")]
        False,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="true")]
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFocusReportBoundToTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportBoundToTimeframe value)
        {
            return value switch
            {
                GetFocusReportBoundToTimeframe.False => "false",
                GetFocusReportBoundToTimeframe.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportBoundToTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetFocusReportBoundToTimeframe.False,
                "true" => GetFocusReportBoundToTimeframe.True,
                _ => null,
            };
        }
    }
}