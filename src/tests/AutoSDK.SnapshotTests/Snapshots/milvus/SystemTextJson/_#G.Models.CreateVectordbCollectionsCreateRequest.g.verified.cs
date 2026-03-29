//HintName: G.Models.CreateVectordbCollectionsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbCollectionsCreateRequest
    {
        /// <summary>
        /// The name of the database. &lt;zilliz&gt;This parameter applies only to dedicated clusters.&lt;/zilliz&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the collection to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        public string? CollectionName { get; set; }

        /// <summary>
        /// The number of dimensions a vector value should have.<br/>
        /// This is required if **dtype** of this field is set to **DataType.FLOAT_VECTOR**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public int? Dimension { get; set; }

        /// <summary>
        /// The metric type applied to this operation. <br/>
        /// Possible values are **L2**, **IP**, and **COSINE**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricType")]
        public string? MetricType { get; set; }

        /// <summary>
        /// The data type of the primary field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idType")]
        public string? IdType { get; set; }

        /// <summary>
        /// Whether the primary field automatically increments. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.<br/>
        /// Default Value: false
        /// </summary>
        /// <default>"false"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AutoID { get; set; } = "false";

        /// <summary>
        /// The name of the primary field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryFieldName")]
        public string? PrimaryFieldName { get; set; }

        /// <summary>
        /// The name of the vector field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorFieldName")]
        public string? VectorFieldName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::G.CollectionSchema? Schema { get; set; }

        /// <summary>
        /// The parameters that apply to the index-building process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexParams")]
        public global::System.Collections.Generic.IList<global::G.IndexParam>? IndexParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::G.CollectionParams? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsCreateRequest" /> class.
        /// </summary>
        /// <param name="autoID">
        /// Whether the primary field automatically increments. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dbName">
        /// The name of the database. &lt;zilliz&gt;This parameter applies only to dedicated clusters.&lt;/zilliz&gt;
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection to create.
        /// </param>
        /// <param name="dimension">
        /// The number of dimensions a vector value should have.<br/>
        /// This is required if **dtype** of this field is set to **DataType.FLOAT_VECTOR**.
        /// </param>
        /// <param name="metricType">
        /// The metric type applied to this operation. <br/>
        /// Possible values are **L2**, **IP**, and **COSINE**.
        /// </param>
        /// <param name="idType">
        /// The data type of the primary field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.
        /// </param>
        /// <param name="primaryFieldName">
        /// The name of the primary field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.
        /// </param>
        /// <param name="vectorFieldName">
        /// The name of the vector field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.
        /// </param>
        /// <param name="schema"></param>
        /// <param name="indexParams">
        /// The parameters that apply to the index-building process.
        /// </param>
        /// <param name="params"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectordbCollectionsCreateRequest(
            string autoID,
            string? dbName,
            string? collectionName,
            int? dimension,
            string? metricType,
            string? idType,
            string? primaryFieldName,
            string? vectorFieldName,
            global::G.CollectionSchema? schema,
            global::System.Collections.Generic.IList<global::G.IndexParam>? indexParams,
            global::G.CollectionParams? @params)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName;
            this.Dimension = dimension;
            this.MetricType = metricType;
            this.IdType = idType;
            this.AutoID = autoID ?? throw new global::System.ArgumentNullException(nameof(autoID));
            this.PrimaryFieldName = primaryFieldName;
            this.VectorFieldName = vectorFieldName;
            this.Schema = schema;
            this.IndexParams = indexParams;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsCreateRequest" /> class.
        /// </summary>
        public CreateVectordbCollectionsCreateRequest()
        {
        }
    }
}