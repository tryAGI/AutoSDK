//HintName: G.Models.ComparativeExperiment.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// ComparativeExperiment schema.
    /// </summary>
    public sealed partial class ComparativeExperiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::G.AnyOf<string, object>? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::G.AnyOf<string, object>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ReferenceDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::G.AnyOf<global::G.ComparativeExperimentExtra, object>? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiments_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SimpleExperimentInfo> ExperimentsInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_stats")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::G.AnyOf<global::G.ComparativeExperimentFeedbackStats, object>? FeedbackStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}