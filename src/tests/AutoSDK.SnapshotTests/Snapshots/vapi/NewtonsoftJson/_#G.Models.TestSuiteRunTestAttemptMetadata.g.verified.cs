//HintName: G.Models.TestSuiteRunTestAttemptMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunTestAttemptMetadata
    {
        /// <summary>
        /// This is the session ID for the test attempt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunTestAttemptMetadata" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// This is the session ID for the test attempt.
        /// </param>
        public TestSuiteRunTestAttemptMetadata(
            string sessionId)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunTestAttemptMetadata" /> class.
        /// </summary>
        public TestSuiteRunTestAttemptMetadata()
        {
        }
    }
}