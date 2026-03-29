//HintName: G.Models.FileFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFile" /> class.
        /// </summary>
        /// <param name="fileData"></param>
        /// <param name="fileId"></param>
        /// <param name="filename"></param>
        public FileFile(
            string? fileData,
            string? fileId,
            string? filename)
        {
            this.FileData = fileData;
            this.FileId = fileId;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFile" /> class.
        /// </summary>
        public FileFile()
        {
        }
    }
}