//HintName: G.ITracesClient.UpdateTrace.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Update trace by id<br/>
        /// Update trace by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateTraceAsync(
            global::System.Guid id,

            global::G.TraceUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update trace by id<br/>
        /// Update trace by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectName">
        /// If null and project_id not specified, Default Project is assumed
        /// </param>
        /// <param name="projectId">
        /// If null and project_name not specified, Default Project is assumed
        /// </param>
        /// <param name="name"></param>
        /// <param name="endTime"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="tags">
        /// Tags
        /// </param>
        /// <param name="tagsToAdd">
        /// Tags to add
        /// </param>
        /// <param name="tagsToRemove">
        /// Tags to remove
        /// </param>
        /// <param name="errorInfo"></param>
        /// <param name="threadId"></param>
        /// <param name="ttft"></param>
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateTraceAsync(
            global::System.Guid id,
            string? projectName = default,
            global::System.Guid? projectId = default,
            string? name = default,
            global::System.DateTime? endTime = default,
            global::G.JsonListString? input = default,
            global::G.JsonListString? output = default,
            global::G.JsonListString? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? tagsToAdd = default,
            global::System.Collections.Generic.IList<string>? tagsToRemove = default,
            global::G.ErrorInfo? errorInfo = default,
            string? threadId = default,
            double? ttft = default,
            global::G.TraceUpdateSource? source = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}