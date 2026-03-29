//HintName: G.JsonConverters.AnalysisData.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AnalysisDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AnalysisData>
    {
        /// <inheritdoc />
        public override global::G.AnalysisData Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("examples")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("required")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("choices")) __score1++;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("required")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("required")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("description")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("required")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.StringAnalysisData? @string = default;
            global::G.EnumAnalysisData? @enum = default;
            global::G.BooleanAnalysisData? boolean = default;
            global::G.NumberAnalysisData? number = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StringAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StringAnalysisData> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StringAnalysisData).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EnumAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EnumAnalysisData> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EnumAnalysisData).Name}");
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BooleanAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BooleanAnalysisData> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BooleanAnalysisData).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NumberAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NumberAnalysisData> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NumberAnalysisData).Name}");
                        number = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@string == null && @enum == null && boolean == null && number == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StringAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StringAnalysisData> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StringAnalysisData).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EnumAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EnumAnalysisData> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EnumAnalysisData).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BooleanAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BooleanAnalysisData> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BooleanAnalysisData).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NumberAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NumberAnalysisData> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NumberAnalysisData).Name}");
                    number = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AnalysisData(
                @string,

                @enum,

                boolean,

                number
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AnalysisData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StringAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StringAnalysisData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StringAnalysisData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String, typeInfo);
            }
            else if (value.IsEnum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EnumAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EnumAnalysisData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EnumAnalysisData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum, typeInfo);
            }
            else if (value.IsBoolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BooleanAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BooleanAnalysisData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BooleanAnalysisData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Boolean, typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NumberAnalysisData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NumberAnalysisData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NumberAnalysisData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Number, typeInfo);
            }
        }
    }
}