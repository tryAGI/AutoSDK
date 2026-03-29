//HintName: G.Models.SearchCommunityVoiceResponseVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voices retrieved from the provider.
    /// </summary>
    public sealed partial class SearchCommunityVoiceResponseVoice
    {
        /// <summary>
        /// id of the voice from the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_voice_id")]
        public string? ProviderVoiceId { get; set; }

        /// <summary>
        /// Name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// For elevenlabs only. User id of the voice owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_user_id")]
        public string? PublicUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCommunityVoiceResponseVoice" /> class.
        /// </summary>
        /// <param name="providerVoiceId">
        /// id of the voice from the provider.
        /// </param>
        /// <param name="name">
        /// Name of the voice.
        /// </param>
        /// <param name="description">
        /// Description of the voice.
        /// </param>
        /// <param name="publicUserId">
        /// For elevenlabs only. User id of the voice owner.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchCommunityVoiceResponseVoice(
            string? providerVoiceId,
            string? name,
            string? description,
            string? publicUserId)
        {
            this.ProviderVoiceId = providerVoiceId;
            this.Name = name;
            this.Description = description;
            this.PublicUserId = publicUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCommunityVoiceResponseVoice" /> class.
        /// </summary>
        public SearchCommunityVoiceResponseVoice()
        {
        }
    }
}