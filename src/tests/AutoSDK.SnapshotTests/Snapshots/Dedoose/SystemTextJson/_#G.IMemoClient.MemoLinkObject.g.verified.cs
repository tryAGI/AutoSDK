//HintName: G.IMemoClient.MemoLinkObject.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// LinkObject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="id1"></param>
        /// <param name="position1"></param>
        /// <param name="id2"></param>
        /// <param name="position2"></param>
        /// <param name="id3"></param>
        /// <param name="position3"></param>
        /// <param name="id4"></param>
        /// <param name="position4"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MemoLinkObjectAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? memoId = default,
            global::System.Guid? id1 = default,
            int? position1 = default,
            global::System.Guid? id2 = default,
            int? position2 = default,
            global::System.Guid? id3 = default,
            int? position3 = default,
            global::System.Guid? id4 = default,
            int? position4 = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}