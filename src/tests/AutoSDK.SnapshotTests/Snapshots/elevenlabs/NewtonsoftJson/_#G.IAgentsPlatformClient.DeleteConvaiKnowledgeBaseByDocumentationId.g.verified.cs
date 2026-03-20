//HintName: G.IAgentsPlatformClient.DeleteConvaiKnowledgeBaseByDocumentationId.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// Delete Knowledge Base Document Or Folder<br/>
        /// Delete a document or folder from the knowledge base.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="force">
        /// If set to true, the document or folder will be deleted regardless of whether it is used by any agents and it will be removed from the dependent agents. For non-empty folders, this will also delete all child documents and folders.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteConvaiKnowledgeBaseByDocumentationIdAsync(
            string documentationId,
            bool? force = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}