//HintName: G.IPersonasClient.DeletePersona.g.cs
#nullable enable

namespace G
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Delete Persona<br/>
        /// Deletes a single persona.
        /// </summary>
        /// <param name="personaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePersonaAsync(
            string personaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}