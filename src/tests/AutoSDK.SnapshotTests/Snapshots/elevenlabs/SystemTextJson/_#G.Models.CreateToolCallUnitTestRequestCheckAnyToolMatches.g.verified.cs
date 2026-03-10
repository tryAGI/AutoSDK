//HintName: G.Models.CreateToolCallUnitTestRequestCheckAnyToolMatches.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If set to True this test will pass if any tool call returned by the LLM matches the criteria. Otherwise it will fail if more than one tool is returned by the agent.
    /// </summary>
    public sealed partial class CreateToolCallUnitTestRequestCheckAnyToolMatches
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}