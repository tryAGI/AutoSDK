//HintName: G.Models.AzureContentSafetyParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureContentSafetyParameters
    {
        /// <summary>
        /// Array of blocklist names to check against<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocklistNames")]
        public global::System.Collections.Generic.IList<string>? BlocklistNames { get; set; }

        /// <summary>
        /// API version for the Content Safety API<br/>
        /// Default Value: 2024-09-01
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiVersion")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Severity threshold for the Content Safety API<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        public double? Severity { get; set; }

        /// <summary>
        /// Categories to check against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<global::G.AzureContentSafetyParametersCategorie>? Categories { get; set; }

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
        /// Initializes a new instance of the <see cref="AzureContentSafetyParameters" /> class.
        /// </summary>
        /// <param name="blocklistNames">
        /// Array of blocklist names to check against<br/>
        /// Default Value: []
        /// </param>
        /// <param name="apiVersion">
        /// API version for the Content Safety API<br/>
        /// Default Value: 2024-09-01
        /// </param>
        /// <param name="severity">
        /// Severity threshold for the Content Safety API<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="categories">
        /// Categories to check against
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureContentSafetyParameters(
            global::System.Collections.Generic.IList<string>? blocklistNames,
            string? apiVersion,
            double? severity,
            global::System.Collections.Generic.IList<global::G.AzureContentSafetyParametersCategorie>? categories,
            double? timeout)
        {
            this.BlocklistNames = blocklistNames;
            this.ApiVersion = apiVersion;
            this.Severity = severity;
            this.Categories = categories;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureContentSafetyParameters" /> class.
        /// </summary>
        public AzureContentSafetyParameters()
        {
        }
    }
}