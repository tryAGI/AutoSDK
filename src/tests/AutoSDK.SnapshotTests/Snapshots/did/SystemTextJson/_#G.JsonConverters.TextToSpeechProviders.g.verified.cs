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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersMicrosoft), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersMicrosoft> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersMicrosoft).Name}");
                        microsoft = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersElevenLabs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersElevenLabs> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersElevenLabs).Name}");
                        elevenLabs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersAmazon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersAmazon> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersAmazon).Name}");
                        amazon = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersGoogle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersGoogle> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersGoogle).Name}");
                        google = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersOpenAI), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersOpenAI> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersOpenAI).Name}");
                        openAI = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersMicrosoft), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersMicrosoft> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersMicrosoft).Name}");
                    microsoft = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersElevenLabs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersElevenLabs> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersElevenLabs).Name}");
                    elevenLabs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersAmazon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersAmazon> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersAmazon).Name}");
                    amazon = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersGoogle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersGoogle> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersGoogle).Name}");
                    google = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersOpenAI), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersOpenAI> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersOpenAI).Name}");
                    openAI = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMicrosoft)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersMicrosoft), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersMicrosoft?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersMicrosoft).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Microsoft!, typeInfo);
            }
            else if (value.IsElevenLabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersElevenLabs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersElevenLabs?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersElevenLabs).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenLabs!, typeInfo);
            }
            else if (value.IsAmazon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersAmazon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersAmazon?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersAmazon).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Amazon!, typeInfo);
            }
            else if (value.IsGoogle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersGoogle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersGoogle?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersGoogle).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Google!, typeInfo);
            }
            else if (value.IsOpenAI)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextToSpeechProvidersOpenAI), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextToSpeechProvidersOpenAI?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextToSpeechProvidersOpenAI).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAI!, typeInfo);
            }
        }
    }
}