//HintName: G.IPropertyClient.HideProperty.g.cs
#nullable enable

namespace G
{
    public partial interface IPropertyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ResultErrorString, global::G.ResultSuccessString, global::G.ResultSuccessUnknownArray, global::G.HidePropertyResponse2>> HidePropertyAsync(

            global::G.HidePropertyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ResultErrorString, global::G.ResultSuccessString, global::G.ResultSuccessUnknownArray, global::G.HidePropertyResponse2>> HidePropertyAsync(
            string key,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}