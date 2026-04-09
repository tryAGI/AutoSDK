//HintName: G.JsonConverters.FunctionCallOutputItemOutputOneOf1Items.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FunctionCallOutputItemOutputOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FunctionCallOutputItemOutputOneOf1Items>
    {
        /// <inheritdoc />
        public override global::G.FunctionCallOutputItemOutputOneOf1Items Read(
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
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("detail")) __score1++;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("file_data")) __score2++;
            if (__jsonProps.Contains("file_id")) __score2++;
            if (__jsonProps.Contains("file_url")) __score2++;
            if (__jsonProps.Contains("filename")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.InputText? inputText = default;
            global::G.FunctionCallOutputItemOutputOneOf1Items1? functionCallOutputItemOutputOneOf1Items1 = default;
            global::G.InputFile? inputFile = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputText).Name}");
                        inputText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallOutputItemOutputOneOf1Items1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallOutputItemOutputOneOf1Items1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionCallOutputItemOutputOneOf1Items1).Name}");
                        functionCallOutputItemOutputOneOf1Items1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputFile> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputFile).Name}");
                        inputFile = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputText == null && functionCallOutputItemOutputOneOf1Items1 == null && inputFile == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputText).Name}");
                    inputText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallOutputItemOutputOneOf1Items1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallOutputItemOutputOneOf1Items1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionCallOutputItemOutputOneOf1Items1).Name}");
                    functionCallOutputItemOutputOneOf1Items1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputFile> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputFile).Name}");
                    inputFile = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FunctionCallOutputItemOutputOneOf1Items(
                inputText,

                functionCallOutputItemOutputOneOf1Items1,

                inputFile
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FunctionCallOutputItemOutputOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputText!, typeInfo);
            }
            else if (value.IsFunctionCallOutputItemOutputOneOf1Items1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FunctionCallOutputItemOutputOneOf1Items1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FunctionCallOutputItemOutputOneOf1Items1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FunctionCallOutputItemOutputOneOf1Items1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutputItemOutputOneOf1Items1!, typeInfo);
            }
            else if (value.IsInputFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFile!, typeInfo);
            }
        }
    }
}