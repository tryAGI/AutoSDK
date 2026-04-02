//HintName: G.JsonConverters.InputContent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputContent>
    {
        /// <inheritdoc />
        public override global::G.InputContent Read(
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
            if (__jsonProps.Contains("file_id")) __score1++;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("file_data")) __score2++;
            if (__jsonProps.Contains("file_id")) __score2++;
            if (__jsonProps.Contains("filename")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.InputText? textInput = default;
            global::G.InputImage? imageInput = default;
            global::G.InputFile? fileInput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        textInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputText>(__rawJson, options);
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
                        imageInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputImage>(__rawJson, options);
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
                        fileInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputFile>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textInput == null && imageInput == null && fileInput == null)
            {
                try
                {
                    textInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputText>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    imageInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputImage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fileInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputFile>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.InputContent(
                textInput,

                imageInput,

                fileInput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextInput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextInput, typeof(global::G.InputText), options);
            }
            else if (value.IsImageInput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageInput, typeof(global::G.InputImage), options);
            }
            else if (value.IsFileInput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileInput, typeof(global::G.InputFile), options);
            }
        }
    }
}