//HintName: G.IVariablesClient.DeleteVariable.g.cs
#nullable enable

namespace G
{
    public partial interface IVariablesClient
    {
        /// <summary>
        /// Delete a variable by ID<br/>
        /// Delete a specific variable by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVariableAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}