//HintName: G.Models.CreateVectordbEntitiesSearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbEntitiesSearchRequest
    {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the collection to which this operation applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// A list of vector embeddings.<br/>
        /// &lt;include target="milvus"&gt;Milvus&lt;/include&gt;&lt;include target="zilliz"&gt;Zilliz Cloud&lt;/include&gt; searches for the most similar vector embeddings to the specified ones.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.AnyOf<int?, string>>> Vector { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annsField")]
        public string? AnnsField { get; set; }

        /// <summary>
        /// The filter used to find matches for the search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// The total number of entities to return.<br/>
        /// You can use this parameter in combination with **offset** in **param** to enable pagination.<br/>
        /// The sum of this value and **offset** in **param** should be less than 16,384. 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        ///     The number of records to skip in the search result.      You can use this parameter in combination with limit to enable pagination.     The sum of this value and limit should be less than 16,384. 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// https://zilliverse.feishu.cn/docx/S3brdwmUHoG33dxhifpcruAYnsb
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groupingField")]
        public string? GroupingField { get; set; }

        /// <summary>
        /// An array of fields to return along with the search results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputFields")]
        public global::System.Collections.Generic.IList<string>? OutputFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchParams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SearchParams SearchParams { get; set; } = default!;

        /// <summary>
        /// The name of the partitions to which this operation applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partitionNames")]
        public global::System.Collections.Generic.IList<string>? PartitionNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbEntitiesSearchRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the collection to which this operation applies.
        /// </param>
        /// <param name="vector">
        /// A list of vector embeddings.<br/>
        /// &lt;include target="milvus"&gt;Milvus&lt;/include&gt;&lt;include target="zilliz"&gt;Zilliz Cloud&lt;/include&gt; searches for the most similar vector embeddings to the specified ones.
        /// </param>
        /// <param name="searchParams"></param>
        /// <param name="dbName">
        /// The name of the database.
        /// </param>
        /// <param name="annsField"></param>
        /// <param name="filter">
        /// The filter used to find matches for the search.
        /// </param>
        /// <param name="limit">
        /// The total number of entities to return.<br/>
        /// You can use this parameter in combination with **offset** in **param** to enable pagination.<br/>
        /// The sum of this value and **offset** in **param** should be less than 16,384. 
        /// </param>
        /// <param name="offset">
        ///     The number of records to skip in the search result.      You can use this parameter in combination with limit to enable pagination.     The sum of this value and limit should be less than 16,384. 
        /// </param>
        /// <param name="groupingField">
        /// https://zilliverse.feishu.cn/docx/S3brdwmUHoG33dxhifpcruAYnsb
        /// </param>
        /// <param name="outputFields">
        /// An array of fields to return along with the search results.
        /// </param>
        /// <param name="partitionNames">
        /// The name of the partitions to which this operation applies.
        /// </param>
        public CreateVectordbEntitiesSearchRequest(
            string collectionName,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.AnyOf<int?, string>>> vector,
            global::G.SearchParams searchParams,
            string? dbName,
            string? annsField,
            string? filter,
            int? limit,
            int? offset,
            string? groupingField,
            global::System.Collections.Generic.IList<string>? outputFields,
            global::System.Collections.Generic.IList<string>? partitionNames)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.Vector = vector ?? throw new global::System.ArgumentNullException(nameof(vector));
            this.AnnsField = annsField;
            this.Filter = filter;
            this.Limit = limit;
            this.Offset = offset;
            this.GroupingField = groupingField;
            this.OutputFields = outputFields;
            this.SearchParams = searchParams ?? throw new global::System.ArgumentNullException(nameof(searchParams));
            this.PartitionNames = partitionNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbEntitiesSearchRequest" /> class.
        /// </summary>
        public CreateVectordbEntitiesSearchRequest()
        {
        }
    }
}