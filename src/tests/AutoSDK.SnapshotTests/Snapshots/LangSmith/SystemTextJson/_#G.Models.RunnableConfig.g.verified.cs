//HintName: G.Models.RunnableConfig.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a Runnable.
    /// </summary>
    public sealed partial class RunnableConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbacks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<object>, object>? Callbacks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_name")]
        public string? RunName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrency")]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recursion_limit")]
        public int? RecursionLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurable")]
        public object? Configurable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public global::System.Guid? RunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunnableConfig" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="metadata"></param>
        /// <param name="callbacks"></param>
        /// <param name="runName"></param>
        /// <param name="maxConcurrency"></param>
        /// <param name="recursionLimit"></param>
        /// <param name="configurable"></param>
        /// <param name="runId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunnableConfig(
            global::System.Collections.Generic.IList<string>? tags,
            object? metadata,
            global::G.AnyOf<global::System.Collections.Generic.IList<object>, object>? callbacks,
            string? runName,
            int? maxConcurrency,
            int? recursionLimit,
            object? configurable,
            global::System.Guid? runId)
        {
            this.Tags = tags;
            this.Metadata = metadata;
            this.Callbacks = callbacks;
            this.RunName = runName;
            this.MaxConcurrency = maxConcurrency;
            this.RecursionLimit = recursionLimit;
            this.Configurable = configurable;
            this.RunId = runId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunnableConfig" /> class.
        /// </summary>
        public RunnableConfig()
        {
        }
    }
}