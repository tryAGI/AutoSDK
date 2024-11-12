//HintName: G.IMemoClient.MemoStartExportMemosXML.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// StartExportMemosXML.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoIds"></param>
        /// <param name="codeSelection"></param>
        /// <param name="mediaSelection"></param>
        /// <param name="excerptsSelection"></param>
        /// <param name="descriptorsSelection"></param>
        /// <param name="symKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MemoStartExportMemosXMLAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? memoIds = default,
            int? codeSelection = default,
            int? mediaSelection = default,
            int? excerptsSelection = default,
            int? descriptorsSelection = default,
            string? symKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}