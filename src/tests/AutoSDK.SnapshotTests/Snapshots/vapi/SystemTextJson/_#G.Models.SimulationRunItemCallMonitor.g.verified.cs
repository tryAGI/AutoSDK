//HintName: G.Models.SimulationRunItemCallMonitor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunItemCallMonitor
    {
        /// <summary>
        /// This is the WebSocket URL to listen to the live call audio (combined both parties).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listenUrl")]
        public string? ListenUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemCallMonitor" /> class.
        /// </summary>
        /// <param name="listenUrl">
        /// This is the WebSocket URL to listen to the live call audio (combined both parties).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunItemCallMonitor(
            string? listenUrl)
        {
            this.ListenUrl = listenUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemCallMonitor" /> class.
        /// </summary>
        public SimulationRunItemCallMonitor()
        {
        }
    }
}