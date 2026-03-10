//HintName: G.Models.ASTNotEqualsOperatorNodeInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTNotEqualsOperatorNodeInput
    {
        /// <summary>
        /// Default Value: neq_operator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Left11 Left { get; set; } = default!;

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Right11 Right { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTNotEqualsOperatorNodeInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: neq_operator
        /// </param>
        /// <param name="left">
        /// Left operand of the binary operator.
        /// </param>
        /// <param name="right">
        /// Right operand of the binary operator.
        /// </param>
        public ASTNotEqualsOperatorNodeInput(
            global::G.Left11 left,
            global::G.Right11 right,
            string? type)
        {
            this.Left = left;
            this.Right = right;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTNotEqualsOperatorNodeInput" /> class.
        /// </summary>
        public ASTNotEqualsOperatorNodeInput()
        {
        }
    }
}