//HintName: G.IPersonasClient.PatchPersona.g.cs
#nullable enable

namespace G
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Patch Persona<br/>
        /// Updates a persona using JSON Patch (RFC 6902).
        /// </summary>
        /// <param name="personaId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Persona> PatchPersonaAsync(
            string personaId,

            global::System.Collections.Generic.IList<global::G.JsonPatchOperation> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}