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
        [global::Newtonsoft.Json.JsonProperty("manifest_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ManifestUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostTrainingRequestItemSentiments Sentiments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("I_know_I_am_going_to_make_this_avatar_public_for_everyone_and_this_is_the_manifest_url_again")]
        public string? IKnowIAmGoingToMakeThisAvatarPublicForEveryoneAndThisIsTheManifestUrlAgain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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