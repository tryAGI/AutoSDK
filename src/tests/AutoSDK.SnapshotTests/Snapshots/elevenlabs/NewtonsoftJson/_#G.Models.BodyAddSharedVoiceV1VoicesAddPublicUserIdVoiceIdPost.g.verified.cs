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
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.<br/>
        /// Example: John Smith
        /// </summary>
        /// <example>John Smith</example>
        [global::Newtonsoft.Json.JsonProperty("new_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost" /> class.
        /// </summary>
        /// <param name="newName">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.<br/>
        /// Example: John Smith
        /// </param>
        public BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost(
            string newName)
        {
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost" /> class.
        /// </summary>
        public BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost()
        {
        }
    }
}