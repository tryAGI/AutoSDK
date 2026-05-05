using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static FileWithName WebSocketClient(
        WebSocketClient wsClient,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{wsClient.FileNameWithoutExtension}.g.cs",
            Text: GenerateWebSocketClient(wsClient));
    }

    public static string GenerateWebSocketClient(
        WebSocketClient wsClient)
    {
        var hasOptions = !wsClient.Settings.HasJsonSerializerContext();
        var eventSurface = GenerateWebSocketEventSurface(wsClient);

        return $@"
#nullable enable

namespace {wsClient.Settings.Namespace}
{{
    {wsClient.Summary.ToXmlDocumentationSummary()}
    public sealed partial class {wsClient.ClassName} : global::System.IDisposable, global::System.IAsyncDisposable
    {{
        /// <summary>
        /// Default WebSocket base URL.
        /// </summary>
        public const string DefaultBaseUrl = ""{wsClient.BaseUrl}"";

        private global::System.Net.WebSockets.ClientWebSocket _clientWebSocket;
        private global::System.Uri? _lastConnectUri;
        private global::System.Collections.Generic.Dictionary<string, string>? _lastAdditionalHeaders;
        private global::System.Collections.Generic.List<string>? _lastAdditionalSubProtocols;
        private global::System.TimeSpan? _lastKeepAliveInterval;
        private global::System.TimeSpan? _lastConnectTimeout;
{(wsClient.Authorizations.Any(static x => !x.WebSocketSubProtocols.IsEmpty) ? "        private bool _lastUseSubprotocolAuth;\n" : string.Empty)}
{eventSurface}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
{(hasOptions ? $@"
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions {{ get; set; }} = new global::System.Text.Json.JsonSerializerOptions();" : $@"
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext {{ get; set; }} = global::{wsClient.Settings.JsonSerializerContext}.Default;")}

        /// <summary>
        /// Gets a value indicating whether the WebSocket connection is open.
        /// </summary>
        public bool IsConnected => _clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open;

        /// <summary>
        /// Creates a new instance of the {wsClient.ClassName}.
        /// If no clientWebSocket is provided, a new one will be created.
        /// </summary>
        /// <param name=""clientWebSocket"">The ClientWebSocket instance. If not provided, a new one will be created.</param>
        public {wsClient.ClassName}(
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null)
        {{
            _clientWebSocket = clientWebSocket ?? new global::System.Net.WebSockets.ClientWebSocket();

            Initialized(_clientWebSocket);
        }}

{GenerateWebSocketAuthorizationConstructors(wsClient)}

{GenerateConnectAsync(wsClient)}

        /// <summary>
        /// Sends a raw text message over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (!IsConnected)
            {{
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }}

            await _clientWebSocket.SendAsync(
                buffer: new global::System.ArraySegment<byte>(global::System.Text.Encoding.UTF8.GetBytes(text)),
                messageType: global::System.Net.WebSockets.WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }}

        /// <summary>
        /// Sends raw bytes over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            global::System.ArraySegment<byte> bytes,
            global::System.Net.WebSockets.WebSocketMessageType messageType,
            bool endOfMessage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (!IsConnected)
            {{
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }}

            await _clientWebSocket.SendAsync(
                bytes,
                messageType,
                endOfMessage,
                cancellationToken).ConfigureAwait(false);
        }}

        /// <inheritdoc/>
        public void Dispose()
        {{
            _clientWebSocket.Dispose();
        }}

        /// <inheritdoc/>
        public async global::System.Threading.Tasks.ValueTask DisposeAsync()
        {{
            if (IsConnected)
            {{
                try
                {{
                    await _clientWebSocket.CloseAsync(
                        closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                        statusDescription: ""Closing"",
                        cancellationToken: default).ConfigureAwait(false);
                }}
                catch (global::System.Net.WebSockets.WebSocketException)
                {{
                    // Ignore errors during dispose
                }}
            }}
            _clientWebSocket.Dispose();
        }}

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
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateWebSocketAuthorizationConstructors(WebSocketClient wsClient)
    {
        var result = new System.Text.StringBuilder();
        var hasStoredHeaderAuth = wsClient.Authorizations.Any(static auth =>
            auth.Type == SecuritySchemeType.Http &&
            !string.Equals(auth.Scheme, "basic", StringComparison.OrdinalIgnoreCase) ||
            auth.Type == SecuritySchemeType.ApiKey &&
            auth.In == ParameterLocation.Header);
        var hasSubprotocolAuth = wsClient.Authorizations.Any(static auth => !auth.WebSocketSubProtocols.IsEmpty);
        var bridgeApiKeyToSubprotocol = hasSubprotocolAuth &&
                                        wsClient.Authorizations.Any(static auth =>
                                            !auth.WebSocketSubProtocols.IsEmpty &&
                                            auth.Parameters.Contains("apiKey"));

        if (hasStoredHeaderAuth)
        {
            result.AppendLine(@"
        private string? _storedAuthorizationHeaderName;
        private string? _storedAuthorizationHeaderScheme;
        private string? _storedAuthorizationApiKey;");
        }

        if (hasSubprotocolAuth)
        {
            result.AppendLine(@"
        private readonly global::System.Collections.Generic.Dictionary<string, string> _subprotocolAuthorizationValues = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal);
        private bool _preferSubprotocolAuth;");
        }

        foreach (var auth in wsClient.Authorizations)
        {
            if (!auth.WebSocketSubProtocols.IsEmpty)
            {
                result.AppendLine(GenerateSubprotocolAuthorizationMethod(auth));
            }
            else if (auth.Type == SecuritySchemeType.Http &&
                     !string.Equals(auth.Scheme, "basic", StringComparison.OrdinalIgnoreCase))
            {
                var friendlyName = string.IsNullOrWhiteSpace(auth.FriendlyName)
                    ? auth.Scheme.ToPropertyName()
                    : auth.FriendlyName;
                var schemeName = string.IsNullOrWhiteSpace(auth.Scheme)
                    ? "Bearer"
                    : auth.Scheme;

                var authorizationBlock = $@"
        /// <summary>
        /// Authorize using {schemeName} authentication.
        /// </summary>
        /// <param name=""apiKey""></param>
        public void AuthorizeUsing{friendlyName}(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _storedAuthorizationApiKey = apiKey;
            _storedAuthorizationHeaderName = ""Authorization"";
            _storedAuthorizationHeaderScheme = ""{schemeName}"";
{(hasSubprotocolAuth ? "            _preferSubprotocolAuth = false;\n" : string.Empty)}{(bridgeApiKeyToSubprotocol ? "            _subprotocolAuthorizationValues[\"apiKey\"] = apiKey;\n" : string.Empty)}        }}

        /// <summary>
        /// Creates a new instance with {schemeName} token authentication.
        /// </summary>
        /// <param name=""apiKey""></param>
        /// <param name=""clientWebSocket""></param>
        public {wsClient.ClassName}(
            string apiKey,
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null) : this(clientWebSocket)
        {{
            Authorizing(_clientWebSocket, ref apiKey);

            AuthorizeUsing{friendlyName}(apiKey);

            Authorized(_clientWebSocket);
        }}";
                result.AppendLine(authorizationBlock);
            }
            else if (auth.Type == SecuritySchemeType.ApiKey &&
                     auth.In == ParameterLocation.Header)
            {
                var authorizationBlock = $@"
        /// <summary>
        /// Authorize using API key in header.
        /// </summary>
        /// <param name=""apiKey""></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _storedAuthorizationApiKey = apiKey;
            _storedAuthorizationHeaderName = ""{auth.Name}"";
            _storedAuthorizationHeaderScheme = null;
{(hasSubprotocolAuth ? "            _preferSubprotocolAuth = false;\n" : string.Empty)}{(bridgeApiKeyToSubprotocol ? "            _subprotocolAuthorizationValues[\"apiKey\"] = apiKey;\n" : string.Empty)}        }}

        /// <summary>
        /// Creates a new instance with API key header authentication.
        /// </summary>
        /// <param name=""apiKey""></param>
        /// <param name=""clientWebSocket""></param>
        public {wsClient.ClassName}(
            string apiKey,
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null) : this(clientWebSocket)
        {{
            Authorizing(_clientWebSocket, ref apiKey);

            AuthorizeUsingApiKeyInHeader(apiKey);

            Authorized(_clientWebSocket);
        }}";
                result.AppendLine(authorizationBlock);
            }
            else if (auth.Type == SecuritySchemeType.ApiKey &&
                     auth.In == ParameterLocation.Query)
            {
                var authorizationBlock = $@"
        /// <summary>
        /// Authorize using API key in query parameter.
        /// The key will be appended to the URL during ConnectAsync.
        /// </summary>
        /// <param name=""apiKey""></param>
        public void AuthorizeUsingApiKeyInQuery(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            // Query parameter auth is handled during ConnectAsync
            _queryApiKey = apiKey;
            _queryApiKeyName = ""{auth.Name}"";
{(bridgeApiKeyToSubprotocol ? "            _subprotocolAuthorizationValues[\"apiKey\"] = apiKey;\n" : string.Empty)}        }}

        private string? _queryApiKey;
        private string? _queryApiKeyName;";
                result.AppendLine(authorizationBlock);
            }
        }

        return result.ToString();
    }

    private static string GenerateWebSocketEventSurface(WebSocketClient wsClient)
    {
        var receiveEventType = wsClient.BaseReceiveEventType.CSharpTypeWithoutNullability;
        var messageEvents = new System.Text.StringBuilder();
        var seenEventNames = new HashSet<string>(StringComparer.Ordinal);

        if (!string.IsNullOrWhiteSpace(receiveEventType))
        {
            var messageReceivedEvent = $@"
        /// <summary>
        /// Raised after a text message is deserialized into the receive event type.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<{receiveEventType}>>? MessageReceived;";
            messageEvents.Append(messageReceivedEvent);
        }

        foreach (var operation in wsClient.ReceiveOperations)
        {
            var messageType = operation.MessageType.CSharpTypeWithoutNullability;
            if (string.IsNullOrWhiteSpace(messageType) ||
                !CanGenerateTypedWebSocketMessageEvent(wsClient, operation.MessageType))
            {
                continue;
            }

            var eventName = operation.MessageName.ToPropertyName() + "Received";
            if (!seenEventNames.Add(eventName))
            {
                continue;
            }

            var typedMessageEvent = $@"
        /// <summary>
        /// Raised after a {operation.MessageName.ClearForXml()} message is deserialized.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<{messageType}>>? {eventName};";
            messageEvents.Append(typedMessageEvent);
        }

        return $@"
        /// <summary>
        /// Current WebSocket connection status.
        /// </summary>
        public enum AutoSDKWebSocketConnectionStatus
        {{
            /// <summary>
            /// The client is not connected.
            /// </summary>
            Disconnected,

            /// <summary>
            /// The client is connecting.
            /// </summary>
            Connecting,

            /// <summary>
            /// The client is connected.
            /// </summary>
            Connected,

            /// <summary>
            /// The client observed a normal close.
            /// </summary>
            Closed,

            /// <summary>
            /// The client observed a connection error.
            /// </summary>
            Faulted,
        }}

        /// <summary>
        /// Configures automatic reconnect attempts after receive-loop WebSocket failures.
        /// </summary>
        public sealed class AutoSDKWebSocketReconnectOptions
        {{
            /// <summary>
            /// Enables reconnect attempts from the receive loop.
            /// </summary>
            public bool Enabled {{ get; set; }}

            /// <summary>
            /// Maximum reconnect attempts per observed receive failure.
            /// </summary>
            public int MaxAttempts {{ get; set; }} = 3;

            /// <summary>
            /// Delay before the first reconnect attempt.
            /// </summary>
            public global::System.TimeSpan InitialDelay {{ get; set; }} = global::System.TimeSpan.FromSeconds(1);

            /// <summary>
            /// Maximum delay between reconnect attempts.
            /// </summary>
            public global::System.TimeSpan MaxDelay {{ get; set; }} = global::System.TimeSpan.FromSeconds(30);

            /// <summary>
            /// Multiplier applied to the delay after each failed reconnect attempt.
            /// </summary>
            public double BackoffMultiplier {{ get; set; }} = 2D;
        }}

        /// <summary>
        /// Event data for closed WebSocket connections.
        /// </summary>
        public sealed class AutoSDKWebSocketClosedEventArgs : global::System.EventArgs
        {{
            /// <summary>
            /// Initializes a new instance of the <see cref=""AutoSDKWebSocketClosedEventArgs""/> class.
            /// </summary>
            public AutoSDKWebSocketClosedEventArgs(
                global::System.Net.WebSockets.WebSocketCloseStatus? closeStatus,
                string? closeStatusDescription)
            {{
                CloseStatus = closeStatus;
                CloseStatusDescription = closeStatusDescription;
            }}

            /// <summary>
            /// Gets the WebSocket close status.
            /// </summary>
            public global::System.Net.WebSockets.WebSocketCloseStatus? CloseStatus {{ get; }}

            /// <summary>
            /// Gets the WebSocket close status description.
            /// </summary>
            public string? CloseStatusDescription {{ get; }}
        }}

        /// <summary>
        /// Event data for WebSocket exceptions.
        /// </summary>
        public sealed class AutoSDKWebSocketExceptionEventArgs : global::System.EventArgs
        {{
            /// <summary>
            /// Initializes a new instance of the <see cref=""AutoSDKWebSocketExceptionEventArgs""/> class.
            /// </summary>
            public AutoSDKWebSocketExceptionEventArgs(
                global::System.Exception exception)
            {{
                Exception = exception ?? throw new global::System.ArgumentNullException(nameof(exception));
            }}

            /// <summary>
            /// Gets the observed exception.
            /// </summary>
            public global::System.Exception Exception {{ get; }}
        }}

        /// <summary>
        /// Event data for WebSocket reconnect attempts.
        /// </summary>
        public sealed class AutoSDKWebSocketReconnectEventArgs : global::System.EventArgs
        {{
            /// <summary>
            /// Initializes a new instance of the <see cref=""AutoSDKWebSocketReconnectEventArgs""/> class.
            /// </summary>
            public AutoSDKWebSocketReconnectEventArgs(
                int attempt,
                global::System.TimeSpan delay,
                global::System.Exception exception)
            {{
                Attempt = attempt;
                Delay = delay;
                Exception = exception ?? throw new global::System.ArgumentNullException(nameof(exception));
            }}

            /// <summary>
            /// Gets the reconnect attempt number.
            /// </summary>
            public int Attempt {{ get; }}

            /// <summary>
            /// Gets the delay before the reconnect attempt.
            /// </summary>
            public global::System.TimeSpan Delay {{ get; }}

            /// <summary>
            /// Gets the exception that triggered reconnect.
            /// </summary>
            public global::System.Exception Exception {{ get; }}
        }}

        /// <summary>
        /// Event data for deserialized WebSocket messages.
        /// </summary>
        public sealed class AutoSDKWebSocketMessageEventArgs<TMessage> : global::System.EventArgs
        {{
            /// <summary>
            /// Initializes a new instance of the <see cref=""AutoSDKWebSocketMessageEventArgs{{TMessage}}""/> class.
            /// </summary>
            public AutoSDKWebSocketMessageEventArgs(
                TMessage message,
                string rawText,
                global::System.Text.Json.JsonElement? json)
            {{
                Message = message;
                RawText = rawText ?? string.Empty;
                Json = json;
            }}

            /// <summary>
            /// Gets the deserialized message.
            /// </summary>
            public TMessage Message {{ get; }}

            /// <summary>
            /// Gets the raw text received from the WebSocket.
            /// </summary>
            public string RawText {{ get; }}

            /// <summary>
            /// Gets the parsed JSON payload when available.
            /// </summary>
            public global::System.Text.Json.JsonElement? Json {{ get; }}
        }}

        /// <summary>
        /// Event data for messages that could not be deserialized into a known receive type.
        /// </summary>
        public sealed class AutoSDKWebSocketUnknownMessageEventArgs : global::System.EventArgs
        {{
            /// <summary>
            /// Initializes a new instance of the <see cref=""AutoSDKWebSocketUnknownMessageEventArgs""/> class.
            /// </summary>
            public AutoSDKWebSocketUnknownMessageEventArgs(
                string rawText,
                global::System.Text.Json.JsonElement? json)
            {{
                RawText = rawText ?? string.Empty;
                Json = json;
            }}

            /// <summary>
            /// Gets the raw text received from the WebSocket.
            /// </summary>
            public string RawText {{ get; }}

            /// <summary>
            /// Gets the parsed JSON payload when available.
            /// </summary>
            public global::System.Text.Json.JsonElement? Json {{ get; }}
        }}

        /// <summary>
        /// Gets the current WebSocket connection status.
        /// </summary>
        public AutoSDKWebSocketConnectionStatus Status {{ get; private set; }} = AutoSDKWebSocketConnectionStatus.Disconnected;

        /// <summary>
        /// Gets reconnect options used by the receive loop.
        /// </summary>
        public AutoSDKWebSocketReconnectOptions ReconnectOptions {{ get; }} = new AutoSDKWebSocketReconnectOptions();

        /// <summary>
        /// Raised after the WebSocket connection is opened.
        /// </summary>
        public event global::System.EventHandler? Connected;

        /// <summary>
        /// Raised after the WebSocket connection is closed.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketClosedEventArgs>? Closed;

        /// <summary>
        /// Raised after a WebSocket connection exception is observed.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketExceptionEventArgs>? ExceptionOccurred;

        /// <summary>
        /// Raised before a reconnect attempt starts.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketReconnectEventArgs>? Reconnecting;

        /// <summary>
        /// Raised when an inbound text message cannot be deserialized into a known receive event.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketUnknownMessageEventArgs>? UnknownMessage;
{messageEvents}".TrimEnd();
    }

    private static bool CanGenerateTypedWebSocketMessageEvent(
        WebSocketClient wsClient,
        TypeData messageType)
    {
        return string.Equals(messageType.Namespace, wsClient.Settings.Namespace, StringComparison.Ordinal);
    }

    private static string GenerateSubprotocolAuthorizationMethod(Authorization auth)
    {
        var xmlParams = auth.Parameters.Select(parameter =>
            $@"        /// <param name=""{parameter.ToParameterName()}""></param>");
        var parameterDeclarations = auth.Parameters.Select(parameter =>
            $@"            string {parameter.ToParameterName()}");
        var assignments = auth.Parameters.Select(parameter =>
        {
            var parameterName = parameter.ToParameterName();
            return $@"            var {parameterName}Value = {parameterName} ?? throw new global::System.ArgumentNullException(nameof({parameterName}));
            _subprotocolAuthorizationValues[""{parameter}""] = {parameterName}Value;";
        });
        var signature = auth.Parameters.Length == 0
            ? string.Empty
            : $@"
{parameterDeclarations.Inject().TrimEnd(',')}
";

        return $@"
        /// <summary>
        /// Authorize using WebSocket subprotocol authentication.
        /// </summary>
{xmlParams.Inject(emptyValue: string.Empty)}
        public void {auth.MethodName}({signature}        )
        {{
{assignments.Inject(emptyValue: string.Empty)}
            _preferSubprotocolAuth = true;
        }}";
    }

    private static string GenerateConnectAsync(WebSocketClient wsClient)
    {
        var serverVariables = wsClient.ServerVariables.ToArray();
        var signatureParams = wsClient.QueryParameters.ToArray();
        var serializedParams = wsClient.SerializedQueryParameters.ToArray();
        var hasTypedParameters = serverVariables.Length > 0 || signatureParams.Length > 0;
        var hasRequiredParameters = serverVariables.Any(static x => x.IsRequired) || signatureParams.Any(static x => x.IsRequired);
        var hasSubprotocolAuth = wsClient.Authorizations.Any(static x => !x.WebSocketSubProtocols.IsEmpty);
        var hasStoredHeaderAuth = wsClient.Authorizations.Any(static x =>
            x.Type == SecuritySchemeType.Http &&
            !string.Equals(x.Scheme, "basic", StringComparison.OrdinalIgnoreCase) ||
            x.Type == SecuritySchemeType.ApiKey &&
            x.In == ParameterLocation.Header);
        var supportsQueryApiKeyAuth = wsClient.Authorizations.Any(
            static x => x.Type == SecuritySchemeType.ApiKey &&
                        x.In == ParameterLocation.Query);
        var appendQueryApiKeyIfNeeded = supportsQueryApiKeyAuth
            ? @"
                if (_queryApiKey is not null && _queryApiKeyName is not null)
                {
                    __pathBuilder.AddRequiredParameter(_queryApiKeyName, _queryApiKey);
                }"
            : string.Empty;
        var applyStoredAuthorization = GenerateStoredWebSocketAuthorization(
            wsClient,
            hasStoredHeaderAuth,
            hasSubprotocolAuth);
        var connectionOptionsExtraParameter = hasSubprotocolAuth
            ? ",\n            bool useSubprotocolAuth"
            : string.Empty;
        var applyStoredAuthorizationCall = hasStoredHeaderAuth || hasSubprotocolAuth
            ? $"            ApplyStoredAuthorization({(hasSubprotocolAuth ? "useSubprotocolAuth" : "false")});\n"
            : string.Empty;

        var rememberConnectionOptionsUseSubprotocolParameter = hasSubprotocolAuth
            ? @",
            bool useSubprotocolAuth"
            : string.Empty;
        var rememberConnectionOptionsUseSubprotocolAssignment = hasSubprotocolAuth
            ? @"
            _lastUseSubprotocolAuth = useSubprotocolAuth;"
            : string.Empty;
        var reconnectUseSubprotocolArgument = hasSubprotocolAuth
            ? @",
                        useSubprotocolAuth: _lastUseSubprotocolAuth"
            : string.Empty;
        var connectionHelpers = @"
" + applyStoredAuthorization + @"
        private void RememberConnectionOptions(
            global::System.Uri uri,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols,
            global::System.TimeSpan? keepAliveInterval,
            global::System.TimeSpan? connectTimeout" + rememberConnectionOptionsUseSubprotocolParameter + @")
        {
            _lastConnectUri = uri;
            _lastAdditionalHeaders = additionalHeaders is null
                ? null
                : new global::System.Collections.Generic.Dictionary<string, string>(
                    additionalHeaders,
                    global::System.StringComparer.OrdinalIgnoreCase);
            _lastAdditionalSubProtocols = additionalSubProtocols is null
                ? null
                : new global::System.Collections.Generic.List<string>(additionalSubProtocols);
            _lastKeepAliveInterval = keepAliveInterval;
            _lastConnectTimeout = connectTimeout;" + rememberConnectionOptionsUseSubprotocolAssignment + @"
        }

        private void ResetClientWebSocket()
        {
            _clientWebSocket.Dispose();
            _clientWebSocket = new global::System.Net.WebSockets.ClientWebSocket();
            Initialized(_clientWebSocket);
        }

        private void RaiseClosed(
            global::System.Net.WebSockets.WebSocketCloseStatus? closeStatus,
            string? closeStatusDescription)
        {
            Status = AutoSDKWebSocketConnectionStatus.Closed;
            Closed?.Invoke(
                this,
                new AutoSDKWebSocketClosedEventArgs(closeStatus, closeStatusDescription));
        }

        private void RaiseException(
            global::System.Exception exception)
        {
            Status = AutoSDKWebSocketConnectionStatus.Faulted;
            ExceptionOccurred?.Invoke(
                this,
                new AutoSDKWebSocketExceptionEventArgs(exception));
        }

        private global::System.TimeSpan GetReconnectDelay(
            int attempt)
        {
            var delay = ReconnectOptions.InitialDelay;
            if (delay < global::System.TimeSpan.Zero)
            {
                delay = global::System.TimeSpan.Zero;
            }

            var multiplier = ReconnectOptions.BackoffMultiplier;
            if (multiplier < 1D)
            {
                multiplier = 1D;
            }

            for (var index = 1; index < attempt; index++)
            {
                var nextMilliseconds = delay.TotalMilliseconds * multiplier;
                if (nextMilliseconds >= ReconnectOptions.MaxDelay.TotalMilliseconds)
                {
                    delay = ReconnectOptions.MaxDelay;
                    break;
                }

                delay = global::System.TimeSpan.FromMilliseconds(nextMilliseconds);
            }

            if (ReconnectOptions.MaxDelay >= global::System.TimeSpan.Zero &&
                delay > ReconnectOptions.MaxDelay)
            {
                delay = ReconnectOptions.MaxDelay;
            }

            return delay;
        }

        private async global::System.Threading.Tasks.Task<bool> TryReconnectAsync(
            global::System.Exception exception,
            global::System.Threading.CancellationToken cancellationToken)
        {
            if (!ReconnectOptions.Enabled ||
                _lastConnectUri is null ||
                cancellationToken.IsCancellationRequested)
            {
                return false;
            }

            var maxAttempts = ReconnectOptions.MaxAttempts < 1 ? 1 : ReconnectOptions.MaxAttempts;
            var lastException = exception;
            for (var attempt = 1; attempt <= maxAttempts; attempt++)
            {
                var delay = GetReconnectDelay(attempt);
                Reconnecting?.Invoke(
                    this,
                    new AutoSDKWebSocketReconnectEventArgs(attempt, delay, lastException));

                if (delay > global::System.TimeSpan.Zero)
                {
                    await global::System.Threading.Tasks.Task.Delay(delay, cancellationToken).ConfigureAwait(false);
                }

                try
                {
                    ResetClientWebSocket();
                    await ConnectAsync(
                        uri: _lastConnectUri,
                        additionalHeaders: _lastAdditionalHeaders,
                        additionalSubProtocols: _lastAdditionalSubProtocols,
                        keepAliveInterval: _lastKeepAliveInterval,
                        connectTimeout: _lastConnectTimeout" + reconnectUseSubprotocolArgument + @",
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    return true;
                }
                catch (global::System.Exception reconnectException) when (
                    reconnectException is global::System.Net.WebSockets.WebSocketException ||
                    reconnectException is global::System.Net.Http.HttpRequestException ||
                    reconnectException is global::System.OperationCanceledException)
                {
                    lastException = reconnectException;
                    RaiseException(reconnectException);
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        private void ApplyConnectionOptions(
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols,
            global::System.TimeSpan? keepAliveInterval" + connectionOptionsExtraParameter + @")
        {
            if (keepAliveInterval is not null)
            {
                _clientWebSocket.Options.KeepAliveInterval = keepAliveInterval.Value;
            }

" + applyStoredAuthorizationCall + @"
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
                Status = AutoSDKWebSocketConnectionStatus.Connecting;
                await _clientWebSocket.ConnectAsync(uri, __effectiveCancellationToken).ConfigureAwait(false);
                Status = AutoSDKWebSocketConnectionStatus.Connected;
                Connected?.Invoke(this, global::System.EventArgs.Empty);
            }
            catch (global::System.Exception exception) when (
                exception is global::System.Net.WebSockets.WebSocketException ||
                exception is global::System.Net.Http.HttpRequestException ||
                exception is global::System.OperationCanceledException)
            {
                RaiseException(exception);
                throw;
            }
            finally
            {
                __timeoutCancellationTokenSource?.Dispose();
            }
        }";

        if (!hasTypedParameters)
        {
            return $@"
{connectionHelpers}

        /// <inheritdoc cref=""global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)""/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            {(hasSubprotocolAuth ? "bool useSubprotocolAuth = false,\n            " : string.Empty)}global::System.Threading.CancellationToken cancellationToken = default)
        {{
            global::System.Uri __uri;
            if (uri is not null)
            {{
                __uri = uri;
            }}
            else
            {{
                var __pathBuilder = new global::{wsClient.Settings.Namespace}.PathBuilder(
                    path: DefaultBaseUrl);
{appendQueryApiKeyIfNeeded}
                __uri = new global::System.Uri(__pathBuilder.ToString());
            }}

            RememberConnectionOptions(__uri, additionalHeaders, additionalSubProtocols, keepAliveInterval, connectTimeout{(hasSubprotocolAuth ? ", useSubprotocolAuth" : string.Empty)});
            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval{(hasSubprotocolAuth ? ", useSubprotocolAuth" : string.Empty)});
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }}";
        }

        var xmlDoc = new System.Text.StringBuilder();
        var parameterSignature = new System.Text.StringBuilder();
        var baseUrlReplacements = new System.Text.StringBuilder();
        var pathBuilderCalls = new System.Text.StringBuilder();

        xmlDoc.AppendLine("        /// <summary>");
        xmlDoc.AppendLine("        /// Connects to the WebSocket server with typed connection parameters.");
        xmlDoc.AppendLine("        /// </summary>");

        var isFirst = true;

        void AppendParameter(MethodParameter param, bool preferNonNullableDefaultType)
        {
            var xmlSummary = !string.IsNullOrWhiteSpace(param.Description)
                ? param.Description.ClearForXml()
                : !string.IsNullOrWhiteSpace(param.Summary)
                    ? param.Summary.ClearForXml()
                    : string.Empty;

            if (!string.IsNullOrWhiteSpace(xmlSummary))
            {
                xmlSummary = xmlSummary
                    .Replace("\r\n", " ")
                    .Replace("\r", " ")
                    .Replace("\n", " ")
                    .Trim();
                var xmlParamDoc = $"        /// <param name=\"{param.ParameterName}\">{xmlSummary}</param>";
                xmlDoc.AppendLine(xmlParamDoc);
            }

            if (!isFirst)
            {
                parameterSignature.AppendLine(",");
            }
            isFirst = false;

            if (param.IsRequired && !param.HasSchemaDefault)
            {
                var parameterDeclaration =
                    $"            {param.Type.CSharpTypeWithoutNullability} {param.ParameterName}";
                parameterSignature.Append(parameterDeclaration);
            }
            else
            {
                var parameterType = preferNonNullableDefaultType && param.HasSchemaDefault
                    ? param.Type.CSharpTypeWithoutNullability
                    : param.Type.CSharpType;
                var parameterDefaultValue = param.HasSchemaDefault
                    ? param.ParameterDefaultValue
                    : "default";
                var parameterDeclaration =
                    $"            {parameterType} {param.ParameterName} = {parameterDefaultValue}";
                parameterSignature.Append(parameterDeclaration);
            }
        }

        foreach (var param in serverVariables)
        {
            AppendParameter(param, preferNonNullableDefaultType: true);

            if (wsClient.BaseUrlTemplate.Contains("{" + param.Id + "}", StringComparison.Ordinal))
            {
                var replacementLine =
                    $"                __baseUrl = __baseUrl.Replace(\"{{{param.Id}}}\", global::System.Uri.EscapeDataString({param.ParameterName}));";
                baseUrlReplacements.AppendLine(replacementLine);
            }
            else
            {
                var pathBuilderCall =
                    $"                .AddRequiredParameter(\"{param.Id}\", {param.ParameterName})";
                pathBuilderCalls.AppendLine(pathBuilderCall);
            }
        }

        foreach (var param in signatureParams)
        {
            AppendParameter(param, preferNonNullableDefaultType: false);
        }

        xmlDoc.AppendLine("        /// <param name=\"uri\">Optional WebSocket endpoint override.</param>");
        xmlDoc.AppendLine("        /// <param name=\"additionalHeaders\">Additional headers applied before connecting.</param>");
        xmlDoc.AppendLine("        /// <param name=\"additionalSubProtocols\">Additional WebSocket subprotocols applied before connecting.</param>");
        xmlDoc.AppendLine("        /// <param name=\"keepAliveInterval\">Optional keep-alive interval.</param>");
        xmlDoc.AppendLine("        /// <param name=\"connectTimeout\">Optional connect timeout.</param>");
        if (hasSubprotocolAuth)
        {
            xmlDoc.AppendLine("        /// <param name=\"useSubprotocolAuth\">When true, applies stored subprotocol authentication instead of header authentication.</param>");
        }
        xmlDoc.AppendLine("        /// <param name=\"cancellationToken\">A cancellation token.</param>");

        foreach (var param in serializedParams)
        {
            var additionalArguments = param.Type.IsArray
                ? $", delimiter: \"{param.Delimiter}\", explode: {(param.Explode ? "true" : "false")}"
                : string.Empty;
            if (param.Type.IsArray && param.Type.SubTypes[0].Unbox<TypeData>().CSharpTypeWithoutNullability is not "string")
            {
                additionalArguments = $", selector: static x => {param.Selector}" + additionalArguments;
            }

            if (param.IsRequired && !param.Type.IsNullable)
            {
                // For non-nullable required params, replace ?. with . since the type is non-nullable
                var value = param.Value.Replace("?.", ".");
                var pathBuilderCall =
                    $"                .AddRequiredParameter(\"{param.Id}\", {value}{additionalArguments})";
                pathBuilderCalls.AppendLine(pathBuilderCall);
            }
            else
            {
                var pathBuilderCall =
                    $"                .AddOptionalParameter(\"{param.Id}\", {param.Value}{additionalArguments})";
                pathBuilderCalls.AppendLine(pathBuilderCall);
            }
        }

        var templateConstant = !string.IsNullOrWhiteSpace(wsClient.BaseUrlTemplate)
            ? $@"

        private const string DefaultBaseUrlTemplate = {wsClient.BaseUrlTemplate.ToCSharpStringLiteral()};"
            : string.Empty;

        var simpleOverload = hasRequiredParameters ? $@"

        /// <inheritdoc cref=""global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)""/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            {(hasSubprotocolAuth ? "bool useSubprotocolAuth = false,\n            " : string.Empty)}global::System.Threading.CancellationToken cancellationToken = default)
        {{
            global::System.Uri __uri;
            if (uri is not null)
            {{
                __uri = uri;
            }}
            else
            {{
                var __pathBuilder = new global::{wsClient.Settings.Namespace}.PathBuilder(
                    path: DefaultBaseUrl);
{appendQueryApiKeyIfNeeded}
                __uri = new global::System.Uri(__pathBuilder.ToString());
            }}

            RememberConnectionOptions(__uri, additionalHeaders, additionalSubProtocols, keepAliveInterval, connectTimeout{(hasSubprotocolAuth ? ", useSubprotocolAuth" : string.Empty)});
            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval{(hasSubprotocolAuth ? ", useSubprotocolAuth" : string.Empty)});
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }}" : string.Empty;

        var baseUrlSource = !string.IsNullOrWhiteSpace(wsClient.BaseUrlTemplate)
            ? "DefaultBaseUrlTemplate"
            : "DefaultBaseUrl";

        return $@"
{connectionHelpers}{templateConstant}
{simpleOverload}

{xmlDoc}        public async global::System.Threading.Tasks.Task ConnectAsync(
{parameterSignature},
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            {(hasSubprotocolAuth ? "bool useSubprotocolAuth = false,\n            " : string.Empty)}global::System.Threading.CancellationToken cancellationToken = default)
        {{
            global::System.Uri __uri;
            if (uri is not null)
            {{
                __uri = uri;
            }}
            else
            {{
                var __baseUrl = {baseUrlSource};
{baseUrlReplacements}                var __pathBuilder = new global::{wsClient.Settings.Namespace}.PathBuilder(
                    path: __baseUrl);
                __pathBuilder
{pathBuilderCalls}                ;
{appendQueryApiKeyIfNeeded}
                __uri = new global::System.Uri(__pathBuilder.ToString());
            }}

            RememberConnectionOptions(__uri, additionalHeaders, additionalSubProtocols, keepAliveInterval, connectTimeout{(hasSubprotocolAuth ? ", useSubprotocolAuth" : string.Empty)});
            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval{(hasSubprotocolAuth ? ", useSubprotocolAuth" : string.Empty)});
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }}";
    }

    private static string GenerateStoredWebSocketAuthorization(
        WebSocketClient wsClient,
        bool hasStoredHeaderAuth,
        bool hasSubprotocolAuth)
    {
        if (!hasStoredHeaderAuth && !hasSubprotocolAuth)
        {
            return string.Empty;
        }

        var subprotocolBlocks = wsClient.Authorizations
            .Where(static auth => !auth.WebSocketSubProtocols.IsEmpty)
            .Select(auth =>
            {
                var condition = auth.Parameters.Length == 0
                    ? "true"
                    : string.Join(" && ", auth.Parameters.Select(parameter =>
                        $@"_subprotocolAuthorizationValues.ContainsKey(""{parameter}"")"));
                var parameterReads = auth.Parameters.Select(parameter =>
                {
                    var parameterName = parameter.ToParameterName();
                    return $@"                    var __{parameterName} = _subprotocolAuthorizationValues[""{parameter}""];
";
                }).Inject(emptyValue: string.Empty);
                if (parameterReads.Length > 0)
                {
                    parameterReads += "\n";
                }
                var addProtocols = auth.WebSocketSubProtocols
                    .Distinct(StringComparer.Ordinal)
                    .Select((template, index) =>
                    {
                        var replacements = auth.Parameters.Select(parameter =>
                        {
                            var parameterName = parameter.ToParameterName();
                            return $@"                    __subProtocol = __subProtocol.Replace(""{{{parameter}}}"", __{parameterName});
";
                        }).Inject(emptyValue: string.Empty);
                        if (replacements.Length > 0)
                        {
                            replacements += "\n";
                        }
                        var declaration = index == 0 ? "var " : string.Empty;
                        return $@"                    {declaration}__subProtocol = {template.ToCSharpStringLiteral()};
{replacements}                    _clientWebSocket.Options.AddSubProtocol(__subProtocol);
";
                    }).Inject(emptyValue: string.Empty);
                if (addProtocols.Length > 0)
                {
                    addProtocols += "\n";
                }

                return $@"                if ({condition})
                {{
{parameterReads}{addProtocols}                    return;
                }}
";
            }).Inject(emptyValue: string.Empty);
        if (subprotocolBlocks.Length > 0)
        {
            subprotocolBlocks += "\n";
        }

        var headerBlock = hasStoredHeaderAuth
            ? @"
            if (_storedAuthorizationApiKey is not null &&
                _storedAuthorizationHeaderName is not null)
            {
                var __authorizationValue = _storedAuthorizationHeaderScheme is not null
                    ? $""{_storedAuthorizationHeaderScheme} {_storedAuthorizationApiKey}""
                    : _storedAuthorizationApiKey;
                _clientWebSocket.Options.SetRequestHeader(_storedAuthorizationHeaderName, __authorizationValue);
            }"
            : string.Empty;

        return $@"
        private void ApplyStoredAuthorization(
            bool useSubprotocolAuth)
        {{
{(hasSubprotocolAuth ? $@"            if (useSubprotocolAuth || _preferSubprotocolAuth)
            {{
{subprotocolBlocks}                return;
            }}
" : string.Empty)}{headerBlock}
        }}";
    }
}
