//HintName: G.Models.ShotstackDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send videos and assets to the  [Shotstack hosting and CDN](https://shotstack.io/docs/guide/serving-assets/destinations/shotstack/) service.  This destination is enabled by default.
    /// </summary>
    public sealed partial class ShotstackDestination
    {
        /// <summary>
        /// The destination to send assets to - set to `shotstack` for Shotstack hosting and CDN.<br/>
        /// Default Value: shotstack<br/>
        /// Example: shotstack
        /// </summary>
        /// <default>"shotstack"</default>
        /// <example>shotstack</example>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// Set to `true` to [opt-out](https://shotstack.io/docs/guide/serving-assets/self-host/) from the Shotstack hosting and CDN service. All files must be downloaded within 24 hours of rendering.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public bool? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackDestination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send assets to - set to `shotstack` for Shotstack hosting and CDN.<br/>
        /// Default Value: shotstack<br/>
        /// Example: shotstack
        /// </param>
        /// <param name="exclude">
        /// Set to `true` to [opt-out](https://shotstack.io/docs/guide/serving-assets/self-host/) from the Shotstack hosting and CDN service. All files must be downloaded within 24 hours of rendering.<br/>
        /// Example: false
        /// </param>
        public ShotstackDestination(
            string provider,
            bool? exclude)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackDestination" /> class.
        /// </summary>
        public ShotstackDestination()
        {
        }
    }
}