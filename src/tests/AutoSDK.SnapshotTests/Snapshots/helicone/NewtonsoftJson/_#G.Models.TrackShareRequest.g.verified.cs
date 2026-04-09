//HintName: G.Models.TrackShareRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackShareRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("platform", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TrackShareRequestPlatformJsonConverter))]
        public global::G.TrackShareRequestPlatform Platform { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feature", Required = global::Newtonsoft.Json.Required.Always)]
        public string Feature { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackShareRequest" /> class.
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="feature"></param>
        /// <param name="email"></param>
        public TrackShareRequest(
            global::G.TrackShareRequestPlatform platform,
            string feature,
            string email)
        {
            this.Platform = platform;
            this.Feature = feature ?? throw new global::System.ArgumentNullException(nameof(feature));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackShareRequest" /> class.
        /// </summary>
        public TrackShareRequest()
        {
        }
    }
}