//HintName: G.Models.VisionRequestFileVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of file variables required for the analysis. The files must be uploaded to the Writer platform before they can be used in a vision request. Learn how to upload files using the [Files API](https://dev.writer.com/api-reference/file-api/upload-files).<br/>
    /// Supported file types: JPG, PNG, PDF, TXT. The maximum allowed file size for each file is 7MB.
    /// </summary>
    public sealed partial class VisionRequestFileVariable
    {
        /// <summary>
        /// The name of the file variable. You must reference this name in the prompt with double curly braces (`{{}}`). For example, `Describe the difference between the image {{image_1}} and the image {{image_2}}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The File ID of the file to analyze. The file must be uploaded to the Writer platform before it can be used in a vision request. Supported file types: JPG, PNG, PDF, TXT (max 7MB each).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionRequestFileVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the file variable. You must reference this name in the prompt with double curly braces (`{{}}`). For example, `Describe the difference between the image {{image_1}} and the image {{image_2}}`.
        /// </param>
        /// <param name="fileId">
        /// The File ID of the file to analyze. The file must be uploaded to the Writer platform before it can be used in a vision request. Supported file types: JPG, PNG, PDF, TXT (max 7MB each).
        /// </param>
        public VisionRequestFileVariable(
            string name,
            string fileId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionRequestFileVariable" /> class.
        /// </summary>
        public VisionRequestFileVariable()
        {
        }
    }
}