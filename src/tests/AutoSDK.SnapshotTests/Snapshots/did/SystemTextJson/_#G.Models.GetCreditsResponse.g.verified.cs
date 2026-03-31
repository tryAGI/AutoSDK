//HintName: G.Models.GetCreditsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCreditsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetCreditsResponseCredit> Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Remaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreditsResponse" /> class.
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="remaining"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCreditsResponse(
            global::System.Collections.Generic.IList<global::G.GetCreditsResponseCredit> credits,
            double remaining,
            double total)
        {
            this.Credits = credits ?? throw new global::System.ArgumentNullException(nameof(credits));
            this.Remaining = remaining;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreditsResponse" /> class.
        /// </summary>
        public GetCreditsResponse()
        {
        }
    }
}