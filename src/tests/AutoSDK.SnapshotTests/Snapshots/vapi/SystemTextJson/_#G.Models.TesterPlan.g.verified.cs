//HintName: G.Models.TesterPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TesterPlan
    {
        /// <summary>
        /// Pass a transient assistant to use for the test assistant.<br/>
        /// Make sure to write a detailed system prompt for a test assistant, and use the {{test.script}} variable to access the test script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// Pass an assistant id that can be access<br/>
        /// Make sure to write a detailed system prompt for the test assistant, and use the {{test.script}} variable to access the test script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// Add any assistant overrides to the test assistant.<br/>
        /// One use case is if you want to pass custom variables into the test using variableValues, that you can then access in the script<br/>
        /// and rubric using {{varName}}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TesterPlan" /> class.
        /// </summary>
        /// <param name="assistant">
        /// Pass a transient assistant to use for the test assistant.<br/>
        /// Make sure to write a detailed system prompt for a test assistant, and use the {{test.script}} variable to access the test script.
        /// </param>
        /// <param name="assistantId">
        /// Pass an assistant id that can be access<br/>
        /// Make sure to write a detailed system prompt for the test assistant, and use the {{test.script}} variable to access the test script.
        /// </param>
        /// <param name="assistantOverrides">
        /// Add any assistant overrides to the test assistant.<br/>
        /// One use case is if you want to pass custom variables into the test using variableValues, that you can then access in the script<br/>
        /// and rubric using {{varName}}.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TesterPlan(
            global::G.CreateAssistantDTO? assistant,
            string? assistantId,
            global::G.AssistantOverrides? assistantOverrides)
        {
            this.Assistant = assistant;
            this.AssistantId = assistantId;
            this.AssistantOverrides = assistantOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TesterPlan" /> class.
        /// </summary>
        public TesterPlan()
        {
        }
    }
}