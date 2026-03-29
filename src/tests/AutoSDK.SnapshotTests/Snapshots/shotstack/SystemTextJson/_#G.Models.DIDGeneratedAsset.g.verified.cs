//HintName: G.Models.DIDGeneratedAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using D-ID. D-ID provide a text-to-avatar service. The D-ID provider works on a bring-your-own-key basis, credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/d-id), not in the request.
    /// </summary>
    public sealed partial class DIDGeneratedAsset
    {
        /// <summary>
        /// The name of the provider - set to `d-id` for D-ID.<br/>
        /// Default Value: d-id
        /// </summary>
        /// <default>global::G.DIDGeneratedAssetProvider.DId</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DIDGeneratedAssetProviderJsonConverter))]
        public global::G.DIDGeneratedAssetProvider Provider { get; set; } = global::G.DIDGeneratedAssetProvider.DId;

        /// <summary>
        /// Generate assets using the third party D-ID provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_didtexttoavataroptions"&gt;DidTextToAvatarOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DIDTextToAvatarOptions Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DIDGeneratedAsset" /> class.
        /// </summary>
        /// <param name="options">
        /// Generate assets using the third party D-ID provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_didtexttoavataroptions"&gt;DidTextToAvatarOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="provider">
        /// The name of the provider - set to `d-id` for D-ID.<br/>
        /// Default Value: d-id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DIDGeneratedAsset(
            global::G.DIDTextToAvatarOptions options,
            global::G.DIDGeneratedAssetProvider provider = global::G.DIDGeneratedAssetProvider.DId)
        {
            this.Provider = provider;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DIDGeneratedAsset" /> class.
        /// </summary>
        public DIDGeneratedAsset()
        {
        }
    }
}