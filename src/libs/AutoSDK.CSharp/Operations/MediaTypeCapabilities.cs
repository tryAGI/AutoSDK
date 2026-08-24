using AutoSDK.Extensions;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public enum MediaTypeKind
{
    Json,
    MultipartFormData,
    FormUrlEncoded,
    Binary,
    Text,
    SequentialJson,
    ServerSentEvents,
    AwsEventStream,
    MessagePack,
    Protobuf,
    VendorSpecific,
}

public enum MediaTypeTransportSupport
{
    Unsupported,
    Typed,
    Raw,
    Streaming,
}

public sealed class MediaTypeCapability
{
    public MediaTypeCapability(
        string mediaTypes,
        MediaTypeKind kind,
        MediaTypeTransportSupport request,
        MediaTypeTransportSupport response,
        string notes)
    {
        MediaTypes = mediaTypes;
        Kind = kind;
        Request = request;
        Response = response;
        Notes = notes;
    }

    public string MediaTypes { get; }
    public MediaTypeKind Kind { get; }
    public MediaTypeTransportSupport Request { get; }
    public MediaTypeTransportSupport Response { get; }
    public string Notes { get; }
}

/// <summary>
/// Describes the wire representations that AutoSDK can faithfully encode and decode.
/// Representation planners, diagnostics, audit output, and the checked-in capability
/// documentation all consume this contract.
/// </summary>
public static class MediaTypeCapabilities
{
    private static readonly MediaTypeCapability[] s_matrix =
    [
        new("application/json, text/json, application/*+json", MediaTypeKind.Json,
            MediaTypeTransportSupport.Typed, MediaTypeTransportSupport.Typed,
            "Typed JSON serialization and deserialization; equivalent vendor JSON types are deduplicated."),
        new("multipart/form-data", MediaTypeKind.MultipartFormData,
            MediaTypeTransportSupport.Typed, MediaTypeTransportSupport.Unsupported,
            "Typed request parts, including repeated and binary file parts."),
        new("application/x-www-form-urlencoded", MediaTypeKind.FormUrlEncoded,
            MediaTypeTransportSupport.Typed, MediaTypeTransportSupport.Unsupported,
            "Typed request properties are emitted as form fields."),
        new("application/octet-stream, application/zip, application/pdf, image/*, audio/*, video/*, font/*",
            MediaTypeKind.Binary, MediaTypeTransportSupport.Raw, MediaTypeTransportSupport.Raw,
            "Raw string or byte-array request transport and byte-array responses; response stream companions are generated."),
        new("text/* except text/event-stream and text/json", MediaTypeKind.Text,
            MediaTypeTransportSupport.Raw, MediaTypeTransportSupport.Raw,
            "Raw string request and response transport."),
        new("application/x-ndjson, application/jsonl, application/json-seq", MediaTypeKind.SequentialJson,
            MediaTypeTransportSupport.Typed, MediaTypeTransportSupport.Streaming,
            "Typed newline-delimited or record-separated JSON."),
        new("text/event-stream", MediaTypeKind.ServerSentEvents,
            MediaTypeTransportSupport.Unsupported, MediaTypeTransportSupport.Streaming,
            "Typed server-sent event response stream."),
        new("application/vnd.amazon.eventstream", MediaTypeKind.AwsEventStream,
            MediaTypeTransportSupport.Unsupported, MediaTypeTransportSupport.Streaming,
            "AWS event-stream response framing."),
        new("application/msgpack, application/x-msgpack", MediaTypeKind.MessagePack,
            MediaTypeTransportSupport.Raw, MediaTypeTransportSupport.Raw,
            "Raw byte pass-through only; typed MessagePack codecs are not generated."),
        new("application/protobuf, application/x-protobuf, application/vnd.google.protobuf", MediaTypeKind.Protobuf,
            MediaTypeTransportSupport.Raw, MediaTypeTransportSupport.Raw,
            "Raw byte pass-through only; typed protobuf codecs are not generated."),
        new("Other vendor-specific media types", MediaTypeKind.VendorSpecific,
            MediaTypeTransportSupport.Raw, MediaTypeTransportSupport.Raw,
            "Raw string or byte-array pass-through only; typed provider-specific codecs are not generated."),
    ];

    public static IReadOnlyList<MediaTypeCapability> Matrix => s_matrix;

    public static string GenerateMarkdown()
    {
        var lines = new List<string>
        {
            "# Media type capabilities",
            string.Empty,
            "AutoSDK representation planners use this matrix to select only wire formats the generated client can encode or decode faithfully.",
            string.Empty,
            "| Media types | Request | Response | Notes |",
            "| --- | --- | --- | --- |",
        };
        lines.AddRange(s_matrix.Select(static capability =>
            $"| {capability.MediaTypes} | {capability.Request} | {capability.Response} | {capability.Notes} |"));
        lines.Add(string.Empty);
        lines.Add("Raw request support requires a matching string or binary schema. MessagePack, protobuf, and provider-specific typed codecs are intentionally not synthesized; use raw text/bytes or add a JSON/form representation.");
        lines.Add(string.Empty);
        return string.Join("\n", lines);
    }

