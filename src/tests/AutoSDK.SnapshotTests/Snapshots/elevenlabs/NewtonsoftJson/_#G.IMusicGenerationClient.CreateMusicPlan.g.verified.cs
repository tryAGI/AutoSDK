//HintName: G.IMusicGenerationClient.CreateMusicPlan.g.cs
#nullable enable

namespace G
{
    public partial interface IMusicGenerationClient
    {
        /// <summary>
        /// Generate Composition Plan<br/>
        /// Generate a composition plan from a prompt.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MusicPrompt> CreateMusicPlanAsync(

            global::G.BodyGenerateCompositionPlanV1MusicPlanPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Composition Plan<br/>
        /// Generate a composition plan from a prompt.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="prompt">
        /// A simple text prompt to compose a plan from.
        /// </param>
        /// <param name="musicLengthMs">
        /// The length of the composition plan to generate in milliseconds. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </param>
        /// <param name="sourceCompositionPlan">
        /// An optional composition plan to use as a source for the new composition plan.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MusicPrompt> CreateMusicPlanAsync(
            string prompt,
            string? xiApiKey = default,
            int? musicLengthMs = default,
            global::G.MusicPrompt? sourceCompositionPlan = default,
            global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelId? modelId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}