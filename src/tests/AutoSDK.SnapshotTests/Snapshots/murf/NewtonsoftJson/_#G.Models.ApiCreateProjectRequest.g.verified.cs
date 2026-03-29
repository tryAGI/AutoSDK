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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Source Locale
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_locale")]
        public string? SourceLocale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dubbing_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiCreateProjectRequestDubbingType DubbingType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

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