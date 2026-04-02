//HintName: G.JsonConverters.OpenAiResponsesToolChoiceOneOf4Type.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OpenAiResponsesToolChoiceOneOf4TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OpenAiResponsesToolChoiceOneOf4Type>
    {
        /// <inheritdoc />
        public override global::G.OpenAiResponsesToolChoiceOneOf4Type Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.OpenAiResponsesToolChoiceOneOf4Type0? openAiResponsesToolChoiceOneOf4Type0 = default;
            global::G.OpenAiResponsesToolChoiceOneOf4Type1? openAiResponsesToolChoiceOneOf4Type1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        openAiResponsesToolChoiceOneOf4Type0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OpenAiResponsesToolChoiceOneOf4Type0>(__rawJson, options);
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

                        openAiResponsesToolChoiceOneOf4Type1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OpenAiResponsesToolChoiceOneOf4Type1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (openAiResponsesToolChoiceOneOf4Type0 == null && openAiResponsesToolChoiceOneOf4Type1 == null)
            {
                try
                {

                    openAiResponsesToolChoiceOneOf4Type0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OpenAiResponsesToolChoiceOneOf4Type0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    openAiResponsesToolChoiceOneOf4Type1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OpenAiResponsesToolChoiceOneOf4Type1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OpenAiResponsesToolChoiceOneOf4Type(
                openAiResponsesToolChoiceOneOf4Type0,

                openAiResponsesToolChoiceOneOf4Type1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OpenAiResponsesToolChoiceOneOf4Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOpenAiResponsesToolChoiceOneOf4Type0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAiResponsesToolChoiceOneOf4Type0, typeof(global::G.OpenAiResponsesToolChoiceOneOf4Type0), options);
            }
            else if (value.IsOpenAiResponsesToolChoiceOneOf4Type1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAiResponsesToolChoiceOneOf4Type1, typeof(global::G.OpenAiResponsesToolChoiceOneOf4Type1), options);
            }
        }
    }
}