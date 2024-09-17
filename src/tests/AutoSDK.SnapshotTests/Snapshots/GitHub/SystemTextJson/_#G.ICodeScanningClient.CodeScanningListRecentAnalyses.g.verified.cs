//HintName: G.ICodeScanningClient.CodeScanningListRecentAnalyses.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// List code scanning analyses for a repository<br/>
        /// Lists the details of all code scanning analyses for a repository,<br/>
        /// starting with the most recent.<br/>
        /// The response is paginated and you can use the `page` and `per_page` parameters<br/>
        /// to list the analyses you're interested in.<br/>
        /// By default 30 analyses are listed per page.<br/>
        /// The `rules_count` field in the response give the number of rules<br/>
        /// that were run in the analysis.<br/>
        /// For very old analyses this data is not available,<br/>
        /// and `0` is returned in this field.<br/>
        /// **Deprecation notice**:<br/>
        /// The `tool_name` field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The tool name can now be found inside the `tool` field.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="toolName">
        /// The name of the tool used to generate the code scanning analysis.
        /// </param>
        /// <param name="toolGuid">
        /// The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="ref">
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </param>
        /// <param name="sarifId">
        /// An identifier for the upload.<br/>
        /// Example: 6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CodeScanningAnalysis>> CodeScanningListRecentAnalysesAsync(
            string owner,
            string repo,
            string? toolName = default,
            string? toolGuid = default,
            int? page = 1,
            int? perPage = 30,
            string? @ref = default,
            string? sarifId = default,
            global::G.CodeScanningListRecentAnalysesDirection? direction = global::G.CodeScanningListRecentAnalysesDirection.Desc,
            global::G.CodeScanningListRecentAnalysesSort? sort = global::G.CodeScanningListRecentAnalysesSort.Created,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}