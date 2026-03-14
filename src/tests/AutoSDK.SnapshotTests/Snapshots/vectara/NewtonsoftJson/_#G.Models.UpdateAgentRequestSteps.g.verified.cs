//HintName: G.Models.UpdateAgentRequestSteps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A map of additional named steps keyed by step name for partial update.<br/>
    /// Only provided keys are modified; missing keys are preserved.<br/>
    /// Set a key's value to null to delete that step.<br/>
    /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}]}}
    /// </summary>
    public sealed partial class UpdateAgentRequestSteps
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}