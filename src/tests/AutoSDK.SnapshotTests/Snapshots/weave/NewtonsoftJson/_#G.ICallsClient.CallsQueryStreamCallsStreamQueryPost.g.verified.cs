//HintName: G.ICallsClient.CallsQueryStreamCallsStreamQueryPost.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Calls Query Stream
        /// </summary>
        /// <param name="accept">
        /// Default Value: application/jsonl
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CallsQueryStreamCallsStreamQueryPostAsync(

            global::G.CallsQueryReq request,
            string? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calls Query Stream
        /// </summary>
        /// <param name="accept">
        /// Default Value: application/jsonl
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="filter"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="sortBy"></param>
        /// <param name="query"></param>
        /// <param name="includeCosts">
        /// Beta, subject to change. If true, the response will include any model costs for each call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeFeedback">
        /// Beta, subject to change. If true, the response will include feedback for each call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeStorageSize">
        /// Beta, subject to change. If true, the response will include the storage size for a call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTotalStorageSize">
        /// Beta, subject to change. If true, the response will include the total storage size for a trace.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeUsernames">
        /// If true, the response will attempt to resolve each call's wb_user_id to a username for the duration of this request.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="columns"></param>
        /// <param name="expandColumns">
        /// Columns to expand, i.e. refs to other objects
        /// </param>
        /// <param name="returnExpandedColumnValues">
        /// If true, the response will include raw values for expanded columns. If false, the response expand_columns will only be used for filtering and ordering. This is useful for clients that want to resolve refs themselves, e.g. for performance reasons.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CallsQueryStreamCallsStreamQueryPostAsync(
            string projectId,
            string? accept = default,
            global::G.CallsFilter? filter = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy = default,
            global::G.Query? query = default,
            bool? includeCosts = default,
            bool? includeFeedback = default,
            bool? includeStorageSize = default,
            bool? includeTotalStorageSize = default,
            bool? includeUsernames = default,
            global::System.Collections.Generic.IList<string>? columns = default,
            global::System.Collections.Generic.IList<string>? expandColumns = default,
            bool? returnExpandedColumnValues = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}