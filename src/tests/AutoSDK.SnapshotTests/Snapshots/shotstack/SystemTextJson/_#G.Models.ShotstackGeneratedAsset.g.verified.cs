//HintName: G.Models.ShotstackGeneratedAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using the native Shotstack provider. Shotstack provides a text-to-speech and a text-to-image service. The Shotstack provider works natively with your existing API key, no additional credentials are required.
    /// </summary>
    public sealed partial class ShotstackGeneratedAsset
    {
        /// <summary>
        /// The name of the provider - set to `shotstack` for Shotstack.<br/>
        /// Default Value: shotstack
        /// </summary>
        /// <default>global::G.ShotstackGeneratedAssetProvider.Shotstack</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ShotstackGeneratedAssetProviderJsonConverter))]
        public global::G.ShotstackGeneratedAssetProvider Provider { get; set; } = global::G.ShotstackGeneratedAssetProvider.Shotstack;

        /// <summary>
        /// Generate assets using the native Shotstack provider AI services.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ShotstackGeneratedAssetOptionsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ShotstackGeneratedAssetOptions Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackGeneratedAsset" /> class.
        /// </summary>
        /// <param name="options">
        /// Generate assets using the native Shotstack provider AI services.
        /// </param>
        /// <param name="provider">
        /// The name of the provider - set to `shotstack` for Shotstack.<br/>
        /// Default Value: shotstack
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShotstackGeneratedAsset(
            global::G.ShotstackGeneratedAssetOptions options,
            global::G.ShotstackGeneratedAssetProvider provider = global::G.ShotstackGeneratedAssetProvider.Shotstack)
        {
            this.Provider = provider;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackGeneratedAsset" /> class.
        /// </summary>
        public ShotstackGeneratedAsset()
        {
        }
    }
}