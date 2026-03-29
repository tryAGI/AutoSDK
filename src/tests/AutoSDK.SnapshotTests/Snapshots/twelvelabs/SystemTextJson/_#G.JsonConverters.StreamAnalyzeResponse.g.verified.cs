//HintName: G.JsonConverters.StreamAnalyzeResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class StreamAnalyzeResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StreamAnalyzeResponse>
    {
        /// <inheritdoc />
        public override global::G.StreamAnalyzeResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("event_type")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("event_type")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("event_type")) __score2++;
            if (__jsonProps.Contains("finish_reason")) __score2++;
            if (__jsonProps.Contains("metadata")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.StreamStartResponse? streamStartResponse = default;
            global::G.StreamTextResponse? streamTextResponse = default;
            global::G.StreamEndResponse? streamEndResponse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamStartResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamStartResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamStartResponse).Name}");
                        streamStartResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamTextResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamTextResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamTextResponse).Name}");
                        streamTextResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamEndResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamEndResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamEndResponse).Name}");
                        streamEndResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (streamStartResponse == null && streamTextResponse == null && streamEndResponse == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamStartResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamStartResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamStartResponse).Name}");
                    streamStartResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamTextResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamTextResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamTextResponse).Name}");
                    streamTextResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamEndResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamEndResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamEndResponse).Name}");
                    streamEndResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.StreamAnalyzeResponse(
                streamStartResponse,

                streamTextResponse,

                streamEndResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.StreamAnalyzeResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamStartResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamStartResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamStartResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamStartResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamStartResponse, typeInfo);
            }
            else if (value.IsStreamTextResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamTextResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamTextResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamTextResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamTextResponse, typeInfo);
            }
            else if (value.IsStreamEndResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamEndResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamEndResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamEndResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEndResponse, typeInfo);
            }
        }
    }
}