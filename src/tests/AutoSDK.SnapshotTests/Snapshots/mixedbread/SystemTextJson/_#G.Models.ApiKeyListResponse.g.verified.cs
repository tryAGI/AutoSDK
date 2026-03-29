//HintName: G.Models.ApiKeyListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyListResponse
    {
        /// <summary>
        /// Pagination model that includes total count of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PaginationWithTotal Pagination { get; set; }

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The list of API keys
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ApiKey> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyListResponse" /> class.
        /// </summary>
        /// <param name="pagination">
        /// Pagination model that includes total count of items.
        /// </param>
        /// <param name="data">
        /// The list of API keys
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyListResponse(
            global::G.PaginationWithTotal pagination,
            global::System.Collections.Generic.IList<global::G.ApiKey> data,
            string? @object)
        {
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyListResponse" /> class.
        /// </summary>
        public ApiKeyListResponse()
        {
        }
    }
}