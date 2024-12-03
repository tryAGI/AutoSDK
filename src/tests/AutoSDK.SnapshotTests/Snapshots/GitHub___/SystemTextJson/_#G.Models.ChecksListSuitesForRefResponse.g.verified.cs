//HintName: G.Models.ChecksListSuitesForRefResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksListSuitesForRefResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("check_suites")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CheckSuite> CheckSuites { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksListSuitesForRefResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="checkSuites"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChecksListSuitesForRefResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.CheckSuite> checkSuites)
        {
            this.TotalCount = totalCount;
            this.CheckSuites = checkSuites ?? throw new global::System.ArgumentNullException(nameof(checkSuites));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksListSuitesForRefResponse" /> class.
        /// </summary>
        public ChecksListSuitesForRefResponse()
        {
        }
    }
}