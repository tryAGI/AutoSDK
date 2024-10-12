//HintName: G.IMemoClient.MemoUnlinkObject.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// UnlinkObject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="tagId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MemoUnlinkObjectAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? memoId = default,
            global::System.Guid? resourceId = default,
            global::System.Guid? excerptId = default,
            global::System.Guid? descriptorId = default,
            global::System.Guid? tagId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}