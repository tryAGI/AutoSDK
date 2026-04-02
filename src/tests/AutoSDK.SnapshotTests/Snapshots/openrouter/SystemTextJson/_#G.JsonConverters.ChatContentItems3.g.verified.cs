//HintName: G.JsonConverters.ChatContentItems3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatContentItems3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatContentItems3>
    {
        /// <inheritdoc />
        public override global::G.ChatContentItems3 Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("video_url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("video_url")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.LegacyChatContentVideo? legacyChatContentVideo = default;
            global::G.ChatContentVideo? chatContentVideo = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        legacyChatContentVideo = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LegacyChatContentVideo>(__rawJson, options);
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
                        chatContentVideo = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatContentVideo>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (legacyChatContentVideo == null && chatContentVideo == null)
            {
                try
                {
                    legacyChatContentVideo = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LegacyChatContentVideo>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatContentVideo = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatContentVideo>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatContentItems3(
                legacyChatContentVideo,

                chatContentVideo
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatContentItems3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLegacyChatContentVideo)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LegacyChatContentVideo, typeof(global::G.LegacyChatContentVideo), options);
            }
            else if (value.IsChatContentVideo)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentVideo, typeof(global::G.ChatContentVideo), options);
            }
        }
    }
}