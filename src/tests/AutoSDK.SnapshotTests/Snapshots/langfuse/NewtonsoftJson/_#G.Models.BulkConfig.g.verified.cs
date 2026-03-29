//HintName: G.Models.BulkConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Supported { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxOperations", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxOperations { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxPayloadSize", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxPayloadSize { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkConfig" /> class.
        /// </summary>
        /// <param name="supported"></param>
        /// <param name="maxOperations"></param>
        /// <param name="maxPayloadSize"></param>
        public BulkConfig(
            bool supported,
            int maxOperations,
            int maxPayloadSize)
        {
            this.Supported = supported;
            this.MaxOperations = maxOperations;
            this.MaxPayloadSize = maxPayloadSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkConfig" /> class.
        /// </summary>
        public BulkConfig()
        {
        }
    }
}