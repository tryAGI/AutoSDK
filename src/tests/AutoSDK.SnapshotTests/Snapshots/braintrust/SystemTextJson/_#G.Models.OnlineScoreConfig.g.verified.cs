//HintName: G.Models.OnlineScoreConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnlineScoreConfig
    {
        /// <summary>
        /// The sampling rate for online scoring
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SamplingRate { get; set; }

        /// <summary>
        /// The list of functions to run for online scoring. Can include scorers, facets, or other function types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AllOf<global::G.SavedFunctionId?, global::G.AnyOf<global::G.OnlineScoreConfigScorerVariant2Function, global::G.OnlineScoreConfigScorerVariant2Global>?>> Scorers { get; set; }

        /// <summary>
        /// Filter logs using BTQL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btql_filter")]
        public string? BtqlFilter { get; set; }

        /// <summary>
        /// Whether to trigger online scoring on the root span of each trace. Only applies when scope is 'span' or unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_to_root_span")]
        public bool? ApplyToRootSpan { get; set; }

        /// <summary>
        /// Trigger online scoring on any spans with a name in this list. Only applies when scope is 'span' or unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_to_span_names")]
        public global::System.Collections.Generic.IList<string>? ApplyToSpanNames { get; set; }

        /// <summary>
        /// Whether to skip adding scorer spans when computing scores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_logging")]
        public bool? SkipLogging { get; set; }

        /// <summary>
        /// The scope at which to run the functions. Defaults to span-level execution. Trace/group scope requires all functions to be facets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.SpanScope, global::G.TraceScope, global::G.GroupScope, object>))]
        public global::G.AnyOf<global::G.SpanScope, global::G.TraceScope, global::G.GroupScope, object>? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineScoreConfig" /> class.
        /// </summary>
        /// <param name="samplingRate">
        /// The sampling rate for online scoring
        /// </param>
        /// <param name="scorers">
        /// The list of functions to run for online scoring. Can include scorers, facets, or other function types.
        /// </param>
        /// <param name="btqlFilter">
        /// Filter logs using BTQL
        /// </param>
        /// <param name="applyToRootSpan">
        /// Whether to trigger online scoring on the root span of each trace. Only applies when scope is 'span' or unset.
        /// </param>
        /// <param name="applyToSpanNames">
        /// Trigger online scoring on any spans with a name in this list. Only applies when scope is 'span' or unset.
        /// </param>
        /// <param name="skipLogging">
        /// Whether to skip adding scorer spans when computing scores
        /// </param>
        /// <param name="scope">
        /// The scope at which to run the functions. Defaults to span-level execution. Trace/group scope requires all functions to be facets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OnlineScoreConfig(
            double samplingRate,
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.SavedFunctionId?, global::G.AnyOf<global::G.OnlineScoreConfigScorerVariant2Function, global::G.OnlineScoreConfigScorerVariant2Global>?>> scorers,
            string? btqlFilter,
            bool? applyToRootSpan,
            global::System.Collections.Generic.IList<string>? applyToSpanNames,
            bool? skipLogging,
            global::G.AnyOf<global::G.SpanScope, global::G.TraceScope, global::G.GroupScope, object>? scope)
        {
            this.SamplingRate = samplingRate;
            this.Scorers = scorers ?? throw new global::System.ArgumentNullException(nameof(scorers));
            this.BtqlFilter = btqlFilter;
            this.ApplyToRootSpan = applyToRootSpan;
            this.ApplyToSpanNames = applyToSpanNames;
            this.SkipLogging = skipLogging;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineScoreConfig" /> class.
        /// </summary>
        public OnlineScoreConfig()
        {
        }
    }
}