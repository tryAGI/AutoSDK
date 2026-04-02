//HintName: G.JsonConverters.GenerateStreamEnd.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GenerateStreamEndJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GenerateStreamEnd>
    {
        /// <inheritdoc />
        public override global::G.GenerateStreamEnd Read(
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
            if (__jsonProps.Contains("finish_reason")) __score1++;
            if (__jsonProps.Contains("is_finished")) __score1++;
            if (__jsonProps.Contains("response")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.GenerateStreamEvent? @event = default;
            global::G.GenerateStreamEndUbzr0t? ubzr0t = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamEvent).Name}");
                        @event = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEndUbzr0t), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEndUbzr0t> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamEndUbzr0t).Name}");
                        ubzr0t = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@event == null && ubzr0t == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamEvent).Name}");
                    @event = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEndUbzr0t), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEndUbzr0t> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamEndUbzr0t).Name}");
                    ubzr0t = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.GenerateStreamEnd(
                @event,

                ubzr0t
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GenerateStreamEnd value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Event!, typeInfo);
            }
            else if (value.IsUbzr0t)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEndUbzr0t), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEndUbzr0t?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamEndUbzr0t).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ubzr0t!, typeInfo);
            }
        }
    }
}