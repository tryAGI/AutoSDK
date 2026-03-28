//HintName: G.Models.ASTLessThanOrEqualsOperatorNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLessThanOrEqualsOperatorNodeOutput
    {
        /// <summary>
        /// Default Value: lte_operator
        /// </summary>
        /// <default>"lte_operator"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "lte_operator";

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Left10JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Left10 Left { get; set; }

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Right10JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Right10 Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOrEqualsOperatorNodeOutput" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTLessThanOrEqualsOperatorNodeOutput(
            global::G.Left10 left,
            global::G.Right10 right,
            string type = "lte_operator")
        {
            this.Type = type;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOrEqualsOperatorNodeOutput" /> class.
        /// </summary>
        public ASTLessThanOrEqualsOperatorNodeOutput()
        {
        }
    }
}