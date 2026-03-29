//HintName: G.Models.References.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed source information organized by reference type, providing comprehensive metadata about the sources used to generate the response.
    /// </summary>
    public sealed partial class References
    {
        /// <summary>
        /// Array of file-based references from uploaded documents in the Knowledge Graph.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.IList<global::G.File>? Files { get; set; }

        /// <summary>
        /// Array of web-based references from online sources accessed during the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web")]
        public global::System.Collections.Generic.IList<global::G.Web>? Web { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="References" /> class.
        /// </summary>
        /// <param name="files">
        /// Array of file-based references from uploaded documents in the Knowledge Graph.
        /// </param>
        /// <param name="web">
        /// Array of web-based references from online sources accessed during the query.
        /// </param>
        public References(
            global::System.Collections.Generic.IList<global::G.File>? files,
            global::System.Collections.Generic.IList<global::G.Web>? web)
        {
            this.Files = files;
            this.Web = web;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="References" /> class.
        /// </summary>
        public References()
        {
        }
    }
}