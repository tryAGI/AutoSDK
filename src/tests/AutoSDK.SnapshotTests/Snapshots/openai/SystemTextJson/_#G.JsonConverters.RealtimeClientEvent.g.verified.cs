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
            if (__jsonProps.Contains("event_id")) __score0++;
            if (__jsonProps.Contains("item")) __score0++;
            if (__jsonProps.Contains("previous_item_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("event_id")) __score1++;
            if (__jsonProps.Contains("item_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("event_id")) __score2++;
            if (__jsonProps.Contains("item_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("audio_end_ms")) __score3++;
            if (__jsonProps.Contains("content_index")) __score3++;
            if (__jsonProps.Contains("event_id")) __score3++;
            if (__jsonProps.Contains("item_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("audio")) __score4++;
            if (__jsonProps.Contains("event_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("event_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("event_id")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("event_id")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("event_id")) __score8++;
            if (__jsonProps.Contains("response_id")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("event_id")) __score9++;
            if (__jsonProps.Contains("response")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("event_id")) __score10++;
            if (__jsonProps.Contains("session")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("event_id")) __score11++;
            if (__jsonProps.Contains("session")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }

            global::G.RealtimeClientEventConversationItemCreate? conversationItemCreate = default;
            global::G.RealtimeClientEventConversationItemDelete? conversationItemDelete = default;
            global::G.RealtimeClientEventConversationItemRetrieve? conversationItemRetrieve = default;
            global::G.RealtimeClientEventConversationItemTruncate? conversationItemTruncate = default;
            global::G.RealtimeClientEventInputAudioBufferAppend? inputAudioBufferAppend = default;
            global::G.RealtimeClientEventInputAudioBufferClear? inputAudioBufferClear = default;
            global::G.RealtimeClientEventOutputAudioBufferClear? outputAudioBufferClear = default;
            global::G.RealtimeClientEventInputAudioBufferCommit? inputAudioBufferCommit = default;
            global::G.RealtimeClientEventResponseCancel? responseCancel = default;
            global::G.RealtimeClientEventResponseCreate? responseCreate = default;
            global::G.RealtimeClientEventSessionUpdate? sessionUpdate = default;
            global::G.RealtimeClientEventTranscriptionSessionUpdate? transcriptionSessionUpdate = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        conversationItemCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventConversationItemCreate>(__rawJson, options);
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
                        conversationItemDelete = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventConversationItemDelete>(__rawJson, options);
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
                        conversationItemRetrieve = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventConversationItemRetrieve>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        conversationItemTruncate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventConversationItemTruncate>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        inputAudioBufferAppend = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventInputAudioBufferAppend>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        inputAudioBufferClear = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventInputAudioBufferClear>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        outputAudioBufferClear = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventOutputAudioBufferClear>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        inputAudioBufferCommit = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventInputAudioBufferCommit>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        responseCancel = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventResponseCancel>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        responseCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventResponseCreate>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        sessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventSessionUpdate>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        transcriptionSessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventTranscriptionSessionUpdate>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (conversationItemCreate == null && conversationItemDelete == null && conversationItemRetrieve == null && conversationItemTruncate == null && inputAudioBufferAppend == null && inputAudioBufferClear == null && outputAudioBufferClear == null && inputAudioBufferCommit == null && responseCancel == null && responseCreate == null && sessionUpdate == null && transcriptionSessionUpdate == null)
            {
                try
                {
                    conversationItemCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventConversationItemCreate>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemDelete = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventConversationItemDelete>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemRetrieve = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventConversationItemRetrieve>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemTruncate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventConversationItemTruncate>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferAppend = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventInputAudioBufferAppend>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferClear = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventInputAudioBufferClear>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputAudioBufferClear = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventOutputAudioBufferClear>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferCommit = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventInputAudioBufferCommit>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCancel = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventResponseCancel>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventResponseCreate>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    sessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventSessionUpdate>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    transcriptionSessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeClientEventTranscriptionSessionUpdate>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RealtimeClientEvent(
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

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RealtimeClientEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsConversationItemCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreate, typeof(global::G.RealtimeClientEventConversationItemCreate), options);
            }
            else if (value.IsConversationItemDelete)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDelete, typeof(global::G.RealtimeClientEventConversationItemDelete), options);
            }
            else if (value.IsConversationItemRetrieve)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemRetrieve, typeof(global::G.RealtimeClientEventConversationItemRetrieve), options);
            }
            else if (value.IsConversationItemTruncate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncate, typeof(global::G.RealtimeClientEventConversationItemTruncate), options);
            }
            else if (value.IsInputAudioBufferAppend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferAppend, typeof(global::G.RealtimeClientEventInputAudioBufferAppend), options);
            }
            else if (value.IsInputAudioBufferClear)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferClear, typeof(global::G.RealtimeClientEventInputAudioBufferClear), options);
            }
            else if (value.IsOutputAudioBufferClear)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferClear, typeof(global::G.RealtimeClientEventOutputAudioBufferClear), options);
            }
            else if (value.IsInputAudioBufferCommit)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommit, typeof(global::G.RealtimeClientEventInputAudioBufferCommit), options);
            }
            else if (value.IsResponseCancel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCancel, typeof(global::G.RealtimeClientEventResponseCancel), options);
            }
            else if (value.IsResponseCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreate, typeof(global::G.RealtimeClientEventResponseCreate), options);
            }
            else if (value.IsSessionUpdate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdate, typeof(global::G.RealtimeClientEventSessionUpdate), options);
            }
            else if (value.IsTranscriptionSessionUpdate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionSessionUpdate, typeof(global::G.RealtimeClientEventTranscriptionSessionUpdate), options);
            }
        }
    }
}