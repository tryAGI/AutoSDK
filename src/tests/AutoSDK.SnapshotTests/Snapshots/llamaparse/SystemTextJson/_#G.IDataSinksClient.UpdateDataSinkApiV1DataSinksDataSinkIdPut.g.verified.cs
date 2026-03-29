//HintName: G.IDataSinksClient.UpdateDataSinkApiV1DataSinksDataSinkIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSinksClient
    {
        /// <summary>
        /// Update Data Sink<br/>
        /// Update a data sink by ID.
        /// </summary>
        /// <param name="dataSinkId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSink> UpdateDataSinkApiV1DataSinksDataSinkIdPutAsync(
            global::System.Guid dataSinkId,

            global::G.DataSinkUpdate request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Data Sink<br/>
        /// Update a data sink by ID.
        /// </summary>
        /// <param name="dataSinkId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// The name of the data sink.
        /// </param>
        /// <param name="sinkType"></param>
        /// <param name="component">
        /// Component that implements the data sink
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSink> UpdateDataSinkApiV1DataSinksDataSinkIdPutAsync(
            global::System.Guid dataSinkId,
            global::G.ConfigurableDataSinkNames sinkType,
            string? session = default,
            string? name = default,
            global::G.AnyOf<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore, object>? component = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}