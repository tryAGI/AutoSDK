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
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The starting timestamp of the text chunk in seconds relative to the start of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTimestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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