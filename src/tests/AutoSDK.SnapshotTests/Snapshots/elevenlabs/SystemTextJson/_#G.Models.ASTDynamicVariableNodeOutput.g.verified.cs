//HintName: G.Models.ASTDynamicVariableNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTDynamicVariableNodeOutput
    {
        /// <summary>
        /// Default Value: dynamic_variable
        /// </summary>
        /// <default>"dynamic_variable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "dynamic_variable";

        /// <summary>
        /// The name of the dynamic variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTDynamicVariableNodeOutput" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the dynamic variable.
        /// </param>
        /// <param name="type">
        /// Default Value: dynamic_variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTDynamicVariableNodeOutput(
            string name,
            string type = "dynamic_variable")
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTDynamicVariableNodeOutput" /> class.
        /// </summary>
        public ASTDynamicVariableNodeOutput()
        {
        }
    }
}