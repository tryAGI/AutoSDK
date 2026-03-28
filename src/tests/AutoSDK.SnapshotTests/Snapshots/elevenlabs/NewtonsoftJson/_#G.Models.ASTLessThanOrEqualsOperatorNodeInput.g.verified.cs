//HintName: G.Models.ASTLessThanOrEqualsOperatorNodeInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLessThanOrEqualsOperatorNodeInput
    {
        /// <summary>
        /// Default Value: lte_operator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Left9 Left { get; set; } = default!;

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Right9 Right { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOrEqualsOperatorNodeInput" /> class.
        /// </summary>
        /// <param name="left">
        /// Left operand of the binary operator.
        /// </param>
        /// <param name="right">
        /// Right operand of the binary operator.
        /// </param>
        /// <param name="type">
        /// Default Value: lte_operator
        /// </param>
        public ASTLessThanOrEqualsOperatorNodeInput(
            global::G.Left9 left,
            global::G.Right9 right,
            string? type)
        {
            this.Type = type;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOrEqualsOperatorNodeInput" /> class.
        /// </summary>
        public ASTLessThanOrEqualsOperatorNodeInput()
        {
        }
    }
}