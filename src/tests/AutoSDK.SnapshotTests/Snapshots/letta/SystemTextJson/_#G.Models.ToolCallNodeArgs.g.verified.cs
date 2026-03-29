//HintName: G.Models.ToolCallNodeArgs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional prefilled arguments for this child tool. Keys must match the tool's parameter names and values must satisfy the tool's JSON schema. Supports partial prefill; non-overlapping parameters are left to the model.
    /// </summary>
    public sealed partial class ToolCallNodeArgs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}