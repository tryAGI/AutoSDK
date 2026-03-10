//HintName: G.Models.ASTBooleanNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTBooleanNodeOutput
    {
        /// <summary>
        /// Default Value: boolean_literal
        /// </summary>
        /// <default>"boolean_literal"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "boolean_literal";

        /// <summary>
        /// Value of this literal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTBooleanNodeOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: boolean_literal
        /// </param>
        /// <param name="value">
        /// Value of this literal.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTBooleanNodeOutput(
            bool value,
            string type = "boolean_literal")
        {
            this.Value = value;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTBooleanNodeOutput" /> class.
        /// </summary>
        public ASTBooleanNodeOutput()
        {
        }
    }
}