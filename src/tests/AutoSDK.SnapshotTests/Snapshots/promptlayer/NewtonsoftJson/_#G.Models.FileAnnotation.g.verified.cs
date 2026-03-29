//HintName: G.Models.FileAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileAnnotation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"file_citation"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "file_citation";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAnnotation" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="fileId"></param>
        /// <param name="filename"></param>
        /// <param name="type"></param>
        public FileAnnotation(
            int index,
            string fileId,
            string filename,
            string type = "file_citation")
        {
            this.Type = type;
            this.Index = index;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAnnotation" /> class.
        /// </summary>
        public FileAnnotation()
        {
        }
    }
}