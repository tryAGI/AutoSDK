using AutoSDK.Extensions;
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
        var hasOptions = string.IsNullOrWhiteSpace(wsClient.Settings.JsonSerializerContext);

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

        private readonly global::System.Net.WebSockets.ClientWebSocket _clientWebSocket;

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

        /// <inheritdoc cref=""global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)""/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            uri ??= new global::System.Uri(DefaultBaseUrl);

            await _clientWebSocket.ConnectAsync(uri, cancellationToken).ConfigureAwait(false);
        }}

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
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateWebSocketAuthorizationConstructors(WebSocketClient wsClient)
    {
        var result = new System.Text.StringBuilder();

        foreach (var auth in wsClient.Authorizations)
        {
            if (auth.Type == SecuritySchemeType.Http &&
                string.Equals(auth.Scheme, "bearer", StringComparison.OrdinalIgnoreCase))
            {
                result.AppendLine($@"
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name=""apiKey""></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _clientWebSocket.Options.SetRequestHeader(""Authorization"", $""Bearer {{apiKey}}"");
        }}

        /// <summary>
        /// Creates a new instance with bearer token authentication.
        /// </summary>
        /// <param name=""apiKey""></param>
        /// <param name=""clientWebSocket""></param>
        public {wsClient.ClassName}(
            string apiKey,
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null) : this(clientWebSocket)
        {{
            Authorizing(_clientWebSocket, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_clientWebSocket);
        }}");
            }
            else if (auth.Type == SecuritySchemeType.ApiKey &&
                     auth.In == ParameterLocation.Header)
            {
                result.AppendLine($@"
        /// <summary>
        /// Authorize using API key in header.
        /// </summary>
        /// <param name=""apiKey""></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _clientWebSocket.Options.SetRequestHeader(""{auth.Name}"", apiKey);
        }}

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
        }}");
            }
            else if (auth.Type == SecuritySchemeType.ApiKey &&
                     auth.In == ParameterLocation.Query)
            {
                result.AppendLine($@"
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
        }}

        private string? _queryApiKey;
        private string? _queryApiKeyName;");
            }
        }

        return result.ToString();
    }
}
