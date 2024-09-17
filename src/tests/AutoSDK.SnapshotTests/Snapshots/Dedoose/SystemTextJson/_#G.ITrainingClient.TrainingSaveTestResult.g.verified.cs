//HintName: G.ITrainingClient.TrainingSaveTestResult.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// SaveTestResult.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="traineeUserId"></param>
        /// <param name="testId"></param>
        /// <param name="overallRating"></param>
        /// <param name="traineeTagApps"></param>
        /// <param name="completed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainingTestResult> TrainingSaveTestResultAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? traineeUserId = default,
            global::System.Guid? testId = default,
            double? overallRating = default,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>? traineeTagApps = default,
            bool? completed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}