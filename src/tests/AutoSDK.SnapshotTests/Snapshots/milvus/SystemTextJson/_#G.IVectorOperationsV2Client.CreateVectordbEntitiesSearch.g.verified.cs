//HintName: G.IVectorOperationsV2Client.CreateVectordbEntitiesSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorOperationsV2Client
    {
        /// <summary>
        /// Search<br/>
        /// This operation conducts a vector similarity search with an optional scalar filtering expression.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVectordbEntitiesSearchResponse> CreateVectordbEntitiesSearchAsync(

            global::G.CreateVectordbEntitiesSearchRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search<br/>
        /// This operation conducts a vector similarity search with an optional scalar filtering expression.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database.
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection to which this operation applies.
        /// </param>
        /// <param name="vector">
        /// A list of vector embeddings.<br/>
        /// &lt;include target="milvus"&gt;Milvus&lt;/include&gt;&lt;include target="zilliz"&gt;Zilliz Cloud&lt;/include&gt; searches for the most similar vector embeddings to the specified ones.
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
        /// <param name="searchParams"></param>
        /// <param name="partitionNames">
        /// The name of the partitions to which this operation applies.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVectordbEntitiesSearchResponse> CreateVectordbEntitiesSearchAsync(
            string collectionName,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.AnyOf<int?, string>>> vector,
            global::G.SearchParams searchParams,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            string? annsField = default,
            string? filter = default,
            int? limit = default,
            int? offset = default,
            string? groupingField = default,
            global::System.Collections.Generic.IList<string>? outputFields = default,
            global::System.Collections.Generic.IList<string>? partitionNames = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}