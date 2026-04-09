//HintName: G.IApi.CreateTask.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// create a task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SuccessTask> CreateTaskAsync(

            global::G.OneOf<global::G.CreateTaskRequestVariant1, global::G.CreateTaskRequestVariant2, global::G.CreateTaskRequestVariant3, global::G.CreateTaskRequestVariant4, global::G.CreateTaskRequestVariant5, global::G.CreateTaskRequestVariant6, global::G.CreateTaskRequestVariant7, global::G.CreateTaskRequestVariant8, global::G.CreateTaskRequestVariant9> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// create a task
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SuccessTask> CreateTaskAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}