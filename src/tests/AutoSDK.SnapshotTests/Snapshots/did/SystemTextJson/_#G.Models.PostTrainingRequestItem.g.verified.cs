//HintName: G.Models.PostTrainingRequestItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostTrainingRequestItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManifestUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostTrainingRequestItemSentiments Sentiments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("I_know_I_am_going_to_make_this_avatar_public_for_everyone_and_this_is_the_manifest_url_again")]
        public string? IKnowIAmGoingToMakeThisAvatarPublicForEveryoneAndThisIsTheManifestUrlAgain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTrainingRequestItem" /> class.
        /// </summary>
        /// <param name="manifestUrl"></param>
        /// <param name="avatarName"></param>
        /// <param name="displayName"></param>
        /// <param name="ownerId"></param>
        /// <param name="sentiments">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="iKnowIAmGoingToMakeThisAvatarPublicForEveryoneAndThisIsTheManifestUrlAgain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostTrainingRequestItem(
            string manifestUrl,
            string avatarName,
            string displayName,
            string ownerId,
            global::G.PostTrainingRequestItemSentiments sentiments,
            string? iKnowIAmGoingToMakeThisAvatarPublicForEveryoneAndThisIsTheManifestUrlAgain)
        {
            this.ManifestUrl = manifestUrl ?? throw new global::System.ArgumentNullException(nameof(manifestUrl));
            this.AvatarName = avatarName ?? throw new global::System.ArgumentNullException(nameof(avatarName));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Sentiments = sentiments ?? throw new global::System.ArgumentNullException(nameof(sentiments));
            this.IKnowIAmGoingToMakeThisAvatarPublicForEveryoneAndThisIsTheManifestUrlAgain = iKnowIAmGoingToMakeThisAvatarPublicForEveryoneAndThisIsTheManifestUrlAgain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTrainingRequestItem" /> class.
        /// </summary>
        public PostTrainingRequestItem()
        {
        }
    }
}