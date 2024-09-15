//HintName: G.IPipelinesClient.Patch.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Patch<br/>
        /// Update selected fields on a pipeline
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDetailedPatch> PatchAsync(
            string pipelineId,
            global::G.Patch request,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Patch<br/>
        /// Update selected fields on a pipeline
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="public"></param>
        /// <param name="description"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="paperUrl"></param>
        /// <param name="licenseUrl"></param>
        /// <param name="imageUrl"></param>
        /// <param name="readme"></param>
        /// <param name="inputVariables"></param>
        /// <param name="outputVariables"></param>
        /// <param name="accelerators"></param>
        /// <param name="extras"></param>
        /// <param name="scalingConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDetailedPatch> PatchAsync(
            string pipelineId,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            bool @public = default,
            string? description = default,
            string? websiteUrl = default,
            string? repositoryUrl = default,
            string? paperUrl = default,
            string? licenseUrl = default,
            string? imageUrl = default,
            string? readme = default,
            global::System.Collections.Generic.IList<global::G.IOVariable>? inputVariables = default,
            global::System.Collections.Generic.IList<global::G.IOVariable>? outputVariables = default,
            global::System.Collections.Generic.IList<global::G.Accelerator>? accelerators = default,
            global::G.PatchExtras? extras = default,
            string? scalingConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}