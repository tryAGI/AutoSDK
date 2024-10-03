//HintName: G.IModelsClient.JobsApiRoutesFineTuningArchiveFineTunedModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Archive Fine Tuned Model<br/>
        /// Archive a fine-tuned model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ArchiveFTModelOut> JobsApiRoutesFineTuningArchiveFineTunedModelAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}