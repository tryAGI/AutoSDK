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
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> Files { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyConvertDocumentFileStudioV1ChatFilesConvertPost" /> class.
        /// </summary>
        /// <param name="files"></param>
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