//HintName: G.ITrainingClient.AddTest.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// AddTest<br/>
        /// AddTest
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddTestAsync(
            global::G.AddTestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddTest<br/>
        /// AddTest
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="trainingTestType"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdUserId"></param>
        /// <param name="exIds"></param>
        /// <param name="tagIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddTestAsync(
            global::System.Guid projectId,
            int trainingTestType,
            string title,
            string description,
            global::System.Guid createdUserId,
            global::System.Collections.Generic.IList<string> exIds,
            global::System.Collections.Generic.IList<string> tagIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}