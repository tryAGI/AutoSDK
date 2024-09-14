//HintName: G.OrgsClient.OrgsCreateWebhook.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsCreateWebhookArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.OrgsCreateWebhookRequest request);
        partial void PrepareOrgsCreateWebhookRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.OrgsCreateWebhookRequest request);
        partial void ProcessOrgsCreateWebhookResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsCreateWebhookResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an organization webhook<br/>
        /// Create a hook that posts payloads in JSON format.<br/>
        /// You must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or<br/>
        /// edit webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrgHook> OrgsCreateWebhookAsync(
            string org,
            global::G.OrgsCreateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOrgsCreateWebhookArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/hooks", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsCreateWebhookRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsCreateWebhookResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsCreateWebhookResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.OrgHook?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an organization webhook<br/>
        /// Create a hook that posts payloads in JSON format.<br/>
        /// You must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or<br/>
        /// edit webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// Must be passed as "web".
        /// </param>
        /// <param name="config">
        /// Key/value pairs to provide settings for this webhook.
        /// </param>
        /// <param name="events">
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. Set to `["*"]` to receive all possible events.<br/>
        /// Default Value: [push]
        /// </param>
        /// <param name="active">
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrgHook> OrgsCreateWebhookAsync(
            string org,
            string name,
            global::G.OrgsCreateWebhookRequestConfig config,
            global::System.Collections.Generic.IList<string>? events = default,
            bool active = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrgsCreateWebhookRequest
            {
                Name = name,
                Config = config,
                Events = events,
                Active = active,
            };

            return await OrgsCreateWebhookAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}