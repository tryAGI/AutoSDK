//HintName: G.IPipelinesClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve details for a pipeline.<br/>
        /// Note that the fields this endpoint returns are dependent on the provided<br/>
        /// query parameters and will omit any empty fields.<br/>
        /// Accepted query parameters are:<br/>
        /// - include_pointers: include any pointers that point to this pipeline
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="includePointers">
        /// Default Value: false
        /// </param>
        /// <param name="includeExtras">
        /// Default Value: false
        /// </param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppSchemasPipelineGetDetailed> RetrieveAsync(
            string pipelineId,
            bool? includePointers = default,
            bool? includeExtras = default,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}