//HintName: G.Models.ASTNotEqualsOperatorNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTNotEqualsOperatorNodeOutput
    {
        /// <summary>
        /// Default Value: neq_operator
        /// </summary>
        /// <default>"neq_operator"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "neq_operator";

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Left12JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Left12 Left { get; set; }

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Right12JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Right12 Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTNotEqualsOperatorNodeOutput" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTNotEqualsOperatorNodeOutput(
            global::G.Left12 left,
            global::G.Right12 right,
            string type = "neq_operator")
        {
            this.Left = left;
            this.Right = right;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTNotEqualsOperatorNodeOutput" /> class.
        /// </summary>
        public ASTNotEqualsOperatorNodeOutput()
        {
        }
    }
}