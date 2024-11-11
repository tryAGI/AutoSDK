//HintName: G.Models.SecurityAndAnalysisSecretScanning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityAndAnalysisSecretScanning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SecurityAndAnalysisSecretScanningStatusJsonConverter))]
        public global::G.SecurityAndAnalysisSecretScanningStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanning" /> class.
        /// </summary>
        /// <param name="status"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SecurityAndAnalysisSecretScanning(
            global::G.SecurityAndAnalysisSecretScanningStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanning" /> class.
        /// </summary>
        public SecurityAndAnalysisSecretScanning()
        {
        }
    }
}