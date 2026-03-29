//HintName: G.Models.CreateCollectionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCollectionsResponse
    {
        /// <summary>
        /// ID of the created collection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Slug of the created collection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the created collection
        /// </param>
        /// <param name="slug">
        /// Slug of the created collection
        /// </param>
        public CreateCollectionsResponse(
            global::System.Guid? id,
            string? slug)
        {
            this.Id = id;
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponse" /> class.
        /// </summary>
        public CreateCollectionsResponse()
        {
        }
    }
}