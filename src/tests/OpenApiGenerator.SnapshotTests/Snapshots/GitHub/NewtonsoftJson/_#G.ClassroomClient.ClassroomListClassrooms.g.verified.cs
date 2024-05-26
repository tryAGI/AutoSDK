﻿//HintName: G.ClassroomClient.ClassroomListClassrooms.g.cs

#nullable enable

namespace G
{
    public partial class ClassroomClient
    {
        /// <summary>
        /// List classrooms
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ClassroomListClassroomsAsync(
            int page,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/classrooms?page={page}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}