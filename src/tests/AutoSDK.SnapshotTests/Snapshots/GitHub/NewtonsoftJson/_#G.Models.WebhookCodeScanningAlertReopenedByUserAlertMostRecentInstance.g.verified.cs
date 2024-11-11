//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance
    {
        /// <summary>
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string AnalysisKey { get; set; } = default!;

        /// <summary>
        /// Identifies the configuration under which the analysis was executed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classifications")]
        public global::System.Collections.Generic.IList<string>? Classifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_sha")]
        public string? CommitSha { get; set; }

        /// <summary>
        /// Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Environment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceLocation? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceMessage? Message { get; set; }

        /// <summary>
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// State of a code scanning alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState State { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance" /> class.
        /// </summary>
        /// <param name="analysisKey">
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </param>
        /// <param name="category">
        /// Identifies the configuration under which the analysis was executed.
        /// </param>
        /// <param name="classifications"></param>
        /// <param name="commitSha"></param>
        /// <param name="environment">
        /// Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed.
        /// </param>
        /// <param name="location"></param>
        /// <param name="message"></param>
        /// <param name="ref">
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`.
        /// </param>
        /// <param name="state">
        /// State of a code scanning alert.
        /// </param>
        public WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance(
            string analysisKey,
            string environment,
            string @ref,
            global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceState state,
            string? category,
            global::System.Collections.Generic.IList<string>? classifications,
            string? commitSha,
            global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceLocation? location,
            global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceMessage? message)
        {
            this.AnalysisKey = analysisKey ?? throw new global::System.ArgumentNullException(nameof(analysisKey));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.State = state;
            this.Category = category;
            this.Classifications = classifications;
            this.CommitSha = commitSha;
            this.Location = location;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance" /> class.
        /// </summary>
        public WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance?>(serializer.Deserialize<global::G.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstance>(jsonReader));
        }

    }
}