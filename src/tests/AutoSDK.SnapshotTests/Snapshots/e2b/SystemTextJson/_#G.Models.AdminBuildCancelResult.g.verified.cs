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
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelledCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CancelledCount { get; set; }

        /// <summary>
        /// Number of builds that failed to cancel
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
        /// Initializes a new instance of the <see cref="AdminBuildCancelResult" /> class.
        /// </summary>
        /// <param name="cancelledCount">
        /// Number of builds successfully cancelled
        /// </param>
        /// <param name="failedCount">
        /// Number of builds that failed to cancel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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