//HintName: G.Models.BodyImportAgentModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model handle to override the agent's default model. This allows the imported agent to use a different model while keeping other defaults (e.g., context size) from the original configuration.
    /// </summary>
    public sealed partial class BodyImportAgentModel
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}