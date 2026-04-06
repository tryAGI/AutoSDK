//HintName: G.JsonConverters.ResponseStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.ResponseStreamEvent Read(
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
            if (__jsonProps.Contains("delta")) __score0++;
            if (__jsonProps.Contains("sequence_number")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("sequence_number")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("delta")) __score2++;
            if (__jsonProps.Contains("sequence_number")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("sequence_number")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("delta")) __score4++;
            if (__jsonProps.Contains("output_index")) __score4++;
            if (__jsonProps.Contains("sequence_number")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("code")) __score5++;
            if (__jsonProps.Contains("output_index")) __score5++;
            if (__jsonProps.Contains("sequence_number")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("code_interpreter_call")) __score6++;
            if (__jsonProps.Contains("output_index")) __score6++;
            if (__jsonProps.Contains("sequence_number")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("code_interpreter_call")) __score7++;
            if (__jsonProps.Contains("output_index")) __score7++;
            if (__jsonProps.Contains("sequence_number")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("code_interpreter_call")) __score8++;
            if (__jsonProps.Contains("output_index")) __score8++;
            if (__jsonProps.Contains("sequence_number")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("response")) __score9++;
            if (__jsonProps.Contains("sequence_number")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("content_index")) __score10++;
            if (__jsonProps.Contains("item_id")) __score10++;
            if (__jsonProps.Contains("output_index")) __score10++;
            if (__jsonProps.Contains("part")) __score10++;
            if (__jsonProps.Contains("sequence_number")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("content_index")) __score11++;
            if (__jsonProps.Contains("item_id")) __score11++;
            if (__jsonProps.Contains("output_index")) __score11++;
            if (__jsonProps.Contains("part")) __score11++;
            if (__jsonProps.Contains("sequence_number")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("response")) __score12++;
            if (__jsonProps.Contains("sequence_number")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("code")) __score13++;
            if (__jsonProps.Contains("message")) __score13++;
            if (__jsonProps.Contains("param")) __score13++;
            if (__jsonProps.Contains("sequence_number")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("item_id")) __score14++;
            if (__jsonProps.Contains("output_index")) __score14++;
            if (__jsonProps.Contains("sequence_number")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("item_id")) __score15++;
            if (__jsonProps.Contains("output_index")) __score15++;
            if (__jsonProps.Contains("sequence_number")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("item_id")) __score16++;
            if (__jsonProps.Contains("output_index")) __score16++;
            if (__jsonProps.Contains("sequence_number")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("delta")) __score17++;
            if (__jsonProps.Contains("item_id")) __score17++;
            if (__jsonProps.Contains("output_index")) __score17++;
            if (__jsonProps.Contains("sequence_number")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("arguments")) __score18++;
            if (__jsonProps.Contains("item_id")) __score18++;
            if (__jsonProps.Contains("output_index")) __score18++;
            if (__jsonProps.Contains("sequence_number")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("response")) __score19++;
            if (__jsonProps.Contains("sequence_number")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("response")) __score20++;
            if (__jsonProps.Contains("sequence_number")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("response")) __score21++;
            if (__jsonProps.Contains("sequence_number")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("item")) __score22++;
            if (__jsonProps.Contains("output_index")) __score22++;
            if (__jsonProps.Contains("sequence_number")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("item")) __score23++;
            if (__jsonProps.Contains("output_index")) __score23++;
            if (__jsonProps.Contains("sequence_number")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("item_id")) __score24++;
            if (__jsonProps.Contains("output_index")) __score24++;
            if (__jsonProps.Contains("part")) __score24++;
            if (__jsonProps.Contains("sequence_number")) __score24++;
            if (__jsonProps.Contains("summary_index")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("item_id")) __score25++;
            if (__jsonProps.Contains("output_index")) __score25++;
            if (__jsonProps.Contains("part")) __score25++;
            if (__jsonProps.Contains("sequence_number")) __score25++;
            if (__jsonProps.Contains("summary_index")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("delta")) __score26++;
            if (__jsonProps.Contains("item_id")) __score26++;
            if (__jsonProps.Contains("output_index")) __score26++;
            if (__jsonProps.Contains("sequence_number")) __score26++;
            if (__jsonProps.Contains("summary_index")) __score26++;
            if (__jsonProps.Contains("type")) __score26++;
            var __score27 = 0;
            if (__jsonProps.Contains("item_id")) __score27++;
            if (__jsonProps.Contains("output_index")) __score27++;
            if (__jsonProps.Contains("sequence_number")) __score27++;
            if (__jsonProps.Contains("summary_index")) __score27++;
            if (__jsonProps.Contains("text")) __score27++;
            if (__jsonProps.Contains("type")) __score27++;
            var __score28 = 0;
            if (__jsonProps.Contains("content_index")) __score28++;
            if (__jsonProps.Contains("delta")) __score28++;
            if (__jsonProps.Contains("item_id")) __score28++;
            if (__jsonProps.Contains("output_index")) __score28++;
            if (__jsonProps.Contains("sequence_number")) __score28++;
            if (__jsonProps.Contains("type")) __score28++;
            var __score29 = 0;
            if (__jsonProps.Contains("content_index")) __score29++;
            if (__jsonProps.Contains("item_id")) __score29++;
            if (__jsonProps.Contains("output_index")) __score29++;
            if (__jsonProps.Contains("refusal")) __score29++;
            if (__jsonProps.Contains("sequence_number")) __score29++;
            if (__jsonProps.Contains("type")) __score29++;
            var __score30 = 0;
            if (__jsonProps.Contains("content_index")) __score30++;
            if (__jsonProps.Contains("delta")) __score30++;
            if (__jsonProps.Contains("item_id")) __score30++;
            if (__jsonProps.Contains("output_index")) __score30++;
            if (__jsonProps.Contains("sequence_number")) __score30++;
            if (__jsonProps.Contains("type")) __score30++;
            var __score31 = 0;
            if (__jsonProps.Contains("content_index")) __score31++;
            if (__jsonProps.Contains("item_id")) __score31++;
            if (__jsonProps.Contains("output_index")) __score31++;
            if (__jsonProps.Contains("sequence_number")) __score31++;
            if (__jsonProps.Contains("text")) __score31++;
            if (__jsonProps.Contains("type")) __score31++;
            var __score32 = 0;
            if (__jsonProps.Contains("item_id")) __score32++;
            if (__jsonProps.Contains("output_index")) __score32++;
            if (__jsonProps.Contains("sequence_number")) __score32++;
            if (__jsonProps.Contains("type")) __score32++;
            var __score33 = 0;
            if (__jsonProps.Contains("item_id")) __score33++;
            if (__jsonProps.Contains("output_index")) __score33++;
            if (__jsonProps.Contains("sequence_number")) __score33++;
            if (__jsonProps.Contains("type")) __score33++;
            var __score34 = 0;
            if (__jsonProps.Contains("item_id")) __score34++;
            if (__jsonProps.Contains("output_index")) __score34++;
            if (__jsonProps.Contains("sequence_number")) __score34++;
            if (__jsonProps.Contains("type")) __score34++;
            var __score35 = 0;
            if (__jsonProps.Contains("item_id")) __score35++;
            if (__jsonProps.Contains("output_index")) __score35++;
            if (__jsonProps.Contains("sequence_number")) __score35++;
            if (__jsonProps.Contains("type")) __score35++;
            var __score36 = 0;
            if (__jsonProps.Contains("item_id")) __score36++;
            if (__jsonProps.Contains("output_index")) __score36++;
            if (__jsonProps.Contains("sequence_number")) __score36++;
            if (__jsonProps.Contains("type")) __score36++;
            var __score37 = 0;
            if (__jsonProps.Contains("item_id")) __score37++;
            if (__jsonProps.Contains("output_index")) __score37++;
            if (__jsonProps.Contains("sequence_number")) __score37++;
            if (__jsonProps.Contains("type")) __score37++;
            var __score38 = 0;
            if (__jsonProps.Contains("item_id")) __score38++;
            if (__jsonProps.Contains("output_index")) __score38++;
            if (__jsonProps.Contains("partial_image_b64")) __score38++;
            if (__jsonProps.Contains("partial_image_index")) __score38++;
            if (__jsonProps.Contains("sequence_number")) __score38++;
            if (__jsonProps.Contains("type")) __score38++;
            var __score39 = 0;
            if (__jsonProps.Contains("delta")) __score39++;
            if (__jsonProps.Contains("item_id")) __score39++;
            if (__jsonProps.Contains("output_index")) __score39++;
            if (__jsonProps.Contains("sequence_number")) __score39++;
            if (__jsonProps.Contains("type")) __score39++;
            var __score40 = 0;
            if (__jsonProps.Contains("arguments")) __score40++;
            if (__jsonProps.Contains("item_id")) __score40++;
            if (__jsonProps.Contains("output_index")) __score40++;
            if (__jsonProps.Contains("sequence_number")) __score40++;
            if (__jsonProps.Contains("type")) __score40++;
            var __score41 = 0;
            if (__jsonProps.Contains("sequence_number")) __score41++;
            if (__jsonProps.Contains("type")) __score41++;
            var __score42 = 0;
            if (__jsonProps.Contains("sequence_number")) __score42++;
            if (__jsonProps.Contains("type")) __score42++;
            var __score43 = 0;
            if (__jsonProps.Contains("item_id")) __score43++;
            if (__jsonProps.Contains("output_index")) __score43++;
            if (__jsonProps.Contains("sequence_number")) __score43++;
            if (__jsonProps.Contains("type")) __score43++;
            var __score44 = 0;
            if (__jsonProps.Contains("sequence_number")) __score44++;
            if (__jsonProps.Contains("type")) __score44++;
            var __score45 = 0;
            if (__jsonProps.Contains("sequence_number")) __score45++;
            if (__jsonProps.Contains("type")) __score45++;
            var __score46 = 0;
            if (__jsonProps.Contains("sequence_number")) __score46++;
            if (__jsonProps.Contains("type")) __score46++;
            var __score47 = 0;
            if (__jsonProps.Contains("annotation")) __score47++;
            if (__jsonProps.Contains("annotation_index")) __score47++;
            if (__jsonProps.Contains("content_index")) __score47++;
            if (__jsonProps.Contains("item_id")) __score47++;
            if (__jsonProps.Contains("output_index")) __score47++;
            if (__jsonProps.Contains("sequence_number")) __score47++;
            if (__jsonProps.Contains("type")) __score47++;
            var __score48 = 0;
            if (__jsonProps.Contains("response")) __score48++;
            if (__jsonProps.Contains("sequence_number")) __score48++;
            if (__jsonProps.Contains("type")) __score48++;
            var __score49 = 0;
            if (__jsonProps.Contains("content_index")) __score49++;
            if (__jsonProps.Contains("delta")) __score49++;
            if (__jsonProps.Contains("item_id")) __score49++;
            if (__jsonProps.Contains("output_index")) __score49++;
            if (__jsonProps.Contains("sequence_number")) __score49++;
            if (__jsonProps.Contains("type")) __score49++;
            var __score50 = 0;
            if (__jsonProps.Contains("content_index")) __score50++;
            if (__jsonProps.Contains("item_id")) __score50++;
            if (__jsonProps.Contains("output_index")) __score50++;
            if (__jsonProps.Contains("sequence_number")) __score50++;
            if (__jsonProps.Contains("text")) __score50++;
            if (__jsonProps.Contains("type")) __score50++;
            var __score51 = 0;
            if (__jsonProps.Contains("delta")) __score51++;
            if (__jsonProps.Contains("item_id")) __score51++;
            if (__jsonProps.Contains("output_index")) __score51++;
            if (__jsonProps.Contains("sequence_number")) __score51++;
            if (__jsonProps.Contains("summary_index")) __score51++;
            if (__jsonProps.Contains("type")) __score51++;
            var __score52 = 0;
            if (__jsonProps.Contains("item_id")) __score52++;
            if (__jsonProps.Contains("output_index")) __score52++;
            if (__jsonProps.Contains("sequence_number")) __score52++;
            if (__jsonProps.Contains("summary_index")) __score52++;
            if (__jsonProps.Contains("text")) __score52++;
            if (__jsonProps.Contains("type")) __score52++;
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
            if (__score34 > __bestScore) { __bestScore = __score34; __bestIndex = 34; }
            if (__score35 > __bestScore) { __bestScore = __score35; __bestIndex = 35; }
            if (__score36 > __bestScore) { __bestScore = __score36; __bestIndex = 36; }
            if (__score37 > __bestScore) { __bestScore = __score37; __bestIndex = 37; }
            if (__score38 > __bestScore) { __bestScore = __score38; __bestIndex = 38; }
            if (__score39 > __bestScore) { __bestScore = __score39; __bestIndex = 39; }
            if (__score40 > __bestScore) { __bestScore = __score40; __bestIndex = 40; }
            if (__score41 > __bestScore) { __bestScore = __score41; __bestIndex = 41; }
            if (__score42 > __bestScore) { __bestScore = __score42; __bestIndex = 42; }
            if (__score43 > __bestScore) { __bestScore = __score43; __bestIndex = 43; }
            if (__score44 > __bestScore) { __bestScore = __score44; __bestIndex = 44; }
            if (__score45 > __bestScore) { __bestScore = __score45; __bestIndex = 45; }
            if (__score46 > __bestScore) { __bestScore = __score46; __bestIndex = 46; }
            if (__score47 > __bestScore) { __bestScore = __score47; __bestIndex = 47; }
            if (__score48 > __bestScore) { __bestScore = __score48; __bestIndex = 48; }
            if (__score49 > __bestScore) { __bestScore = __score49; __bestIndex = 49; }
            if (__score50 > __bestScore) { __bestScore = __score50; __bestIndex = 50; }
            if (__score51 > __bestScore) { __bestScore = __score51; __bestIndex = 51; }
            if (__score52 > __bestScore) { __bestScore = __score52; __bestIndex = 52; }

            global::G.ResponseAudioDeltaEvent? responseAudioDelta = default;
            global::G.ResponseAudioDoneEvent? responseAudioDone = default;
            global::G.ResponseAudioTranscriptDeltaEvent? responseAudioTranscriptDelta = default;
            global::G.ResponseAudioTranscriptDoneEvent? responseAudioTranscriptDone = default;
            global::G.ResponseCodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta = default;
            global::G.ResponseCodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone = default;
            global::G.ResponseCodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted = default;
            global::G.ResponseCodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress = default;
            global::G.ResponseCodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting = default;
            global::G.ResponseCompletedEvent? responseCompleted = default;
            global::G.ResponseContentPartAddedEvent? responseContentPartAdded = default;
            global::G.ResponseContentPartDoneEvent? responseContentPartDone = default;
            global::G.ResponseCreatedEvent? responseCreated = default;
            global::G.ResponseErrorEvent? error = default;
            global::G.ResponseFileSearchCallCompletedEvent? responseFileSearchCallCompleted = default;
            global::G.ResponseFileSearchCallInProgressEvent? responseFileSearchCallInProgress = default;
            global::G.ResponseFileSearchCallSearchingEvent? responseFileSearchCallSearching = default;
            global::G.ResponseFunctionCallArgumentsDeltaEvent? responseFunctionCallArgumentsDelta = default;
            global::G.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone = default;
            global::G.ResponseInProgressEvent? responseInProgress = default;
            global::G.ResponseFailedEvent? responseFailed = default;
            global::G.ResponseIncompleteEvent? responseIncomplete = default;
            global::G.ResponseOutputItemAddedEvent? responseOutputItemAdded = default;
            global::G.ResponseOutputItemDoneEvent? responseOutputItemDone = default;
            global::G.ResponseReasoningSummaryPartAddedEvent? responseReasoningSummaryPartAdded = default;
            global::G.ResponseReasoningSummaryPartDoneEvent? responseReasoningSummaryPartDone = default;
            global::G.ResponseReasoningSummaryTextDeltaEvent? responseReasoningSummaryTextDelta = default;
            global::G.ResponseReasoningSummaryTextDoneEvent? responseReasoningSummaryTextDone = default;
            global::G.ResponseRefusalDeltaEvent? responseRefusalDelta = default;
            global::G.ResponseRefusalDoneEvent? responseRefusalDone = default;
            global::G.ResponseTextDeltaEvent? responseOutputTextDelta = default;
            global::G.ResponseTextDoneEvent? responseOutputTextDone = default;
            global::G.ResponseWebSearchCallCompletedEvent? responseWebSearchCallCompleted = default;
            global::G.ResponseWebSearchCallInProgressEvent? responseWebSearchCallInProgress = default;
            global::G.ResponseWebSearchCallSearchingEvent? responseWebSearchCallSearching = default;
            global::G.ResponseImageGenCallCompletedEvent? responseImageGenerationCallCompleted = default;
            global::G.ResponseImageGenCallGeneratingEvent? responseImageGenerationCallGenerating = default;
            global::G.ResponseImageGenCallInProgressEvent? responseImageGenerationCallInProgress = default;
            global::G.ResponseImageGenCallPartialImageEvent? responseImageGenerationCallPartialImage = default;
            global::G.ResponseMCPCallArgumentsDeltaEvent? responseMcpCallArgumentsDelta = default;
            global::G.ResponseMCPCallArgumentsDoneEvent? responseMcpCallArgumentsDone = default;
            global::G.ResponseMCPCallCompletedEvent? responseMcpCallCompleted = default;
            global::G.ResponseMCPCallFailedEvent? responseMcpCallFailed = default;
            global::G.ResponseMCPCallInProgressEvent? responseMcpCallInProgress = default;
            global::G.ResponseMCPListToolsCompletedEvent? responseMcpListToolsCompleted = default;
            global::G.ResponseMCPListToolsFailedEvent? responseMcpListToolsFailed = default;
            global::G.ResponseMCPListToolsInProgressEvent? responseMcpListToolsInProgress = default;
            global::G.ResponseOutputTextAnnotationAddedEvent? responseOutputTextAnnotationAdded = default;
            global::G.ResponseQueuedEvent? responseQueued = default;
            global::G.ResponseReasoningDeltaEvent? responseReasoningDelta = default;
            global::G.ResponseReasoningDoneEvent? responseReasoningDone = default;
            global::G.ResponseReasoningSummaryDeltaEvent? responseReasoningSummaryDelta = default;
            global::G.ResponseReasoningSummaryDoneEvent? responseReasoningSummaryDone = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDeltaEvent).Name}");
                        responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDoneEvent).Name}");
                        responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDeltaEvent).Name}");
                        responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDoneEvent).Name}");
                        responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                        responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                        responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCompletedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCompletedEvent).Name}");
                        responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInProgressEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInProgressEvent).Name}");
                        responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInterpretingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                        responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCompletedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCompletedEvent).Name}");
                        responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartAddedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartAddedEvent).Name}");
                        responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartDoneEvent).Name}");
                        responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCreatedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCreatedEvent).Name}");
                        responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseErrorEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseErrorEvent).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallCompletedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallCompletedEvent).Name}");
                        responseFileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallInProgressEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallInProgressEvent).Name}");
                        responseFileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallSearchingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallSearchingEvent).Name}");
                        responseFileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent).Name}");
                        responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDoneEvent).Name}");
                        responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseInProgressEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseInProgressEvent).Name}");
                        responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFailedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFailedEvent).Name}");
                        responseFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseIncompleteEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseIncompleteEvent).Name}");
                        responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemAddedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemAddedEvent).Name}");
                        responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemDoneEvent).Name}");
                        responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartAddedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartAddedEvent).Name}");
                        responseReasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartDoneEvent).Name}");
                        responseReasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDeltaEvent).Name}");
                        responseReasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDoneEvent).Name}");
                        responseReasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDeltaEvent).Name}");
                        responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDoneEvent).Name}");
                        responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDeltaEvent).Name}");
                        responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDoneEvent).Name}");
                        responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallCompletedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallCompletedEvent).Name}");
                        responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallInProgressEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallInProgressEvent).Name}");
                        responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 34)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallSearchingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallSearchingEvent).Name}");
                        responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 35)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallCompletedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallCompletedEvent).Name}");
                        responseImageGenerationCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 36)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallGeneratingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallGeneratingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallGeneratingEvent).Name}");
                        responseImageGenerationCallGenerating = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 37)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallInProgressEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallInProgressEvent).Name}");
                        responseImageGenerationCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 38)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallPartialImageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallPartialImageEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallPartialImageEvent).Name}");
                        responseImageGenerationCallPartialImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 39)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallArgumentsDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallArgumentsDeltaEvent).Name}");
                        responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 40)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallArgumentsDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallArgumentsDoneEvent).Name}");
                        responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 41)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallCompletedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallCompletedEvent).Name}");
                        responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 42)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallFailedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallFailedEvent).Name}");
                        responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 43)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallInProgressEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallInProgressEvent).Name}");
                        responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 44)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsCompletedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsCompletedEvent).Name}");
                        responseMcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 45)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsFailedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsFailedEvent).Name}");
                        responseMcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 46)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsInProgressEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsInProgressEvent).Name}");
                        responseMcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 47)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputTextAnnotationAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputTextAnnotationAddedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputTextAnnotationAddedEvent).Name}");
                        responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 48)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseQueuedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseQueuedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseQueuedEvent).Name}");
                        responseQueued = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 49)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningDeltaEvent).Name}");
                        responseReasoningDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 50)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningDoneEvent).Name}");
                        responseReasoningDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 51)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryDeltaEvent).Name}");
                        responseReasoningSummaryDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 52)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryDoneEvent).Name}");
                        responseReasoningSummaryDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responseAudioDelta == null && responseAudioDone == null && responseAudioTranscriptDelta == null && responseAudioTranscriptDone == null && responseCodeInterpreterCallCodeDelta == null && responseCodeInterpreterCallCodeDone == null && responseCodeInterpreterCallCompleted == null && responseCodeInterpreterCallInProgress == null && responseCodeInterpreterCallInterpreting == null && responseCompleted == null && responseContentPartAdded == null && responseContentPartDone == null && responseCreated == null && error == null && responseFileSearchCallCompleted == null && responseFileSearchCallInProgress == null && responseFileSearchCallSearching == null && responseFunctionCallArgumentsDelta == null && responseFunctionCallArgumentsDone == null && responseInProgress == null && responseFailed == null && responseIncomplete == null && responseOutputItemAdded == null && responseOutputItemDone == null && responseReasoningSummaryPartAdded == null && responseReasoningSummaryPartDone == null && responseReasoningSummaryTextDelta == null && responseReasoningSummaryTextDone == null && responseRefusalDelta == null && responseRefusalDone == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseWebSearchCallCompleted == null && responseWebSearchCallInProgress == null && responseWebSearchCallSearching == null && responseImageGenerationCallCompleted == null && responseImageGenerationCallGenerating == null && responseImageGenerationCallInProgress == null && responseImageGenerationCallPartialImage == null && responseMcpCallArgumentsDelta == null && responseMcpCallArgumentsDone == null && responseMcpCallCompleted == null && responseMcpCallFailed == null && responseMcpCallInProgress == null && responseMcpListToolsCompleted == null && responseMcpListToolsFailed == null && responseMcpListToolsInProgress == null && responseOutputTextAnnotationAdded == null && responseQueued == null && responseReasoningDelta == null && responseReasoningDone == null && responseReasoningSummaryDelta == null && responseReasoningSummaryDone == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDeltaEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDoneEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDeltaEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDoneEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                    responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                    responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCompletedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCompletedEvent).Name}");
                    responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInProgressEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInProgressEvent).Name}");
                    responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInterpretingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                    responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCompletedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCompletedEvent).Name}");
                    responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartAddedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartAddedEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartDoneEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCreatedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCreatedEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseErrorEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseErrorEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallCompletedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallCompletedEvent).Name}");
                    responseFileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallInProgressEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallInProgressEvent).Name}");
                    responseFileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallSearchingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallSearchingEvent).Name}");
                    responseFileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDoneEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseInProgressEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseInProgressEvent).Name}");
                    responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFailedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFailedEvent).Name}");
                    responseFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseIncompleteEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseIncompleteEvent).Name}");
                    responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemAddedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemAddedEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemDoneEvent).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartAddedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartAddedEvent).Name}");
                    responseReasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartDoneEvent).Name}");
                    responseReasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDeltaEvent).Name}");
                    responseReasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDoneEvent).Name}");
                    responseReasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDeltaEvent).Name}");
                    responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDoneEvent).Name}");
                    responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDeltaEvent).Name}");
                    responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDoneEvent).Name}");
                    responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallCompletedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallCompletedEvent).Name}");
                    responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallInProgressEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallInProgressEvent).Name}");
                    responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallSearchingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallSearchingEvent).Name}");
                    responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallCompletedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallCompletedEvent).Name}");
                    responseImageGenerationCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallGeneratingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallGeneratingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallGeneratingEvent).Name}");
                    responseImageGenerationCallGenerating = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallInProgressEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallInProgressEvent).Name}");
                    responseImageGenerationCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallPartialImageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallPartialImageEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallPartialImageEvent).Name}");
                    responseImageGenerationCallPartialImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallArgumentsDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallArgumentsDeltaEvent).Name}");
                    responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallArgumentsDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallArgumentsDoneEvent).Name}");
                    responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallCompletedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallCompletedEvent).Name}");
                    responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallFailedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallFailedEvent).Name}");
                    responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallInProgressEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallInProgressEvent).Name}");
                    responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsCompletedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsCompletedEvent).Name}");
                    responseMcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsFailedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsFailedEvent).Name}");
                    responseMcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsInProgressEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsInProgressEvent).Name}");
                    responseMcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputTextAnnotationAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputTextAnnotationAddedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputTextAnnotationAddedEvent).Name}");
                    responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseQueuedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseQueuedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseQueuedEvent).Name}");
                    responseQueued = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningDeltaEvent).Name}");
                    responseReasoningDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningDoneEvent).Name}");
                    responseReasoningDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryDeltaEvent).Name}");
                    responseReasoningSummaryDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryDoneEvent).Name}");
                    responseReasoningSummaryDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ResponseStreamEvent(
                responseAudioDelta,

                responseAudioDone,

                responseAudioTranscriptDelta,

                responseAudioTranscriptDone,

                responseCodeInterpreterCallCodeDelta,

                responseCodeInterpreterCallCodeDone,

                responseCodeInterpreterCallCompleted,

                responseCodeInterpreterCallInProgress,

                responseCodeInterpreterCallInterpreting,

                responseCompleted,

                responseContentPartAdded,

                responseContentPartDone,

                responseCreated,

                error,

                responseFileSearchCallCompleted,

                responseFileSearchCallInProgress,

                responseFileSearchCallSearching,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                responseInProgress,

                responseFailed,

                responseIncomplete,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseReasoningSummaryPartAdded,

                responseReasoningSummaryPartDone,

                responseReasoningSummaryTextDelta,

                responseReasoningSummaryTextDone,

                responseRefusalDelta,

                responseRefusalDone,

                responseOutputTextDelta,

                responseOutputTextDone,

                responseWebSearchCallCompleted,

                responseWebSearchCallInProgress,

                responseWebSearchCallSearching,

                responseImageGenerationCallCompleted,

                responseImageGenerationCallGenerating,

                responseImageGenerationCallInProgress,

                responseImageGenerationCallPartialImage,

                responseMcpCallArgumentsDelta,

                responseMcpCallArgumentsDone,

                responseMcpCallCompleted,

                responseMcpCallFailed,

                responseMcpCallInProgress,

                responseMcpListToolsCompleted,

                responseMcpListToolsFailed,

                responseMcpListToolsInProgress,

                responseOutputTextAnnotationAdded,

                responseQueued,

                responseReasoningDelta,

                responseReasoningDone,

                responseReasoningSummaryDelta,

                responseReasoningSummaryDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta!, typeInfo);
            }
            else if (value.IsResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone!, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta!, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseAudioTranscriptDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseAudioTranscriptDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDelta!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCodeDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDone!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCompleted!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInProgress!, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCodeInterpreterCallInterpretingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInterpreting!, typeInfo);
            }
            else if (value.IsResponseCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCompleted!, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded!, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseContentPartDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseContentPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone!, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsResponseFileSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallCompleted!, typeInfo);
            }
            else if (value.IsResponseFileSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallInProgress!, typeInfo);
            }
            else if (value.IsResponseFileSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFileSearchCallSearchingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFileSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallSearching!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFunctionCallArgumentsDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFunctionCallArgumentsDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone!, typeInfo);
            }
            else if (value.IsResponseInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseInProgress!, typeInfo);
            }
            else if (value.IsResponseFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFailed!, typeInfo);
            }
            else if (value.IsResponseIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseIncompleteEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseIncompleteEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseIncomplete!, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded!, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputItemDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputItemDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryPartAdded!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryPartDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryPartDone!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryTextDelta!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryTextDone!, typeInfo);
            }
            else if (value.IsResponseRefusalDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDelta!, typeInfo);
            }
            else if (value.IsResponseRefusalDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseRefusalDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseRefusalDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDone!, typeInfo);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDelta!, typeInfo);
            }
            else if (value.IsResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDone!, typeInfo);
            }
            else if (value.IsResponseWebSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallCompleted!, typeInfo);
            }
            else if (value.IsResponseWebSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallInProgress!, typeInfo);
            }
            else if (value.IsResponseWebSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseWebSearchCallSearchingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseWebSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallSearching!, typeInfo);
            }
            else if (value.IsResponseImageGenerationCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallCompleted!, typeInfo);
            }
            else if (value.IsResponseImageGenerationCallGenerating)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallGeneratingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallGeneratingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallGeneratingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallGenerating!, typeInfo);
            }
            else if (value.IsResponseImageGenerationCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallInProgress!, typeInfo);
            }
            else if (value.IsResponseImageGenerationCallPartialImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseImageGenCallPartialImageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseImageGenCallPartialImageEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseImageGenCallPartialImageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallPartialImage!, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallArgumentsDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallArgumentsDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDelta!, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallArgumentsDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallArgumentsDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDone!, typeInfo);
            }
            else if (value.IsResponseMcpCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallCompleted!, typeInfo);
            }
            else if (value.IsResponseMcpCallFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallFailed!, typeInfo);
            }
            else if (value.IsResponseMcpCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallInProgress!, typeInfo);
            }
            else if (value.IsResponseMcpListToolsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsCompleted!, typeInfo);
            }
            else if (value.IsResponseMcpListToolsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsFailed!, typeInfo);
            }
            else if (value.IsResponseMcpListToolsInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseMCPListToolsInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseMCPListToolsInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseMCPListToolsInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsInProgress!, typeInfo);
            }
            else if (value.IsResponseOutputTextAnnotationAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseOutputTextAnnotationAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseOutputTextAnnotationAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseOutputTextAnnotationAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextAnnotationAdded!, typeInfo);
            }
            else if (value.IsResponseQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseQueuedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseQueuedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseQueuedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseQueued!, typeInfo);
            }
            else if (value.IsResponseReasoningDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningDelta!, typeInfo);
            }
            else if (value.IsResponseReasoningDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningDone!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryDelta!, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseReasoningSummaryDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseReasoningSummaryDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseReasoningSummaryDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryDone!, typeInfo);
            }
        }
    }
}