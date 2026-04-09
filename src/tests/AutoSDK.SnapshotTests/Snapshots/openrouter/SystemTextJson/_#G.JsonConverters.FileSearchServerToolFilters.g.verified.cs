//HintName: G.JsonConverters.FileSearchServerToolFilters.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FileSearchServerToolFiltersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FileSearchServerToolFilters>
    {
        /// <inheritdoc />
        public override global::G.FileSearchServerToolFilters Read(
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
            if (__jsonProps.Contains("key")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("filters")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.FileSearchServerToolFilters0? fileSearchServerToolFilters0 = default;
            global::G.CompoundFilter? compoundFilter = default;
            object? fileSearchServerToolFiltersVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchServerToolFilters0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchServerToolFilters0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchServerToolFilters0).Name}");
                        fileSearchServerToolFilters0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompoundFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompoundFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompoundFilter).Name}");
                        compoundFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        fileSearchServerToolFiltersVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (fileSearchServerToolFilters0 == null && compoundFilter == null && fileSearchServerToolFiltersVariant3 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchServerToolFilters0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchServerToolFilters0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchServerToolFilters0).Name}");
                    fileSearchServerToolFilters0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompoundFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompoundFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompoundFilter).Name}");
                    compoundFilter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    fileSearchServerToolFiltersVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FileSearchServerToolFilters(
                fileSearchServerToolFilters0,

                compoundFilter,

                fileSearchServerToolFiltersVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FileSearchServerToolFilters value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFileSearchServerToolFilters0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FileSearchServerToolFilters0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FileSearchServerToolFilters0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FileSearchServerToolFilters0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchServerToolFilters0!, typeInfo);
            }
            else if (value.IsCompoundFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompoundFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompoundFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompoundFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompoundFilter!, typeInfo);
            }
            else if (value.IsFileSearchServerToolFiltersVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchServerToolFiltersVariant3!, typeInfo);
            }
        }
    }
}