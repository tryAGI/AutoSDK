//HintName: G.Models.HeyGenGeneratedAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using HeyGen. HeyGen provide a text-to-avatar service.  The HeyGen provider works on a bring-your-own-key basis, credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/heygen), not in the request.
    /// </summary>
    public sealed partial class HeyGenGeneratedAsset
    {
        /// <summary>
        /// The name of the provider - set to `heygen` for HeyGen.<br/>
        /// Default Value: heygen
        /// </summary>
        /// <default>global::G.HeyGenGeneratedAssetProvider.Heygen</default>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.HeyGenGeneratedAssetProviderJsonConverter))]
        public global::G.HeyGenGeneratedAssetProvider Provider { get; set; } = global::G.HeyGenGeneratedAssetProvider.Heygen;

        /// <summary>
        /// Generate assets using the third party HeyGen provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_heygentexttoavataroptions"&gt;HeyGenTextToAvatarOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HeyGenTextToAvatarOptions Options { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeyGenGeneratedAsset" /> class.
        /// </summary>
        /// <param name="options">
        /// Generate assets using the third party HeyGen provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_heygentexttoavataroptions"&gt;HeyGenTextToAvatarOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="provider">
        /// The name of the provider - set to `heygen` for HeyGen.<br/>
        /// Default Value: heygen
        /// </param>
        public HeyGenGeneratedAsset(
            global::G.HeyGenTextToAvatarOptions options,
            global::G.HeyGenGeneratedAssetProvider provider = global::G.HeyGenGeneratedAssetProvider.Heygen)
        {
            this.Provider = provider;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeyGenGeneratedAsset" /> class.
        /// </summary>
        public HeyGenGeneratedAsset()
        {
        }
    }
}