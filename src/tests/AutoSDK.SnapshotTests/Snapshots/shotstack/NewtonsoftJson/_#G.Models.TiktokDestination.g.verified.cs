//HintName: G.Models.TiktokDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send videos to TikTok. TikTok credentials are required and added via the [dashboard](https://dashboard.shotstack.io/integrations/tiktok), not in the request.
    /// </summary>
    public sealed partial class TiktokDestination
    {
        /// <summary>
        /// The destination to send video to - set to `tiktok` for TikTok.<br/>
        /// Default Value: tiktok<br/>
        /// Example: tiktok
        /// </summary>
        /// <default>"tiktok"</default>
        /// <example>tiktok</example>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// Pass additional options to control how TikTok publishes video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.TiktokDestinationOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TiktokDestination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send video to - set to `tiktok` for TikTok.<br/>
        /// Default Value: tiktok<br/>
        /// Example: tiktok
        /// </param>
        /// <param name="options">
        /// Pass additional options to control how TikTok publishes video.
        /// </param>
        public TiktokDestination(
            string provider,
            global::G.TiktokDestinationOptions? options)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TiktokDestination" /> class.
        /// </summary>
        public TiktokDestination()
        {
        }
    }
}