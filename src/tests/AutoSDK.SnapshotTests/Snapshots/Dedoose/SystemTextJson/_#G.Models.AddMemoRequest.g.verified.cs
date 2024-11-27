//HintName: G.Models.AddMemoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddMemoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> FolderIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedObjects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MemoLinkedObjects LinkedObjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMemoRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="dataPath"></param>
        /// <param name="folderIds"></param>
        /// <param name="linkedObjects"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AddMemoRequest(
            global::System.Guid projectId,
            string title,
            string dataPath,
            global::System.Collections.Generic.IList<global::System.Guid> folderIds,
            global::G.MemoLinkedObjects linkedObjects)
        {
            this.ProjectId = projectId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.DataPath = dataPath ?? throw new global::System.ArgumentNullException(nameof(dataPath));
            this.FolderIds = folderIds ?? throw new global::System.ArgumentNullException(nameof(folderIds));
            this.LinkedObjects = linkedObjects ?? throw new global::System.ArgumentNullException(nameof(linkedObjects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMemoRequest" /> class.
        /// </summary>
        public AddMemoRequest()
        {
        }
    }
}