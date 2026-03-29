//HintName: G.Models.PortkeyPIIParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PortkeyPIIParameters
    {
        /// <summary>
        /// Whether to redact detected PII<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact")]
        public bool? Redact { get; set; }

        /// <summary>
        /// Types of PII that should NOT be allowed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PortkeyPIIParametersCategorie> Categories { get; set; }

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PortkeyPIIParameters" /> class.
        /// </summary>
        /// <param name="categories">
        /// Types of PII that should NOT be allowed
        /// </param>
        /// <param name="redact">
        /// Whether to redact detected PII<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PortkeyPIIParameters(
            global::System.Collections.Generic.IList<global::G.PortkeyPIIParametersCategorie> categories,
            bool? redact,
            double? timeout)
        {
            this.Redact = redact;
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortkeyPIIParameters" /> class.
        /// </summary>
        public PortkeyPIIParameters()
        {
        }
    }
}