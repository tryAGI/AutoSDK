//HintName: G.Models.MonitorResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonitorResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MonitorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterPassed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FilterPassed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorResult" /> class.
        /// </summary>
        /// <param name="monitorId"></param>
        /// <param name="filterPassed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonitorResult(
            string monitorId,
            bool filterPassed)
        {
            this.MonitorId = monitorId ?? throw new global::System.ArgumentNullException(nameof(monitorId));
            this.FilterPassed = filterPassed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorResult" /> class.
        /// </summary>
        public MonitorResult()
        {
        }
    }
}