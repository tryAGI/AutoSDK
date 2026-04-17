//HintName: G.DeepgramInlinePayloadsListenV1RealtimeClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Speech-to-text streaming channel.
    /// </summary>
    public sealed partial class DeepgramInlinePayloadsListenV1RealtimeClient : global::System.IDisposable, global::System.IAsyncDisposable
    {
        /// <summary>
        /// Default WebSocket base URL.
        /// </summary>
        public const string DefaultBaseUrl = "wss://api.deepgram.com/v1/listen";

        private readonly global::System.Net.WebSockets.ClientWebSocket _clientWebSocket;

        /// <summary>
        /// 
        /// </summary>

        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions();

        /// <summary>
        /// Gets a value indicating whether the WebSocket connection is open.
        /// </summary>
        public bool IsConnected => _clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open;

        /// <summary>
        /// Creates a new instance of the DeepgramInlinePayloadsListenV1RealtimeClient.
        /// If no clientWebSocket is provided, a new one will be created.
        /// </summary>
        /// <param name="clientWebSocket">The ClientWebSocket instance. If not provided, a new one will be created.</param>
        public DeepgramInlinePayloadsListenV1RealtimeClient(
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null)
        {
            _clientWebSocket = clientWebSocket ?? new global::System.Net.WebSockets.ClientWebSocket();

            Initialized(_clientWebSocket);
        }


        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _clientWebSocket.Options.SetRequestHeader("Authorization", $"bearer {apiKey}");
        }

        /// <summary>
        /// Creates a new instance with bearer token authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="clientWebSocket"></param>
        public DeepgramInlinePayloadsListenV1RealtimeClient(
            string apiKey,
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null) : this(clientWebSocket)
        {
            Authorizing(_clientWebSocket, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_clientWebSocket);
        }




        private void ApplyConnectionOptions(
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols,
            global::System.TimeSpan? keepAliveInterval)
        {
            if (keepAliveInterval is not null)
            {
                _clientWebSocket.Options.KeepAliveInterval = keepAliveInterval.Value;
            }

            if (additionalHeaders is not null)
            {
                foreach (var header in additionalHeaders)
                {
                    _clientWebSocket.Options.SetRequestHeader(header.Key, header.Value);
                }
            }

            if (additionalSubProtocols is not null)
            {
                foreach (var subProtocol in additionalSubProtocols)
                {
                    _clientWebSocket.Options.AddSubProtocol(subProtocol);
                }
            }
        }

        private async global::System.Threading.Tasks.Task ConnectAsyncCore(
            global::System.Uri uri,
            global::System.TimeSpan? connectTimeout,
            global::System.Threading.CancellationToken cancellationToken)
        {
            global::System.Threading.CancellationTokenSource? __timeoutCancellationTokenSource = null;
            var __effectiveCancellationToken = cancellationToken;

            if (connectTimeout is not null)
            {
                __timeoutCancellationTokenSource = global::System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                __timeoutCancellationTokenSource.CancelAfter(connectTimeout.Value);
                __effectiveCancellationToken = __timeoutCancellationTokenSource.Token;
            }

            try
            {
                await _clientWebSocket.ConnectAsync(uri, __effectiveCancellationToken).ConfigureAwait(false);
            }
            finally
            {
                __timeoutCancellationTokenSource?.Dispose();
            }
        }

        private const string DefaultBaseUrlTemplate = "wss://api.deepgram.com/v1/listen";


        /// <inheritdoc cref="global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)"/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            global::System.Uri __uri;
            if (uri is not null)
            {
                __uri = uri;
            }
            else
            {
                var __pathBuilder = new global::G.PathBuilder(
                    path: DefaultBaseUrl);

                __uri = new global::System.Uri(__pathBuilder.ToString());
            }

            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Connects to the WebSocket server with typed connection parameters.
        /// </summary>
        /// <param name="model">AI model used for transcription.</param>
        /// <param name="channels">Audio channels to transcribe.</param>
        /// <param name="encoding">Encoding format of the submitted audio.</param>
        /// <param name="extra">Extra key-value metadata to attach to the request.</param>
        /// <param name="keywords">Keywords to boost in transcription.</param>
        /// <param name="language">BCP-47 language tag for the primary spoken language.</param>
        /// <param name="sampleRate">Sample rate of the audio stream in Hz.</param>
        /// <param name="uri">Optional WebSocket endpoint override.</param>
        /// <param name="additionalHeaders">Additional headers applied before connecting.</param>
        /// <param name="additionalSubProtocols">Additional WebSocket subprotocols applied before connecting.</param>
        /// <param name="keepAliveInterval">Optional keep-alive interval.</param>
        /// <param name="connectTimeout">Optional connect timeout.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::G.ListenV1Model model,
            global::System.Collections.Generic.IList<int>? channels = default,
            global::G.ListenV1Encoding? encoding = default,
            global::G.ListenV1Extra? extra = default,
            global::System.Collections.Generic.IList<string>? keywords = default,
            string? language = default,
            int? sampleRate = default,
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            global::System.Uri __uri;
            if (uri is not null)
            {
                __uri = uri;
            }
            else
            {
                var __baseUrl = DefaultBaseUrlTemplate;
                var __pathBuilder = new global::G.PathBuilder(
                    path: __baseUrl);
                __pathBuilder
                .AddRequiredParameter("model", model.ToValueString())
                .AddOptionalParameter("channels", channels, selector: static x => x.ToString()!, delimiter: ",", explode: true)
                .AddOptionalParameter("encoding", encoding?.ToValueString())
                .AddOptionalParameter("extra[priority]", extra?.Priority?.ToString())
                .AddOptionalParameter("extra[tag]", extra?.Tag)
                .AddOptionalParameter("keywords", keywords, delimiter: ",", explode: true)
                .AddOptionalParameter("language", language)
                .AddOptionalParameter("sample_rate", sampleRate?.ToString())
                ;

                __uri = new global::System.Uri(__pathBuilder.ToString());
            }

            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a raw text message over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            await _clientWebSocket.SendAsync(
                buffer: new global::System.ArraySegment<byte>(global::System.Text.Encoding.UTF8.GetBytes(text)),
                messageType: global::System.Net.WebSockets.WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends raw bytes over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            global::System.ArraySegment<byte> bytes,
            global::System.Net.WebSockets.WebSocketMessageType messageType,
            bool endOfMessage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            await _clientWebSocket.SendAsync(
                bytes,
                messageType,
                endOfMessage,
                cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _clientWebSocket.Dispose();
        }

        /// <inheritdoc/>
        public async global::System.Threading.Tasks.ValueTask DisposeAsync()
        {
            if (IsConnected)
            {
                try
                {
                    await _clientWebSocket.CloseAsync(
                        closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                        statusDescription: "Closing",
                        cancellationToken: default).ConfigureAwait(false);
                }
                catch (global::System.Net.WebSockets.WebSocketException)
                {
                    // Ignore errors during dispose
                }
            }
            _clientWebSocket.Dispose();
        }

        partial void Initialized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void Authorizing(
            global::System.Net.WebSockets.ClientWebSocket client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareArguments(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareRequest(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
        partial void OnReceiveException(
            global::System.Exception exception,
            ref bool rethrow);
    }
}