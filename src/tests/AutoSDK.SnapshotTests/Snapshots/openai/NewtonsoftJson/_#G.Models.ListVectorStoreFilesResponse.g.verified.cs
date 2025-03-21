//HintName: G.Models.ListVectorStoreFilesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListVectorStoreFilesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VectorStoreFileObject> Data { get; set; } = default!;

        /// <summary>
        /// Example: file-abc123
        /// </summary>
        /// <example>file-abc123</example>
        [global::Newtonsoft.Json.JsonProperty("first_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstId { get; set; } = default!;

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Example: file-abc456
        /// </summary>
        /// <example>file-abc456</example>
        [global::Newtonsoft.Json.JsonProperty("last_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastId { get; set; } = default!;

        /// <summary>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVectorStoreFilesResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstId">
        /// Example: file-abc123
        /// </param>
        /// <param name="hasMore">
        /// Example: false
        /// </param>
        /// <param name="lastId">
        /// Example: file-abc456
        /// </param>
        /// <param name="object">
        /// Example: list
        /// </param>
        public ListVectorStoreFilesResponse(
            global::System.Collections.Generic.IList<global::G.VectorStoreFileObject> data,
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
        /// Initializes a new instance of the <see cref="ListVectorStoreFilesResponse" /> class.
        /// </summary>
        public ListVectorStoreFilesResponse()
        {
        }
    }
}