//HintName: G.IClassifiersClient.ClassificationsV1ClassificationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IClassifiersClient
    {
        /// <summary>
        /// Classifications
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassificationResponse> ClassificationsV1ClassificationsPostAsync(
            global::G.ClassificationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Classifications
        /// </summary>
        /// <param name="input">
        /// Text to classify.
        /// </param>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassificationResponse> ClassificationsV1ClassificationsPostAsync(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}