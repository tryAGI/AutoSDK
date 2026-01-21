//HintName: G.IConversationalAIClient.EditConvaiKnowledgeBaseByDocumentationId.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Update Document<br/>
        /// Update the name of a document
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse> EditConvaiKnowledgeBaseByDocumentationIdAsync(
            string documentationId,
            global::G.BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Document<br/>
        /// Update the name of a document
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse> EditConvaiKnowledgeBaseByDocumentationIdAsync(
            string documentationId,
            string name,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}