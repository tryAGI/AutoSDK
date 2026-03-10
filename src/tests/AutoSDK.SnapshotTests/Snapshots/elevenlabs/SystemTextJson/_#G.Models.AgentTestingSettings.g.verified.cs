//HintName: G.Models.AgentTestingSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings for agent testing configuration.<br/>
    /// Example: {"attached_tests":[{"test_id":"test_123","workflow_node_id":"node_abc"},{"test_id":"test_456"}],"referenced_tests_ids":["test_123","test_456"]}
    /// </summary>
    public sealed partial class AgentTestingSettings
    {
        /// <summary>
        /// List of test IDs that should be run for this agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_tests")]
        public global::System.Collections.Generic.IList<global::G.AttachedTestModel>? AttachedTests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestingSettings" /> class.
        /// </summary>
        /// <param name="attachedTests">
        /// List of test IDs that should be run for this agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestingSettings(
            global::System.Collections.Generic.IList<global::G.AttachedTestModel>? attachedTests)
        {
            this.AttachedTests = attachedTests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestingSettings" /> class.
        /// </summary>
        public AgentTestingSettings()
        {
        }
    }
}