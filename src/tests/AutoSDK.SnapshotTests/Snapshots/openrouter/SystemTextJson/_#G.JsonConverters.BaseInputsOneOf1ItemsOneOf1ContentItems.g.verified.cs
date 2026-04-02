//HintName: G.JsonConverters.BaseInputsOneOf1ItemsOneOf1ContentItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseInputsOneOf1ItemsOneOf1ContentItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseInputsOneOf1ItemsOneOf1ContentItems>
    {
        /// <inheritdoc />
        public override global::G.BaseInputsOneOf1ItemsOneOf1ContentItems Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

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
            var __score3 = 0;
            if (__jsonProps.Contains("input_audio")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.InputText? inputText = default;
            global::G.InputImage? inputImage = default;
            global::G.InputFile? inputFile = default;
            global::G.InputAudio? inputAudio = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        inputText = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputText>(__rawJson, options);
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
                        inputImage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputImage>(__rawJson, options);
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
                        inputFile = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputFile>(__rawJson, options);
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
                        inputAudio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputAudio>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputText == null && inputImage == null && inputFile == null && inputAudio == null)
            {
                try
                {
                    inputText = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputText>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputImage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputImage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputFile = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputFile>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputAudio>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseInputsOneOf1ItemsOneOf1ContentItems(
                inputText,

                inputImage,

                inputFile,

                inputAudio
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseInputsOneOf1ItemsOneOf1ContentItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInputText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputText, typeof(global::G.InputText), options);
            }
            else if (value.IsInputImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputImage, typeof(global::G.InputImage), options);
            }
            else if (value.IsInputFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFile, typeof(global::G.InputFile), options);
            }
            else if (value.IsInputAudio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudio, typeof(global::G.InputAudio), options);
            }
        }
    }
}