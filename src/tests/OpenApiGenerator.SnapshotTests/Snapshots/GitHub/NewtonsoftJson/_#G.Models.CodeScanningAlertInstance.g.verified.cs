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
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis_key")]
        public string? AnalysisKey { get; set; }

        /// <summary>
        /// Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// State of a code scanning alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.CodeScanningAlertState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_sha")]
        public string? CommitSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::G.CodeScanningAlertInstanceMessage? Message { get; set; }

        /// <summary>
        /// Describe a region within a file for the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public global::G.CodeScanningAlertLocation? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Classifications that have been applied to the file that triggered the alert.<br/>
        /// For example identifying it as documentation, or a generated file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classifications")]
        public global::System.Collections.Generic.IList<global::G.CodeScanningAlertClassification>? Classifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}