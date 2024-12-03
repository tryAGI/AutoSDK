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
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// The SHA of the commit to which the analysis you are uploading relates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitSha { get; set; }

        /// <summary>
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnalysisKey { get; set; }

        /// <summary>
        /// Identifies the variable values associated with the environment in which this analysis was performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Example: error reading field xyz
        /// </summary>
        /// <example>error reading field xyz</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// The time that the analysis was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The total number of results in the analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResultsCount { get; set; }

        /// <summary>
        /// The total number of rules used in the analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RulesCount { get; set; }

        /// <summary>
        /// Unique identifier for this analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The REST API URL of the analysis resource.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// An identifier for the upload.<br/>
        /// Example: 6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53
        /// </summary>
        /// <example>6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sarif_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SarifId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodeScanningAnalysisTool Tool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deletable { get; set; }

        /// <summary>
        /// Warning generated when processing the analysis<br/>
        /// Example: 123 results were ignored
        /// </summary>
        /// <example>123 results were ignored</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Warning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
    }
}