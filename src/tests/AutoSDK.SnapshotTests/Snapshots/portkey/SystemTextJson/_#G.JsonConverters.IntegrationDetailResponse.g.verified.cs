//HintName: G.JsonConverters.IntegrationDetailResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class IntegrationDetailResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.IntegrationDetailResponse>
    {
        /// <inheritdoc />
        public override global::G.IntegrationDetailResponse Read(
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
            if (__jsonProps.Contains("ai_provider_id")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("last_updated_at")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("object")) __score0++;
            if (__jsonProps.Contains("organisation_id")) __score0++;
            if (__jsonProps.Contains("slug")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("allow_all_models")) __score1++;
            if (__jsonProps.Contains("configurations")) __score1++;
            if (__jsonProps.Contains("global_workspace_access_settings")) __score1++;
            if (__jsonProps.Contains("masked_key")) __score1++;
            if (__jsonProps.Contains("secret_mappings")) __score1++;
            if (__jsonProps.Contains("workspace_count")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.IntegrationList? list = default;
            global::G.IntegrationDetailResponseVariant2? integrationDetailResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.IntegrationList), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.IntegrationList> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.IntegrationList).Name}");
                        list = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.IntegrationDetailResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.IntegrationDetailResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.IntegrationDetailResponseVariant2).Name}");
                        integrationDetailResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (list == null && integrationDetailResponseVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.IntegrationList), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.IntegrationList> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.IntegrationList).Name}");
                    list = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.IntegrationDetailResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.IntegrationDetailResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.IntegrationDetailResponseVariant2).Name}");
                    integrationDetailResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.IntegrationDetailResponse(
                list,

                integrationDetailResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.IntegrationDetailResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsList)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.IntegrationList), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.IntegrationList?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.IntegrationList).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.List!, typeInfo);
            }
            else if (value.IsIntegrationDetailResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.IntegrationDetailResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.IntegrationDetailResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.IntegrationDetailResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IntegrationDetailResponseVariant2!, typeInfo);
            }
        }
    }
}