//HintName: G.JsonConverters.CreateResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateResponse>
    {
        /// <inheritdoc />
        public override global::G.CreateResponse Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("background")) __score1++;
            if (__jsonProps.Contains("max_output_tokens")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("previous_response_id")) __score1++;
            if (__jsonProps.Contains("prompt")) __score1++;
            if (__jsonProps.Contains("reasoning")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            if (__jsonProps.Contains("tool_choice")) __score1++;
            if (__jsonProps.Contains("tools")) __score1++;
            if (__jsonProps.Contains("truncation")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("include")) __score2++;
            if (__jsonProps.Contains("input")) __score2++;
            if (__jsonProps.Contains("instructions")) __score2++;
            if (__jsonProps.Contains("parallel_tool_calls")) __score2++;
            if (__jsonProps.Contains("store")) __score2++;
            if (__jsonProps.Contains("stream")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.CreateModelResponseProperties? modelProperties = default;
            global::G.ResponseProperties? properties = default;
            global::G.CreateResponseVariant3? createResponseVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModelResponseProperties> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateModelResponseProperties).Name}");
                        modelProperties = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseProperties> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseProperties).Name}");
                        properties = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateResponseVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateResponseVariant3).Name}");
                        createResponseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (modelProperties == null && properties == null && createResponseVariant3 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModelResponseProperties> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateModelResponseProperties).Name}");
                    modelProperties = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseProperties> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseProperties).Name}");
                    properties = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateResponseVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateResponseVariant3).Name}");
                    createResponseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateResponse(
                modelProperties,

                properties,

                createResponseVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsModelProperties)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateModelResponseProperties).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelProperties!.Value, typeInfo);
            }
            else if (value.IsProperties)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseProperties?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseProperties).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Properties!, typeInfo);
            }
            else if (value.IsCreateResponseVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateResponseVariant3!, typeInfo);
            }
        }
    }
}