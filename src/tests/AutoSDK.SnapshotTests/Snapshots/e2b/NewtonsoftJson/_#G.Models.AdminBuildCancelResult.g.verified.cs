//HintName: G.Models.AdminBuildCancelResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminBuildCancelResult
    {
        /// <summary>
        /// Number of builds successfully cancelled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelledCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int CancelledCount { get; set; } = default!;

        /// <summary>
        /// Number of builds that failed to cancel
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failedCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailedCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBuildCancelResult" /> class.
        /// </summary>
        /// <param name="cancelledCount">
        /// Number of builds successfully cancelled
        /// </param>
        /// <param name="failedCount">
        /// Number of builds that failed to cancel
        /// </param>
        public AdminBuildCancelResult(
            int cancelledCount,
            int failedCount)
        {
            this.CancelledCount = cancelledCount;
            this.FailedCount = failedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBuildCancelResult" /> class.
        /// </summary>
        public AdminBuildCancelResult()
        {
        }
    }
}