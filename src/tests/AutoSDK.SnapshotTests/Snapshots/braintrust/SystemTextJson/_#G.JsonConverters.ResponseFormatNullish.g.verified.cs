//HintName: G.JsonConverters.ResponseFormatNullish.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatNullishJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseFormatNullish>
    {
        /// <inheritdoc />
        public override global::G.ResponseFormatNullish Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("json_schema")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.ResponseFormatNullishJsonObject? jsonObject = default;
            global::G.ResponseFormatNullishJsonSchema? jsonSchema = default;
            global::G.ResponseFormatNullishText? text = default;
            object? responseFormatNullishVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        jsonObject = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatNullishJsonObject>(__rawJson, options);
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
                        jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatNullishJsonSchema>(__rawJson, options);
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
                        text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatNullishText>(__rawJson, options);
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
                        responseFormatNullishVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (jsonObject == null && jsonSchema == null && text == null && responseFormatNullishVariant4 == null)
            {
                try
                {
                    jsonObject = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatNullishJsonObject>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatNullishJsonSchema>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFormatNullishText>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFormatNullishVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ResponseFormatNullish(
                jsonObject,

                jsonSchema,

                text,

                responseFormatNullishVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseFormatNullish value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsJsonObject)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonObject, typeof(global::G.ResponseFormatNullishJsonObject), options);
            }
            else if (value.IsJsonSchema)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema, typeof(global::G.ResponseFormatNullishJsonSchema), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.ResponseFormatNullishText), options);
            }
            else if (value.IsResponseFormatNullishVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFormatNullishVariant4, typeof(object), options);
            }
        }
    }
}