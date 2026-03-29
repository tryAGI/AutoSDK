//HintName: G.Models.GetCollectionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCollectionsResponse
    {
        /// <summary>
        /// Total number of collections matching the criteria
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.CollectionWithDetails>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of collections matching the criteria
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCollectionsResponse(
            int? total,
            global::System.Collections.Generic.IList<global::G.CollectionWithDetails>? data)
        {
            this.Total = total;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponse" /> class.
        /// </summary>
        public GetCollectionsResponse()
        {
        }
    }
}