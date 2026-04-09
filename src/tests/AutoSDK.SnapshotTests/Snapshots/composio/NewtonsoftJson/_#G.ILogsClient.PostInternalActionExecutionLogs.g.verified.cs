//HintName: G.ILogsClient.PostInternalActionExecutionLogs.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Search and retrieve action execution logs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostInternalActionExecutionLogsResponse> PostInternalActionExecutionLogsAsync(

            global::G.PostInternalActionExecutionLogsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search and retrieve action execution logs
        /// </summary>
        /// <param name="cursor">
        /// cursor_that_can_be_used_to_paginate_through_the_logs
        /// </param>
        /// <param name="limit">
        /// number_of_logs_to_return
        /// </param>
        /// <param name="caseSensitive">
        /// whether_the_search_is_case_sensitive_or_not
        /// </param>
        /// <param name="from">
        /// start_time_of_the_logs_in_epoch_time
        /// </param>
        /// <param name="to">
        /// end_time_of_the_logs_in_epoch_time
        /// </param>
        /// <param name="searchParams"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostInternalActionExecutionLogsResponse> PostInternalActionExecutionLogsAsync(
            double? cursor = default,
            double? limit = default,
            bool? caseSensitive = default,
            double? from = default,
            double? to = default,
            global::System.Collections.Generic.IList<global::G.PostInternalActionExecutionLogsRequestSearchParam>? searchParams = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}