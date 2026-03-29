//HintName: G.Models.HardwareTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HardwareTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection_data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.HardwareUsage> CollectionData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareTelemetry" /> class.
        /// </summary>
        /// <param name="collectionData"></param>
        public HardwareTelemetry(
            global::System.Collections.Generic.Dictionary<string, global::G.HardwareUsage> collectionData)
        {
            this.CollectionData = collectionData ?? throw new global::System.ArgumentNullException(nameof(collectionData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareTelemetry" /> class.
        /// </summary>
        public HardwareTelemetry()
        {
        }
    }
}