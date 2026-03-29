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
        [global::Newtonsoft.Json.JsonProperty("killedCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int KilledCount { get; set; } = default!;

        /// <summary>
        /// Number of sandboxes that failed to kill
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failedCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailedCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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