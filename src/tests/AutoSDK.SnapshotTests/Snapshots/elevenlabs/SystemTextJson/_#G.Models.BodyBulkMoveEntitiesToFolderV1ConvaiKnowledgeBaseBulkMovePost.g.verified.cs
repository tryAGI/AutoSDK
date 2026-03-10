//HintName: G.Models.BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost
    {
        /// <summary>
        /// The ids of documents or folders from the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DocumentIds { get; set; }

        /// <summary>
        /// The folder to move the entities to. If not set, the entities will be moved to the root folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("move_to")]
        public string? MoveTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost" /> class.
        /// </summary>
        /// <param name="documentIds">
        /// The ids of documents or folders from the knowledge base.
        /// </param>
        /// <param name="moveTo">
        /// The folder to move the entities to. If not set, the entities will be moved to the root folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost(
            global::System.Collections.Generic.IList<string> documentIds,
            string? moveTo)
        {
            this.DocumentIds = documentIds ?? throw new global::System.ArgumentNullException(nameof(documentIds));
            this.MoveTo = moveTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost" /> class.
        /// </summary>
        public BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost()
        {
        }
    }
}