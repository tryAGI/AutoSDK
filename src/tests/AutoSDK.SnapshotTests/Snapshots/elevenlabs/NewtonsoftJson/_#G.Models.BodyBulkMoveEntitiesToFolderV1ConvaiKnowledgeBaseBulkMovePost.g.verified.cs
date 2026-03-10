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
        [global::Newtonsoft.Json.JsonProperty("document_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> DocumentIds { get; set; } = default!;

        /// <summary>
        /// The folder to move the entities to. If not set, the entities will be moved to the root folder.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("move_to")]
        public string? MoveTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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