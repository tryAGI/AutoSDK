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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("converting", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Converting { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_snippet", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlSnippet { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioNativeCreateProjectResponseModel" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="converting"></param>
        /// <param name="htmlSnippet"></param>
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