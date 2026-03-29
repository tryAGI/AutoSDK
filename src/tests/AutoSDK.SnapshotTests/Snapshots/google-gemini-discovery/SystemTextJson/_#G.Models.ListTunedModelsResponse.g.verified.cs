//HintName: G.Models.ListTunedModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from `ListTunedModels` containing a paginated list of Models.
    /// </summary>
    public sealed partial class ListTunedModelsResponse
    {
        /// <summary>
        /// The returned Models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunedModels")]
        public global::System.Collections.Generic.IList<global::G.TunedModel>? TunedModels { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTunedModelsResponse" /> class.
        /// </summary>
        /// <param name="tunedModels">
        /// The returned Models.
        /// </param>
        /// <param name="nextPageToken">
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTunedModelsResponse(
            global::System.Collections.Generic.IList<global::G.TunedModel>? tunedModels,
            string? nextPageToken)
        {
            this.TunedModels = tunedModels;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTunedModelsResponse" /> class.
        /// </summary>
        public ListTunedModelsResponse()
        {
        }
    }
}