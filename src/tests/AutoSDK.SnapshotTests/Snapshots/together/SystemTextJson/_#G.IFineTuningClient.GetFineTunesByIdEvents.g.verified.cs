//HintName: G.IFineTuningClient.GetFineTunesByIdEvents.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List job events<br/>
        /// List the events for a single fine-tuning job.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FinetuneListEvents> GetFineTunesByIdEventsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}