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
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.HardwareUsage> CollectionData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareTelemetry" /> class.
        /// </summary>
        /// <param name="collectionData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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