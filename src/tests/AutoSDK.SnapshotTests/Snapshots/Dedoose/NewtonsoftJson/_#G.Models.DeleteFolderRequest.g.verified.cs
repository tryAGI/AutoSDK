//HintName: G.Models.DeleteFolderRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFolderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MemoFolder Folder { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderRequest" /> class.
        /// </summary>
        /// <param name="folder"></param>
        public DeleteFolderRequest(
            global::G.MemoFolder folder)
        {
            this.Folder = folder ?? throw new global::System.ArgumentNullException(nameof(folder));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderRequest" /> class.
        /// </summary>
        public DeleteFolderRequest()
        {
        }
    }
}