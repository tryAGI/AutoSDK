//HintName: G.IModelsClient.RetrieveModelV1ModelsModelIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Retrieve Model<br/>
        /// Retrieve a model information.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetrieveModelV1ModelsModelIdGetResponse> RetrieveModelV1ModelsModelIdGetAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}