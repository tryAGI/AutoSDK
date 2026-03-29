//HintName: G.Models.PatchSpanIFrame.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchSpanIFrame
    {
        /// <summary>
        /// Name of the span iframe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL to embed the project viewer in an iframe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Whether to post messages to the iframe containing the span's data. This is useful when you want to render more data than fits in the URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_message")]
        public bool? PostMessage { get; set; }

        /// <summary>
        /// Textual description of the span iframe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSpanIFrame" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the span iframe
        /// </param>
        /// <param name="url">
        /// URL to embed the project viewer in an iframe
        /// </param>
        /// <param name="postMessage">
        /// Whether to post messages to the iframe containing the span's data. This is useful when you want to render more data than fits in the URL.
        /// </param>
        /// <param name="description">
        /// Textual description of the span iframe
        /// </param>
        public PatchSpanIFrame(
            string? name,
            string? url,
            bool? postMessage,
            string? description)
        {
            this.Name = name;
            this.Url = url;
            this.PostMessage = postMessage;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSpanIFrame" /> class.
        /// </summary>
        public PatchSpanIFrame()
        {
        }
    }
}