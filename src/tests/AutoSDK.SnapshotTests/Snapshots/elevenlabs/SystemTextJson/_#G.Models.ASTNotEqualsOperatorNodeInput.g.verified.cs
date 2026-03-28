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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Left11JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Left11 Left { get; set; }

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Right11JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Right11 Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTNotEqualsOperatorNodeInput" /> class.
        /// </summary>
        /// <param name="left">
        /// Left operand of the binary operator.
        /// </param>
        /// <param name="right">
        /// Right operand of the binary operator.
        /// </param>
        /// <param name="type">
        /// Default Value: neq_operator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTNotEqualsOperatorNodeInput(
            global::G.Left11 left,
            global::G.Right11 right,
            string? type)
        {
            this.Type = type;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTNotEqualsOperatorNodeInput" /> class.
        /// </summary>
        public ASTNotEqualsOperatorNodeInput()
        {
        }
    }
}