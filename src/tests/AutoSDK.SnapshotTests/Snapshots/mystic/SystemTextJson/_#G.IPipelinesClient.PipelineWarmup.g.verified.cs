﻿//HintName: G.IPipelinesClient.PipelineWarmup.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Pipeline Warmup
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PipelineWarmupAsync(
            string pipelineIdOrPointer,
            global::G.PipelineWarmup request,
            string? pipelineId = default,
            string? pointer = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Pipeline Warmup
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="minimumNodes"></param>
        /// <param name="duration">
        /// Default Value: 300
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PipelineWarmupAsync(
            string pipelineIdOrPointer,
            int minimumNodes,
            string? pipelineId = default,
            string? pointer = default,
            int? duration = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}