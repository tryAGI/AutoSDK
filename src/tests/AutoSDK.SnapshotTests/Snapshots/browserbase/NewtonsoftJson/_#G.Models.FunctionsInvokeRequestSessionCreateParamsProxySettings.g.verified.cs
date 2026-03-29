//HintName: G.Models.FunctionsInvokeRequestSessionCreateParamsProxySettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// [NOT IN DOCS] Supplementary proxy settings. Optional.
    /// </summary>
    public sealed partial class FunctionsInvokeRequestSessionCreateParamsProxySettings
    {
        /// <summary>
        /// [NOT IN DOCS] The TLS certificate IDs to trust. Optional.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caCertificates", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> CaCertificates { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParamsProxySettings" /> class.
        /// </summary>
        /// <param name="caCertificates">
        /// [NOT IN DOCS] The TLS certificate IDs to trust. Optional.<br/>
        /// Default Value: []
        /// </param>
        public FunctionsInvokeRequestSessionCreateParamsProxySettings(
            global::System.Collections.Generic.IList<global::System.Guid> caCertificates)
        {
            this.CaCertificates = caCertificates ?? throw new global::System.ArgumentNullException(nameof(caCertificates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParamsProxySettings" /> class.
        /// </summary>
        public FunctionsInvokeRequestSessionCreateParamsProxySettings()
        {
        }
    }
}