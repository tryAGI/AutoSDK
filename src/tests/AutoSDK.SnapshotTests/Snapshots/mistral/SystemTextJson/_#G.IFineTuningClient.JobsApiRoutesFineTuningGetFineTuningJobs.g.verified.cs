//HintName: G.IFineTuningClient.JobsApiRoutesFineTuningGetFineTuningJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Get Fine Tuning Jobs<br/>
        /// Get a list of fine-tuning jobs for your organization and user.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="model"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdByMe">
        /// Default Value: false
        /// </param>
        /// <param name="status"></param>
        /// <param name="wandbProject"></param>
        /// <param name="wandbName"></param>
        /// <param name="suffix"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.JobsOut> JobsApiRoutesFineTuningGetFineTuningJobsAsync(
            int? page = 0,
            int? pageSize = 100,
            string? model = default,
            global::System.DateTime? createdAfter = default,
            bool? createdByMe = false,
            global::G.JobsApiRoutesFineTuningGetFineTuningJobsStatus? status = default,
            string? wandbProject = default,
            string? wandbName = default,
            string? suffix = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}