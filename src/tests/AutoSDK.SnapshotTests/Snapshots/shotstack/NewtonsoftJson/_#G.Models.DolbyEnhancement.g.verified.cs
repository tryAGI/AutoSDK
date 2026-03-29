//HintName: G.Models.DolbyEnhancement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dolby.io audio enhancement provider. Credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/dolby), not in the request.
    /// </summary>
    public sealed partial class DolbyEnhancement
    {
        /// <summary>
        /// The enhancement provider to use - set to `dolby` for Dolby.<br/>
        /// Default Value: dolby<br/>
        /// Example: dolby
        /// </summary>
        /// <default>"dolby"</default>
        /// <example>dolby</example>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// Options for the Dolby.io audio enhancement provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DolbyEnhancementOptions Options { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DolbyEnhancement" /> class.
        /// </summary>
        /// <param name="provider">
        /// The enhancement provider to use - set to `dolby` for Dolby.<br/>
        /// Default Value: dolby<br/>
        /// Example: dolby
        /// </param>
        /// <param name="options">
        /// Options for the Dolby.io audio enhancement provider.
        /// </param>
        public DolbyEnhancement(
            string provider,
            global::G.DolbyEnhancementOptions options)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DolbyEnhancement" /> class.
        /// </summary>
        public DolbyEnhancement()
        {
        }
    }
}