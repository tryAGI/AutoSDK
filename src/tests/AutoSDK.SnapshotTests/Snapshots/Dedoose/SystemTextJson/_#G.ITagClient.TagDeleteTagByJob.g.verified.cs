//HintName: G.ITagClient.TagDeleteTagByJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// DeleteTagByJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="sortOrder"></param>
        /// <param name="color"></param>
        /// <param name="allowDecimalWeight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TagDeleteTagByJobAsync(
            string? token = default,
            global::System.Guid currentProjectId = default,
            string? projectIdKey = default,
            global::System.Guid projectId = default,
            global::System.Guid id = default,
            global::System.Guid projectIDL = default,
            string? title = default,
            string? description = default,
            bool isWeighted = default,
            double weightMin = default,
            double weightMax = default,
            double weightDefault = default,
            int sortOrder = default,
            int color = default,
            bool allowDecimalWeight = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}