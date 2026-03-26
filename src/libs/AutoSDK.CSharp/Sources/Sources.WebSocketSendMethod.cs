using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static FileWithName WebSocketSendMethod(
        WebSocketEndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{endPoint.FileNameWithoutExtension}.g.cs",
            Text: GenerateWebSocketSendMethod(endPoint));
    }

    public static string GenerateWebSocketSendMethod(
        WebSocketEndPoint endPoint)
    {
        var hasOptions = string.IsNullOrWhiteSpace(endPoint.Settings.JsonSerializerContext);
        var messageTypeName = endPoint.MessageType.CSharpType;

        if (string.IsNullOrWhiteSpace(messageTypeName))
        {
            return string.Empty;
        }

        // CSharpType already includes global:: prefix and nullable suffix
        var nonNullableType = endPoint.MessageType.CSharpTypeWithoutNullability;

        var serializeCall = hasOptions
            ? $"global::System.Text.Json.JsonSerializer.Serialize(message, typeof({nonNullableType}), JsonSerializerOptions)"
            : $"global::System.Text.Json.JsonSerializer.Serialize(message, typeof({nonNullableType}), JsonSerializerContext)";

        return $@"
#nullable enable

namespace {endPoint.Settings.Namespace}
{{
    public sealed partial class {endPoint.ClassName}
    {{
        {endPoint.Summary.ToXmlDocumentationSummary(level: 8)}
        /// <param name=""message"">The message to send.</param>
        /// <param name=""cancellationToken"">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task {endPoint.MethodName}(
            {nonNullableType} message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = {serializeCall};

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
