//HintName: G.ITagClient.TagRemoveTagApplication.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// RemoveTagApplication.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="tagAppId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagAppDTO> TagRemoveTagApplicationAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? tagAppId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}