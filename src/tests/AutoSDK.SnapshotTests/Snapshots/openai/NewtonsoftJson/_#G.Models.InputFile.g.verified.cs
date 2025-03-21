//HintName: G.Models.InputFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A file input to the model.
    /// </summary>
    public sealed partial class InputFile
    {
        /// <summary>
        /// The content of the file to be sent to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// The ID of the file to be sent to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The name of the file to be sent to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The type of the input item. Always `input_file`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputFileType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFile" /> class.
        /// </summary>
        /// <param name="fileData">
        /// The content of the file to be sent to the model.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file to be sent to the model.
        /// </param>
        /// <param name="filename">
        /// The name of the file to be sent to the model.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `input_file`.
        /// </param>
        public InputFile(
            string? fileData,
            string? fileId,
            string? filename,
            global::G.InputFileType type)
        {
            this.FileData = fileData;
            this.FileId = fileId;
            this.Filename = filename;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFile" /> class.
        /// </summary>
        public InputFile()
        {
        }
    }
}