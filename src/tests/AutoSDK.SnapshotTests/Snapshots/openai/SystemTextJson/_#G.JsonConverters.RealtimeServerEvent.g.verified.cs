//HintName: G.JsonConverters.RealtimeServerEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RealtimeServerEvent>
    {
        /// <inheritdoc />
        public override global::G.RealtimeServerEvent Read(
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
            if (__jsonProps.Contains("conversation")) __score0++;
            if (__jsonProps.Contains("event_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("event_id")) __score1++;
            if (__jsonProps.Contains("item")) __score1++;
            if (__jsonProps.Contains("previous_item_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("event_id")) __score2++;
            if (__jsonProps.Contains("item_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("content_index")) __score3++;
            if (__jsonProps.Contains("event_id")) __score3++;
            if (__jsonProps.Contains("item_id")) __score3++;
            if (__jsonProps.Contains("logprobs")) __score3++;
            if (__jsonProps.Contains("transcript")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("content_index")) __score4++;
            if (__jsonProps.Contains("delta")) __score4++;
            if (__jsonProps.Contains("event_id")) __score4++;
            if (__jsonProps.Contains("item_id")) __score4++;
            if (__jsonProps.Contains("logprobs")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("content_index")) __score5++;
            if (__jsonProps.Contains("error")) __score5++;
            if (__jsonProps.Contains("event_id")) __score5++;
            if (__jsonProps.Contains("item_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("event_id")) __score6++;
            if (__jsonProps.Contains("item")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("audio_end_ms")) __score7++;
            if (__jsonProps.Contains("content_index")) __score7++;
            if (__jsonProps.Contains("event_id")) __score7++;
            if (__jsonProps.Contains("item_id")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("error")) __score8++;
            if (__jsonProps.Contains("event_id")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("event_id")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("event_id")) __score10++;
            if (__jsonProps.Contains("item_id")) __score10++;
            if (__jsonProps.Contains("previous_item_id")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("audio_start_ms")) __score11++;
            if (__jsonProps.Contains("event_id")) __score11++;
            if (__jsonProps.Contains("item_id")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("audio_end_ms")) __score12++;
            if (__jsonProps.Contains("event_id")) __score12++;
            if (__jsonProps.Contains("item_id")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("event_id")) __score13++;
            if (__jsonProps.Contains("rate_limits")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("content_index")) __score14++;
            if (__jsonProps.Contains("delta")) __score14++;
            if (__jsonProps.Contains("event_id")) __score14++;
            if (__jsonProps.Contains("item_id")) __score14++;
            if (__jsonProps.Contains("output_index")) __score14++;
            if (__jsonProps.Contains("response_id")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("content_index")) __score15++;
            if (__jsonProps.Contains("event_id")) __score15++;
            if (__jsonProps.Contains("item_id")) __score15++;
            if (__jsonProps.Contains("output_index")) __score15++;
            if (__jsonProps.Contains("response_id")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("content_index")) __score16++;
            if (__jsonProps.Contains("delta")) __score16++;
            if (__jsonProps.Contains("event_id")) __score16++;
            if (__jsonProps.Contains("item_id")) __score16++;
            if (__jsonProps.Contains("output_index")) __score16++;
            if (__jsonProps.Contains("response_id")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("content_index")) __score17++;
            if (__jsonProps.Contains("event_id")) __score17++;
            if (__jsonProps.Contains("item_id")) __score17++;
            if (__jsonProps.Contains("output_index")) __score17++;
            if (__jsonProps.Contains("response_id")) __score17++;
            if (__jsonProps.Contains("transcript")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("content_index")) __score18++;
            if (__jsonProps.Contains("event_id")) __score18++;
            if (__jsonProps.Contains("item_id")) __score18++;
            if (__jsonProps.Contains("output_index")) __score18++;
            if (__jsonProps.Contains("part")) __score18++;
            if (__jsonProps.Contains("response_id")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("content_index")) __score19++;
            if (__jsonProps.Contains("event_id")) __score19++;
            if (__jsonProps.Contains("item_id")) __score19++;
            if (__jsonProps.Contains("output_index")) __score19++;
            if (__jsonProps.Contains("part")) __score19++;
            if (__jsonProps.Contains("response_id")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("event_id")) __score20++;
            if (__jsonProps.Contains("response")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("event_id")) __score21++;
            if (__jsonProps.Contains("response")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("call_id")) __score22++;
            if (__jsonProps.Contains("delta")) __score22++;
            if (__jsonProps.Contains("event_id")) __score22++;
            if (__jsonProps.Contains("item_id")) __score22++;
            if (__jsonProps.Contains("output_index")) __score22++;
            if (__jsonProps.Contains("response_id")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("arguments")) __score23++;
            if (__jsonProps.Contains("call_id")) __score23++;
            if (__jsonProps.Contains("event_id")) __score23++;
            if (__jsonProps.Contains("item_id")) __score23++;
            if (__jsonProps.Contains("output_index")) __score23++;
            if (__jsonProps.Contains("response_id")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("event_id")) __score24++;
            if (__jsonProps.Contains("item")) __score24++;
            if (__jsonProps.Contains("output_index")) __score24++;
            if (__jsonProps.Contains("response_id")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("event_id")) __score25++;
            if (__jsonProps.Contains("item")) __score25++;
            if (__jsonProps.Contains("output_index")) __score25++;
            if (__jsonProps.Contains("response_id")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("content_index")) __score26++;
            if (__jsonProps.Contains("delta")) __score26++;
            if (__jsonProps.Contains("event_id")) __score26++;
            if (__jsonProps.Contains("item_id")) __score26++;
            if (__jsonProps.Contains("output_index")) __score26++;
            if (__jsonProps.Contains("response_id")) __score26++;
            if (__jsonProps.Contains("type")) __score26++;
            var __score27 = 0;
            if (__jsonProps.Contains("content_index")) __score27++;
            if (__jsonProps.Contains("event_id")) __score27++;
            if (__jsonProps.Contains("item_id")) __score27++;
            if (__jsonProps.Contains("output_index")) __score27++;
            if (__jsonProps.Contains("response_id")) __score27++;
            if (__jsonProps.Contains("text")) __score27++;
            if (__jsonProps.Contains("type")) __score27++;
            var __score28 = 0;
            if (__jsonProps.Contains("event_id")) __score28++;
            if (__jsonProps.Contains("session")) __score28++;
            if (__jsonProps.Contains("type")) __score28++;
            var __score29 = 0;
            if (__jsonProps.Contains("event_id")) __score29++;
            if (__jsonProps.Contains("session")) __score29++;
            if (__jsonProps.Contains("type")) __score29++;
            var __score30 = 0;
            if (__jsonProps.Contains("event_id")) __score30++;
            if (__jsonProps.Contains("session")) __score30++;
            if (__jsonProps.Contains("type")) __score30++;
            var __score31 = 0;
            if (__jsonProps.Contains("event_id")) __score31++;
            if (__jsonProps.Contains("response_id")) __score31++;
            if (__jsonProps.Contains("type")) __score31++;
            var __score32 = 0;
            if (__jsonProps.Contains("event_id")) __score32++;
            if (__jsonProps.Contains("response_id")) __score32++;
            if (__jsonProps.Contains("type")) __score32++;
            var __score33 = 0;
            if (__jsonProps.Contains("event_id")) __score33++;
            if (__jsonProps.Contains("response_id")) __score33++;
            if (__jsonProps.Contains("type")) __score33++;
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
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }
            if (__score25 > __bestScore) { __bestScore = __score25; __bestIndex = 25; }
            if (__score26 > __bestScore) { __bestScore = __score26; __bestIndex = 26; }
            if (__score27 > __bestScore) { __bestScore = __score27; __bestIndex = 27; }
            if (__score28 > __bestScore) { __bestScore = __score28; __bestIndex = 28; }
            if (__score29 > __bestScore) { __bestScore = __score29; __bestIndex = 29; }
            if (__score30 > __bestScore) { __bestScore = __score30; __bestIndex = 30; }
            if (__score31 > __bestScore) { __bestScore = __score31; __bestIndex = 31; }
            if (__score32 > __bestScore) { __bestScore = __score32; __bestIndex = 32; }
            if (__score33 > __bestScore) { __bestScore = __score33; __bestIndex = 33; }

            global::G.RealtimeServerEventConversationCreated? conversationCreated = default;
            global::G.RealtimeServerEventConversationItemCreated? conversationItemCreated = default;
            global::G.RealtimeServerEventConversationItemDeleted? conversationItemDeleted = default;
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted = default;
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta = default;
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed = default;
            global::G.RealtimeServerEventConversationItemRetrieved? conversationItemRetrieved = default;
            global::G.RealtimeServerEventConversationItemTruncated? conversationItemTruncated = default;
            global::G.RealtimeServerEventError? error = default;
            global::G.RealtimeServerEventInputAudioBufferCleared? inputAudioBufferCleared = default;
            global::G.RealtimeServerEventInputAudioBufferCommitted? inputAudioBufferCommitted = default;
            global::G.RealtimeServerEventInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted = default;
            global::G.RealtimeServerEventInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped = default;
            global::G.RealtimeServerEventRateLimitsUpdated? rateLimitsUpdated = default;
            global::G.RealtimeServerEventResponseAudioDelta? responseAudioDelta = default;
            global::G.RealtimeServerEventResponseAudioDone? responseAudioDone = default;
            global::G.RealtimeServerEventResponseAudioTranscriptDelta? responseAudioTranscriptDelta = default;
            global::G.RealtimeServerEventResponseAudioTranscriptDone? responseAudioTranscriptDone = default;
            global::G.RealtimeServerEventResponseContentPartAdded? responseContentPartAdded = default;
            global::G.RealtimeServerEventResponseContentPartDone? responseContentPartDone = default;
            global::G.RealtimeServerEventResponseCreated? responseCreated = default;
            global::G.RealtimeServerEventResponseDone? responseDone = default;
            global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta = default;
            global::G.RealtimeServerEventResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone = default;
            global::G.RealtimeServerEventResponseOutputItemAdded? responseOutputItemAdded = default;
            global::G.RealtimeServerEventResponseOutputItemDone? responseOutputItemDone = default;
            global::G.RealtimeServerEventResponseTextDelta? responseTextDelta = default;
            global::G.RealtimeServerEventResponseTextDone? responseTextDone = default;
            global::G.RealtimeServerEventSessionCreated? sessionCreated = default;
            global::G.RealtimeServerEventSessionUpdated? sessionUpdated = default;
            global::G.RealtimeServerEventTranscriptionSessionUpdated? transcriptionSessionUpdated = default;
            global::G.RealtimeServerEventOutputAudioBufferStarted? outputAudioBufferStarted = default;
            global::G.RealtimeServerEventOutputAudioBufferStopped? outputAudioBufferStopped = default;
            global::G.RealtimeServerEventOutputAudioBufferCleared? outputAudioBufferCleared = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationCreated>(__rawJson, options);
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
                        conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemCreated>(__rawJson, options);
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
                        conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemDeleted>(__rawJson, options);
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
                        conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted>(__rawJson, options);
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
                        conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta>(__rawJson, options);
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
                        conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed>(__rawJson, options);
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
                        conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemRetrieved>(__rawJson, options);
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
                        conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemTruncated>(__rawJson, options);
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
                        error = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventError>(__rawJson, options);
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
                        inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventInputAudioBufferCleared>(__rawJson, options);
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
                        inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventInputAudioBufferCommitted>(__rawJson, options);
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
                        inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventInputAudioBufferSpeechStarted>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventInputAudioBufferSpeechStopped>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventRateLimitsUpdated>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseAudioDelta>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseAudioDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseAudioTranscriptDelta>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseAudioTranscriptDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseContentPartAdded>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseContentPartDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        responseCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseCreated>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        responseDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 23)
                {
                    try
                    {
                        responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 24)
                {
                    try
                    {
                        responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseOutputItemAdded>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 25)
                {
                    try
                    {
                        responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseOutputItemDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 26)
                {
                    try
                    {
                        responseTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseTextDelta>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 27)
                {
                    try
                    {
                        responseTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseTextDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 28)
                {
                    try
                    {
                        sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventSessionCreated>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 29)
                {
                    try
                    {
                        sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventSessionUpdated>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 30)
                {
                    try
                    {
                        transcriptionSessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventTranscriptionSessionUpdated>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 31)
                {
                    try
                    {
                        outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventOutputAudioBufferStarted>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 32)
                {
                    try
                    {
                        outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventOutputAudioBufferStopped>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 33)
                {
                    try
                    {
                        outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventOutputAudioBufferCleared>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (conversationCreated == null && conversationItemCreated == null && conversationItemDeleted == null && conversationItemInputAudioTranscriptionCompleted == null && conversationItemInputAudioTranscriptionDelta == null && conversationItemInputAudioTranscriptionFailed == null && conversationItemRetrieved == null && conversationItemTruncated == null && error == null && inputAudioBufferCleared == null && inputAudioBufferCommitted == null && inputAudioBufferSpeechStarted == null && inputAudioBufferSpeechStopped == null && rateLimitsUpdated == null && responseAudioDelta == null && responseAudioDone == null && responseAudioTranscriptDelta == null && responseAudioTranscriptDone == null && responseContentPartAdded == null && responseContentPartDone == null && responseCreated == null && responseDone == null && responseFunctionCallArgumentsDelta == null && responseFunctionCallArgumentsDone == null && responseOutputItemAdded == null && responseOutputItemDone == null && responseTextDelta == null && responseTextDone == null && sessionCreated == null && sessionUpdated == null && transcriptionSessionUpdated == null && outputAudioBufferStarted == null && outputAudioBufferStopped == null && outputAudioBufferCleared == null)
            {
                try
                {
                    conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationCreated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemCreated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemDeleted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemRetrieved>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventConversationItemTruncated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    error = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventError>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventInputAudioBufferCleared>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventInputAudioBufferCommitted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventInputAudioBufferSpeechStarted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventInputAudioBufferSpeechStopped>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventRateLimitsUpdated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseAudioDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseAudioDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseAudioTranscriptDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseAudioTranscriptDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseContentPartAdded>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseContentPartDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseCreated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseOutputItemAdded>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseOutputItemDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseTextDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventResponseTextDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventSessionCreated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventSessionUpdated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    transcriptionSessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventTranscriptionSessionUpdated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventOutputAudioBufferStarted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventOutputAudioBufferStopped>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RealtimeServerEventOutputAudioBufferCleared>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RealtimeServerEvent(
                conversationCreated,

                conversationItemCreated,

                conversationItemDeleted,

                conversationItemInputAudioTranscriptionCompleted,

                conversationItemInputAudioTranscriptionDelta,

                conversationItemInputAudioTranscriptionFailed,

                conversationItemRetrieved,

                conversationItemTruncated,

                error,

                inputAudioBufferCleared,

                inputAudioBufferCommitted,

                inputAudioBufferSpeechStarted,

                inputAudioBufferSpeechStopped,

                rateLimitsUpdated,

                responseAudioDelta,

                responseAudioDone,

                responseAudioTranscriptDelta,

                responseAudioTranscriptDone,

                responseContentPartAdded,

                responseContentPartDone,

                responseCreated,

                responseDone,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseTextDelta,

                responseTextDone,

                sessionCreated,

                sessionUpdated,

                transcriptionSessionUpdated,

                outputAudioBufferStarted,

                outputAudioBufferStopped,

                outputAudioBufferCleared
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RealtimeServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsConversationCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated, typeof(global::G.RealtimeServerEventConversationCreated), options);
            }
            else if (value.IsConversationItemCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreated, typeof(global::G.RealtimeServerEventConversationItemCreated), options);
            }
            else if (value.IsConversationItemDeleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDeleted, typeof(global::G.RealtimeServerEventConversationItemDeleted), options);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionCompleted, typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options);
            }
            else if (value.IsConversationItemInputAudioTranscriptionDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionDelta, typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options);
            }
            else if (value.IsConversationItemInputAudioTranscriptionFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionFailed, typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options);
            }
            else if (value.IsConversationItemRetrieved)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemRetrieved, typeof(global::G.RealtimeServerEventConversationItemRetrieved), options);
            }
            else if (value.IsConversationItemTruncated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncated, typeof(global::G.RealtimeServerEventConversationItemTruncated), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::G.RealtimeServerEventError), options);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCleared, typeof(global::G.RealtimeServerEventInputAudioBufferCleared), options);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted, typeof(global::G.RealtimeServerEventInputAudioBufferCommitted), options);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted, typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted), options);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped, typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped), options);
            }
            else if (value.IsRateLimitsUpdated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsUpdated, typeof(global::G.RealtimeServerEventRateLimitsUpdated), options);
            }
            else if (value.IsResponseAudioDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta, typeof(global::G.RealtimeServerEventResponseAudioDelta), options);
            }
            else if (value.IsResponseAudioDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone, typeof(global::G.RealtimeServerEventResponseAudioDone), options);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta, typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta), options);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone, typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone), options);
            }
            else if (value.IsResponseContentPartAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded, typeof(global::G.RealtimeServerEventResponseContentPartAdded), options);
            }
            else if (value.IsResponseContentPartDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone, typeof(global::G.RealtimeServerEventResponseContentPartDone), options);
            }
            else if (value.IsResponseCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeof(global::G.RealtimeServerEventResponseCreated), options);
            }
            else if (value.IsResponseDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone, typeof(global::G.RealtimeServerEventResponseDone), options);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta, typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta), options);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone), options);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeof(global::G.RealtimeServerEventResponseOutputItemAdded), options);
            }
            else if (value.IsResponseOutputItemDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone, typeof(global::G.RealtimeServerEventResponseOutputItemDone), options);
            }
            else if (value.IsResponseTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDelta, typeof(global::G.RealtimeServerEventResponseTextDelta), options);
            }
            else if (value.IsResponseTextDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDone, typeof(global::G.RealtimeServerEventResponseTextDone), options);
            }
            else if (value.IsSessionCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated, typeof(global::G.RealtimeServerEventSessionCreated), options);
            }
            else if (value.IsSessionUpdated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated, typeof(global::G.RealtimeServerEventSessionUpdated), options);
            }
            else if (value.IsTranscriptionSessionUpdated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionSessionUpdated, typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated), options);
            }
            else if (value.IsOutputAudioBufferStarted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStarted, typeof(global::G.RealtimeServerEventOutputAudioBufferStarted), options);
            }
            else if (value.IsOutputAudioBufferStopped)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStopped, typeof(global::G.RealtimeServerEventOutputAudioBufferStopped), options);
            }
            else if (value.IsOutputAudioBufferCleared)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferCleared, typeof(global::G.RealtimeServerEventOutputAudioBufferCleared), options);
            }
        }
    }
}