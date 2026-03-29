//HintName: G.Models.CreateSpanIFrame.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpanIFrame
    {
        /// <summary>
        /// Unique identifier for the project that the span iframe belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Name of the span iframe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the span iframe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL to embed the project viewer in an iframe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Whether to post messages to the iframe containing the span's data. This is useful when you want to render more data than fits in the URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_message")]
        public bool? PostMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpanIFrame" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the span iframe belongs under
        /// </param>
        /// <param name="name">
        /// Name of the span iframe
        /// </param>
        /// <param name="url">
        /// URL to embed the project viewer in an iframe
        /// </param>
        /// <param name="description">
        /// Textual description of the span iframe
        /// </param>
        /// <param name="postMessage">
        /// Whether to post messages to the iframe containing the span's data. This is useful when you want to render more data than fits in the URL.
        /// </param>
        public CreateSpanIFrame(
            global::System.Guid projectId,
            string name,
            string url,
            string? description,
            bool? postMessage)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PostMessage = postMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpanIFrame" /> class.
        /// </summary>
        public CreateSpanIFrame()
        {
        }
    }
}