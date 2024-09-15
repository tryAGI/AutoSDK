//HintName: G.IApi.CancelTrainings.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Cancel a training
        /// </summary>
        /// <param name="trainingId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CancelTrainingsAsync(
            string trainingId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}