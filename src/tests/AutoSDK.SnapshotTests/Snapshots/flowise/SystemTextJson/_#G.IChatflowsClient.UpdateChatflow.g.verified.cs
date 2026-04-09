//HintName: G.IChatflowsClient.UpdateChatflow.g.cs
#nullable enable

namespace G
{
    public partial interface IChatflowsClient
    {
        /// <summary>
        /// Update chatflow details<br/>
        /// Update the details of an existing chatflow
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Chatflow> UpdateChatflowAsync(
            string id,

            global::G.Chatflow request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update chatflow details<br/>
        /// Update the details of an existing chatflow
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId">
        /// Example: d290f1ee-6c54-4b01-90e6-d701748f0851
        /// </param>
        /// <param name="name">
        /// Example: MyChatFlow
        /// </param>
        /// <param name="flowData">
        /// Example: {}
        /// </param>
        /// <param name="deployed"></param>
        /// <param name="isPublic"></param>
        /// <param name="apikeyid"></param>
        /// <param name="chatbotConfig">
        /// Example: {}
        /// </param>
        /// <param name="apiConfig">
        /// Example: {}
        /// </param>
        /// <param name="analytic">
        /// Example: {}
        /// </param>
        /// <param name="speechToText">
        /// Example: {}
        /// </param>
        /// <param name="category">
        /// Example: category1;category2
        /// </param>
        /// <param name="type"></param>
        /// <param name="createdDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="updatedDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Chatflow> UpdateChatflowAsync(
            string id,
            string? requestId = default,
            string? name = default,
            string? flowData = default,
            bool? deployed = default,
            bool? isPublic = default,
            string? apikeyid = default,
            string? chatbotConfig = default,
            string? apiConfig = default,
            string? analytic = default,
            string? speechToText = default,
            string? category = default,
            global::G.ChatflowType? type = default,
            global::System.DateTime? createdDate = default,
            global::System.DateTime? updatedDate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}