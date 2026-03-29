//HintName: G.IUtilityClient.DeleteFinetuneV1DeleteFinetunePost.g.cs
#nullable enable

namespace G
{
    public partial interface IUtilityClient
    {
        /// <summary>
        /// Delete Finetune<br/>
        /// Delete a finetune_id that was created by the user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteFinetuneResponse> DeleteFinetuneV1DeleteFinetunePostAsync(

            global::G.DeleteFinetuneInputs request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Finetune<br/>
        /// Delete a finetune_id that was created by the user
        /// </summary>
        /// <param name="finetuneId">
        /// ID of the fine-tuned model you want to delete.<br/>
        /// Example: my-finetune
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteFinetuneResponse> DeleteFinetuneV1DeleteFinetunePostAsync(
            string finetuneId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}