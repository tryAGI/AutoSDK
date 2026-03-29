//HintName: G.IConfigsClient.CreateConfigVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Create a config version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnConfig> CreateConfigVersionAsync(
            string id,

            global::G.PostedConfigVersion request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a config version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionDescription"></param>
        /// <param name="eviVersion"></param>
        /// <param name="prompt"></param>
        /// <param name="voice"></param>
        /// <param name="languageModel"></param>
        /// <param name="ellmModel"></param>
        /// <param name="tools"></param>
        /// <param name="builtinTools"></param>
        /// <param name="eventMessages"></param>
        /// <param name="timeouts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnConfig> CreateConfigVersionAsync(
            string id,
            string? versionDescription = default,
            string? eviVersion = default,
            global::G.PostedConfigPromptSpec? prompt = default,
            global::G.PostedUtteranceVoice? voice = default,
            global::G.PostedLanguageModel? languageModel = default,
            global::G.PostedEllmModel? ellmModel = default,
            global::System.Collections.Generic.IList<global::G.PostedUserDefinedToolSpec>? tools = default,
            global::System.Collections.Generic.IList<global::G.PostedBuiltinTool>? builtinTools = default,
            global::G.PostedEventMessageSpecs? eventMessages = default,
            global::G.PostedTimeoutSpecs? timeouts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}