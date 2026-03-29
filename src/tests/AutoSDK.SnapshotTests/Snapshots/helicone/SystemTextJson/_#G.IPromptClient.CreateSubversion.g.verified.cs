//HintName: G.IPromptClient.CreateSubversion.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionResultString> CreateSubversionAsync(
            string promptVersionId,

            global::G.PromptCreateSubversionParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="newHeliconeTemplate"></param>
        /// <param name="isMajorVersion"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="experimentId"></param>
        /// <param name="bumpForMajorPromptVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionResultString> CreateSubversionAsync(
            string promptVersionId,
            object newHeliconeTemplate,
            bool? isMajorVersion = default,
            global::G.RecordStringAny? metadata = default,
            string? experimentId = default,
            string? bumpForMajorPromptVersionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}