//HintName: G.ITagClient.TagAddExcerptTagApplication.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// AddExcerptTagApplication.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="tagId"></param>
        /// <param name="weight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagAppDTO> TagAddExcerptTagApplicationAsync(
            string? token = default,
            global::System.Guid userId = default,
            global::System.Guid projectId = default,
            global::System.Guid resourceId = default,
            global::System.Guid excerptId = default,
            global::System.Guid tagId = default,
            double weight = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}