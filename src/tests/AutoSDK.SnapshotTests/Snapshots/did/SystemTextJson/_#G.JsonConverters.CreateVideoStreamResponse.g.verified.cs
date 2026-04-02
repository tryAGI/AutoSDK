//HintName: G.JsonConverters.CreateVideoStreamResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateVideoStreamResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateVideoStreamResponse>
    {
        /// <inheritdoc />
        public override global::G.CreateVideoStreamResponse Read(
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
            if (__jsonProps.Contains("status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("duration")) __score1++;
            if (__jsonProps.Contains("session_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.CreateVideoStreamResponseVariant1? createVideoStreamResponseVariant1 = default;
            global::G.CreateVideoStreamResponseVariant2? createVideoStreamResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        createVideoStreamResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateVideoStreamResponseVariant1>(__rawJson, options);
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
                        createVideoStreamResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateVideoStreamResponseVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createVideoStreamResponseVariant1 == null && createVideoStreamResponseVariant2 == null)
            {
                try
                {
                    createVideoStreamResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateVideoStreamResponseVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    createVideoStreamResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateVideoStreamResponseVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateVideoStreamResponse(
                createVideoStreamResponseVariant1,

                createVideoStreamResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateVideoStreamResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCreateVideoStreamResponseVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateVideoStreamResponseVariant1, typeof(global::G.CreateVideoStreamResponseVariant1), options);
            }
            else if (value.IsCreateVideoStreamResponseVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateVideoStreamResponseVariant2, typeof(global::G.CreateVideoStreamResponseVariant2), options);
            }
        }
    }
}