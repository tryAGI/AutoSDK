//HintName: G.Models.AudioNativeEditContentResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"converting":false,"html_snippet":"\u003Cdiv id=\u0027audio-native-player\u0027\u003E\u003C/div\u003E","project_id":"JBFqnCBsd6RMkjVDRZzb","publishing":false}
    /// </summary>
    public sealed partial class AudioNativeEditContentResponseModel
    {
        /// <summary>
        /// The ID of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Whether the project is currently being converted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("converting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Converting { get; set; }

        /// <summary>
        /// Whether the project is currently being published.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Publishing { get; set; }

        /// <summary>
        /// The HTML snippet to embed the Audio Native player.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_snippet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlSnippet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioNativeEditContentResponseModel" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project.
        /// </param>
        /// <param name="converting">
        /// Whether the project is currently being converted.
        /// </param>
        /// <param name="publishing">
        /// Whether the project is currently being published.
        /// </param>
        /// <param name="htmlSnippet">
        /// The HTML snippet to embed the Audio Native player.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioNativeEditContentResponseModel(
            string projectId,
            bool converting,
            bool publishing,
            string htmlSnippet)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Converting = converting;
            this.Publishing = publishing;
            this.HtmlSnippet = htmlSnippet ?? throw new global::System.ArgumentNullException(nameof(htmlSnippet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioNativeEditContentResponseModel" /> class.
        /// </summary>
        public AudioNativeEditContentResponseModel()
        {
        }
    }
}