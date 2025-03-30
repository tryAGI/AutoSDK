//HintName: G.Models.PlaygroundSavedOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundSavedOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests_per_second")]
        public int? RequestsPerSecond { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSavedOptions" /> class.
        /// </summary>
        /// <param name="requestsPerSecond"></param>
        public PlaygroundSavedOptions(
            int? requestsPerSecond)
        {
            this.RequestsPerSecond = requestsPerSecond;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSavedOptions" /> class.
        /// </summary>
        public PlaygroundSavedOptions()
        {
        }
    }
}