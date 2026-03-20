//HintName: G.IApi.OpenaiImagesVariationsV1OpenaiImagesVariationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Openai Images Variations<br/>
        /// Generate a similar image using OpenAI Images Variations API
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAIImagesOut> OpenaiImagesVariationsV1OpenaiImagesVariationsPostAsync(
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}