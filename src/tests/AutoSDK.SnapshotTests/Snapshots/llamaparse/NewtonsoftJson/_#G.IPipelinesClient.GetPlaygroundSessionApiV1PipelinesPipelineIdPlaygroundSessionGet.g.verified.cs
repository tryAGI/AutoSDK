//HintName: G.IPipelinesClient.GetPlaygroundSessionApiV1PipelinesPipelineIdPlaygroundSessionGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Get Playground Session<br/>
        /// Get a playground session for a user and pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PlaygroundSession> GetPlaygroundSessionApiV1PipelinesPipelineIdPlaygroundSessionGetAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}