//HintName: G.JsonConverters.ValueFilter.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ValueFilterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ValueFilter>
    {
        /// <inheritdoc />
        public override global::G.ValueFilter Read(
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
            if (__jsonProps.Contains("op")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("op")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("op")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("op")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("op")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("op")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.StringFilter? @string = default;
            global::G.NumberFilter? number = default;
            global::G.BooleanFilter? boolean = default;
            global::G.RangeFilter? range = default;
            global::G.EnumFilter? @enum = default;
            global::G.PresentFilter? present = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StringFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StringFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StringFilter).Name}");
                        @string = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NumberFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NumberFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NumberFilter).Name}");
                        number = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BooleanFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BooleanFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BooleanFilter).Name}");
                        boolean = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RangeFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RangeFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RangeFilter).Name}");
                        range = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EnumFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EnumFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EnumFilter).Name}");
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PresentFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PresentFilter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PresentFilter).Name}");
                        present = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@string == null && number == null && boolean == null && range == null && @enum == null && present == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StringFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StringFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StringFilter).Name}");
                    @string = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NumberFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NumberFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NumberFilter).Name}");
                    number = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BooleanFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BooleanFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BooleanFilter).Name}");
                    boolean = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RangeFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RangeFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RangeFilter).Name}");
                    range = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EnumFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EnumFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EnumFilter).Name}");
                    @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PresentFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PresentFilter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PresentFilter).Name}");
                    present = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ValueFilter(
                @string,

                number,

                boolean,

                range,

                @enum,

                present
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ValueFilter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StringFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StringFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StringFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String!, typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NumberFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NumberFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NumberFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Number!, typeInfo);
            }
            else if (value.IsBoolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BooleanFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BooleanFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BooleanFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Boolean!, typeInfo);
            }
            else if (value.IsRange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RangeFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RangeFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RangeFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Range!, typeInfo);
            }
            else if (value.IsEnum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EnumFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EnumFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EnumFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum!, typeInfo);
            }
            else if (value.IsPresent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PresentFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PresentFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PresentFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Present!, typeInfo);
            }
        }
    }
}