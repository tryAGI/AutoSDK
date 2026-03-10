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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Left9JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Left9 Left { get; set; }

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Right9JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Right9 Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOrEqualsOperatorNodeInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: lte_operator
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
        public ASTLessThanOrEqualsOperatorNodeInput(
            global::G.Left9 left,
            global::G.Right9 right,
            string? type)
        {
            this.Left = left;
            this.Right = right;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOrEqualsOperatorNodeInput" /> class.
        /// </summary>
        public ASTLessThanOrEqualsOperatorNodeInput()
        {
        }
    }
}