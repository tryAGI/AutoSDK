//HintName: G.Models.TextChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextChunk
    {
        /// <summary>
        /// The text content of the chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The starting timestamp of the text chunk in seconds relative to the start of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextChunk" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content of the chunk.
        /// </param>
        /// <param name="startTimestamp">
        /// The starting timestamp of the text chunk in seconds relative to the start of the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextChunk(
            string text,
            double startTimestamp)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.StartTimestamp = startTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextChunk" /> class.
        /// </summary>
        public TextChunk()
        {
        }
    }
}