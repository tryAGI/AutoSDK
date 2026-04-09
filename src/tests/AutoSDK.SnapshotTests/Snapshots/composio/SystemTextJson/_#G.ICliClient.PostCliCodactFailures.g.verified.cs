//HintName: G.ICliClient.PostCliCodactFailures.g.cs
#nullable enable

namespace G
{
    public partial interface ICliClient
    {
        /// <summary>
        /// Ingest CLI codact failures<br/>
        /// Accepts CLI-reported codact failures authenticated by user API key and stores them in ClickHouse for later analysis.
        /// </summary>
        /// <param name="xUserApiKey">
        /// User API key used to authenticate the CLI codact failure.<br/>
        /// Example: uak_abc123xyz456...
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostCliCodactFailuresResponse> PostCliCodactFailuresAsync(
            string xUserApiKey,

            global::G.PostCliCodactFailuresRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ingest CLI codact failures<br/>
        /// Accepts CLI-reported codact failures authenticated by user API key and stores them in ClickHouse for later analysis.
        /// </summary>
        /// <param name="xUserApiKey">
        /// User API key used to authenticate the CLI codact failure.<br/>
        /// Example: uak_abc123xyz456...
        /// </param>
        /// <param name="failureType">
        /// Type of codact failure being recorded.<br/>
        /// Example: wrong_tool_slug
        /// </param>
        /// <param name="toolInfo">
        /// Optional tool metadata when the failure can be tied to a toolkit or concrete tool version.<br/>
        /// Example: {"toolkit":"github","tool":{"slug":"GITHUB_CREATE_ISSUE","version":"2026.03.23"}}
        /// </param>
        /// <param name="ctx">
        /// Arbitrary failure context from the CLI.<br/>
        /// Example: {"invalid_tool_slug":"GITHUB_MAKE_ISSUE","candidate_tool_slugs":["GITHUB_CREATE_ISSUE"]}
        /// </param>
        /// <param name="session">
        /// Arbitrary session payload from the CLI.<br/>
        /// Example: {"id":"sess_123","model":"gpt-5.2"}
        /// </param>
        /// <param name="requestId">
        /// Optional request identifier associated with the failure.<br/>
        /// Example: req_123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostCliCodactFailuresResponse> PostCliCodactFailuresAsync(
            string xUserApiKey,
            global::G.PostCliCodactFailuresRequestFailureType failureType,
            global::System.Collections.Generic.Dictionary<string, object?> ctx,
            global::System.Collections.Generic.Dictionary<string, object?> session,
            global::G.PostCliCodactFailuresRequestToolInfo? toolInfo = default,
            string? requestId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}