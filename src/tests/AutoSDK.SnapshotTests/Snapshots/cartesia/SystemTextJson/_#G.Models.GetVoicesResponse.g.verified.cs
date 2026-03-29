//HintName: G.Models.GetVoicesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoicesResponse
    {
        /// <summary>
        /// The paginated list of Voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Voice> Data { get; set; }

        /// <summary>
        /// Whether there are more Voices to fetch (using `starting_after=id`, where id is the ID of the last Voice in the current response).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The paginated list of Voices.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more Voices to fetch (using `starting_after=id`, where id is the ID of the last Voice in the current response).
        /// </param>
        /// <param name="nextPage">
        /// The ID of the voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoicesResponse(
            global::System.Collections.Generic.IList<global::G.Voice> data,
            bool hasMore,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponse" /> class.
        /// </summary>
        public GetVoicesResponse()
        {
        }
    }
}