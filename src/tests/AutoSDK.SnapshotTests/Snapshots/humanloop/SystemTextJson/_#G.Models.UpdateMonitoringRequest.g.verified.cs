//HintName: G.Models.UpdateMonitoringRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMonitoringRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activate")]
        public global::System.Collections.Generic.IList<global::G.UpdateMonitoringRequestActivateItem>? Activate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivate")]
        public global::System.Collections.Generic.IList<global::G.UpdateMonitoringRequestDeactivateItem>? Deactivate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMonitoringRequest" /> class.
        /// </summary>
        /// <param name="activate"></param>
        /// <param name="deactivate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMonitoringRequest(
            global::System.Collections.Generic.IList<global::G.UpdateMonitoringRequestActivateItem>? activate,
            global::System.Collections.Generic.IList<global::G.UpdateMonitoringRequestDeactivateItem>? deactivate)
        {
            this.Activate = activate;
            this.Deactivate = deactivate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMonitoringRequest" /> class.
        /// </summary>
        public UpdateMonitoringRequest()
        {
        }
    }
}