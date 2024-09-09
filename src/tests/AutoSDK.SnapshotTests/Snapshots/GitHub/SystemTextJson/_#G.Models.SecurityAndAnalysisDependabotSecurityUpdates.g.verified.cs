//HintName: G.Models.SecurityAndAnalysisDependabotSecurityUpdates.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enable or disable Dependabot security updates for the repository.
    /// </summary>
    public sealed partial class SecurityAndAnalysisDependabotSecurityUpdates
    {
        /// <summary>
        /// The enablement status of Dependabot security updates for the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.SecurityAndAnalysisDependabotSecurityUpdatesStatusJsonConverter))]
        public global::G.SecurityAndAnalysisDependabotSecurityUpdatesStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}