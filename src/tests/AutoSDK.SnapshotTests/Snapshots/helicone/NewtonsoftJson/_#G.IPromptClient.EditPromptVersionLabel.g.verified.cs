//HintName: G.IPromptClient.EditPromptVersionLabel.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultMetadataRecordStringAnyString> EditPromptVersionLabelAsync(
            string promptVersionId,

            global::G.PromptEditSubversionLabelParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="label"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultMetadataRecordStringAnyString> EditPromptVersionLabelAsync(
            string promptVersionId,
            string label,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}