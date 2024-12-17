//HintName: G.Models.ChatCitationGenerationEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCitationGenerationEvent : ChatStreamEvent
    {
        /// <summary>
        /// Citations for the generated reply.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCitation> Citations { get; set; } = default!;


        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitationGenerationEvent" /> class.
        /// </summary>
        /// <param name="citations">
        /// Citations for the generated reply.
        /// </param>
        public ChatCitationGenerationEvent(
            global::System.Collections.Generic.IList<global::G.ChatCitation> citations)
        {
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitationGenerationEvent" /> class.
        /// </summary>
        public ChatCitationGenerationEvent()
        {
        }
    }
}