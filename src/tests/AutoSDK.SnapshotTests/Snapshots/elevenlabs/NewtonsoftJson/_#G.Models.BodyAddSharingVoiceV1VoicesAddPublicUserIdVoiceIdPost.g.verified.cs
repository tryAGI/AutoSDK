﻿//HintName: G.Models.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost
    {
        /// <summary>
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost" /> class.
        /// </summary>
        /// <param name="newName">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        public BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost(
            string newName)
        {
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost" /> class.
        /// </summary>
        public BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost()
        {
        }
    }
}