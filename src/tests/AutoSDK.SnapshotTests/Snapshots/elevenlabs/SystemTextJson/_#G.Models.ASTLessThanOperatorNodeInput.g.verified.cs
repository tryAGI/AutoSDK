//HintName: G.Models.ASTLessThanOperatorNodeInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLessThanOperatorNodeInput
    {
        /// <summary>
        /// Default Value: lt_operator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Left7JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Left7 Left { get; set; }

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Right7JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Right7 Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOperatorNodeInput" /> class.
        /// </summary>
        /// <param name="left">
        /// Left operand of the binary operator.
        /// </param>
        /// <param name="right">
        /// Right operand of the binary operator.
        /// </param>
        /// <param name="type">
        /// Default Value: lt_operator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTLessThanOperatorNodeInput(
            global::G.Left7 left,
            global::G.Right7 right,
            string? type)
        {
            this.Type = type;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOperatorNodeInput" /> class.
        /// </summary>
        public ASTLessThanOperatorNodeInput()
        {
        }
    }
}