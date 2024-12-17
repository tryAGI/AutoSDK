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
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCitation> Citations { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitationGenerationEvent" /> class.
        /// </summary>
        /// <param name="citations">
        /// Citations for the generated reply.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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