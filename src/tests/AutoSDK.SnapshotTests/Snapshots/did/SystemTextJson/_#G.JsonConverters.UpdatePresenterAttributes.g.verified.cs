//HintName: G.JsonConverters.UpdatePresenterAttributes.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UpdatePresenterAttributesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdatePresenterAttributes>
    {
        /// <inheritdoc />
        public override global::G.UpdatePresenterAttributes Read(
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
            if (__jsonProps.Contains("a2e_model")) __score0++;
            if (__jsonProps.Contains("entity__modified_at")) __score0++;
            if (__jsonProps.Contains("face_rect")) __score0++;
            if (__jsonProps.Contains("gender")) __score0++;
            if (__jsonProps.Contains("idle_video")) __score0++;
            if (__jsonProps.Contains("image_url")) __score0++;
            if (__jsonProps.Contains("is_greenscreen")) __score0++;
            if (__jsonProps.Contains("is_streamable")) __score0++;
            if (__jsonProps.Contains("labels")) __score0++;
            if (__jsonProps.Contains("modified_at")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("preview_url")) __score0++;
            if (__jsonProps.Contains("show")) __score0++;
            if (__jsonProps.Contains("talking_preview_url")) __score0++;
            if (__jsonProps.Contains("thumbnail_url")) __score0++;
            if (__jsonProps.Contains("video_url")) __score0++;
            if (__jsonProps.Contains("voice")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("ownerId")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("newOwnerId")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.UpdatePresenterAttributesVariant1? updatePresenterAttributesVariant1 = default;
            global::G.UpdatePresenterAttributesVariant2? updatePresenterAttributesVariant2 = default;
            global::G.UpdatePresenterAttributesVariant3? updatePresenterAttributesVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        updatePresenterAttributesVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdatePresenterAttributesVariant1>(__rawJson, options);
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
                        updatePresenterAttributesVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdatePresenterAttributesVariant2>(__rawJson, options);
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
                        updatePresenterAttributesVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdatePresenterAttributesVariant3>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (updatePresenterAttributesVariant1 == null && updatePresenterAttributesVariant2 == null && updatePresenterAttributesVariant3 == null)
            {
                try
                {
                    updatePresenterAttributesVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdatePresenterAttributesVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    updatePresenterAttributesVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdatePresenterAttributesVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    updatePresenterAttributesVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdatePresenterAttributesVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.UpdatePresenterAttributes(
                updatePresenterAttributesVariant1,

                updatePresenterAttributesVariant2,

                updatePresenterAttributesVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpdatePresenterAttributes value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUpdatePresenterAttributesVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdatePresenterAttributesVariant1, typeof(global::G.UpdatePresenterAttributesVariant1), options);
            }
            else if (value.IsUpdatePresenterAttributesVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdatePresenterAttributesVariant2, typeof(global::G.UpdatePresenterAttributesVariant2), options);
            }
            else if (value.IsUpdatePresenterAttributesVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdatePresenterAttributesVariant3, typeof(global::G.UpdatePresenterAttributesVariant3), options);
            }
        }
    }
}