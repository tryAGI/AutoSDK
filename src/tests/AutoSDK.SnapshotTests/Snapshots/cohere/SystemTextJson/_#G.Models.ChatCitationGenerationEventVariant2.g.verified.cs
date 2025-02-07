//HintName: G.Models.ChatCitationGenerationEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCitationGenerationEventVariant2
    {
        /// <summary>
        /// Citations for the generated reply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCitation> Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitationGenerationEventVariant2" /> class.
        /// </summary>
        /// <param name="citations">
        /// Citations for the generated reply.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCitationGenerationEventVariant2(
            global::System.Collections.Generic.IList<global::G.ChatCitation> citations)
        {
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitationGenerationEventVariant2" /> class.
        /// </summary>
        public ChatCitationGenerationEventVariant2()
        {
        }
    }
}