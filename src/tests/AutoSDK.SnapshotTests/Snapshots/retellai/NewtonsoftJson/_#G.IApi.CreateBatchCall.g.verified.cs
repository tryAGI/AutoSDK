//HintName: G.IApi.CreateBatchCall.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a batch call
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchCallResponse> CreateBatchCallAsync(

            global::G.CreateBatchCallRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch call
        /// </summary>
        /// <param name="name">
        /// The name of the batch call. Only used for your own reference.<br/>
        /// Example: First batch call
        /// </param>
        /// <param name="triggerTimestamp">
        /// The scheduled time for sending the batch call, represented as a Unix timestamp in milliseconds. If omitted, the call will be sent immediately.<br/>
        /// Example: 1735718400000
        /// </param>
        /// <param name="fromNumber">
        /// The number you own in E.164 format. Must be a number purchased from Retell or imported to Retell.<br/>
        /// Example: +14157774444
        /// </param>
        /// <param name="reservedConcurrency">
        /// Number of concurrency reserved for all other calls that are not triggered by batch calls, such as inbound calls.
        /// </param>
        /// <param name="tasks">
        /// A list of individual call tasks to be executed as part of the batch call. Each task represents a single outbound call and includes details such as the recipient's phone number and optional dynamic variables to personalize the call content.
        /// </param>
        /// <param name="callTimeWindow">
        /// Allowed calling windows in a specific timezone. Each window is a half-open interval [startMin, endMin) in minutes since 00:00 local time. Cross-midnight windows are NOT allowed (must satisfy startMin &lt; endMin). `endMin = 1440` (24:00) is valid.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchCallResponse> CreateBatchCallAsync(
            string fromNumber,
            global::System.Collections.Generic.IList<global::G.BatchCallTask> tasks,
            string? name = default,
            double? triggerTimestamp = default,
            int? reservedConcurrency = default,
            global::G.CallTimeWindow? callTimeWindow = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}