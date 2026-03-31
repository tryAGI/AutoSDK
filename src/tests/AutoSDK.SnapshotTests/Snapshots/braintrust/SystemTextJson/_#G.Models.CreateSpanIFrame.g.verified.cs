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
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Name of the span iframe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Textual description of the span iframe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL to embed the project viewer in an iframe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Whether to post messages to the iframe containing the span's data. This is useful when you want to render more data than fits in the URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_message")]
        public bool? PostMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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