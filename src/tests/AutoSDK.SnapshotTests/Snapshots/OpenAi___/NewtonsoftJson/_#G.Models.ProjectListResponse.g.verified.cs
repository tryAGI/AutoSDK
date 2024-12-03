//HintName: G.Models.ProjectListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ProjectListResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Project> Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectListResponse" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="data"></param>
        /// <param name="firstId"></param>
        /// <param name="lastId"></param>
        /// <param name="hasMore"></param>
        public ProjectListResponse(
            global::System.Collections.Generic.IList<global::G.Project> data,
            string firstId,
            string lastId,
            bool hasMore,
            global::G.ProjectListResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.HasMore = hasMore;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectListResponse" /> class.
        /// </summary>
        public ProjectListResponse()
        {
        }
    }
}