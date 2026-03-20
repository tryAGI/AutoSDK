//HintName: G.Models.ResponseConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response configuration for response.create events.
    /// </summary>
    public sealed partial class ResponseConfig
    {
        /// <summary>
        /// Response modalities.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modalities")]
        public global::System.Collections.Generic.IList<string>? Modalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfig" /> class.
        /// </summary>
        /// <param name="modalities">
        /// Response modalities.
        /// </param>
        public ResponseConfig(
            global::System.Collections.Generic.IList<string>? modalities)
        {
            this.Modalities = modalities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfig" /> class.
        /// </summary>
        public ResponseConfig()
        {
        }
    }
}