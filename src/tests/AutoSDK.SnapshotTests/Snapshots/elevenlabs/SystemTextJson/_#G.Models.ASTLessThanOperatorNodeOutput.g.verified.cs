//HintName: G.Models.ASTLessThanOperatorNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLessThanOperatorNodeOutput
    {
        /// <summary>
        /// Default Value: lt_operator
        /// </summary>
        /// <default>"lt_operator"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "lt_operator";

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Left8JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Left8 Left { get; set; }

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Right8JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Right8 Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOperatorNodeOutput" /> class.
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
        public ASTLessThanOperatorNodeOutput(
            global::G.Left8 left,
            global::G.Right8 right,
            string type = "lt_operator")
        {
            this.Type = type;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOperatorNodeOutput" /> class.
        /// </summary>
        public ASTLessThanOperatorNodeOutput()
        {
        }
    }
}