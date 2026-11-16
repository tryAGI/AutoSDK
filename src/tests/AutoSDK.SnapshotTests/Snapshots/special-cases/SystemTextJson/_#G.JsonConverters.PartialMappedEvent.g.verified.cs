//HintName: G.JsonConverters.PartialMappedEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PartialMappedEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PartialMappedEvent>
    {
        /// <inheritdoc />
        public override global::G.PartialMappedEvent Read(
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
            if (__jsonProps.Contains("kind")) __score0++;
            if (__jsonProps.Contains("startedAt")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("kind")) __score1++;
            if (__jsonProps.Contains("reason")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.MappedStartEvent? start = default;
            global::G.MappedStopEvent? stop = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MappedStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MappedStartEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MappedStartEvent).Name}");
                        start = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MappedStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MappedStopEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MappedStopEvent).Name}");
                        stop = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (start == null && stop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MappedStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MappedStartEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MappedStartEvent).Name}");
                    start = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (start == null && stop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MappedStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MappedStopEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MappedStopEvent).Name}");
                    stop = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::G.PartialMappedEvent(
                start,

                stop
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PartialMappedEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MappedStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MappedStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MappedStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickStart(), typeInfo);
            }
            else if (value.IsStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MappedStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MappedStopEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MappedStopEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickStop(), typeInfo);
            }
        }
    }
}