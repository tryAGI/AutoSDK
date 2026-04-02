//HintName: G.JsonConverters.AgentPresenter.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentPresenterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentPresenter>
    {
        /// <inheritdoc />
        public override global::G.AgentPresenter Read(
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
            if (__jsonProps.Contains("source_url")) __score0++;
            if (__jsonProps.Contains("stitch")) __score0++;
            if (__jsonProps.Contains("thumbnail")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("voice")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("background")) __score1++;
            if (__jsonProps.Contains("presenter_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("voice")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("background")) __score2++;
            if (__jsonProps.Contains("presenter_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("voice")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.AgentPresenterPhotoAvatar? photoAvatar = default;
            global::G.AgentPresenterVideoAvatar? videoAvatar = default;
            global::G.AgentPresenterExpressiveAvatar? expressiveAvatar = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        photoAvatar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentPresenterPhotoAvatar>(__rawJson, options);
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
                        videoAvatar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentPresenterVideoAvatar>(__rawJson, options);
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
                        expressiveAvatar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentPresenterExpressiveAvatar>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (photoAvatar == null && videoAvatar == null && expressiveAvatar == null)
            {
                try
                {
                    photoAvatar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentPresenterPhotoAvatar>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    videoAvatar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentPresenterVideoAvatar>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    expressiveAvatar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentPresenterExpressiveAvatar>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AgentPresenter(
                photoAvatar,

                videoAvatar,

                expressiveAvatar
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentPresenter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPhotoAvatar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhotoAvatar, typeof(global::G.AgentPresenterPhotoAvatar), options);
            }
            else if (value.IsVideoAvatar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoAvatar, typeof(global::G.AgentPresenterVideoAvatar), options);
            }
            else if (value.IsExpressiveAvatar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpressiveAvatar, typeof(global::G.AgentPresenterExpressiveAvatar), options);
            }
        }
    }
}