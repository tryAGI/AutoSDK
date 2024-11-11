//HintName: G.Models.CodeScanningAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningAnalysis
    {
        /// <summary>
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit to which the analysis you are uploading relates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitSha { get; set; } = default!;

        /// <summary>
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string AnalysisKey { get; set; } = default!;

        /// <summary>
        /// Identifies the variable values associated with the environment in which this analysis was performed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Environment { get; set; } = default!;

        /// <summary>
        /// Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Example: error reading field xyz
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// The time that the analysis was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The total number of results in the analysis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ResultsCount { get; set; } = default!;

        /// <summary>
        /// The total number of rules used in the analysis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rules_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RulesCount { get; set; } = default!;

        /// <summary>
        /// Unique identifier for this analysis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The REST API URL of the analysis resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// An identifier for the upload.<br/>
        /// Example: 6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sarif_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SarifId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningAnalysisTool Tool { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deletable", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deletable { get; set; } = default!;

        /// <summary>
        /// Warning generated when processing the analysis<br/>
        /// Example: 123 results were ignored
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warning", Required = global::Newtonsoft.Json.Required.Always)]
        public string Warning { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAnalysis" /> class.
        /// </summary>
        /// <param name="ref">
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </param>
        /// <param name="commitSha">
        /// The SHA of the commit to which the analysis you are uploading relates.
        /// </param>
        /// <param name="analysisKey">
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </param>
        /// <param name="environment">
        /// Identifies the variable values associated with the environment in which this analysis was performed.
        /// </param>
        /// <param name="category">
        /// Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.
        /// </param>
        /// <param name="error">
        /// Example: error reading field xyz
        /// </param>
        /// <param name="createdAt">
        /// The time that the analysis was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="resultsCount">
        /// The total number of results in the analysis.
        /// </param>
        /// <param name="rulesCount">
        /// The total number of rules used in the analysis.
        /// </param>
        /// <param name="id">
        /// Unique identifier for this analysis.
        /// </param>
        /// <param name="url">
        /// The REST API URL of the analysis resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sarifId">
        /// An identifier for the upload.<br/>
        /// Example: 6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53
        /// </param>
        /// <param name="tool"></param>
        /// <param name="deletable"></param>
        /// <param name="warning">
        /// Warning generated when processing the analysis<br/>
        /// Example: 123 results were ignored
        /// </param>
        public CodeScanningAnalysis(
            string @ref,
            string commitSha,
            string analysisKey,
            string environment,
            string error,
            int resultsCount,
            int rulesCount,
            int id,
            string sarifId,
            global::G.CodeScanningAnalysisTool tool,
            bool deletable,
            string warning,
            string? category,
            global::System.DateTime createdAt = default!,
            string url = default!)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.CommitSha = commitSha ?? throw new global::System.ArgumentNullException(nameof(commitSha));
            this.AnalysisKey = analysisKey ?? throw new global::System.ArgumentNullException(nameof(analysisKey));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.ResultsCount = resultsCount;
            this.RulesCount = rulesCount;
            this.Id = id;
            this.SarifId = sarifId ?? throw new global::System.ArgumentNullException(nameof(sarifId));
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Deletable = deletable;
            this.Warning = warning ?? throw new global::System.ArgumentNullException(nameof(warning));
            this.Category = category;
            this.CreatedAt = createdAt;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAnalysis" /> class.
        /// </summary>
        public CodeScanningAnalysis()
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
        public static global::G.CodeScanningAnalysis? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeScanningAnalysis>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CodeScanningAnalysis?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodeScanningAnalysis?>(serializer.Deserialize<global::G.CodeScanningAnalysis>(jsonReader));
        }

    }
}