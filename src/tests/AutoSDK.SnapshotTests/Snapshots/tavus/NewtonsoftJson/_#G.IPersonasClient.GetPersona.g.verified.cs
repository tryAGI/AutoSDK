//HintName: G.IPersonasClient.GetPersona.g.cs
#nullable enable

namespace G
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Get Persona<br/>
        /// Returns a single persona.
        /// </summary>
        /// <param name="personaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Persona> GetPersonaAsync(
            string personaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}