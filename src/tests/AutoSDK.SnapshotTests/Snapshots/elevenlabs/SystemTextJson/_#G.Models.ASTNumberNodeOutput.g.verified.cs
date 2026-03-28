//HintName: G.Models.ASTNumberNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTNumberNodeOutput
    {
        /// <summary>
        /// Default Value: number_literal
        /// </summary>
        /// <default>"number_literal"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "number_literal";

        /// <summary>
        /// Value of this literal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTNumberNodeOutput" /> class.
        /// </summary>
        /// <param name="value">
        /// Value of this literal.
        /// </param>
        /// <param name="type">
        /// Default Value: number_literal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTNumberNodeOutput(
            double value,
            string type = "number_literal")
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTNumberNodeOutput" /> class.
        /// </summary>
        public ASTNumberNodeOutput()
        {
        }
    }
}