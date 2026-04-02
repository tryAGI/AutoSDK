//HintName: G.JsonConverters.CreateSecretRequestDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateSecretRequestDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateSecretRequestDto>
    {
        /// <inheritdoc />
        public override global::G.CreateSecretRequestDto Read(
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
            if (__jsonProps.Contains("password")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("username")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("provider")) __score1++;
            if (__jsonProps.Contains("token")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("api_key")) __score2++;
            if (__jsonProps.Contains("header_name")) __score2++;
            if (__jsonProps.Contains("provider")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.CreateSecretRequestDtoBasicAuthentication? basicAuthentication = default;
            global::G.CreateSecretRequestDtoBearerToken? bearerToken = default;
            global::G.CreateSecretRequestDtoApiKey? apiKey = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        basicAuthentication = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSecretRequestDtoBasicAuthentication>(__rawJson, options);
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
                        bearerToken = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSecretRequestDtoBearerToken>(__rawJson, options);
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
                        apiKey = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSecretRequestDtoApiKey>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (basicAuthentication == null && bearerToken == null && apiKey == null)
            {
                try
                {
                    basicAuthentication = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSecretRequestDtoBasicAuthentication>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    bearerToken = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSecretRequestDtoBearerToken>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    apiKey = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSecretRequestDtoApiKey>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateSecretRequestDto(
                basicAuthentication,

                bearerToken,

                apiKey
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateSecretRequestDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBasicAuthentication)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasicAuthentication, typeof(global::G.CreateSecretRequestDtoBasicAuthentication), options);
            }
            else if (value.IsBearerToken)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BearerToken, typeof(global::G.CreateSecretRequestDtoBearerToken), options);
            }
            else if (value.IsApiKey)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey, typeof(global::G.CreateSecretRequestDtoApiKey), options);
            }
        }
    }
}