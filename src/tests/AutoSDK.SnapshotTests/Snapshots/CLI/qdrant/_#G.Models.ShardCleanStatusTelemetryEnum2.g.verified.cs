//HintName: G.Models.ShardCleanStatusTelemetryEnum2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardCleanStatusTelemetryEnum2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ShardCleanStatusProgressTelemetry Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardCleanStatusTelemetryEnum2" /> class.
        /// </summary>
        /// <param name="progress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShardCleanStatusTelemetryEnum2(
            global::G.ShardCleanStatusProgressTelemetry progress)
        {
            this.Progress = progress ?? throw new global::System.ArgumentNullException(nameof(progress));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardCleanStatusTelemetryEnum2" /> class.
        /// </summary>
        public ShardCleanStatusTelemetryEnum2()
        {
        }
    }
}