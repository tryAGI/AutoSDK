//HintName: G.IStructuredOutputsClient.StructuredOutputControllerRun.g.cs
#nullable enable

namespace G
{
    public partial interface IStructuredOutputsClient
    {
        /// <summary>
        /// Run Structured Output
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StructuredOutput> StructuredOutputControllerRunAsync(

            global::G.StructuredOutputRunDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Structured Output
        /// </summary>
        /// <param name="previewEnabled">
        /// This is the preview flag for the re-run. If true, the re-run will be executed and the response will be returned immediately and the call artifact will NOT be updated.<br/>
        /// If false (default), the re-run will be executed and the response will be updated in the call artifact.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="structuredOutputId">
        /// This is the ID of the structured output that will be run. This must be provided unless a transient structured output is provided.<br/>
        /// When the re-run is executed, only the value of this structured output will be replaced with the new value, or added if not present.
        /// </param>
        /// <param name="structuredOutput">
        /// This is the transient structured output that will be run. This must be provided if a structured output ID is not provided.<br/>
        /// When the re-run is executed, the structured output value will be added to the existing artifact.
        /// </param>
        /// <param name="callIds">
        /// This is the array of callIds that will be updated with the new structured output value. If preview is true, this array must be provided and contain exactly 1 callId.<br/>
        /// If preview is false, up to 100 callIds may be provided.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StructuredOutput> StructuredOutputControllerRunAsync(
            global::System.Collections.Generic.IList<string> callIds,
            bool? previewEnabled = default,
            string? structuredOutputId = default,
            global::G.CreateStructuredOutputDTO? structuredOutput = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}