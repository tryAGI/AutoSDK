//HintName: G.ITablesClient.TableCreateTableCreatePost.g.cs
#nullable enable

namespace G
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Table Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TableCreateRes> TableCreateTableCreatePostAsync(

            global::G.TableCreateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Table Create
        /// </summary>
        /// <param name="table"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TableCreateRes> TableCreateTableCreatePostAsync(
            global::G.TableSchemaForInsert table,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}