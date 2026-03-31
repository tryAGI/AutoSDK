//HintName: G.Models.ProjectSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSettings
    {
        /// <summary>
        /// The key used to join two experiments (defaults to `input`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison_key")]
        public string? ComparisonKey { get; set; }

        /// <summary>
        /// The id of the experiment to use as the default baseline for comparisons
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_experiment_id")]
        public global::System.Guid? BaselineExperimentId { get; set; }

        /// <summary>
        /// The order of the fields to display in the trace view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanFieldOrder")]
        public global::System.Collections.Generic.IList<global::G.ProjectSettingsSpanFieldOrderItem>? SpanFieldOrder { get; set; }

        /// <summary>
        /// The remote eval sources to use for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_eval_sources")]
        public global::System.Collections.Generic.IList<global::G.ProjectSettingsRemoteEvalSource>? RemoteEvalSources { get; set; }

        /// <summary>
        /// If true, disable real-time queries for this project. This can improve query performance for high-volume logs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_realtime_queries")]
        public bool? DisableRealtimeQueries { get; set; }

        /// <summary>
        /// Default preprocessor for this project. When set, functions that use preprocessors will use this instead of their built-in default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_preprocessor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NullableSavedFunctionIdJsonConverter))]
        public global::G.NullableSavedFunctionId? DefaultPreprocessor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettings" /> class.
        /// </summary>
        /// <param name="comparisonKey">
        /// The key used to join two experiments (defaults to `input`)
        /// </param>
        /// <param name="baselineExperimentId">
        /// The id of the experiment to use as the default baseline for comparisons
        /// </param>
        /// <param name="spanFieldOrder">
        /// The order of the fields to display in the trace view
        /// </param>
        /// <param name="remoteEvalSources">
        /// The remote eval sources to use for the project
        /// </param>
        /// <param name="disableRealtimeQueries">
        /// If true, disable real-time queries for this project. This can improve query performance for high-volume logs.
        /// </param>
        /// <param name="defaultPreprocessor">
        /// Default preprocessor for this project. When set, functions that use preprocessors will use this instead of their built-in default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSettings(
            string? comparisonKey,
            global::System.Guid? baselineExperimentId,
            global::System.Collections.Generic.IList<global::G.ProjectSettingsSpanFieldOrderItem>? spanFieldOrder,
            global::System.Collections.Generic.IList<global::G.ProjectSettingsRemoteEvalSource>? remoteEvalSources,
            bool? disableRealtimeQueries,
            global::G.NullableSavedFunctionId? defaultPreprocessor)
        {
            this.ComparisonKey = comparisonKey;
            this.BaselineExperimentId = baselineExperimentId;
            this.SpanFieldOrder = spanFieldOrder;
            this.RemoteEvalSources = remoteEvalSources;
            this.DisableRealtimeQueries = disableRealtimeQueries;
            this.DefaultPreprocessor = defaultPreprocessor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettings" /> class.
        /// </summary>
        public ProjectSettings()
        {
        }
    }
}