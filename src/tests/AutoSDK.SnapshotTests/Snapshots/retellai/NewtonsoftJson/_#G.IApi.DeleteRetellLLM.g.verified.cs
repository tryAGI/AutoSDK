//HintName: G.IApi.DeleteRetellLLM.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete an existing Retell LLM Response Engine
        /// </summary>
        /// <param name="llmId">
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteRetellLLMAsync(
            string llmId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}