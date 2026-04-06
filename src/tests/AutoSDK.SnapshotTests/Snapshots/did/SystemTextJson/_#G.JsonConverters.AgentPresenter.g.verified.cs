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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPresenterPhotoAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPresenterPhotoAvatar> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentPresenterPhotoAvatar).Name}");
                        photoAvatar = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPresenterVideoAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPresenterVideoAvatar> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentPresenterVideoAvatar).Name}");
                        videoAvatar = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPresenterExpressiveAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPresenterExpressiveAvatar> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentPresenterExpressiveAvatar).Name}");
                        expressiveAvatar = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPresenterPhotoAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPresenterPhotoAvatar> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentPresenterPhotoAvatar).Name}");
                    photoAvatar = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPresenterVideoAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPresenterVideoAvatar> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentPresenterVideoAvatar).Name}");
                    videoAvatar = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPresenterExpressiveAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPresenterExpressiveAvatar> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentPresenterExpressiveAvatar).Name}");
                    expressiveAvatar = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPhotoAvatar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPresenterPhotoAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPresenterPhotoAvatar?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentPresenterPhotoAvatar).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhotoAvatar!, typeInfo);
            }
            else if (value.IsVideoAvatar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPresenterVideoAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPresenterVideoAvatar?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentPresenterVideoAvatar).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoAvatar!, typeInfo);
            }
            else if (value.IsExpressiveAvatar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentPresenterExpressiveAvatar), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentPresenterExpressiveAvatar?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentPresenterExpressiveAvatar).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpressiveAvatar!, typeInfo);
            }
        }
    }
}