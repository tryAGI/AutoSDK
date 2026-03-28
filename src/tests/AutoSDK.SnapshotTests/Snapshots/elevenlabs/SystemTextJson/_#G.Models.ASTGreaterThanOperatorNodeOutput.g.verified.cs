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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "gt_operator";

        /// <summary>
        /// Left operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Left4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Left4 Left { get; set; }

        /// <summary>
        /// Right operand of the binary operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Right4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Right4 Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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