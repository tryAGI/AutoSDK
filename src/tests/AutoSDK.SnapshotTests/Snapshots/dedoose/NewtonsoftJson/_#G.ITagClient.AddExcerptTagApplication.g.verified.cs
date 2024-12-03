//HintName: G.ITagClient.AddExcerptTagApplication.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// AddExcerptTagApplication<br/>
        /// AddExcerptTagApplication
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagAppDTO> AddExcerptTagApplicationAsync(
            global::G.AddExcerptTagApplicationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddExcerptTagApplication<br/>
        /// AddExcerptTagApplication
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="tagId"></param>
        /// <param name="weight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagAppDTO> AddExcerptTagApplicationAsync(
            global::System.Guid userId,
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Guid excerptId,
            global::System.Guid tagId,
            double? weight,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}