//HintName: G.JsonConverters.ApplicationInputOptions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ApplicationInputOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ApplicationInputOptions>
    {
        /// <inheritdoc />
        public override global::G.ApplicationInputOptions Read(
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
            if (__jsonProps.Contains("list")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("file_types")) __score1++;
            if (__jsonProps.Contains("max_file_size_mb")) __score1++;
            if (__jsonProps.Contains("max_files")) __score1++;
            if (__jsonProps.Contains("max_word_count")) __score1++;
            if (__jsonProps.Contains("upload_types")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("file_types")) __score2++;
            if (__jsonProps.Contains("max_image_size_mb")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("max_fields")) __score3++;
            if (__jsonProps.Contains("min_fields")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.ApplicationInputDropdownOptions? dropdown = default;
            global::G.ApplicationInputFileOptions? file = default;
            global::G.ApplicationInputMediaOptions? media = default;
            global::G.ApplicationInputTextOptions? text = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputDropdownOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputDropdownOptions> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputDropdownOptions).Name}");
                        dropdown = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputFileOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputFileOptions> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputFileOptions).Name}");
                        file = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputMediaOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputMediaOptions> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputMediaOptions).Name}");
                        media = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputTextOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputTextOptions> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputTextOptions).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (dropdown == null && file == null && media == null && text == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputDropdownOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputDropdownOptions> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputDropdownOptions).Name}");
                    dropdown = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputFileOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputFileOptions> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputFileOptions).Name}");
                    file = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputMediaOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputMediaOptions> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputMediaOptions).Name}");
                    media = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputTextOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputTextOptions> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputTextOptions).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ApplicationInputOptions(
                dropdown,

                file,

                media,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ApplicationInputOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDropdown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputDropdownOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputDropdownOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputDropdownOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dropdown!, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputFileOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputFileOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputFileOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File!, typeInfo);
            }
            else if (value.IsMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputMediaOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputMediaOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputMediaOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Media!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplicationInputTextOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplicationInputTextOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplicationInputTextOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}