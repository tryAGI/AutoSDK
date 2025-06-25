//HintName: G.Models.GetCheermotesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCheermotesResponse
    {
        /// <summary>
        /// The list of Cheermotes. The list is in ascending order by the `order` field’s value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Cheermote> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheermotesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of Cheermotes. The list is in ascending order by the `order` field’s value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCheermotesResponse(
            global::System.Collections.Generic.IList<global::G.Cheermote> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheermotesResponse" /> class.
        /// </summary>
        public GetCheermotesResponse()
        {
        }
    }
}