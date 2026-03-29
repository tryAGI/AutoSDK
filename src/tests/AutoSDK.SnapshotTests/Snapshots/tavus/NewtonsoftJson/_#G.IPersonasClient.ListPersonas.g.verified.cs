//HintName: G.IPersonasClient.ListPersonas.g.cs
#nullable enable

namespace G
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// List Personas<br/>
        /// Returns a list of all personas.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPersonasResponse> ListPersonasAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}