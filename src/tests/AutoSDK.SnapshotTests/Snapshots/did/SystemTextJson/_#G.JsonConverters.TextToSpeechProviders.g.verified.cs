//HintName: G.JsonConverters.TextToSpeechProviders.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TextToSpeechProvidersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TextToSpeechProviders>
    {
        /// <inheritdoc />
        public override global::G.TextToSpeechProviders Read(
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
            if (__jsonProps.Contains("language")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("voice_config")) __score0++;
            if (__jsonProps.Contains("voice_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("language")) __score1++;
            if (__jsonProps.Contains("model_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("voice_config")) __score1++;
            if (__jsonProps.Contains("voice_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("language")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("voice_id")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("voice_id")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("language")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("voice_config")) __score4++;
            if (__jsonProps.Contains("voice_id")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.TextToSpeechProvidersMicrosoft? microsoft = default;
            global::G.TextToSpeechProvidersElevenLabs? elevenLabs = default;
            global::G.TextToSpeechProvidersAmazon? amazon = default;
            global::G.TextToSpeechProvidersGoogle? google = default;
            global::G.TextToSpeechProvidersOpenAI? openAI = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        microsoft = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextToSpeechProvidersMicrosoft>(__rawJson, options);
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
                        elevenLabs = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextToSpeechProvidersElevenLabs>(__rawJson, options);
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
                        amazon = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextToSpeechProvidersAmazon>(__rawJson, options);
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
                        google = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextToSpeechProvidersGoogle>(__rawJson, options);
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
                        openAI = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextToSpeechProvidersOpenAI>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (microsoft == null && elevenLabs == null && amazon == null && google == null && openAI == null)
            {
                try
                {
                    microsoft = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextToSpeechProvidersMicrosoft>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    elevenLabs = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextToSpeechProvidersElevenLabs>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    amazon = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextToSpeechProvidersAmazon>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    google = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextToSpeechProvidersGoogle>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    openAI = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextToSpeechProvidersOpenAI>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TextToSpeechProviders(
                microsoft,

                elevenLabs,

                amazon,

                google,

                openAI
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TextToSpeechProviders value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMicrosoft)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Microsoft, typeof(global::G.TextToSpeechProvidersMicrosoft), options);
            }
            else if (value.IsElevenLabs)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenLabs, typeof(global::G.TextToSpeechProvidersElevenLabs), options);
            }
            else if (value.IsAmazon)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Amazon, typeof(global::G.TextToSpeechProvidersAmazon), options);
            }
            else if (value.IsGoogle)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Google, typeof(global::G.TextToSpeechProvidersGoogle), options);
            }
            else if (value.IsOpenAI)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAI, typeof(global::G.TextToSpeechProvidersOpenAI), options);
            }
        }
    }
}