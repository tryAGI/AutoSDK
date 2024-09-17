//HintName: G.IFinetuningClient.CreateFinetunedModel.g.cs
#nullable enable

namespace G
{
    public partial interface IFinetuningClient
    {
        /// <summary>
        /// Trains and deploys a fine-tuned model.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFinetunedModelResponse> CreateFinetunedModelAsync(
            global::G.FinetunedModel request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trains and deploys a fine-tuned model.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="id">
        /// read-only. FinetunedModel ID.
        /// </param>
        /// <param name="name">
        /// FinetunedModel name (e.g. `foobar`).
        /// </param>
        /// <param name="creatorId">
        /// read-only. User ID of the creator.
        /// </param>
        /// <param name="organizationId">
        /// read-only. Organization ID.
        /// </param>
        /// <param name="settings">
        /// The configuration used for fine-tuning.
        /// </param>
        /// <param name="status">
        /// The possible stages of a fine-tuned model life-cycle.<br/>
        ///  - STATUS_UNSPECIFIED: Unspecified status.<br/>
        ///  - STATUS_FINETUNING: The fine-tuned model is being fine-tuned.<br/>
        ///  - STATUS_DEPLOYING_API: The fine-tuned model is being deployed.<br/>
        ///  - STATUS_READY: The fine-tuned model is ready to receive requests.<br/>
        ///  - STATUS_FAILED: The fine-tuned model failed.<br/>
        ///  - STATUS_DELETED: The fine-tuned model was deleted.<br/>
        ///  - STATUS_TEMPORARILY_OFFLINE: The fine-tuned model is temporarily unavailable.<br/>
        ///  - STATUS_PAUSED: The fine-tuned model is paused (Vanilla only).<br/>
        ///  - STATUS_QUEUED: The fine-tuned model is queued for training.<br/>
        /// Default Value: STATUS_UNSPECIFIED
        /// </param>
        /// <param name="createdAt">
        /// read-only. Creation timestamp.
        /// </param>
        /// <param name="updatedAt">
        /// read-only. Latest update timestamp.
        /// </param>
        /// <param name="completedAt">
        /// read-only. Timestamp for the completed fine-tuning.
        /// </param>
        /// <param name="lastUsed">
        /// read-only. Timestamp for the latest request to this fine-tuned model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFinetunedModelResponse> CreateFinetunedModelAsync(
            string name,
            global::G.Settings settings,
            string? xClientName = default,
            string? id = default,
            string? creatorId = default,
            string? organizationId = default,
            global::G.Status? status = global::G.Status.STATUSUNSPECIFIED,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? updatedAt = default,
            global::System.DateTime? completedAt = default,
            global::System.DateTime? lastUsed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}