    public static MediaTypeKind Classify(string? mediaType)
    {
        var normalized = mediaType.NormalizeMimeType();
        if (normalized.IsJsonMimeType())
        {
            return MediaTypeKind.Json;
        }

        if (normalized.IsSequentialJsonMimeType())
        {
            return MediaTypeKind.SequentialJson;
        }

        if (normalized.IsServerSentEventsMimeType())
        {
            return MediaTypeKind.ServerSentEvents;
        }

        if (normalized.IsAwsEventStreamMimeType())
        {
            return MediaTypeKind.AwsEventStream;
        }

        if (normalized.IsMimeType("multipart/form-data"))
        {
            return MediaTypeKind.MultipartFormData;
        }

        if (normalized.IsMimeType("application/x-www-form-urlencoded"))
        {
            return MediaTypeKind.FormUrlEncoded;
        }

        if (IsMessagePack(normalized))
        {
            return MediaTypeKind.MessagePack;
        }

        if (IsProtobuf(normalized))
        {
            return MediaTypeKind.Protobuf;
        }

        if (normalized.IsBinaryResponseMimeType())
        {
            return MediaTypeKind.Binary;
        }

        if (normalized.StartsWith("text/", StringComparison.OrdinalIgnoreCase))
        {
            return MediaTypeKind.Text;
        }

        return MediaTypeKind.VendorSpecific;
    }

    public static MediaTypeTransportSupport GetRequestSupport(string? mediaType)
    {
        return Classify(mediaType) switch
        {
            MediaTypeKind.Json or
            MediaTypeKind.MultipartFormData or
            MediaTypeKind.FormUrlEncoded or
            MediaTypeKind.SequentialJson => MediaTypeTransportSupport.Typed,
            MediaTypeKind.Binary or
            MediaTypeKind.Text or
            MediaTypeKind.MessagePack or
            MediaTypeKind.Protobuf or
            MediaTypeKind.VendorSpecific => MediaTypeTransportSupport.Raw,
            _ => MediaTypeTransportSupport.Unsupported,
        };
    }

    public static MediaTypeTransportSupport GetResponseSupport(string? mediaType)
    {
        return Classify(mediaType) switch
        {
            MediaTypeKind.Json => MediaTypeTransportSupport.Typed,
            MediaTypeKind.SequentialJson or
            MediaTypeKind.ServerSentEvents or
            MediaTypeKind.AwsEventStream => MediaTypeTransportSupport.Streaming,
            MediaTypeKind.Binary or
            MediaTypeKind.Text or
            MediaTypeKind.MessagePack or
            MediaTypeKind.Protobuf or
            MediaTypeKind.VendorSpecific => MediaTypeTransportSupport.Raw,
            _ => MediaTypeTransportSupport.Unsupported,
        };
    }

    public static bool CanEncodeRequest(string? mediaType, IOpenApiSchema? schema)
    {
        if (schema == null && GetRequestSupport(mediaType) == MediaTypeTransportSupport.Raw)
        {
            return true;
        }

        return GetRequestSupport(mediaType) switch
        {
            MediaTypeTransportSupport.Typed => true,
            MediaTypeTransportSupport.Raw when Classify(mediaType) is MediaTypeKind.MessagePack or MediaTypeKind.Protobuf =>
                RequestRepresentationPlanner.ContainsBinary(schema),
            MediaTypeTransportSupport.Raw => IsRawTextSchema(schema) || RequestRepresentationPlanner.ContainsBinary(schema),
            _ => false,
        };
    }

    public static string GetRequestLimitation(string mediaType, IOpenApiSchema? schema)
    {
        var support = GetRequestSupport(mediaType);
        var expected = support == MediaTypeTransportSupport.Raw
            ? Classify(mediaType) is MediaTypeKind.MessagePack or MediaTypeKind.Protobuf
                ? "a binary schema for raw byte pass-through"
                : "a string or binary schema for raw pass-through"
            : "a supported typed request encoder";
        var schemaDescription = schema == null ? "no schema" : "a typed non-raw schema";
        return $"AutoSDK cannot encode request media type '{mediaType}' with {schemaDescription}. " +
               $"This media type requires {expected}; add a supported representation or pass raw content.";
    }

    public static bool IsRawTextSchema(IOpenApiSchema? schema)
    {
        if (schema == null)
        {
            return false;
        }

        var resolved = schema.ResolveIfRequired();
        return !resolved.IsBinary() &&
               (resolved.Type & JsonSchemaType.String) == JsonSchemaType.String;
    }

    private static bool IsMessagePack(string mediaType)
    {
        return mediaType.Equals("application/msgpack", StringComparison.OrdinalIgnoreCase) ||
               mediaType.Equals("application/x-msgpack", StringComparison.OrdinalIgnoreCase) ||
               mediaType.EndsWith("+msgpack", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsProtobuf(string mediaType)
    {
        return mediaType.Equals("application/protobuf", StringComparison.OrdinalIgnoreCase) ||
               mediaType.Equals("application/x-protobuf", StringComparison.OrdinalIgnoreCase) ||
               mediaType.Equals("application/vnd.google.protobuf", StringComparison.OrdinalIgnoreCase) ||
               mediaType.EndsWith("+protobuf", StringComparison.OrdinalIgnoreCase) ||
               mediaType.EndsWith("+proto", StringComparison.OrdinalIgnoreCase);
    }
}
