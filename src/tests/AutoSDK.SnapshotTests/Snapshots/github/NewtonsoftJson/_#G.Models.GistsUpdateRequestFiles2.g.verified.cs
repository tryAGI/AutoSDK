//HintName: G.Models.GistsUpdateRequestFiles2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistsUpdateRequestFiles2
    {
        /// <summary>
        /// The new content of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The new filename for the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsUpdateRequestFiles2" /> class.
        /// </summary>
        /// <param name="content">
        /// The new content of the file.
        /// </param>
        /// <param name="filename">
        /// The new filename for the file.
        /// </param>
        public GistsUpdateRequestFiles2(
            string? content,
            string? filename)
        {
            this.Content = content;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsUpdateRequestFiles2" /> class.
        /// </summary>
        public GistsUpdateRequestFiles2()
        {
        }
    }
}