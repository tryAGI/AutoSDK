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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "dynamic_variable";

        /// <summary>
        /// The name of the dynamic variable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTDynamicVariableNodeOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: dynamic_variable
        /// </param>
        /// <param name="name">
        /// The name of the dynamic variable.
        /// </param>
        public ASTDynamicVariableNodeOutput(
            string name,
            string type = "dynamic_variable")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTDynamicVariableNodeOutput" /> class.
        /// </summary>
        public ASTDynamicVariableNodeOutput()
        {
        }
    }
}