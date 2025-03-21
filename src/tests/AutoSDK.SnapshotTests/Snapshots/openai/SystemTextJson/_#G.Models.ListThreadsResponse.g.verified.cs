//HintName: G.Models.ListThreadsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListThreadsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ThreadObject> Data { get; set; }

        /// <summary>
        /// Example: asst_abc123
        /// </summary>
        /// <example>asst_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Example: asst_abc456
        /// </summary>
        /// <example>asst_abc456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListThreadsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstId">
        /// Example: asst_abc123
        /// </param>
        /// <param name="hasMore">
        /// Example: false
        /// </param>
        /// <param name="lastId">
        /// Example: asst_abc456
        /// </param>
        /// <param name="object">
        /// Example: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListThreadsResponse(
            global::System.Collections.Generic.IList<global::G.ThreadObject> data,
            string firstId,
            bool hasMore,
            string lastId,
            string @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.HasMore = hasMore;
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListThreadsResponse" /> class.
        /// </summary>
        public ListThreadsResponse()
        {
        }
    }
}