//HintName: G.Models.ASTEqualsOperatorNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTEqualsOperatorNodeOutput
    {
        /// <summary>
        /// Default Value: eq_operator
        /// </summary>
        /// <default>"eq_operator"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "eq_operator";

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Left2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Left2 Left { get; set; }

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Right2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Right2 Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTEqualsOperatorNodeOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: eq_operator
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
        public ASTEqualsOperatorNodeOutput(
            global::G.Left2 left,
            global::G.Right2 right,
            string type = "eq_operator")
        {
            this.Left = left;
            this.Right = right;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTEqualsOperatorNodeOutput" /> class.
        /// </summary>
        public ASTEqualsOperatorNodeOutput()
        {
        }
    }
}