//HintName: G.Models.TestSuiteRunTestResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunTestResult
    {
        /// <summary>
        /// This is the test that was run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestSuiteTestVoice Test { get; set; }

        /// <summary>
        /// These are the attempts made for this test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TestSuiteRunTestAttempt> Attempts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunTestResult" /> class.
        /// </summary>
        /// <param name="test">
        /// This is the test that was run.
        /// </param>
        /// <param name="attempts">
        /// These are the attempts made for this test.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunTestResult(
            global::G.TestSuiteTestVoice test,
            global::System.Collections.Generic.IList<global::G.TestSuiteRunTestAttempt> attempts)
        {
            this.Test = test ?? throw new global::System.ArgumentNullException(nameof(test));
            this.Attempts = attempts ?? throw new global::System.ArgumentNullException(nameof(attempts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunTestResult" /> class.
        /// </summary>
        public TestSuiteRunTestResult()
        {
        }
    }
}