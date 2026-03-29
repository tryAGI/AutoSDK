//HintName: G.Models.ApiProjectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectResponse
    {
        /// <summary>
        /// Your Project Id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Project Name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Source Locale
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_locale")]
        public string? SourceLocale { get; set; }

        /// <summary>
        /// Dubbing Type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dubbing_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiProjectResponseDubbingType DubbingType { get; set; } = default!;

        /// <summary>
        /// List of target locales
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_locales", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TargetLocales { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectResponse" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Your Project Id
        /// </param>
        /// <param name="dubbingType">
        /// Dubbing Type
        /// </param>
        /// <param name="targetLocales">
        /// List of target locales
        /// </param>
        /// <param name="name">
        /// Project Name
        /// </param>
        /// <param name="description"></param>
        /// <param name="sourceLocale">
        /// Source Locale
        /// </param>
        public ApiProjectResponse(
            string projectId,
            global::G.ApiProjectResponseDubbingType dubbingType,
            global::System.Collections.Generic.IList<string> targetLocales,
            string? name,
            string? description,
            string? sourceLocale)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name;
            this.Description = description;
            this.SourceLocale = sourceLocale;
            this.DubbingType = dubbingType;
            this.TargetLocales = targetLocales ?? throw new global::System.ArgumentNullException(nameof(targetLocales));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectResponse" /> class.
        /// </summary>
        public ApiProjectResponse()
        {
        }
    }
}