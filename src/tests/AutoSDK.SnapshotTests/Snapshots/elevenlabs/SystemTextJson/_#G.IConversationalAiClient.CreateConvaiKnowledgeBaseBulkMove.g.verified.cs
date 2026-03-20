//HintName: G.IConversationalAiClient.CreateConvaiKnowledgeBaseBulkMove.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAiClient
    {
        /// <summary>
        /// Bulk Move Entities To Folder<br/>
        /// Moves multiple entities from one folder to another.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateConvaiKnowledgeBaseBulkMoveAsync(

            global::G.BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Move Entities To Folder<br/>
        /// Moves multiple entities from one folder to another.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="documentIds">
        /// The ids of documents or folders from the knowledge base.
        /// </param>
        /// <param name="moveTo">
        /// The folder to move the entities to. If not set, the entities will be moved to the root folder.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateConvaiKnowledgeBaseBulkMoveAsync(
            global::System.Collections.Generic.IList<string> documentIds,
            string? xiApiKey = default,
            string? moveTo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}