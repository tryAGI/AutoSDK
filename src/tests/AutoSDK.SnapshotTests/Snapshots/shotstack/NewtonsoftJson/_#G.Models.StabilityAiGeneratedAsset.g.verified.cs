//HintName: G.Models.StabilityAiGeneratedAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using Stability AI. Stability AI provide a text-to-image service using Stable Diffusion. The Stability AI provider works on a bring-your-own-key basis, credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/stability-ai), not in the request.
    /// </summary>
    public sealed partial class StabilityAiGeneratedAsset
    {
        /// <summary>
        /// The name of the provider - set to `stability-ai` for Stability AI.<br/>
        /// Default Value: stability-ai
        /// </summary>
        /// <default>global::G.StabilityAiGeneratedAssetProvider.StabilityAi</default>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.StabilityAiGeneratedAssetProvider Provider { get; set; } = global::G.StabilityAiGeneratedAssetProvider.StabilityAi;

        /// <summary>
        /// Generate assets using Stability AI provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_stabilityaitexttoimageoptions"&gt;StabilityAiTextToImageOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StabilityAiTextToImageOptions Options { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StabilityAiGeneratedAsset" /> class.
        /// </summary>
        /// <param name="options">
        /// Generate assets using Stability AI provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_stabilityaitexttoimageoptions"&gt;StabilityAiTextToImageOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="provider">
        /// The name of the provider - set to `stability-ai` for Stability AI.<br/>
        /// Default Value: stability-ai
        /// </param>
        public StabilityAiGeneratedAsset(
            global::G.StabilityAiTextToImageOptions options,
            global::G.StabilityAiGeneratedAssetProvider provider = global::G.StabilityAiGeneratedAssetProvider.StabilityAi)
        {
            this.Provider = provider;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StabilityAiGeneratedAsset" /> class.
        /// </summary>
        public StabilityAiGeneratedAsset()
        {
        }
    }
}