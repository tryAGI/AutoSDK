//HintName: G.Models.ConditionalToolRuleSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConditionalToolRuleSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_child")]
        public string? DefaultChild { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("child_output_mapping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> ChildOutputMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_output_mapping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireOutputMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalToolRuleSchema" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
        /// <param name="childOutputMapping"></param>
        /// <param name="requireOutputMapping"></param>
        /// <param name="defaultChild"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConditionalToolRuleSchema(
            string toolName,
            string type,
            global::System.Collections.Generic.Dictionary<string, string> childOutputMapping,
            bool requireOutputMapping,
            string? defaultChild)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DefaultChild = defaultChild;
            this.ChildOutputMapping = childOutputMapping ?? throw new global::System.ArgumentNullException(nameof(childOutputMapping));
            this.RequireOutputMapping = requireOutputMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalToolRuleSchema" /> class.
        /// </summary>
        public ConditionalToolRuleSchema()
        {
        }
    }
}