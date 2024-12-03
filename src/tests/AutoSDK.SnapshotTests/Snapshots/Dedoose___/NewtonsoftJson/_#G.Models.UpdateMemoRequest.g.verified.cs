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
        [global::Newtonsoft.Json.JsonProperty("memo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Memo Memo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folderIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> FolderIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("linkedObjects", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MemoLinkedObjects LinkedObjects { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMemoRequest" /> class.
        /// </summary>
        /// <param name="memo"></param>
        /// <param name="folderIds"></param>
        /// <param name="linkedObjects"></param>
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