//HintName: G.IChatClient.ListChatCompletions.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// List stored Chat Completions. Only Chat Completions that have been stored<br/>
        /// with the `store` parameter set to `true` will be returned.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionList> ListChatCompletionsAsync(
            string? model = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? after = default,
            int? limit = default,
            global::G.ListChatCompletionsOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}