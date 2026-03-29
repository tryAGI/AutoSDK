//HintName: G.Models.CreateClipTrainRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipTrainRequest
    {
        /// <summary>
        /// The source URL of the clip video to train, the video must be longer than 3 minutes and have a resolution higher than 0.5 megapixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// A name for the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The gender of the presenter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateClipTrainRequestGender Gender { get; set; } = default!;

        /// <summary>
        /// Id of the related consent for the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consent_id")]
        public string? ConsentId { get; set; }

        /// <summary>
        /// The webhook to call when the training is done
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// Configuration options for the clip training
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.CreateClipTrainRequestConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipTrainRequest" /> class.
        /// </summary>
        /// <param name="sourceUrl">
        /// The source URL of the clip video to train, the video must be longer than 3 minutes and have a resolution higher than 0.5 megapixels.
        /// </param>
        /// <param name="gender">
        /// The gender of the presenter
        /// </param>
        /// <param name="name">
        /// A name for the avatar
        /// </param>
        /// <param name="consentId">
        /// Id of the related consent for the clip
        /// </param>
        /// <param name="webhook">
        /// The webhook to call when the training is done
        /// </param>
        /// <param name="config">
        /// Configuration options for the clip training
        /// </param>
        public CreateClipTrainRequest(
            string sourceUrl,
            global::G.CreateClipTrainRequestGender gender,
            string? name,
            string? consentId,
            string? webhook,
            global::G.CreateClipTrainRequestConfig? config)
        {
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.Name = name;
            this.Gender = gender;
            this.ConsentId = consentId;
            this.Webhook = webhook;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipTrainRequest" /> class.
        /// </summary>
        public CreateClipTrainRequest()
        {
        }
    }
}