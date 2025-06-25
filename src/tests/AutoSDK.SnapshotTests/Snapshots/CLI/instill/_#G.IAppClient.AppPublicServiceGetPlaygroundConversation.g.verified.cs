﻿//HintName: G.IAppClient.AppPublicServiceGetPlaygroundConversation.g.cs
#nullable enable

namespace G
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Get Playground Conversation<br/>
        /// Returns the latest conversation of auth user(e.g. login user and api key user).
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPlaygroundConversationResponse> AppPublicServiceGetPlaygroundConversationAsync(
            string namespaceId,
            string appId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}