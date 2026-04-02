//HintName: G.JsonConverters.ChatDebugEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatDebugEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatDebugEvent>
    {
        /// <inheritdoc />
        public override global::G.ChatDebugEvent Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("prompt")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ChatStreamEvent? stream = default;
            global::G.ChatDebugEvent352j0t? event352j0t = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEvent).Name}");
                        stream = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatDebugEvent352j0t), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatDebugEvent352j0t> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatDebugEvent352j0t).Name}");
                        event352j0t = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (stream == null && event352j0t == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEvent).Name}");
                    stream = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatDebugEvent352j0t), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatDebugEvent352j0t> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatDebugEvent352j0t).Name}");
                    event352j0t = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatDebugEvent(
                stream,

                event352j0t
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatDebugEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStream)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stream!, typeInfo);
            }
            else if (value.IsEvent352j0t)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatDebugEvent352j0t), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatDebugEvent352j0t?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatDebugEvent352j0t).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Event352j0t!, typeInfo);
            }
        }
    }
}