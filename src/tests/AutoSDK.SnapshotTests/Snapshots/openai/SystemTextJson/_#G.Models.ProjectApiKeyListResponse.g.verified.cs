//HintName: G.Models.ProjectApiKeyListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectApiKeyListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ProjectApiKey> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectApiKeyListResponseObjectJsonConverter))]
        public global::G.ProjectApiKeyListResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKeyListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstId"></param>
        /// <param name="hasMore"></param>
        /// <param name="lastId"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectApiKeyListResponse(
            global::System.Collections.Generic.IList<global::G.ProjectApiKey> data,
            string firstId,
            bool hasMore,
            string lastId,
            global::G.ProjectApiKeyListResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.HasMore = hasMore;
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKeyListResponse" /> class.
        /// </summary>
        public ProjectApiKeyListResponse()
        {
        }
    }
}