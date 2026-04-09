//HintName: G.IPersonasClient.CreatePersona.g.cs
#nullable enable

namespace G
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Create Persona<br/>
        /// Create and customize a persona's behavior and capabilities for CVI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Persona> CreatePersonaAsync(

            global::G.CreatePersonaRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Persona<br/>
        /// Create and customize a persona's behavior and capabilities for CVI.
        /// </summary>
        /// <param name="personaName"></param>
        /// <param name="systemPrompt">
        /// System prompt defining persona behavior. Required for full pipeline mode.
        /// </param>
        /// <param name="context"></param>
        /// <param name="defaultReplicaId"></param>
        /// <param name="pipelineMode"></param>
        /// <param name="layers"></param>
        /// <param name="guardrailsId"></param>
        /// <param name="objectivesId"></param>
        /// <param name="documentIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Persona> CreatePersonaAsync(
            string? personaName = default,
            string? systemPrompt = default,
            string? context = default,
            string? defaultReplicaId = default,
            global::G.CreatePersonaRequestPipelineMode? pipelineMode = default,
            global::G.PersonaLayers? layers = default,
            string? guardrailsId = default,
            string? objectivesId = default,
            global::System.Collections.Generic.IList<string>? documentIds = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}