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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// List of translations that were created or updated.<br/>
        /// Example: [{"language":"fr","status":"in_progress","step":"translation"}]
        /// </summary>
        /// <example>[{"language":"fr","status":"in_progress","step":"translation"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("translations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UpsertVideoTranslationsRunningWorkflowApiItem> Translations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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