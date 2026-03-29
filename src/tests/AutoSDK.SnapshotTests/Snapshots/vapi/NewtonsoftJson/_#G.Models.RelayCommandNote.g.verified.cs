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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RelayCommandNoteType Type { get; set; }

        /// <summary>
        /// The note content to add to the conversation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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