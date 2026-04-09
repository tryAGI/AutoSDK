//HintName: G.IToolsClient.CountTools.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Count Tools<br/>
        /// Get a count of all tools available to agents belonging to the org of the user.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="names">
        /// Filter by specific tool names
        /// </param>
        /// <param name="toolIds">
        /// Filter by specific tool IDs - accepts repeated params or comma-separated values
        /// </param>
        /// <param name="search">
        /// Search tool names (case-insensitive partial match)
        /// </param>
        /// <param name="toolTypes">
        /// Filter by tool type(s) - accepts repeated params or comma-separated values
        /// </param>
        /// <param name="excludeToolTypes">
        /// Tool type(s) to exclude - accepts repeated params or comma-separated values
        /// </param>
        /// <param name="returnOnlyLettaTools">
        /// Count only tools with tool_type starting with 'letta_'<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeLettaTools">
        /// Exclude built-in Letta tools from the count<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<int> CountToolsAsync(
            string? name = default,
            global::System.Collections.Generic.IList<string>? names = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? toolTypes = default,
            global::System.Collections.Generic.IList<string>? excludeToolTypes = default,
            bool? returnOnlyLettaTools = default,
            bool? excludeLettaTools = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}