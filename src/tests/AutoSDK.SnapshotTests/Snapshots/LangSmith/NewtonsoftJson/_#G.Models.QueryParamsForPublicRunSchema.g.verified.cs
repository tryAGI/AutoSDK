//HintName: G.Models.QueryParamsForPublicRunSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query params for public run endpoints.
    /// </summary>
    public sealed partial class QueryParamsForPublicRunSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryParamsForPublicRunSchema" /> class.
        /// </summary>
        /// <param name="id"></param>
        public QueryParamsForPublicRunSchema(
            global::System.Collections.Generic.IList<global::System.Guid>? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryParamsForPublicRunSchema" /> class.
        /// </summary>
        public QueryParamsForPublicRunSchema()
        {
        }
    }
}