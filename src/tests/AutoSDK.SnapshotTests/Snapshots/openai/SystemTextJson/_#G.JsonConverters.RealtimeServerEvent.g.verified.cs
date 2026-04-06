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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationCreated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationCreated).Name}");
                        conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemCreated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemCreated).Name}");
                        conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemDeleted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemDeleted).Name}");
                        conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                        conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                        conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                        conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemRetrieved> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemRetrieved).Name}");
                        conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemTruncated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemTruncated).Name}");
                        conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventError).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCleared> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCleared).Name}");
                        inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCommitted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCommitted).Name}");
                        inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStarted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                        inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStopped> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                        inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventRateLimitsUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventRateLimitsUpdated).Name}");
                        rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDelta).Name}");
                        responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDone).Name}");
                        responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                        responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                        responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartAdded> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartAdded).Name}");
                        responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartDone).Name}");
                        responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseCreated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseCreated).Name}");
                        responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseDone).Name}");
                        responseDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                        responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                        responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemAdded> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemAdded).Name}");
                        responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemDone).Name}");
                        responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDelta).Name}");
                        responseTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDone).Name}");
                        responseTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionCreated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionCreated).Name}");
                        sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionUpdated).Name}");
                        sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventTranscriptionSessionUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated).Name}");
                        transcriptionSessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStarted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStarted).Name}");
                        outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStopped> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStopped).Name}");
                        outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferCleared> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferCleared).Name}");
                        outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationCreated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationCreated).Name}");
                    conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemCreated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemCreated).Name}");
                    conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemDeleted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemDeleted).Name}");
                    conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                    conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                    conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                    conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemRetrieved> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemRetrieved).Name}");
                    conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemTruncated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemTruncated).Name}");
                    conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventError).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCleared> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCleared).Name}");
                    inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCommitted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCommitted).Name}");
                    inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStarted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                    inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStopped> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                    inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventRateLimitsUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventRateLimitsUpdated).Name}");
                    rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDelta).Name}");
                    responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDone).Name}");
                    responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                    responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                    responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartAdded> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartAdded).Name}");
                    responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartDone).Name}");
                    responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseCreated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseCreated).Name}");
                    responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseDone).Name}");
                    responseDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                    responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                    responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemAdded> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemAdded).Name}");
                    responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemDone).Name}");
                    responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDelta).Name}");
                    responseTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDone).Name}");
                    responseTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionCreated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionCreated).Name}");
                    sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionUpdated).Name}");
                    sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventTranscriptionSessionUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated).Name}");
                    transcriptionSessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStarted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStarted).Name}");
                    outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStopped> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStopped).Name}");
                    outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferCleared> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferCleared).Name}");
                    outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated!, typeInfo);
            }
            else if (value.IsConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreated!, typeInfo);
            }
            else if (value.IsConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDeleted!, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionCompleted!, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionDelta!, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionFailed!, typeInfo);
            }
            else if (value.IsConversationItemRetrieved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemRetrieved?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemRetrieved).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemRetrieved!, typeInfo);
            }
            else if (value.IsConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventConversationItemTruncated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventConversationItemTruncated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncated!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCleared!, typeInfo);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferCommitted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferCommitted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted!, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted!, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventInputAudioBufferSpeechStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped!, typeInfo);
            }
            else if (value.IsRateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventRateLimitsUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventRateLimitsUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsUpdated!, typeInfo);
            }
            else if (value.IsResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta!, typeInfo);
            }
            else if (value.IsResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone!, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta!, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseAudioTranscriptDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone!, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded!, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseContentPartDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseContentPartDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone!, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated!, typeInfo);
            }
            else if (value.IsResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseFunctionCallArgumentsDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone!, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded!, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseOutputItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseOutputItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone!, typeInfo);
            }
            else if (value.IsResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDelta!, typeInfo);
            }
            else if (value.IsResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventResponseTextDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventResponseTextDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDone!, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated!, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated!, typeInfo);
            }
            else if (value.IsTranscriptionSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventTranscriptionSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventTranscriptionSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionSessionUpdated!, typeInfo);
            }
            else if (value.IsOutputAudioBufferStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStarted!, typeInfo);
            }
            else if (value.IsOutputAudioBufferStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStopped!, typeInfo);
            }
            else if (value.IsOutputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RealtimeServerEventOutputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RealtimeServerEventOutputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferCleared!, typeInfo);
            }
        }
    }
}