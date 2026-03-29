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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The File ID of the file to analyze. The file must be uploaded to the Writer platform before you use it with the Vision tool. Supported file types: JPG, PNG, PDF, TXT. The maximum allowed file size is 7MB.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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