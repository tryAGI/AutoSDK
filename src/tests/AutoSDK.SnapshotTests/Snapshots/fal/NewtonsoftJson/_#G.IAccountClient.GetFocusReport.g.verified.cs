//HintName: G.IAccountClient.GetFocusReport.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// FOCUS Report<br/>
        /// Returns a FOCUS compliant billing report as a CSV download.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with FOCUS reports enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// Supports two data sources:<br/>
        /// - **invoice**: Finalized invoice data for a billing month. Includes usage charges, credits, and taxes.<br/>
        /// - **estimate**: Real-time usage estimates for a date range. Pre-invoice data that may change once invoiced.<br/>
        /// The report follows the [FinOps FOCUS specification](https://focus.finops.org/) for cloud billing data interoperability.<br/>
        /// **Invoice reports** default to the most recently available billing month.<br/>
        /// **Usage estimates** default to the last 24 hours, with a maximum 90-day lookback.<br/>
        ///     
        /// </summary>
        /// <param name="source">
        /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range.<br/>
        /// Example: invoice
        /// </param>
        /// <param name="billingMonth">
        /// Invoice billing month (YYYY-MM). The month the invoice was issued (e.g. '2025-02' for January charges). Used with source=invoice. Defaults to most recent available billing month.<br/>
        /// Example: 2025-02
        /// </param>
        /// <param name="chargeMonth">
        /// Charge month (YYYY-MM). The month charges were incurred. Converted to billing_month by adding 1 month (billing in arrears). Alternative to billing_month. Used with source=invoice.<br/>
        /// Example: 2025-01
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="timezone">
        /// Timezone for date aggregation and boundaries. All timestamps in responses are in UTC, but this controls how dates are bucketed.<br/>
        /// Default Value: UTC<br/>
        /// Example: UTC
        /// </param>
        /// <param name="timeframe">
        /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="boundToTimeframe">
        /// Whether to adjust start/end dates to align with timeframe boundaries and use exclusive end. Defaults to true. When true, dates are aligned to the start of the timeframe period (e.g., start of day) and end is made exclusive (e.g., start of next day). When false, uses exact dates provided.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFocusReportAsync(
            global::G.GetFocusReportSource source,
            string? billingMonth = default,
            string? chargeMonth = default,
            global::G.AnyOf<global::System.DateTime?, string>? start = default,
            global::G.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::G.GetFocusReportTimeframe? timeframe = default,
            global::G.GetFocusReportBoundToTimeframe? boundToTimeframe = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}