//HintName: G.Models.AudioNativeCreateProjectResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioNativeCreateProjectResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("converting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Converting { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="AudioNativeCreateProjectResponseModel" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="converting"></param>
        /// <param name="htmlSnippet"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AudioNativeCreateProjectResponseModel(
            string projectId,
            bool converting,
            string htmlSnippet)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Converting = converting;
            this.HtmlSnippet = htmlSnippet ?? throw new global::System.ArgumentNullException(nameof(htmlSnippet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioNativeCreateProjectResponseModel" /> class.
        /// </summary>
        public AudioNativeCreateProjectResponseModel()
        {
        }
    }
}