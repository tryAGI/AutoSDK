//HintName: G.Models.FilePath.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilePath
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FilePathTypeJsonConverter))]
        public global::G.FilePathType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public double Index { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilePath" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="index"></param>
        /// <param name="type"></param>
        public FilePath(
            string fileId,
            double index,
            global::G.FilePathType type)
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilePath" /> class.
        /// </summary>
        public FilePath()
        {
        }
    }
}