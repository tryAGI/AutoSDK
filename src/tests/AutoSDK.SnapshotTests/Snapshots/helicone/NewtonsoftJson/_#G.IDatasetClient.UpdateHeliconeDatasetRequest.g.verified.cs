//HintName: G.IDatasetClient.UpdateHeliconeDatasetRequest.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ResultErrorUnknown, global::G.ResultSuccessAny>> UpdateHeliconeDatasetRequestAsync(
            string datasetId,
            string requestId,

            global::G.UpdateHeliconeDatasetRequestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="requestId"></param>
        /// <param name="responseBody"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ResultErrorUnknown, global::G.ResultSuccessAny>> UpdateHeliconeDatasetRequestAsync(
            string datasetId,
            string requestId,
            global::G.Json? responseBody = default,
            global::G.Json? requestBody = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}