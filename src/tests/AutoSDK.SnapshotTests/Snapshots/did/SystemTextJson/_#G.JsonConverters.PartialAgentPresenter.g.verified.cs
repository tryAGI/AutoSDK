//HintName: G.JsonConverters.PartialAgentPresenter.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PartialAgentPresenterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PartialAgentPresenter>
    {
        /// <inheritdoc />
        public override global::G.PartialAgentPresenter Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.PartialAgentPresenterPhotoAvatar? photoAvatar = default;
            global::G.PartialAgentPresenterVideoAvatar? videoAvatar = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        photoAvatar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PartialAgentPresenterPhotoAvatar>(__rawJson, options);
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
                        videoAvatar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PartialAgentPresenterVideoAvatar>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (photoAvatar == null && videoAvatar == null)
            {
                try
                {
                    photoAvatar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PartialAgentPresenterPhotoAvatar>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    videoAvatar = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PartialAgentPresenterVideoAvatar>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.PartialAgentPresenter(
                photoAvatar,

                videoAvatar
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PartialAgentPresenter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPhotoAvatar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhotoAvatar, typeof(global::G.PartialAgentPresenterPhotoAvatar), options);
            }
            else if (value.IsVideoAvatar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoAvatar, typeof(global::G.PartialAgentPresenterVideoAvatar), options);
            }
        }
    }
}