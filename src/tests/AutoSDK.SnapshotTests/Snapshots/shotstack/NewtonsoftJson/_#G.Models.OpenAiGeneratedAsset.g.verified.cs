//HintName: G.Models.OpenAiGeneratedAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using OpenAI. OpenAI provide a text generation service using ChatGPT 3.5 and 4. The OpenAI provider works on a bring-your-own-key basis, credentials are required and must be added via the [dashboard](https://dashboard.shotstack.io/integrations/openai), not in the request.
    /// </summary>
    public sealed partial class OpenAiGeneratedAsset
    {
        /// <summary>
        /// The name of the provider - set to `openai` for OpenAI.<br/>
        /// Default Value: openai
        /// </summary>
        /// <default>global::G.OpenAiGeneratedAssetProvider.Openai</default>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.OpenAiGeneratedAssetProvider Provider { get; set; } = global::G.OpenAiGeneratedAssetProvider.Openai;

        /// <summary>
        /// Generate assets using OpenAI provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_openaitextgeneratoroptions"&gt;OpenAiTextGeneratorOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAiTextGeneratorOptions Options { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiGeneratedAsset" /> class.
        /// </summary>
        /// <param name="options">
        /// Generate assets using OpenAI provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_openaitextgeneratoroptions"&gt;OpenAiTextGeneratorOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="provider">
        /// The name of the provider - set to `openai` for OpenAI.<br/>
        /// Default Value: openai
        /// </param>
        public OpenAiGeneratedAsset(
            global::G.OpenAiTextGeneratorOptions options,
            global::G.OpenAiGeneratedAssetProvider provider = global::G.OpenAiGeneratedAssetProvider.Openai)
        {
            this.Provider = provider;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiGeneratedAsset" /> class.
        /// </summary>
        public OpenAiGeneratedAsset()
        {
        }
    }
}