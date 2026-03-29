//HintName: G.IVariablesClient.GetAllVariables.g.cs
#nullable enable

namespace G
{
    public partial interface IVariablesClient
    {
        /// <summary>
        /// List all variables<br/>
        /// Retrieve a list of all variables
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Variable>> GetAllVariablesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}