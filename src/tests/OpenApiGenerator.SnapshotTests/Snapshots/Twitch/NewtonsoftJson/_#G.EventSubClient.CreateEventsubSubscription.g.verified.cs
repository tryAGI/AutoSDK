//HintName: G.EventSubClient.CreateEventsubSubscription.g.cs

#nullable enable

namespace G
{
    public partial class EventSubClient
    {
        /// <summary>
        /// Creates an EventSub subscription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreateEventSubSubscriptionResponse> CreateEventsubSubscriptionAsync(
            CreateEventSubSubscriptionBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/eventsub/subscriptions", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<CreateEventSubSubscriptionResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates an EventSub subscription.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="version"></param>
        /// <param name="condition"></param>
        /// <param name="transport"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreateEventSubSubscriptionResponse> CreateEventsubSubscriptionAsync(
            CreateEventSubSubscriptionBodyType type,
            string version,
            object condition,
            CreateEventSubSubscriptionBodyTransport transport,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateEventSubSubscriptionBody
            {
                Type = type,
                Version = version,
                Condition = condition,
                Transport = transport,
            };

            return await CreateEventsubSubscriptionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}