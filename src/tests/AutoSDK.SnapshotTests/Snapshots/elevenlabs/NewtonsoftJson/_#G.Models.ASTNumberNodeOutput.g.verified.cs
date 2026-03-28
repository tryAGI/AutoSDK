//HintName: G.Models.ASTNumberNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTNumberNodeOutput
    {
        /// <summary>
        /// Default Value: number_literal
        /// </summary>
        /// <default>"number_literal"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "number_literal";

        /// <summary>
        /// Value of this literal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTNumberNodeOutput" /> class.
        /// </summary>
        /// <param name="value">
        /// Value of this literal.
        /// </param>
        /// <param name="type">
        /// Default Value: number_literal
        /// </param>
        public ASTNumberNodeOutput(
            double value,
            string type = "number_literal")
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTNumberNodeOutput" /> class.
        /// </summary>
        public ASTNumberNodeOutput()
        {
        }
    }
}