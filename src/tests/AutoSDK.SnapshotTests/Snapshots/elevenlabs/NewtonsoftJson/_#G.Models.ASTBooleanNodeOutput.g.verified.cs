//HintName: G.Models.ASTBooleanNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTBooleanNodeOutput
    {
        /// <summary>
        /// Default Value: boolean_literal
        /// </summary>
        /// <default>"boolean_literal"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "boolean_literal";

        /// <summary>
        /// Value of this literal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTBooleanNodeOutput" /> class.
        /// </summary>
        /// <param name="value">
        /// Value of this literal.
        /// </param>
        /// <param name="type">
        /// Default Value: boolean_literal
        /// </param>
        public ASTBooleanNodeOutput(
            bool value,
            string type = "boolean_literal")
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTBooleanNodeOutput" /> class.
        /// </summary>
        public ASTBooleanNodeOutput()
        {
        }
    }
}