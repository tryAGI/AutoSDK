//HintName: G.Models.VisionToolRequestFileVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VisionToolRequestFileVariable
    {
        /// <summary>
        /// The name of the file variable. You must reference this name in the `message.content` field of the request to the chat completions endpoint. Use double curly braces (`{{}}`) to reference the file. For example, `Describe the difference between the image {{image_1}} and the image {{image_2}}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The File ID of the file to analyze. The file must be uploaded to the Writer platform before you use it with the Vision tool. Supported file types: JPG, PNG, PDF, TXT. The maximum allowed file size is 7MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionToolRequestFileVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the file variable. You must reference this name in the `message.content` field of the request to the chat completions endpoint. Use double curly braces (`{{}}`) to reference the file. For example, `Describe the difference between the image {{image_1}} and the image {{image_2}}`.
        /// </param>
        /// <param name="fileId">
        /// The File ID of the file to analyze. The file must be uploaded to the Writer platform before you use it with the Vision tool. Supported file types: JPG, PNG, PDF, TXT. The maximum allowed file size is 7MB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionToolRequestFileVariable(
            string name,
            string fileId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionToolRequestFileVariable" /> class.
        /// </summary>
        public VisionToolRequestFileVariable()
        {
        }
    }
}