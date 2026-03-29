//HintName: G.ITablesClient.TableCreateFromDigestsTableCreateFromDigestsPost.g.cs
#nullable enable

namespace G
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Table Create From Digests
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TableCreateFromDigestsRes> TableCreateFromDigestsTableCreateFromDigestsPostAsync(

            global::G.TableCreateFromDigestsReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Table Create From Digests
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rowDigests"></param>
        /// <param name="expectedDigest">
        /// Client-computed table digest for server-side validation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TableCreateFromDigestsRes> TableCreateFromDigestsTableCreateFromDigestsPostAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> rowDigests,
            string? expectedDigest = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}