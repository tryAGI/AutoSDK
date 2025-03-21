//HintName: G.Models.ApiKeyList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.AdminApiKey>? Data { get; set; }

        /// <summary>
        /// Example: key_abc
        /// </summary>
        /// <example>key_abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Example: key_xyz
        /// </summary>
        /// <example>key_xyz</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyList" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstId">
        /// Example: key_abc
        /// </param>
        /// <param name="hasMore">
        /// Example: false
        /// </param>
        /// <param name="lastId">
        /// Example: key_xyz
        /// </param>
        /// <param name="object">
        /// Example: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyList(
            global::System.Collections.Generic.IList<global::G.AdminApiKey>? data,
            string? firstId,
            bool? hasMore,
            string? lastId,
            string? @object)
        {
            this.Data = data;
            this.FirstId = firstId;
            this.HasMore = hasMore;
            this.LastId = lastId;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyList" /> class.
        /// </summary>
        public ApiKeyList()
        {
        }
    }
}