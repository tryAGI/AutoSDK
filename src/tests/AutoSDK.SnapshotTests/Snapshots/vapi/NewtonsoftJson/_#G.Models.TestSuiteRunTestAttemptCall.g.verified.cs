//HintName: G.Models.TestSuiteRunTestAttemptCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunTestAttemptCall
    {
        /// <summary>
        /// This is the artifact of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Artifact Artifact { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunTestAttemptCall" /> class.
        /// </summary>
        /// <param name="artifact">
        /// This is the artifact of the call.
        /// </param>
        public TestSuiteRunTestAttemptCall(
            global::G.Artifact artifact)
        {
            this.Artifact = artifact ?? throw new global::System.ArgumentNullException(nameof(artifact));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunTestAttemptCall" /> class.
        /// </summary>
        public TestSuiteRunTestAttemptCall()
        {
        }
    }
}