//HintName: G.Models.AddVoiceToProviderDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddVoiceToProviderDTO
    {
        /// <summary>
        /// This is the owner_id of your shared voice which you want to add to your provider Account from Provider Voice Library
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// This is the voice_id of the shared voice which you want to add to your provider Account from Provider Voice Library
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// This is the new name of the voice which you want to have once you have added voice to your provider Account from Provider Voice Library
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceToProviderDTO" /> class.
        /// </summary>
        /// <param name="ownerId">
        /// This is the owner_id of your shared voice which you want to add to your provider Account from Provider Voice Library
        /// </param>
        /// <param name="voiceId">
        /// This is the voice_id of the shared voice which you want to add to your provider Account from Provider Voice Library
        /// </param>
        /// <param name="name">
        /// This is the new name of the voice which you want to have once you have added voice to your provider Account from Provider Voice Library
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddVoiceToProviderDTO(
            string ownerId,
            string voiceId,
            string name)
        {
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceToProviderDTO" /> class.
        /// </summary>
        public AddVoiceToProviderDTO()
        {
        }
    }
}