//HintName: G.JsonConverters.CreateTranscriptionResponseStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateTranscriptionResponseStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTranscriptionResponseStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.CreateTranscriptionResponseStreamEvent Read(
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
            if (__jsonProps.Contains("delta")) __score0++;
            if (__jsonProps.Contains("logprobs")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("logprobs")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.TranscriptTextDeltaEvent? transcriptTextDelta = default;
            global::G.TranscriptTextDoneEvent? transcriptTextDone = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        transcriptTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranscriptTextDeltaEvent>(__rawJson, options);
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
                        transcriptTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranscriptTextDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (transcriptTextDelta == null && transcriptTextDone == null)
            {
                try
                {
                    transcriptTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranscriptTextDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    transcriptTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranscriptTextDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateTranscriptionResponseStreamEvent(
                transcriptTextDelta,

                transcriptTextDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTranscriptionResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTranscriptTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptTextDelta, typeof(global::G.TranscriptTextDeltaEvent), options);
            }
            else if (value.IsTranscriptTextDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptTextDone, typeof(global::G.TranscriptTextDoneEvent), options);
            }
        }
    }
}