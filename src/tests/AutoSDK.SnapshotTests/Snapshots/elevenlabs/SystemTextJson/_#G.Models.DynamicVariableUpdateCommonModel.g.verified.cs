//HintName: G.Models.DynamicVariableUpdateCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tracks a dynamic variable update that occurred during tool execution.
    /// </summary>
    public sealed partial class DynamicVariableUpdateCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_value")]
        public string? OldValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolRequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariableUpdateCommonModel" /> class.
        /// </summary>
        /// <param name="variableName"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <param name="updatedAt"></param>
        /// <param name="toolName"></param>
        /// <param name="toolRequestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicVariableUpdateCommonModel(
            string variableName,
            string newValue,
            double updatedAt,
            string toolName,
            string toolRequestId,
            string? oldValue)
        {
            this.VariableName = variableName ?? throw new global::System.ArgumentNullException(nameof(variableName));
            this.NewValue = newValue ?? throw new global::System.ArgumentNullException(nameof(newValue));
            this.UpdatedAt = updatedAt;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolRequestId = toolRequestId ?? throw new global::System.ArgumentNullException(nameof(toolRequestId));
            this.OldValue = oldValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariableUpdateCommonModel" /> class.
        /// </summary>
        public DynamicVariableUpdateCommonModel()
        {
        }
    }
}