//HintName: G.IPersonalizedVideoClient.PersonalizedVideoAudienceDetail.g.cs
#nullable enable

namespace G
{
    public partial interface IPersonalizedVideoClient
    {
        /// <summary>
        /// personalized_video/audience/detail<br/>
        /// personalized_video/audience/detail
        /// </summary>
        /// <param name="id">
        /// Example: &lt;video-id&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PersonalizedVideoAudienceDetailAsync(
            string? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}