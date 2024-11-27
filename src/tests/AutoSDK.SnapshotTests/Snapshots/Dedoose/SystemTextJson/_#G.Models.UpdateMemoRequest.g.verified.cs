//HintName: G.Models.UpdateMemoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMemoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Memo Memo { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateMemoRequest" /> class.
        /// </summary>
        /// <param name="memo"></param>
        /// <param name="folderIds"></param>
        /// <param name="linkedObjects"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateMemoRequest(
            global::G.Memo memo,
            global::System.Collections.Generic.IList<global::System.Guid> folderIds,
            global::G.MemoLinkedObjects linkedObjects)
        {
            this.Memo = memo ?? throw new global::System.ArgumentNullException(nameof(memo));
            this.FolderIds = folderIds ?? throw new global::System.ArgumentNullException(nameof(folderIds));
            this.LinkedObjects = linkedObjects ?? throw new global::System.ArgumentNullException(nameof(linkedObjects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMemoRequest" /> class.
        /// </summary>
        public UpdateMemoRequest()
        {
        }
    }
}