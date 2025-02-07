//HintName: G.Models.CodeScanningAlertInstance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningAlertInstance
    {
        /// <summary>
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_key")]
        public string? AnalysisKey { get; set; }

        /// <summary>
        /// Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// State of a code scanning alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeScanningAlertStateJsonConverter))]
        public global::G.CodeScanningAlertState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_sha")]
        public string? CommitSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::G.CodeScanningAlertInstanceMessage? Message { get; set; }

        /// <summary>
        /// Describe a region within a file for the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::G.CodeScanningAlertLocation? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Classifications that have been applied to the file that triggered the alert.<br/>
        /// For example identifying it as documentation, or a generated file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifications")]
        public global::System.Collections.Generic.IList<global::G.CodeScanningAlertClassification>? Classifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertInstance" /> class.
        /// </summary>
        /// <param name="ref">
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </param>
        /// <param name="analysisKey">
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </param>
        /// <param name="environment">
        /// Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed.
        /// </param>
        /// <param name="category">
        /// Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.
        /// </param>
        /// <param name="state">
        /// State of a code scanning alert.
        /// </param>
        /// <param name="commitSha"></param>
        /// <param name="message"></param>
        /// <param name="location">
        /// Describe a region within a file for the alert.
        /// </param>
        /// <param name="htmlUrl"></param>
        /// <param name="classifications">
        /// Classifications that have been applied to the file that triggered the alert.<br/>
        /// For example identifying it as documentation, or a generated file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningAlertInstance(
            string? @ref,
            string? analysisKey,
            string? environment,
            string? category,
            global::G.CodeScanningAlertState? state,
            string? commitSha,
            global::G.CodeScanningAlertInstanceMessage? message,
            global::G.CodeScanningAlertLocation? location,
            string? htmlUrl,
            global::System.Collections.Generic.IList<global::G.CodeScanningAlertClassification>? classifications)
        {
            this.Ref = @ref;
            this.AnalysisKey = analysisKey;
            this.Environment = environment;
            this.Category = category;
            this.State = state;
            this.CommitSha = commitSha;
            this.Message = message;
            this.Location = location;
            this.HtmlUrl = htmlUrl;
            this.Classifications = classifications;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertInstance" /> class.
        /// </summary>
        public CodeScanningAlertInstance()
        {
        }
    }
}