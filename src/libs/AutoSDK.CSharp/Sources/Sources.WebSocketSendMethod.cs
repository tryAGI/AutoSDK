using System;
using System.Linq;
using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static FileWithName WebSocketSendMethod(
        WebSocketEndPoint endPoint,
        ModelData messageModel = default,
        CancellationToken cancellationToken = default)
    {
        var text = GenerateWebSocketSendMethod(endPoint, messageModel);
        if (string.IsNullOrWhiteSpace(text))
        {
            return FileWithName.Empty;
        }

        return new FileWithName(
            Name: $"{endPoint.FileNameWithoutExtension}.g.cs",
            Text: text);
    }

    public static string GenerateWebSocketSendMethod(
        WebSocketEndPoint endPoint,
        ModelData messageModel = default)
    {
        var hasOptions = !endPoint.Settings.HasJsonSerializerContext();
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

        var convenienceOverload = GenerateWebSocketBinaryPayloadOverload(endPoint, messageModel);

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
{(!string.IsNullOrWhiteSpace(convenienceOverload) ? convenienceOverload : TrimmedLine)}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateWebSocketBinaryPayloadOverload(
        WebSocketEndPoint endPoint,
        ModelData messageModel)
    {
        if (string.IsNullOrWhiteSpace(messageModel.ClassName))
        {
            return string.Empty;
        }

        var binaryProperties = GetWebSocketBinaryPayloadProperties(messageModel);
        if (binaryProperties.Length != 1)
        {
            return string.Empty;
        }

        var binaryProperty = binaryProperties[0];
        var otherProperties = messageModel.Properties
            .Where(x => x.Name != binaryProperty.Name && !x.IsReadOnly)
            .ToArray();
        var requiredProperties = otherProperties
            .Where(x => x.IsRequired)
            .ToArray();
        var optionalProperties = otherProperties
            .Where(x => !x.IsRequired)
            .ToArray();
        var overloadParameters = string.Join(
            ",\n",
            new[]
            {
                $"            global::System.ReadOnlyMemory<byte> {binaryProperty.ParameterName}",
            }.Concat(requiredProperties.Select(property =>
                $"            {property.Type.CSharpType} {property.ParameterName}"))
            .Concat(optionalProperties.Select(property =>
                $"            {property.Type.CSharpType} {property.ParameterName}{GetWebSocketOptionalParameterDefaultValue(property)}"))
            .Concat([
                "            global::System.Threading.CancellationToken cancellationToken = default",
            ]));
        var assignments = string.Join(
            "\n",
            new[]
            {
                $"                {binaryProperty.Name} = {GetWebSocketBinaryPayloadAssignment(binaryProperty)}",
            }.Concat(otherProperties.Select(property =>
                $"                {property.Name} = {property.ParameterName},")));
        var otherParameterDocumentation = requiredProperties
            .Concat(optionalProperties)
            .Select(property => $@"        /// <param name=""{property.ParameterName}"">{(property.Description ?? property.Summary).ClearForXml()}</param>
")
            .Inject();

        return $@"

        {binaryProperty.Description.ToXmlDocumentationSummary(level: 8)}
        /// <param name=""{binaryProperty.ParameterName}"">The binary payload to send.</param>
{otherParameterDocumentation}
        /// <param name=""cancellationToken"">A cancellation token.</param>
        public global::System.Threading.Tasks.Task {endPoint.MethodName}(
{overloadParameters})
        {{
            return {endPoint.MethodName}(
                new {messageModel.GlobalClassName}
                {{
{assignments}
                }},
                cancellationToken);
        }}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GetWebSocketBinaryPayloadAssignment(PropertyData property)
    {
        return string.Equals(property.Type.CSharpTypeWithoutNullability, "byte[]", StringComparison.Ordinal)
            ? $"{property.ParameterName}.ToArray(),"
            : $"global::System.Convert.ToBase64String({property.ParameterName}.Span),";
    }

    private static string GetWebSocketOptionalParameterDefaultValue(PropertyData property)
    {
        return !property.Type.IsValueType && !property.Type.CSharpTypeNullability
            ? " = default!"
            : " = default";
    }
}
