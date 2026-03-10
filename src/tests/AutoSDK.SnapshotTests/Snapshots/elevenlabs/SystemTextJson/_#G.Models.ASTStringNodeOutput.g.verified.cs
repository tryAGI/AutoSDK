//HintName: G.Models.ASTStringNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTStringNodeOutput
    {
        /// <summary>
        /// Default Value: string_literal
        /// </summary>
        /// <default>"string_literal"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "string_literal";

        /// <summary>
        /// Value of this literal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTStringNodeOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: string_literal
        /// </param>
        /// <param name="value">
        /// Value of this literal.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTStringNodeOutput(
            string value,
            string type = "string_literal")
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTStringNodeOutput" /> class.
        /// </summary>
        public ASTStringNodeOutput()
        {
        }
    }
}