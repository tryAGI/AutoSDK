//HintName: G.Models.ToolCallDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains the chunk of the tool call generation in the stream.
    /// </summary>
    public sealed partial class ToolCallDelta
    {
        /// <summary>
        /// Name of the tool call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Index of the tool call generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public double? Index { get; set; }

        /// <summary>
        /// Chunk of the tool parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public string? Parameters { get; set; }

        /// <summary>
        /// Chunk of the tool plan text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallDelta" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool call
        /// </param>
        /// <param name="index">
        /// Index of the tool call generated
        /// </param>
        /// <param name="parameters">
        /// Chunk of the tool parameters
        /// </param>
        /// <param name="text">
        /// Chunk of the tool plan text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallDelta(
            string? name,
            double? index,
            string? parameters,
            string? text)
        {
            this.Name = name;
            this.Index = index;
            this.Parameters = parameters;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallDelta" /> class.
        /// </summary>
        public ToolCallDelta()
        {
        }
    }
}