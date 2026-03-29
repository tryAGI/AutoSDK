//HintName: G.Models.SourceFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("md5sum")]
        public string? Md5sum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceFile" /> class.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="contentType"></param>
        /// <param name="md5sum"></param>
        public SourceFile(
            string? filename,
            string? contentType,
            string? md5sum)
        {
            this.Filename = filename;
            this.ContentType = contentType;
            this.Md5sum = md5sum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceFile" /> class.
        /// </summary>
        public SourceFile()
        {
        }
    }
}