//HintName: G.Models.Create1Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Create1Request
    {
        /// <summary>
        /// The URL of the source video to create an avatar from<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </summary>
        /// <example>https://path.to.directory/movie.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// Unique identifier of a valid consent video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consent_id")]
        public string? ConsentId { get; set; }

        /// <summary>
        /// A name for the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including animate details<br/>
        /// In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </summary>
        /// <example>https://host.domain.tld/to/webhook</example>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the scene response and webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// Whether the video is a green screen video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_greenscreen")]
        public bool? IsGreenscreen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Create1Request" /> class.
        /// </summary>
        /// <param name="sourceUrl">
        /// The URL of the source video to create an avatar from<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="consentId">
        /// Unique identifier of a valid consent video
        /// </param>
        /// <param name="name">
        /// A name for the avatar
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details<br/>
        /// In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the scene response and webhook.
        /// </param>
        /// <param name="isGreenscreen">
        /// Whether the video is a green screen video
        /// </param>
        public Create1Request(
            string sourceUrl,
            string? consentId,
            string? name,
            string? webhook,
            string? userData,
            bool? isGreenscreen)
        {
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.ConsentId = consentId;
            this.Name = name;
            this.Webhook = webhook;
            this.UserData = userData;
            this.IsGreenscreen = isGreenscreen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Create1Request" /> class.
        /// </summary>
        public Create1Request()
        {
        }
    }
}