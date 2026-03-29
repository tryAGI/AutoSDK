//HintName: G.IAssistantsClient.CreateAssistant.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Create a new assistant<br/>
        /// Create a new assistant with the provided details
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Assistant> CreateAssistantAsync(

            global::G.Assistant request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new assistant<br/>
        /// Create a new assistant with the provided details
        /// </summary>
        /// <param name="id">
        /// Example: d290f1ee-6c54-4b01-90e6-d701748f0851
        /// </param>
        /// <param name="details"></param>
        /// <param name="credential">
        /// Example: 7db93c02-8d5a-4117-a8f1-3dfb6721b339
        /// </param>
        /// <param name="iconSrc">
        /// Example: /images/assistant.png
        /// </param>
        /// <param name="createdDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="updatedDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Assistant> CreateAssistantAsync(
            string? id = default,
            global::G.AssistantDetails? details = default,
            string? credential = default,
            string? iconSrc = default,
            global::System.DateTime? createdDate = default,
            global::System.DateTime? updatedDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}