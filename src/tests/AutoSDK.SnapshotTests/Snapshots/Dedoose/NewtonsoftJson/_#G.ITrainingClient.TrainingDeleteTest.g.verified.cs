//HintName: G.ITrainingClient.TrainingDeleteTest.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// DeleteTest.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="testType"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdOn"></param>
        /// <param name="projectId"></param>
        /// <param name="excerptCount"></param>
        /// <param name="tagCount"></param>
        /// <param name="creator"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainingTest> TrainingDeleteTestAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? id = default,
            int? testType = default,
            string? title = default,
            string? description = default,
            global::System.DateTime? createdOn = default,
            global::System.Guid? projectId = default,
            int? excerptCount = default,
            int? tagCount = default,
            global::System.Guid? creator = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}