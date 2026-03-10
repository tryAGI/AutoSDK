//HintName: G.Models.SayNodeLiteralMessageOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SayNodeLiteralMessageOutput
    {
        /// <summary>
        /// Default Value: literal
        /// </summary>
        /// <default>"literal"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "literal";

        /// <summary>
        /// Literal text message to be spoken by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SayNodeLiteralMessageOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: literal
        /// </param>
        /// <param name="text">
        /// Literal text message to be spoken by the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SayNodeLiteralMessageOutput(
            string text,
            string type = "literal")
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SayNodeLiteralMessageOutput" /> class.
        /// </summary>
        public SayNodeLiteralMessageOutput()
        {
        }
    }
}