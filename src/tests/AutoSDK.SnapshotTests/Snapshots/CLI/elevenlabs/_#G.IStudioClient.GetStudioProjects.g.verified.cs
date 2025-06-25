﻿//HintName: G.IStudioClient.GetStudioProjects.g.cs
#nullable enable

namespace G
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// List Studio Projects<br/>
        /// Returns a list of your Studio projects with metadata.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetProjectsResponseModel> GetStudioProjectsAsync(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}