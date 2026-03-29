//HintName: G.Models.UpsertVideoTranslationsRunningWorkflowApiItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertVideoTranslationsRunningWorkflowApiItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Default Value: in_progress
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStatusJsonConverter))]
        public global::G.UpsertVideoTranslationsRunningWorkflowApiItemStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStepJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UpsertVideoTranslationsRunningWorkflowApiItemStep Step { get; set; }

        /// <summary>
        /// Whether the translation was started by the request.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedByRequest")]
        public bool? StartedByRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertVideoTranslationsRunningWorkflowApiItem" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="step"></param>
        /// <param name="status">
        /// Default Value: in_progress
        /// </param>
        /// <param name="startedByRequest">
        /// Whether the translation was started by the request.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertVideoTranslationsRunningWorkflowApiItem(
            string language,
            global::G.UpsertVideoTranslationsRunningWorkflowApiItemStep step,
            global::G.UpsertVideoTranslationsRunningWorkflowApiItemStatus? status,
            bool? startedByRequest)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Status = status;
            this.Step = step;
            this.StartedByRequest = startedByRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertVideoTranslationsRunningWorkflowApiItem" /> class.
        /// </summary>
        public UpsertVideoTranslationsRunningWorkflowApiItem()
        {
        }
    }
}