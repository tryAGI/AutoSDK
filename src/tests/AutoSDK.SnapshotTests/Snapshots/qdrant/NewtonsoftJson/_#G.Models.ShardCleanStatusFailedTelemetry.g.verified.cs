//HintName: G.Models.ShardCleanStatusFailedTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardCleanStatusFailedTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reason { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardCleanStatusFailedTelemetry" /> class.
        /// </summary>
        /// <param name="reason"></param>
        public ShardCleanStatusFailedTelemetry(
            string reason)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardCleanStatusFailedTelemetry" /> class.
        /// </summary>
        public ShardCleanStatusFailedTelemetry()
        {
        }
    }
}