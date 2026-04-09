//HintName: G.IMetaInformationClient.GetUsage.g.cs
#nullable enable

namespace G
{
    public partial interface IMetaInformationClient
    {
        /// <summary>
        /// Check Usage and Limits<br/>
        /// Retrieve usage information within the current billing period together with the corresponding account limits. Usage is returned for:<br/>
        /// - translated characters<br/>
        /// - translated documents<br/>
        /// - translated documents, team totals (for team accounts only)<br/>
        /// Character usage includes both text and document translations, and is measured by the source text length in Unicode code points,<br/>
        /// so for example "A", "Δ", "あ", and "深" are each counted as a single character.<br/>
        /// Document usage only includes document translations, and is measured in individual documents.<br/>
        /// Depending on the user account type, some usage types will be omitted.<br/>
        /// Character usage is only included for developer accounts.<br/>
        /// Document usage is only included for non-developer accounts, and team-combined document usage is only included for non-developer team accounts.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UsageResponse> GetUsageAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Usage and Limits<br/>
        /// Retrieve usage information within the current billing period together with the corresponding account limits. Usage is returned for:<br/>
        /// - translated characters<br/>
        /// - translated documents<br/>
        /// - translated documents, team totals (for team accounts only)<br/>
        /// Character usage includes both text and document translations, and is measured by the source text length in Unicode code points,<br/>
        /// so for example "A", "Δ", "あ", and "深" are each counted as a single character.<br/>
        /// Document usage only includes document translations, and is measured in individual documents.<br/>
        /// Depending on the user account type, some usage types will be omitted.<br/>
        /// Character usage is only included for developer accounts.<br/>
        /// Document usage is only included for non-developer accounts, and team-combined document usage is only included for non-developer team accounts.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.UsageResponse>> GetUsageAsResponseAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}