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
        [global::System.Text.Json.Serialization.JsonPropertyName("folder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MemoFolder Folder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderRequest" /> class.
        /// </summary>
        /// <param name="folder"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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