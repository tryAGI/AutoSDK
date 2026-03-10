//HintName: G.Models.BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost
    {
        /// <summary>
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewName { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bookmarked")]
        public bool? Bookmarked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost" /> class.
        /// </summary>
        /// <param name="newName">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="bookmarked">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost(
            string newName,
            bool? bookmarked)
        {
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
            this.Bookmarked = bookmarked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost" /> class.
        /// </summary>
        public BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost()
        {
        }
    }
}