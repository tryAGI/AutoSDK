//HintName: G.Models.ApiInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiInfo
    {
        /// <summary>
        /// api id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_id")]
        public string? ApiId { get; set; }

        /// <summary>
        /// api描述
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// api名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInfo" /> class.
        /// </summary>
        /// <param name="apiId">
        /// api id
        /// </param>
        /// <param name="description">
        /// api描述
        /// </param>
        /// <param name="name">
        /// api名称
        /// </param>
        public ApiInfo(
            string? apiId,
            string? description,
            string? name)
        {
            this.ApiId = apiId;
            this.Description = description;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInfo" /> class.
        /// </summary>
        public ApiInfo()
        {
        }
    }
}