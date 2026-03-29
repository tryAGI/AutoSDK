//HintName: G.Models.DatasetsUploadFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetsUploadFileRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Purpose of the file (e.g., fine_tune)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose")]
        public string? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsUploadFileRequest" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="purpose">
        /// Purpose of the file (e.g., fine_tune)
        /// </param>
        public DatasetsUploadFileRequest(
            byte[]? file,
            string? filename,
            string? purpose)
        {
            this.File = file;
            this.Filename = filename;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsUploadFileRequest" /> class.
        /// </summary>
        public DatasetsUploadFileRequest()
        {
        }
    }
}