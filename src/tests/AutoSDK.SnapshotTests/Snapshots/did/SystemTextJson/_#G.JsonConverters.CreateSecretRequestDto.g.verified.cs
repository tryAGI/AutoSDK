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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretRequestDtoBasicAuthentication), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretRequestDtoBasicAuthentication> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretRequestDtoBasicAuthentication).Name}");
                        basicAuthentication = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretRequestDtoBearerToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretRequestDtoBearerToken> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretRequestDtoBearerToken).Name}");
                        bearerToken = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretRequestDtoApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretRequestDtoApiKey> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretRequestDtoApiKey).Name}");
                        apiKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretRequestDtoBasicAuthentication), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretRequestDtoBasicAuthentication> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretRequestDtoBasicAuthentication).Name}");
                    basicAuthentication = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretRequestDtoBearerToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretRequestDtoBearerToken> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretRequestDtoBearerToken).Name}");
                    bearerToken = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretRequestDtoApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretRequestDtoApiKey> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretRequestDtoApiKey).Name}");
                    apiKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBasicAuthentication)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretRequestDtoBasicAuthentication), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretRequestDtoBasicAuthentication?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretRequestDtoBasicAuthentication).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasicAuthentication!, typeInfo);
            }
            else if (value.IsBearerToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretRequestDtoBearerToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretRequestDtoBearerToken?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretRequestDtoBearerToken).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BearerToken!, typeInfo);
            }
            else if (value.IsApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSecretRequestDtoApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSecretRequestDtoApiKey?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSecretRequestDtoApiKey).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey!, typeInfo);
            }
        }
    }
}