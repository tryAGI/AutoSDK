//HintName: G.IRestClient.PublishPromptTemplateRestPromptTemplatesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IRestClient
    {
        /// <summary>
        /// Publish Prompt Template
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptTemplateResponse> PublishPromptTemplateRestPromptTemplatesPostAsync(

            global::G.CreatePromptTemplate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish Prompt Template
        /// </summary>
        /// <param name="promptTemplate"></param>
        /// <param name="promptVersion"></param>
        /// <param name="releaseLabels"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptTemplateResponse> PublishPromptTemplateRestPromptTemplatesPostAsync(
            global::G.BasePromptTemplate promptTemplate,
            global::G.PromptVersion promptVersion,
            global::System.Collections.Generic.IList<string>? releaseLabels = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}