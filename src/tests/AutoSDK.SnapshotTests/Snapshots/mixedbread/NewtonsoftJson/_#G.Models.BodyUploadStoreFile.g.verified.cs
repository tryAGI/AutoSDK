//HintName: G.Models.BodyUploadStoreFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadStoreFile
    {
        /// <summary>
        /// The file to upload and index
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// The file to upload and index
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public string? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadStoreFile" /> class.
        /// </summary>
        /// <param name="file">
        /// The file to upload and index
        /// </param>
        /// <param name="filename">
        /// The file to upload and index
        /// </param>
        /// <param name="params"></param>
        public BodyUploadStoreFile(
            byte[] file,
            string filename,
            string? @params)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadStoreFile" /> class.
        /// </summary>
        public BodyUploadStoreFile()
        {
        }
    }
}