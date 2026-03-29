//HintName: G.Models.GetFocusReportSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range.<br/>
    /// Example: invoice
    /// </summary>
    public enum GetFocusReportSource
    {
        /// <summary>
        /// 
        /// </summary>
        Estimate,
        /// <summary>
        /// 
        /// </summary>
        Invoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFocusReportSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportSource value)
        {
            return value switch
            {
                GetFocusReportSource.Estimate => "estimate",
                GetFocusReportSource.Invoice => "invoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportSource? ToEnum(string value)
        {
            return value switch
            {
                "estimate" => GetFocusReportSource.Estimate,
                "invoice" => GetFocusReportSource.Invoice,
                _ => null,
            };
        }
    }
}