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
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Project Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Source Locale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_locale")]
        public string? SourceLocale { get; set; }

        /// <summary>
        /// Dubbing Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbing_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiProjectResponseDubbingTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiProjectResponseDubbingType DubbingType { get; set; }

        /// <summary>
        /// List of target locales
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_locales")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TargetLocales { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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