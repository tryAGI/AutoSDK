//HintName: G.Models.RelayCommandNote.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelayCommandNote
    {
        /// <summary>
        /// The type of relay command
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RelayCommandNoteTypeJsonConverter))]
        public global::G.RelayCommandNoteType Type { get; set; }

        /// <summary>
        /// The note content to add to the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommandNote" /> class.
        /// </summary>
        /// <param name="content">
        /// The note content to add to the conversation
        /// </param>
        /// <param name="type">
        /// The type of relay command
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelayCommandNote(
            string content,
            global::G.RelayCommandNoteType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommandNote" /> class.
        /// </summary>
        public RelayCommandNote()
        {
        }
    }
}