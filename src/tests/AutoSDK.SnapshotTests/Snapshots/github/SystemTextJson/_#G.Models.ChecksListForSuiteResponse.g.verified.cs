//HintName: G.Models.ChecksListForSuiteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksListForSuiteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CheckRun> CheckRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksListForSuiteResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="checkRuns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChecksListForSuiteResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.CheckRun> checkRuns)
        {
            this.TotalCount = totalCount;
            this.CheckRuns = checkRuns ?? throw new global::System.ArgumentNullException(nameof(checkRuns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksListForSuiteResponse" /> class.
        /// </summary>
        public ChecksListForSuiteResponse()
        {
        }
    }
}