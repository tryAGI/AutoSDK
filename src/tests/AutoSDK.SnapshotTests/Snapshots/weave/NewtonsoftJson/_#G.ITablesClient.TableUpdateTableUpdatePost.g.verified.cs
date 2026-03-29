//HintName: G.ITablesClient.TableUpdateTableUpdatePost.g.cs
#nullable enable

namespace G
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Table Update
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TableUpdateRes> TableUpdateTableUpdatePostAsync(

            global::G.TableUpdateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Table Update
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="baseDigest"></param>
        /// <param name="updates"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TableUpdateRes> TableUpdateTableUpdatePostAsync(
            string projectId,
            string baseDigest,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TableAppendSpec, global::G.TablePopSpec, global::G.TableInsertSpec>> updates,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}