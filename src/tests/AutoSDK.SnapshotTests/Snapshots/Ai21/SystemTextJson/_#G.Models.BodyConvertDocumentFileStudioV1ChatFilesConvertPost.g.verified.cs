//HintName: G.Models.BodyConvertDocumentFileStudioV1ChatFilesConvertPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyConvertDocumentFileStudioV1ChatFilesConvertPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyConvertDocumentFileStudioV1ChatFilesConvertPost" /> class.
        /// </summary>
        /// <param name="files"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyConvertDocumentFileStudioV1ChatFilesConvertPost(
            global::System.Collections.Generic.IList<byte[]> files)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyConvertDocumentFileStudioV1ChatFilesConvertPost" /> class.
        /// </summary>
        public BodyConvertDocumentFileStudioV1ChatFilesConvertPost()
        {
        }
    }
}