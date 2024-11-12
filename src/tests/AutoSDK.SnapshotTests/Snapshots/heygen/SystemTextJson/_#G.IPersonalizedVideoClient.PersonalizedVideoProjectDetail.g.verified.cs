//HintName: G.IPersonalizedVideoClient.PersonalizedVideoProjectDetail.g.cs
#nullable enable

namespace G
{
    public partial interface IPersonalizedVideoClient
    {
        /// <summary>
        /// personalized_video/project/detail<br/>
        /// personalized_video/project/detail
        /// </summary>
        /// <param name="id">
        /// Example: &lt;project-id&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PersonalizedVideoProjectDetailAsync(
            string? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}