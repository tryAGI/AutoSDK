//HintName: G.IFinetuneClient.CreateFineTuningJob.g.cs
#nullable enable

namespace G
{
    public partial interface IFinetuneClient
    {
        /// <summary>
        /// Create a Finetune Job<br/>
        /// Finetune a provider model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FineTuningJob> CreateFineTuningJobAsync(

            global::G.AnyOf<global::G.OpenAIFinetuneJob, global::G.BedrockFinetuneJob, global::G.PortkeyFinetuneJob> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Finetune Job<br/>
        /// Finetune a provider model
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FineTuningJob> CreateFineTuningJobAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}