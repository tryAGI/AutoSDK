//HintName: G.IMlClient.Train.g.cs
#nullable enable

namespace G
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Train<br/>
        ///         After you add an ML backend, call this API with the ML backend ID to start training with <br/>
        ///         already-labeled tasks. <br/>
        ///         <br/>
        ///         Get the ML backend ID by [listing the ML backends for a project](https://labelstud.io/api/#operation/api_ml_list).<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task TrainAsync(
            int id,

            global::G.ApiMlTrainCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train<br/>
        ///         After you add an ML backend, call this API with the ML backend ID to start training with <br/>
        ///         already-labeled tasks. <br/>
        ///         <br/>
        ///         Get the ML backend ID by [listing the ML backends for a project](https://labelstud.io/api/#operation/api_ml_list).<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="useGroundTruth">
        /// Whether to include ground truth annotations in training
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task TrainAsync(
            int id,
            bool? useGroundTruth = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}