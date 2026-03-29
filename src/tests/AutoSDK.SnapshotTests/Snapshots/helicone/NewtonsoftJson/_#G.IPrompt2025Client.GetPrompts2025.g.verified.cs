//HintName: G.IPrompt2025Client.GetPrompts2025.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025ArrayString> GetPrompts2025Async(

            global::G.GetPrompts2025Request request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="tagsFilter"></param>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025ArrayString> GetPrompts2025Async(
            double pageSize,
            double page,
            global::System.Collections.Generic.IList<string> tagsFilter,
            string search,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}