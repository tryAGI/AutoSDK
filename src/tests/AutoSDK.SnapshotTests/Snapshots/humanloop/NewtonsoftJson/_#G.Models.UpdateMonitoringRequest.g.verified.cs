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
        [global::Newtonsoft.Json.JsonProperty("activate")]
        public global::System.Collections.Generic.IList<global::G.UpdateMonitoringRequestActivateItem>? Activate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deactivate")]
        public global::System.Collections.Generic.IList<global::G.UpdateMonitoringRequestDeactivateItem>? Deactivate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMonitoringRequest" /> class.
        /// </summary>
        /// <param name="activate"></param>
        /// <param name="deactivate"></param>
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