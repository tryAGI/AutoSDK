//HintName: G.JsonConverters.WebSocketRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class WebSocketRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebSocketRequest>
    {
        /// <inheritdoc />
        public override global::G.WebSocketRequest Read(
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
            if (__jsonProps.Contains("add_phoneme_timestamps")) __score0++;
            if (__jsonProps.Contains("add_timestamps")) __score0++;
            if (__jsonProps.Contains("context_id")) __score0++;
            if (__jsonProps.Contains("continue")) __score0++;
            if (__jsonProps.Contains("flush")) __score0++;
            if (__jsonProps.Contains("generation_config")) __score0++;
            if (__jsonProps.Contains("language")) __score0++;
            if (__jsonProps.Contains("max_buffer_delay_ms")) __score0++;
            if (__jsonProps.Contains("model_id")) __score0++;
            if (__jsonProps.Contains("output_format")) __score0++;
            if (__jsonProps.Contains("pronunciation_dict_id")) __score0++;
            if (__jsonProps.Contains("speed")) __score0++;
            if (__jsonProps.Contains("transcript")) __score0++;
            if (__jsonProps.Contains("use_normalized_timestamps")) __score0++;
            if (__jsonProps.Contains("voice")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("cancel")) __score1++;
            if (__jsonProps.Contains("context_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.GenerationRequest? generationRequest = default;
            global::G.CancelContextRequest? cancelContextRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                        generationRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CancelContextRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CancelContextRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CancelContextRequest).Name}");
                        cancelContextRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (generationRequest == null && cancelContextRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                    generationRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CancelContextRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CancelContextRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CancelContextRequest).Name}");
                    cancelContextRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.WebSocketRequest(
                generationRequest,

                cancelContextRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebSocketRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGenerationRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerationRequest, typeInfo);
            }
            else if (value.IsCancelContextRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CancelContextRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CancelContextRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CancelContextRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CancelContextRequest, typeInfo);
            }
        }
    }
}