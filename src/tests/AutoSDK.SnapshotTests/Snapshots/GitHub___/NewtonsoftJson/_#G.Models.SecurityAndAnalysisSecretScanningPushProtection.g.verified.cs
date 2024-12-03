//HintName: G.Models.SecurityAndAnalysisSecretScanningPushProtection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityAndAnalysisSecretScanningPushProtection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.SecurityAndAnalysisSecretScanningPushProtectionStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanningPushProtection" /> class.
        /// </summary>
        /// <param name="status"></param>
        public SecurityAndAnalysisSecretScanningPushProtection(
            global::G.SecurityAndAnalysisSecretScanningPushProtectionStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanningPushProtection" /> class.
        /// </summary>
        public SecurityAndAnalysisSecretScanningPushProtection()
        {
        }
    }
}