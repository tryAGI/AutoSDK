//HintName: G.Models.FunctionToolDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionToolDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.ToolParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionToolDefinition" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FunctionToolDefinition(
            string name,
            string? description,
            global::G.ToolParameters? parameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionToolDefinition" /> class.
        /// </summary>
        public FunctionToolDefinition()
        {
        }
    }
}