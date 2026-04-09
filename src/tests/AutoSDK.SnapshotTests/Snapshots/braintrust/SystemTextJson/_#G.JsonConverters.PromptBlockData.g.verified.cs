//HintName: G.JsonConverters.PromptBlockData.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PromptBlockDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PromptBlockData>
    {
        /// <inheritdoc />
        public override global::G.PromptBlockData Read(
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
            if (__jsonProps.Contains("messages")) __score0++;
            if (__jsonProps.Contains("tools")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.PromptBlockDataChat? chat = default;
            global::G.PromptBlockDataCompletion? completion = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptBlockDataChat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptBlockDataChat> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptBlockDataChat).Name}");
                        chat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptBlockDataCompletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptBlockDataCompletion> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptBlockDataCompletion).Name}");
                        completion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chat == null && completion == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptBlockDataChat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptBlockDataChat> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptBlockDataChat).Name}");
                    chat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptBlockDataCompletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptBlockDataCompletion> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptBlockDataCompletion).Name}");
                    completion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.PromptBlockData(
                chat,

                completion
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PromptBlockData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptBlockDataChat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptBlockDataChat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptBlockDataChat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat!, typeInfo);
            }
            else if (value.IsCompletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptBlockDataCompletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptBlockDataCompletion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptBlockDataCompletion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion!, typeInfo);
            }
        }
    }
}