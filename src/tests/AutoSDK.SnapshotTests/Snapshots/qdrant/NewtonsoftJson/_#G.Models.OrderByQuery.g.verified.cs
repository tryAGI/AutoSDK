//HintName: G.Models.OrderByQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderByQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrderByInterface OrderBy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderByQuery" /> class.
        /// </summary>
        /// <param name="orderBy"></param>
        public OrderByQuery(
            global::G.OrderByInterface orderBy)
        {
            this.OrderBy = orderBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderByQuery" /> class.
        /// </summary>
        public OrderByQuery()
        {
        }
    }
}