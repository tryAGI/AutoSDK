//HintName: G.JsonConverters.CollectionTelemetryEnum.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CollectionTelemetryEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CollectionTelemetryEnum>
    {
        /// <inheritdoc />
        public override global::G.CollectionTelemetryEnum Read(
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
            if (__jsonProps.Contains("config")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("init_time_ms")) __score0++;
            if (__jsonProps.Contains("resharding")) __score0++;
            if (__jsonProps.Contains("shard_clean_tasks")) __score0++;
            if (__jsonProps.Contains("shards")) __score0++;
            if (__jsonProps.Contains("transfers")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("optimizers_status")) __score1++;
            if (__jsonProps.Contains("params")) __score1++;
            if (__jsonProps.Contains("vectors")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.CollectionTelemetry? value1 = default;
            global::G.CollectionsAggregatedTelemetry? value2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CollectionTelemetry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CollectionTelemetry> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CollectionTelemetry).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CollectionsAggregatedTelemetry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CollectionsAggregatedTelemetry> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CollectionsAggregatedTelemetry).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CollectionTelemetry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CollectionTelemetry> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CollectionTelemetry).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CollectionsAggregatedTelemetry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CollectionsAggregatedTelemetry> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CollectionsAggregatedTelemetry).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CollectionTelemetryEnum(
                value1,

                value2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CollectionTelemetryEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CollectionTelemetry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CollectionTelemetry?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CollectionTelemetry).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CollectionsAggregatedTelemetry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CollectionsAggregatedTelemetry?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CollectionsAggregatedTelemetry).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
        }
    }
}