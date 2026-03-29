//HintName: G.Models.UpsertVideoTranslationsSuccessApiResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertVideoTranslationsSuccessApiResponse
    {
        /// <summary>
        /// The ID of the studio video to translate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// List of translations that were created or updated.<br/>
        /// Example: [{"language":"fr","status":"in_progress","step":"translation"}]
        /// </summary>
        /// <example>[{"language":"fr","status":"in_progress","step":"translation"}]</example>
        [global::Newtonsoft.Json.JsonProperty("translations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UpsertVideoTranslationsRunningWorkflowApiItem> Translations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertVideoTranslationsSuccessApiResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the studio video to translate.
        /// </param>
        /// <param name="translations">
        /// List of translations that were created or updated.<br/>
        /// Example: [{"language":"fr","status":"in_progress","step":"translation"}]
        /// </param>
        public UpsertVideoTranslationsSuccessApiResponse(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::G.UpsertVideoTranslationsRunningWorkflowApiItem> translations)
        {
            this.Id = id;
            this.Translations = translations ?? throw new global::System.ArgumentNullException(nameof(translations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertVideoTranslationsSuccessApiResponse" /> class.
        /// </summary>
        public UpsertVideoTranslationsSuccessApiResponse()
        {
        }
    }
}