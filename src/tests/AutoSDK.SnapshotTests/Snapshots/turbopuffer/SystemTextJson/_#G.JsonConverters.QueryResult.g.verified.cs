//HintName: G.JsonConverters.QueryResult.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class QueryResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.QueryResult>
    {
        /// <inheritdoc />
        public override global::G.QueryResult Read(
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
            if (__jsonProps.Contains("aggregation_groups")) __score0++;
            if (__jsonProps.Contains("aggregations")) __score0++;
            if (__jsonProps.Contains("rows")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("billing")) __score1++;
            if (__jsonProps.Contains("performance")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.SingleQueryResult? single = default;
            global::G.QueryResultVariant2? queryResultVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SingleQueryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SingleQueryResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SingleQueryResult).Name}");
                        single = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryResultVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryResultVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.QueryResultVariant2).Name}");
                        queryResultVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (single == null && queryResultVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SingleQueryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SingleQueryResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SingleQueryResult).Name}");
                    single = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryResultVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryResultVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.QueryResultVariant2).Name}");
                    queryResultVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.QueryResult(
                single,

                queryResultVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.QueryResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSingle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SingleQueryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SingleQueryResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SingleQueryResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Single!, typeInfo);
            }
            else if (value.IsQueryResultVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.QueryResultVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.QueryResultVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.QueryResultVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueryResultVariant2!, typeInfo);
            }
        }
    }
}