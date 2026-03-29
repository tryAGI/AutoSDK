//HintName: G.IPromptClient.CreatePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultCreatePromptResponseString> CreatePromptAsync(

            global::G.CreatePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="userDefinedId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultCreatePromptResponseString> CreatePromptAsync(
            global::G.RecordStringAny metadata,
            object prompt,
            string userDefinedId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}