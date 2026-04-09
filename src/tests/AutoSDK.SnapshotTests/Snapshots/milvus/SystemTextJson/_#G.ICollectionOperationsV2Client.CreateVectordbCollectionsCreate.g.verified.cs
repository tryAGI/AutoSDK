//HintName: G.ICollectionOperationsV2Client.CreateVectordbCollectionsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionOperationsV2Client
    {
        /// <summary>
        /// Create Collection<br/>
        /// This operation creates a collection in a specified cluster.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.HttpapiGenericRespCustomerCreateIndexResp> CreateVectordbCollectionsCreateAsync(
            int requestTimeout,

            global::G.CreateVectordbCollectionsCreateRequest request,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Collection<br/>
        /// This operation creates a collection in a specified cluster.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
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
        /// <param name="autoID">
        /// Whether the primary field automatically increments. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.<br/>
        /// Default Value: false
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.HttpapiGenericRespCustomerCreateIndexResp> CreateVectordbCollectionsCreateAsync(
            int requestTimeout,
            string? authorization = default,
            string? dbName = default,
            string? collectionName = default,
            int? dimension = default,
            string? metricType = default,
            string? idType = default,
            string autoID = "false",
            string? primaryFieldName = default,
            string? vectorFieldName = default,
            global::G.CollectionSchema? schema = default,
            global::System.Collections.Generic.IList<global::G.IndexParam>? indexParams = default,
            global::G.CollectionParams? @params = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}