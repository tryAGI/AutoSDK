//HintName: G.Models.ASTGreaterThanOrEqualsOperatorNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTGreaterThanOrEqualsOperatorNodeOutput
    {
        /// <summary>
        /// Default Value: gte_operator
        /// </summary>
        /// <default>"gte_operator"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "gte_operator";

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Left6 Left { get; set; } = default!;

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Right6 Right { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTGreaterThanOrEqualsOperatorNodeOutput" /> class.
        /// </summary>
        /// <param name="left">
        /// Left operand of the binary operator.
        /// </param>
        /// <param name="right">
        /// Right operand of the binary operator.
        /// </param>
        /// <param name="type">
        /// Default Value: gte_operator
        /// </param>
        public ASTGreaterThanOrEqualsOperatorNodeOutput(
            global::G.Left6 left,
            global::G.Right6 right,
            string type = "gte_operator")
        {
            this.Type = type;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTGreaterThanOrEqualsOperatorNodeOutput" /> class.
        /// </summary>
        public ASTGreaterThanOrEqualsOperatorNodeOutput()
        {
        }
    }
}