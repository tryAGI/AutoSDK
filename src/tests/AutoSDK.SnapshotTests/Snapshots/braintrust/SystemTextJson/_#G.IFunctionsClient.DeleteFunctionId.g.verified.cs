//HintName: G.IFunctionsClient.DeleteFunctionId.g.cs
#nullable enable

namespace G
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Delete function<br/>
        /// Delete a function object by its id
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Function2> DeleteFunctionIdAsync(
            global::System.Guid functionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}