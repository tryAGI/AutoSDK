//HintName: G.IFinetuningClient.ListEvents.g.cs
#nullable enable

namespace G
{
    public partial interface IFinetuningClient
    {
        /// <summary>
        /// Retrieves the chronology of statuses the fine-tuned model has been through.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="orderBy"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListEventsResponse> ListEventsAsync(
            string finetunedModelId,
            int? pageSize = default,
            string? pageToken = default,
            string? orderBy = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}