//HintName: G.JsonConverters.RealtimeClientEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeClientEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RealtimeClientEvent>
    {
        /// <inheritdoc />
        public override global::G.RealtimeClientEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RealtimeClientEventConversationItemCreate? conversationItemCreate = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemCreate).Name}");
                conversationItemCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventConversationItemDelete? conversationItemDelete = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemDelete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemDelete> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemDelete).Name}");
                conversationItemDelete = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventConversationItemRetrieve? conversationItemRetrieve = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemRetrieve), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemRetrieve> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemRetrieve).Name}");
                conversationItemRetrieve = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventConversationItemTruncate? conversationItemTruncate = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemTruncate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemTruncate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemTruncate).Name}");
                conversationItemTruncate = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventInputAudioBufferAppend? inputAudioBufferAppend = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventInputAudioBufferAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventInputAudioBufferAppend> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventInputAudioBufferAppend).Name}");
                inputAudioBufferAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventInputAudioBufferClear? inputAudioBufferClear = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventInputAudioBufferClear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventInputAudioBufferClear> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventInputAudioBufferClear).Name}");
                inputAudioBufferClear = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventOutputAudioBufferClear? outputAudioBufferClear = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventOutputAudioBufferClear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventOutputAudioBufferClear> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventOutputAudioBufferClear).Name}");
                outputAudioBufferClear = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventInputAudioBufferCommit? inputAudioBufferCommit = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventInputAudioBufferCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventInputAudioBufferCommit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventInputAudioBufferCommit).Name}");
                inputAudioBufferCommit = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventResponseCancel? responseCancel = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventResponseCancel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventResponseCancel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventResponseCancel).Name}");
                responseCancel = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventResponseCreate? responseCreate = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventResponseCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventResponseCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventResponseCreate).Name}");
                responseCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventSessionUpdate? sessionUpdate = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventSessionUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventSessionUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventSessionUpdate).Name}");
                sessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RealtimeClientEventTranscriptionSessionUpdate? transcriptionSessionUpdate = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventTranscriptionSessionUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventTranscriptionSessionUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventTranscriptionSessionUpdate).Name}");
                transcriptionSessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.RealtimeClientEvent(
                conversationItemCreate,
                conversationItemDelete,
                conversationItemRetrieve,
                conversationItemTruncate,
                inputAudioBufferAppend,
                inputAudioBufferClear,
                outputAudioBufferClear,
                inputAudioBufferCommit,
                responseCancel,
                responseCreate,
                sessionUpdate,
                transcriptionSessionUpdate
                );

            if (conversationItemCreate != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemCreate).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemDelete != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemDelete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemDelete> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemDelete).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemRetrieve != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemRetrieve), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemRetrieve> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemRetrieve).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemTruncate != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemTruncate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemTruncate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemTruncate).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferAppend != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventInputAudioBufferAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventInputAudioBufferAppend> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventInputAudioBufferAppend).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferClear != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventInputAudioBufferClear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventInputAudioBufferClear> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventInputAudioBufferClear).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputAudioBufferClear != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventOutputAudioBufferClear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventOutputAudioBufferClear> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventOutputAudioBufferClear).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferCommit != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventInputAudioBufferCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventInputAudioBufferCommit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventInputAudioBufferCommit).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseCancel != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventResponseCancel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventResponseCancel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventResponseCancel).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseCreate != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventResponseCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventResponseCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventResponseCreate).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (sessionUpdate != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventSessionUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventSessionUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventSessionUpdate).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (transcriptionSessionUpdate != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventTranscriptionSessionUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventTranscriptionSessionUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventTranscriptionSessionUpdate).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RealtimeClientEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationItemCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemCreate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemCreate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreate, typeInfo);
            }
            else if (value.IsConversationItemDelete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemDelete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemDelete?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemDelete).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDelete, typeInfo);
            }
            else if (value.IsConversationItemRetrieve)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemRetrieve), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemRetrieve?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemRetrieve).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemRetrieve, typeInfo);
            }
            else if (value.IsConversationItemTruncate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventConversationItemTruncate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventConversationItemTruncate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventConversationItemTruncate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncate, typeInfo);
            }
            else if (value.IsInputAudioBufferAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventInputAudioBufferAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventInputAudioBufferAppend?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventInputAudioBufferAppend).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferAppend, typeInfo);
            }
            else if (value.IsInputAudioBufferClear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventInputAudioBufferClear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventInputAudioBufferClear?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventInputAudioBufferClear).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferClear, typeInfo);
            }
            else if (value.IsOutputAudioBufferClear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventOutputAudioBufferClear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventOutputAudioBufferClear?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventOutputAudioBufferClear).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferClear, typeInfo);
            }
            else if (value.IsInputAudioBufferCommit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventInputAudioBufferCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventInputAudioBufferCommit?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventInputAudioBufferCommit).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommit, typeInfo);
            }
            else if (value.IsResponseCancel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventResponseCancel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventResponseCancel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventResponseCancel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCancel, typeInfo);
            }
            else if (value.IsResponseCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventResponseCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventResponseCreate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventResponseCreate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreate, typeInfo);
            }
            else if (value.IsSessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventSessionUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventSessionUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventSessionUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdate, typeInfo);
            }
            else if (value.IsTranscriptionSessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeClientEventTranscriptionSessionUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeClientEventTranscriptionSessionUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeClientEventTranscriptionSessionUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionSessionUpdate, typeInfo);
            }
        }
    }
}