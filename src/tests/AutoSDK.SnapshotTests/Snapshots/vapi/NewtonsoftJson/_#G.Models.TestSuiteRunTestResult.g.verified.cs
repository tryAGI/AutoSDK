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
        [global::Newtonsoft.Json.JsonProperty("test", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TestSuiteTestVoice Test { get; set; } = default!;

        /// <summary>
        /// These are the attempts made for this test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attempts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TestSuiteRunTestAttempt> Attempts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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