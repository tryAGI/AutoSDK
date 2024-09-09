//HintName: JsonConverters.AssistantStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public class AssistantStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AssistantStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.AssistantStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ThreadStreamEvent? thread = default;
            try
            {
                thread = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ThreadStreamEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEvent? run = default;
            try
            {
                run = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEvent? runStep = default;
            try
            {
                runStep = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MessageStreamEvent? message = default;
            try
            {
                message = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ErrorEvent? error = default;
            try
            {
                error = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ErrorEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.DoneEvent? done = default;
            try
            {
                done = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DoneEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.AssistantStreamEvent(
                thread,
                run,
                runStep,
                message,
                error,
                done
                );

            if (thread != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ThreadStreamEvent>(ref reader, options);
            }
            else if (run != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEvent>(ref reader, options);
            }
            else if (runStep != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStepStreamEvent>(ref reader, options);
            }
            else if (message != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEvent>(ref reader, options);
            }
            else if (error != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ErrorEvent>(ref reader, options);
            }
            else if (done != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DoneEvent>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AssistantStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsThread)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thread, typeof(global::G.ThreadStreamEvent), options);
            }
            else if (value.IsRun)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Run, typeof(global::G.RunStreamEvent), options);
            }
            else if (value.IsRunStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStep, typeof(global::G.RunStepStreamEvent), options);
            }
            else if (value.IsMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeof(global::G.MessageStreamEvent), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::G.ErrorEvent), options);
            }
            else if (value.IsDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done, typeof(global::G.DoneEvent), options);
            }
        }
    }
}