//HintName: JsonConverters.AssistantStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ThreadStreamEvent? thread = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThreadStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThreadStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ThreadStreamEvent).Name}");
                thread = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStreamEvent? run = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEvent).Name}");
                run = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RunStepStreamEvent? runStep = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEvent).Name}");
                runStep = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MessageStreamEvent? message = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEvent).Name}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ErrorEvent? error = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ErrorEvent).Name}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.DoneEvent? done = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DoneEvent).Name}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThreadStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThreadStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ThreadStreamEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (run != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (runStep != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (message != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (error != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ErrorEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (done != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsThread)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThreadStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThreadStreamEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ThreadStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thread, typeInfo);
            }
            else if (value.IsRun)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Run, typeInfo);
            }
            else if (value.IsRunStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepStreamEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStep, typeInfo);
            }
            else if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MessageStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MessageStreamEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MessageStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done, typeInfo);
            }
        }
    }
}