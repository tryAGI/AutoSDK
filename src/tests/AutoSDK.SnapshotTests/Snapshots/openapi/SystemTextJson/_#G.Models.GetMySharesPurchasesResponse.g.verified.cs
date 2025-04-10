//HintName: G.Models.GetMySharesPurchasesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMySharesPurchasesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharesPurchased")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SharesPurchased { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMySharesPurchasesResponse" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="sharesPurchased"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMySharesPurchasesResponse(
            global::System.DateTime date,
            double sharesPurchased)
        {
            this.Date = date;
            this.SharesPurchased = sharesPurchased;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMySharesPurchasesResponse" /> class.
        /// </summary>
        public GetMySharesPurchasesResponse()
        {
        }
    }
}