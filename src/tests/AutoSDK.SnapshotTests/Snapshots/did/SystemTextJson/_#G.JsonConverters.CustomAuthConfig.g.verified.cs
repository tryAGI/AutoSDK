//HintName: G.JsonConverters.CustomAuthConfig.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CustomAuthConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CustomAuthConfig>
    {
        /// <inheritdoc />
        public override global::G.CustomAuthConfig Read(
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
            if (__jsonProps.Contains("headers")) __score0++;
            if (__jsonProps.Contains("key")) __score0++;
            if (__jsonProps.Contains("max_messages")) __score0++;
            if (__jsonProps.Contains("streaming")) __score0++;
            if (__jsonProps.Contains("supports_sentiment")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            if (__jsonProps.Contains("version")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("client_id")) __score1++;
            if (__jsonProps.Contains("client_secret")) __score1++;
            if (__jsonProps.Contains("headers")) __score1++;
            if (__jsonProps.Contains("max_messages")) __score1++;
            if (__jsonProps.Contains("streaming")) __score1++;
            if (__jsonProps.Contains("supports_sentiment")) __score1++;
            if (__jsonProps.Contains("token_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.CustomAuthConfigBasic? basic = default;
            global::G.CustomAuthConfigOAuth2? oAuth2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomAuthConfigBasic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomAuthConfigBasic> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomAuthConfigBasic).Name}");
                        basic = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomAuthConfigOAuth2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomAuthConfigOAuth2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomAuthConfigOAuth2).Name}");
                        oAuth2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (basic == null && oAuth2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomAuthConfigBasic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomAuthConfigBasic> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomAuthConfigBasic).Name}");
                    basic = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomAuthConfigOAuth2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomAuthConfigOAuth2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomAuthConfigOAuth2).Name}");
                    oAuth2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CustomAuthConfig(
                basic,

                oAuth2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CustomAuthConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBasic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomAuthConfigBasic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomAuthConfigBasic?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomAuthConfigBasic).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Basic!, typeInfo);
            }
            else if (value.IsOAuth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomAuthConfigOAuth2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomAuthConfigOAuth2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomAuthConfigOAuth2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OAuth2!, typeInfo);
            }
        }
    }
}