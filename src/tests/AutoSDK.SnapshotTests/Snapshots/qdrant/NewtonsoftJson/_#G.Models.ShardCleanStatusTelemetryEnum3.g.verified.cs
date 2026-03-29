//HintName: G.Models.ShardCleanStatusTelemetryEnum3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardCleanStatusTelemetryEnum3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShardCleanStatusFailedTelemetry Failed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardCleanStatusTelemetryEnum3" /> class.
        /// </summary>
        /// <param name="failed"></param>
        public ShardCleanStatusTelemetryEnum3(
            global::G.ShardCleanStatusFailedTelemetry failed)
        {
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardCleanStatusTelemetryEnum3" /> class.
        /// </summary>
        public ShardCleanStatusTelemetryEnum3()
        {
        }
    }
}