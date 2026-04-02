//HintName: G.JsonConverters.ChatContentEndEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatContentEndEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatContentEndEvent>
    {
        /// <inheritdoc />
        public override global::G.ChatContentEndEvent Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("index")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ChatStreamEventType? streamType = default;
            global::G.ChatContentEndEventMa278i? ma278i = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEventType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEventType> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEventType).Name}");
                        streamType = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentEndEventMa278i), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentEndEventMa278i> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentEndEventMa278i).Name}");
                        ma278i = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (streamType == null && ma278i == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEventType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEventType> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEventType).Name}");
                    streamType = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentEndEventMa278i), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentEndEventMa278i> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentEndEventMa278i).Name}");
                    ma278i = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatContentEndEvent(
                streamType,

                ma278i
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatContentEndEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEventType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEventType?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEventType).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamType!, typeInfo);
            }
            else if (value.IsMa278i)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentEndEventMa278i), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentEndEventMa278i?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentEndEventMa278i).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ma278i!, typeInfo);
            }
        }
    }
}