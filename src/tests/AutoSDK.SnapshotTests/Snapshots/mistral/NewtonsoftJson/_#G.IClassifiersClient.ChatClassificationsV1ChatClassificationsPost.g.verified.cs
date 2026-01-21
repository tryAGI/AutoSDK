//HintName: G.IClassifiersClient.ChatClassificationsV1ChatClassificationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IClassifiersClient
    {
        /// <summary>
        /// Chat Classifications
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassificationResponse> ChatClassificationsV1ChatClassificationsPostAsync(
            global::G.ChatClassificationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Chat Classifications
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input">
        /// Chat to classify
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassificationResponse> ChatClassificationsV1ChatClassificationsPostAsync(
            string model,
            global::G.ChatClassificationRequestInputs input,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}