//HintName: G.Models.ASTLessThanOperatorNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLessThanOperatorNodeOutput
    {
        /// <summary>
        /// Default Value: lt_operator
        /// </summary>
        /// <default>"lt_operator"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "lt_operator";

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Left8 Left { get; set; } = default!;

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Right8 Right { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOperatorNodeOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: lt_operator
        /// </param>
        /// <param name="left">
        /// Left operand of the binary operator.
        /// </param>
        /// <param name="right">
        /// Right operand of the binary operator.
        /// </param>
        public ASTLessThanOperatorNodeOutput(
            global::G.Left8 left,
            global::G.Right8 right,
            string type = "lt_operator")
        {
            this.Left = left;
            this.Right = right;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOperatorNodeOutput" /> class.
        /// </summary>
        public ASTLessThanOperatorNodeOutput()
        {
        }
    }
}