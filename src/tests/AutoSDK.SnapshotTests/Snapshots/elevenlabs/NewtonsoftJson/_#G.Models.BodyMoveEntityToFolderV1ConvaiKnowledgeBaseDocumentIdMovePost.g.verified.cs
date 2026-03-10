//HintName: G.Models.BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost
    {
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
        /// Initializes a new instance of the <see cref="BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost" /> class.
        /// </summary>
        /// <param name="moveTo">
        /// The folder to move the entities to. If not set, the entities will be moved to the root folder.
        /// </param>
        public BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost(
            string? moveTo)
        {
            this.MoveTo = moveTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost" /> class.
        /// </summary>
        public BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost()
        {
        }
    }
}