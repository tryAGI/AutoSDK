//HintName: G.Models.VimeoDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send videos to [Vimeo](https://shotstack.io/docs/guide/serving-assets/destinations/vimeo/) video hosting and streaming service. Vimeo credentials are required and added via the [dashboard](https://dashboard.shotstack.io/integrations/vimeo), not in the request.
    /// </summary>
    public sealed partial class VimeoDestination
    {
        /// <summary>
        /// The destination to send video to - set to `vimeo` for Vimeo.<br/>
        /// Default Value: vimeo<br/>
        /// Example: vimeo
        /// </summary>
        /// <default>"vimeo"</default>
        /// <example>vimeo</example>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// Pass additional options to control how Vimeo publishes video, including name, description and privacy settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.VimeoDestinationOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VimeoDestination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send video to - set to `vimeo` for Vimeo.<br/>
        /// Default Value: vimeo<br/>
        /// Example: vimeo
        /// </param>
        /// <param name="options">
        /// Pass additional options to control how Vimeo publishes video, including name, description and privacy settings.
        /// </param>
        public VimeoDestination(
            string provider,
            global::G.VimeoDestinationOptions? options)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VimeoDestination" /> class.
        /// </summary>
        public VimeoDestination()
        {
        }
    }
}