//HintName: G.IFineTuningClient.CreateFineTuning.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Creates a new fine tuning for the already uploaded files This endpoint is in closed beta. [Contact us](https://groq.com/contact) for more information.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReadFineTuningResponse> CreateFineTuningAsync(

            global::G.CreateFineTuningRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new fine tuning for the already uploaded files This endpoint is in closed beta. [Contact us](https://groq.com/contact) for more information.
        /// </summary>
        /// <param name="baseModel">
        /// BaseModel is the model that the fine tune was originally trained on.
        /// </param>
        /// <param name="inputFileId">
        /// InputFileID is the id of the file that was uploaded via the /files api.
        /// </param>
        /// <param name="name">
        /// Name is the given name to a fine tuned model.
        /// </param>
        /// <param name="type">
        /// Type is the type of fine tuning format such as "lora".
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReadFineTuningResponse> CreateFineTuningAsync(
            string? baseModel = default,
            string? inputFileId = default,
            string? name = default,
            string? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}