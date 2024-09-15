//HintName: G.ITrainingClient.TrainingAddTest.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// AddTest.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="trainingTestType"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdUserId"></param>
        /// <param name="exIds"></param>
        /// <param name="tagIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TrainingAddTestAsync(
            string? token = default,
            global::System.Guid projectId = default,
            int trainingTestType = default,
            string? title = default,
            string? description = default,
            global::System.Guid createdUserId = default,
            global::System.Collections.Generic.IList<string>? exIds = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}