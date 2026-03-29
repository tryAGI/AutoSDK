//HintName: G.Models.TestSuiteRunTestAttempt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunTestAttempt
    {
        /// <summary>
        /// These are the results of the scorers used to evaluate the test attempt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scorerResults", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TestSuiteRunScorerAI> ScorerResults { get; set; } = default!;

        /// <summary>
        /// This is the call made during the test attempt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call")]
        public global::G.TestSuiteRunTestAttemptCall? Call { get; set; }

        /// <summary>
        /// This is the call ID for the test attempt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callId")]
        public string? CallId { get; set; }

        /// <summary>
        /// This is the metadata for the test attempt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.TestSuiteRunTestAttemptMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunTestAttempt" /> class.
        /// </summary>
        /// <param name="scorerResults">
        /// These are the results of the scorers used to evaluate the test attempt.
        /// </param>
        /// <param name="call">
        /// This is the call made during the test attempt.
        /// </param>
        /// <param name="callId">
        /// This is the call ID for the test attempt.
        /// </param>
        /// <param name="metadata">
        /// This is the metadata for the test attempt.
        /// </param>
        public TestSuiteRunTestAttempt(
            global::System.Collections.Generic.IList<global::G.TestSuiteRunScorerAI> scorerResults,
            global::G.TestSuiteRunTestAttemptCall? call,
            string? callId,
            global::G.TestSuiteRunTestAttemptMetadata? metadata)
        {
            this.ScorerResults = scorerResults ?? throw new global::System.ArgumentNullException(nameof(scorerResults));
            this.Call = call;
            this.CallId = callId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunTestAttempt" /> class.
        /// </summary>
        public TestSuiteRunTestAttempt()
        {
        }
    }
}