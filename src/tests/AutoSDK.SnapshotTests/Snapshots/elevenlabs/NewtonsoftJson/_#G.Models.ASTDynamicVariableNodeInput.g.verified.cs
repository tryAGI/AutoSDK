//HintName: G.Models.ASTDynamicVariableNodeInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTDynamicVariableNodeInput
    {
        /// <summary>
        /// Default Value: dynamic_variable
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ASTDynamicVariableNodeInput" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the dynamic variable.
        /// </param>
        /// <param name="type">
        /// Default Value: dynamic_variable
        /// </param>
        public ASTDynamicVariableNodeInput(
            string name,
            string? type)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTDynamicVariableNodeInput" /> class.
        /// </summary>
        public ASTDynamicVariableNodeInput()
        {
        }
    }
}