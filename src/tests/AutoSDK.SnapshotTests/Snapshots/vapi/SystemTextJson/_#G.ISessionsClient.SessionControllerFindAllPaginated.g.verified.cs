//HintName: G.ISessionsClient.SessionControllerFindAllPaginated.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// List Sessions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="assistantId"></param>
        /// <param name="assistantIdAny">
        /// Example: assistant-1,assistant-2,assistant-3
        /// </param>
        /// <param name="squadId"></param>
        /// <param name="workflowId"></param>
        /// <param name="numberE164CheckEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="extension">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="assistantOverrides"></param>
        /// <param name="number"></param>
        /// <param name="sipUri"></param>
        /// <param name="customerName"></param>
        /// <param name="email"></param>
        /// <param name="externalId"></param>
        /// <param name="customerNumberAny">
        /// Example: +1234567890,+0987654321
        /// </param>
        /// <param name="phoneNumberId"></param>
        /// <param name="phoneNumberIdAny"></param>
        /// <param name="page"></param>
        /// <param name="sortOrder"></param>
        /// <param name="limit"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="createdAtGe"></param>
        /// <param name="createdAtLe"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="updatedAtGe"></param>
        /// <param name="updatedAtLe"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SessionPaginatedResponse> SessionControllerFindAllPaginatedAsync(
            string? id = default,
            string? name = default,
            string? assistantId = default,
            string? assistantIdAny = default,
            string? squadId = default,
            string? workflowId = default,
            bool? numberE164CheckEnabled = default,
            string? extension = default,
            object? assistantOverrides = default,
            string? number = default,
            string? sipUri = default,
            string? customerName = default,
            string? email = default,
            string? externalId = default,
            string? customerNumberAny = default,
            string? phoneNumberId = default,
            global::System.Collections.Generic.IList<string>? phoneNumberIdAny = default,
            double? page = default,
            global::G.SessionControllerFindAllPaginatedSortOrder? sortOrder = default,
            double? limit = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? createdAtGe = default,
            global::System.DateTime? createdAtLe = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLt = default,
            global::System.DateTime? updatedAtGe = default,
            global::System.DateTime? updatedAtLe = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}