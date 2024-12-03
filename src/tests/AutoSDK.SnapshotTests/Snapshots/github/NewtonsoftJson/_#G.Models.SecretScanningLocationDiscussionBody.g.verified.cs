//HintName: G.Models.SecretScanningLocationDiscussionBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'discussion_body' secret scanning location type. This location type shows that a secret was detected in the body of a discussion.
    /// </summary>
    public sealed partial class SecretScanningLocationDiscussionBody
    {
        /// <summary>
        /// The URL to the discussion where the secret was detected.<br/>
        /// Example: https://github.com/community/community/discussions/39082#discussion-4566270
        /// </summary>
        /// <example>https://github.com/community/community/discussions/39082#discussion-4566270</example>
        [global::Newtonsoft.Json.JsonProperty("discussion_body_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiscussionBodyUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationDiscussionBody" /> class.
        /// </summary>
        /// <param name="discussionBodyUrl">
        /// The URL to the discussion where the secret was detected.<br/>
        /// Example: https://github.com/community/community/discussions/39082#discussion-4566270
        /// </param>
        public SecretScanningLocationDiscussionBody(
            string discussionBodyUrl)
        {
            this.DiscussionBodyUrl = discussionBodyUrl ?? throw new global::System.ArgumentNullException(nameof(discussionBodyUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationDiscussionBody" /> class.
        /// </summary>
        public SecretScanningLocationDiscussionBody()
        {
        }
    }
}