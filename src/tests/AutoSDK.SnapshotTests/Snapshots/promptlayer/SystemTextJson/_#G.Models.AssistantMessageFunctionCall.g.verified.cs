//HintName: G.Models.AssistantMessageFunctionCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is deprecated. Please use `tool_calls` field to specify tool calls.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class AssistantMessageFunctionCall
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}