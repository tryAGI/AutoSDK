//HintName: G.Models.ASTGreaterThanOperatorNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTGreaterThanOperatorNodeOutput
    {
        /// <summary>
        /// Default Value: gt_operator
        /// </summary>
        /// <default>"gt_operator"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "gt_operator";

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Left4 Left { get; set; } = default!;

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Right4 Right { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTGreaterThanOperatorNodeOutput" /> class.
        /// </summary>
        /// <param name="left">
        /// Left operand of the binary operator.
        /// </param>
        /// <param name="right">
        /// Right operand of the binary operator.
        /// </param>
        /// <param name="type">
        /// Default Value: gt_operator
        /// </param>
        public ASTGreaterThanOperatorNodeOutput(
            global::G.Left4 left,
            global::G.Right4 right,
            string type = "gt_operator")
        {
            this.Type = type;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTGreaterThanOperatorNodeOutput" /> class.
        /// </summary>
        public ASTGreaterThanOperatorNodeOutput()
        {
        }
    }
}