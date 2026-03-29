//HintName: G.Models.AdminSandboxKillResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminSandboxKillResult
    {
        /// <summary>
        /// Number of sandboxes successfully killed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("killedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int KilledCount { get; set; }

        /// <summary>
        /// Number of sandboxes that failed to kill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxKillResult" /> class.
        /// </summary>
        /// <param name="killedCount">
        /// Number of sandboxes successfully killed
        /// </param>
        /// <param name="failedCount">
        /// Number of sandboxes that failed to kill
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSandboxKillResult(
            int killedCount,
            int failedCount)
        {
            this.KilledCount = killedCount;
            this.FailedCount = failedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSandboxKillResult" /> class.
        /// </summary>
        public AdminSandboxKillResult()
        {
        }
    }
}