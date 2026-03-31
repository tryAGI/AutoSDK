//HintName: G.JsonConverters.ScholarSearchRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ScholarSearchRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ScholarSearchRequest>
    {
        /// <inheritdoc />
        public override global::G.ScholarSearchRequest Read(
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
            if (__jsonProps.Contains("autocorrect")) __score0++;
            if (__jsonProps.Contains("gl")) __score0++;
            if (__jsonProps.Contains("hl")) __score0++;
            if (__jsonProps.Contains("num")) __score0++;
            if (__jsonProps.Contains("page")) __score0++;
            if (__jsonProps.Contains("q")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("as_yhi")) __score1++;
            if (__jsonProps.Contains("as_ylo")) __score1++;
            if (__jsonProps.Contains("cites")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.BaseSearchRequest? value1 = default;
            global::G.ScholarSearchRequestVariant2? value2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseSearchRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseSearchRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseSearchRequest).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ScholarSearchRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ScholarSearchRequestVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ScholarSearchRequestVariant2).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseSearchRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseSearchRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseSearchRequest).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ScholarSearchRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ScholarSearchRequestVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ScholarSearchRequestVariant2).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ScholarSearchRequest(
                value1,

                value2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ScholarSearchRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseSearchRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseSearchRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseSearchRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ScholarSearchRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ScholarSearchRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ScholarSearchRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
        }
    }
}