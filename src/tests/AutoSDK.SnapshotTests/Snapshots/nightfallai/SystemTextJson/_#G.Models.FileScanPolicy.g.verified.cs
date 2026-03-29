//HintName: G.Models.FileScanPolicy.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileScanPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookURL")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? WebhookURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectionRules")]
        public global::System.Collections.Generic.IList<global::G.DetectionRule>? DetectionRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectionRuleUUIDs")]
        public global::System.Collections.Generic.IList<string>? DetectionRuleUUIDs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertConfig")]
        public global::G.AlertConfig? AlertConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileScanPolicy" /> class.
        /// </summary>
        /// <param name="detectionRules"></param>
        /// <param name="detectionRuleUUIDs"></param>
        /// <param name="alertConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileScanPolicy(
            global::System.Collections.Generic.IList<global::G.DetectionRule>? detectionRules,
            global::System.Collections.Generic.IList<string>? detectionRuleUUIDs,
            global::G.AlertConfig? alertConfig)
        {
            this.DetectionRules = detectionRules;
            this.DetectionRuleUUIDs = detectionRuleUUIDs;
            this.AlertConfig = alertConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileScanPolicy" /> class.
        /// </summary>
        public FileScanPolicy()
        {
        }
    }
}