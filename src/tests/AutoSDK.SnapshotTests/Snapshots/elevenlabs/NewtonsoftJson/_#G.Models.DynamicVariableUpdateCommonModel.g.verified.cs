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
        [global::Newtonsoft.Json.JsonProperty("variable_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VariableName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("old_value")]
        public string? OldValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewValue { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public double UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolRequestId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariableUpdateCommonModel" /> class.
        /// </summary>
        /// <param name="variableName"></param>
        /// <param name="newValue"></param>
        /// <param name="updatedAt"></param>
        /// <param name="toolName"></param>
        /// <param name="toolRequestId"></param>
        /// <param name="oldValue"></param>
        public DynamicVariableUpdateCommonModel(
            string variableName,
            string newValue,
            double updatedAt,
            string toolName,
            string toolRequestId,
            string? oldValue)
        {
            this.VariableName = variableName ?? throw new global::System.ArgumentNullException(nameof(variableName));
            this.OldValue = oldValue;
            this.NewValue = newValue ?? throw new global::System.ArgumentNullException(nameof(newValue));
            this.UpdatedAt = updatedAt;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolRequestId = toolRequestId ?? throw new global::System.ArgumentNullException(nameof(toolRequestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVariableUpdateCommonModel" /> class.
        /// </summary>
        public DynamicVariableUpdateCommonModel()
        {
        }
    }
}