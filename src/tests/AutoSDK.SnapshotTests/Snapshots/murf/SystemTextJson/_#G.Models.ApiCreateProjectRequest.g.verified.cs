//HintName: G.Models.ApiCreateProjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiCreateProjectRequest
    {
        /// <summary>
        /// Your Project Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Source Locale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_locale")]
        public string? SourceLocale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbing_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiCreateProjectRequestDubbingTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiCreateProjectRequestDubbingType DubbingType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        /// Initializes a new instance of the <see cref="ApiCreateProjectRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Your Project Name
        /// </param>
        /// <param name="dubbingType"></param>
        /// <param name="targetLocales">
        /// List of target locales
        /// </param>
        /// <param name="sourceLocale">
        /// Source Locale
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiCreateProjectRequest(
            string name,
            global::G.ApiCreateProjectRequestDubbingType dubbingType,
            global::System.Collections.Generic.IList<string> targetLocales,
            string? sourceLocale,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceLocale = sourceLocale;
            this.DubbingType = dubbingType;
            this.Description = description;
            this.TargetLocales = targetLocales ?? throw new global::System.ArgumentNullException(nameof(targetLocales));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCreateProjectRequest" /> class.
        /// </summary>
        public ApiCreateProjectRequest()
        {
        }
    }
}