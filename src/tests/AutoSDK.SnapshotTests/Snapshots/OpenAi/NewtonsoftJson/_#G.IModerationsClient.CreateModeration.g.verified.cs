//HintName: G.IModerationsClient.CreateModeration.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationsClient
    {
        /// <summary>
        /// Classifies if text is potentially harmful.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateModerationResponse> CreateModerationAsync(
            global::G.CreateModerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Classifies if text is potentially harmful.
        /// </summary>
        /// <param name="input">
        /// The input text to classify
        /// </param>
        /// <param name="model">
        /// Two content moderations models are available: `text-moderation-stable` and `text-moderation-latest`.<br/>
        /// The default is `text-moderation-latest` which will be automatically upgraded over time. This ensures you are always using our most accurate model. If you use `text-moderation-stable`, we will provide advanced notice before updating the model. Accuracy of `text-moderation-stable` may be slightly lower than for `text-moderation-latest`.<br/>
        /// Default Value: text-moderation-latest<br/>
        /// Example: text-moderation-stable
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateModerationResponse> CreateModerationAsync(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::G.AnyOf<string, global::G.CreateModerationRequestModel?>? model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}