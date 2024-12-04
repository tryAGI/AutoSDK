//HintName: G.IModerationsClient.CreateModeration.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationsClient
    {
        /// <summary>
        /// Classifies if text and/or image inputs are potentially harmful. Learn<br/>
        /// more in the [moderation guide](/docs/guides/moderation).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateModerationResponse> CreateModerationAsync(
            global::G.CreateModerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Classifies if text and/or image inputs are potentially harmful. Learn<br/>
        /// more in the [moderation guide](/docs/guides/moderation).
        /// </summary>
        /// <param name="input">
        /// Input (or inputs) to classify. Can be a single string, an array of strings, or<br/>
        /// an array of multi-modal input objects similar to other models.
        /// </param>
        /// <param name="model">
        /// The content moderation model you would like to use. Learn more in<br/>
        /// [the moderation guide](/docs/guides/moderation), and learn about<br/>
        /// available models [here](/docs/models#moderation).<br/>
        /// Default Value: omni-moderation-latest<br/>
        /// Example: omni-moderation-2024-09-26
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateModerationResponse> CreateModerationAsync(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.InputVariant3Item>> input,
            global::G.AnyOf<string, global::G.CreateModerationRequestModel?>? model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}