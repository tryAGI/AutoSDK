//HintName: G.Api.EndPoints.GenerateCompletion.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Generate a response for a given prompt with a provided model.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<GenerateCompletionResponse> GenerateCompletionAsync(
            GenerateCompletionRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/generate");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            using var reader = new global::System.IO.StreamReader(stream);

            while (!reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {
                var content = await reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                var streamedResponse = global::System.Text.Json.JsonSerializer.Deserialize<GenerateCompletionResponse>(content) ??
                                       throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");

                yield return streamedResponse;
            }
        }

        /// <summary>
        /// Generate a response for a given prompt with a provided model.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="images"></param>
        /// <param name="system"></param>
        /// <param name="template"></param>
        /// <param name="context"></param>
        /// <param name="options"></param>
        /// <param name="format"></param>
        /// <param name="raw"></param>
        /// <param name="stream"></param>
        /// <param name="keepAlive"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<GenerateCompletionResponse> GenerateCompletionAsync(
            string model,
            string prompt,
            global::System.Collections.Generic.IList<string?>? images,
            string? system,
            string? template,
            global::System.Collections.Generic.IList<int>? context,
            RequestOptions? options,
            string? format,
            bool raw,
            bool stream,
            int keepAlive,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new GenerateCompletionRequest
            {
                Model = model,
                Prompt = prompt,
                Images = images,
                System = system,
                Template = template,
                Context = context,
                Options = options,
                Format = format,
                Raw = raw,
                Stream = stream,
                KeepAlive = keepAlive,
            };

            var enumerable = GenerateCompletionAsync(request, cancellationToken);
            await foreach (var response in enumerable)
            {
                yield return response;
            }
        }
    }
}