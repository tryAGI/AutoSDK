//HintName: G.Models.FunctionVersionsListInvocationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionVersionsListInvocationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Invocation> Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionVersionsListInvocationsResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionVersionsListInvocationsResponse(
            global::System.Collections.Generic.IList<global::G.Invocation> results,
            int total)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionVersionsListInvocationsResponse" /> class.
        /// </summary>
        public FunctionVersionsListInvocationsResponse()
        {
        }
    }
}