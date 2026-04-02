//HintName: G.JsonConverters.AssistantsApiResponseFormatOption.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AssistantsApiResponseFormatOptionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AssistantsApiResponseFormatOption>
    {
        /// <inheritdoc />
        public override global::G.AssistantsApiResponseFormatOption Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("json_schema")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.AssistantsApiResponseFormatOptionEnum? @enum = default;
            global::G.ResponseFormatText? text = default;
            global::G.ResponseFormatJsonObject? jsonObject = default;
            global::G.ResponseFormatJsonSchema? jsonSchema = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantsApiResponseFormatOptionEnum>(__rawJson, options);
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
                        text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatText>(__rawJson, options);
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
                        jsonObject = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatJsonObject>(__rawJson, options);
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
                        jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatJsonSchema>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@enum == null && text == null && jsonObject == null && jsonSchema == null)
            {
                try
                {
                    @enum = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantsApiResponseFormatOptionEnum>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatText>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    jsonObject = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatJsonObject>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatJsonSchema>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AssistantsApiResponseFormatOption(
                @enum,

                text,

                jsonObject,

                jsonSchema
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AssistantsApiResponseFormatOption value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEnum)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum, typeof(global::G.AssistantsApiResponseFormatOptionEnum), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.ResponseFormatText), options);
            }
            else if (value.IsJsonObject)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonObject, typeof(global::G.ResponseFormatJsonObject), options);
            }
            else if (value.IsJsonSchema)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema, typeof(global::G.ResponseFormatJsonSchema), options);
            }
        }
    }
}