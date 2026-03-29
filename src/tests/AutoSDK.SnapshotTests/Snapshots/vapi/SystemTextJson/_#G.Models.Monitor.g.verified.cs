//HintName: G.Models.Monitor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Monitor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitors")]
        public global::System.Collections.Generic.IList<global::G.MonitorResult>? Monitors { get; set; }

        /// <summary>
        /// This is the URL where the assistant's calls can be listened to in real-time. To enable, set `assistant.monitorPlan.listenEnabled` to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listenUrl")]
        public string? ListenUrl { get; set; }

        /// <summary>
        /// This is the URL where the assistant's calls can be controlled in real-time. To enable, set `assistant.monitorPlan.controlEnabled` to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlUrl")]
        public string? ControlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Monitor" /> class.
        /// </summary>
        /// <param name="monitors"></param>
        /// <param name="listenUrl">
        /// This is the URL where the assistant's calls can be listened to in real-time. To enable, set `assistant.monitorPlan.listenEnabled` to `true`.
        /// </param>
        /// <param name="controlUrl">
        /// This is the URL where the assistant's calls can be controlled in real-time. To enable, set `assistant.monitorPlan.controlEnabled` to `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Monitor(
            global::System.Collections.Generic.IList<global::G.MonitorResult>? monitors,
            string? listenUrl,
            string? controlUrl)
        {
            this.Monitors = monitors;
            this.ListenUrl = listenUrl;
            this.ControlUrl = controlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Monitor" /> class.
        /// </summary>
        public Monitor()
        {
        }
    }
}