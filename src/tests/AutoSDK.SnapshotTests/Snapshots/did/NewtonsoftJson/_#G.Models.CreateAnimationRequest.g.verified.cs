//HintName: G.Models.CreateAnimationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAnimationRequest
    {
        /// <summary>
        /// The URL of the source image to be animated by the driver video. Image type of jpg|jpeg|tiff|png|bmp<br/>
        /// Default Value: https://d-id-public-bucket.s3.us-west-2.amazonaws.com/alice.jpg<br/>
        /// Example: https://path.to.directory/image.jpg
        /// </summary>
        /// <example>https://path.to.directory/image.jpg</example>
        [global::Newtonsoft.Json.JsonProperty("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// The URL of the driver video to drive the animation, if not provided a driver video will be selected for you from the predefined DriversBank<br/>
        /// Example: bank://nostalgia/
        /// </summary>
        /// <example>bank://nostalgia/</example>
        [global::Newtonsoft.Json.JsonProperty("driver_url")]
        public string? DriverUrl { get; set; }

        /// <summary>
        /// The URL of the animation video, if not provided use default destination<br/>
        /// Supports S3 Signed URLs<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </summary>
        /// <example>https://path.to.directory/movie.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// the face to animate - otherwise detects the dominant face<br/>
        /// Example: {"top_left":[0,0],"size":512}
        /// </summary>
        /// <example>{"top_left":[0,0],"size":512}</example>
        [global::Newtonsoft.Json.JsonProperty("face")]
        public global::G.CreateAnimationRequestFace? Face { get; set; }

        /// <summary>
        /// A webhook URL for sending the payload including animate details. In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </summary>
        /// <example>https://host.domain.tld/to/webhook</example>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// Advanced configuration option
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.CreateAnimationRequestConfig? Config { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the animation response and webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnimationRequest" /> class.
        /// </summary>
        /// <param name="sourceUrl">
        /// The URL of the source image to be animated by the driver video. Image type of jpg|jpeg|tiff|png|bmp<br/>
        /// Default Value: https://d-id-public-bucket.s3.us-west-2.amazonaws.com/alice.jpg<br/>
        /// Example: https://path.to.directory/image.jpg
        /// </param>
        /// <param name="driverUrl">
        /// The URL of the driver video to drive the animation, if not provided a driver video will be selected for you from the predefined DriversBank<br/>
        /// Example: bank://nostalgia/
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the animation video, if not provided use default destination<br/>
        /// Supports S3 Signed URLs<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="face">
        /// the face to animate - otherwise detects the dominant face<br/>
        /// Example: {"top_left":[0,0],"size":512}
        /// </param>
        /// <param name="webhook">
        /// A webhook URL for sending the payload including animate details. In a case of empty value, the webhook will not be triggered<br/>
        /// Example: https://host.domain.tld/to/webhook
        /// </param>
        /// <param name="config">
        /// Advanced configuration option
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the animation response and webhook.
        /// </param>
        public CreateAnimationRequest(
            string? sourceUrl,
            string? driverUrl,
            string? resultUrl,
            global::G.CreateAnimationRequestFace? face,
            string? webhook,
            global::G.CreateAnimationRequestConfig? config,
            string? userData)
        {
            this.SourceUrl = sourceUrl;
            this.DriverUrl = driverUrl;
            this.ResultUrl = resultUrl;
            this.Face = face;
            this.Webhook = webhook;
            this.Config = config;
            this.UserData = userData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnimationRequest" /> class.
        /// </summary>
        public CreateAnimationRequest()
        {
        }
    }
}