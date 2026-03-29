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
        [global::System.Text.Json.Serialization.JsonPropertyName("caCertificates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> CaCertificates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParamsProxySettings" /> class.
        /// </summary>
        /// <param name="caCertificates">
        /// [NOT IN DOCS] The TLS certificate IDs to trust. Optional.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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