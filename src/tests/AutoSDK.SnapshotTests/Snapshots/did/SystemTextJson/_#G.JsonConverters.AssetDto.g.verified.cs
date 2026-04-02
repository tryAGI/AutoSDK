//HintName: G.JsonConverters.AssetDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AssetDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AssetDto>
    {
        /// <inheritdoc />
        public override global::G.AssetDto Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("mime_type")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("source_url")) __score0++;
            if (__jsonProps.Contains("tags")) __score0++;
            if (__jsonProps.Contains("thumbnail_url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("mime_type")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("source_url")) __score1++;
            if (__jsonProps.Contains("tags")) __score1++;
            if (__jsonProps.Contains("thumbnail_url")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.AssetDtoVariant1? assetDtoVariant1 = default;
            global::G.AssetDtoVariant2? assetDtoVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        assetDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssetDtoVariant1>(__rawJson, options);
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
                        assetDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssetDtoVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (assetDtoVariant1 == null && assetDtoVariant2 == null)
            {
                try
                {
                    assetDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssetDtoVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    assetDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssetDtoVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AssetDto(
                assetDtoVariant1,

                assetDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AssetDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAssetDtoVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssetDtoVariant1, typeof(global::G.AssetDtoVariant1), options);
            }
            else if (value.IsAssetDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssetDtoVariant2, typeof(global::G.AssetDtoVariant2), options);
            }
        }
    }
}