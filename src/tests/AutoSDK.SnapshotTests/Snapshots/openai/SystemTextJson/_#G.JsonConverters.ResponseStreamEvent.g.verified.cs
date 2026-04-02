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
                        responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseAudioDeltaEvent>(__rawJson, options);
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
                        responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseAudioDoneEvent>(__rawJson, options);
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
                        responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseAudioTranscriptDeltaEvent>(__rawJson, options);
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
                        responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseAudioTranscriptDoneEvent>(__rawJson, options);
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
                        responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCodeInterpreterCallCodeDeltaEvent>(__rawJson, options);
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
                        responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCodeInterpreterCallCodeDoneEvent>(__rawJson, options);
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
                        responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCodeInterpreterCallCompletedEvent>(__rawJson, options);
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
                        responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCodeInterpreterCallInProgressEvent>(__rawJson, options);
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
                        responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCodeInterpreterCallInterpretingEvent>(__rawJson, options);
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
                        responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCompletedEvent>(__rawJson, options);
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
                        responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseContentPartAddedEvent>(__rawJson, options);
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
                        responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseContentPartDoneEvent>(__rawJson, options);
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
                        responseCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCreatedEvent>(__rawJson, options);
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
                        error = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseErrorEvent>(__rawJson, options);
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
                        responseFileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFileSearchCallCompletedEvent>(__rawJson, options);
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
                        responseFileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFileSearchCallInProgressEvent>(__rawJson, options);
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
                        responseFileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFileSearchCallSearchingEvent>(__rawJson, options);
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
                        responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFunctionCallArgumentsDeltaEvent>(__rawJson, options);
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
                        responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFunctionCallArgumentsDoneEvent>(__rawJson, options);
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
                        responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseInProgressEvent>(__rawJson, options);
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
                        responseFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFailedEvent>(__rawJson, options);
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
                        responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseIncompleteEvent>(__rawJson, options);
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
                        responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseOutputItemAddedEvent>(__rawJson, options);
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
                        responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseOutputItemDoneEvent>(__rawJson, options);
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
                        responseReasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryPartAddedEvent>(__rawJson, options);
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
                        responseReasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryPartDoneEvent>(__rawJson, options);
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
                        responseReasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryTextDeltaEvent>(__rawJson, options);
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
                        responseReasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryTextDoneEvent>(__rawJson, options);
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
                        responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseRefusalDeltaEvent>(__rawJson, options);
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
                        responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseRefusalDoneEvent>(__rawJson, options);
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
                        responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseTextDeltaEvent>(__rawJson, options);
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
                        responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseTextDoneEvent>(__rawJson, options);
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
                        responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseWebSearchCallCompletedEvent>(__rawJson, options);
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
                        responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseWebSearchCallInProgressEvent>(__rawJson, options);
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
                        responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseWebSearchCallSearchingEvent>(__rawJson, options);
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
                        responseImageGenerationCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseImageGenCallCompletedEvent>(__rawJson, options);
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
                        responseImageGenerationCallGenerating = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseImageGenCallGeneratingEvent>(__rawJson, options);
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
                        responseImageGenerationCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseImageGenCallInProgressEvent>(__rawJson, options);
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
                        responseImageGenerationCallPartialImage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseImageGenCallPartialImageEvent>(__rawJson, options);
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
                        responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPCallArgumentsDeltaEvent>(__rawJson, options);
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
                        responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPCallArgumentsDoneEvent>(__rawJson, options);
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
                        responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPCallCompletedEvent>(__rawJson, options);
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
                        responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPCallFailedEvent>(__rawJson, options);
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
                        responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPCallInProgressEvent>(__rawJson, options);
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
                        responseMcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPListToolsCompletedEvent>(__rawJson, options);
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
                        responseMcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPListToolsFailedEvent>(__rawJson, options);
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
                        responseMcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPListToolsInProgressEvent>(__rawJson, options);
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
                        responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseOutputTextAnnotationAddedEvent>(__rawJson, options);
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
                        responseQueued = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseQueuedEvent>(__rawJson, options);
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
                        responseReasoningDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningDeltaEvent>(__rawJson, options);
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
                        responseReasoningDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningDoneEvent>(__rawJson, options);
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
                        responseReasoningSummaryDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryDeltaEvent>(__rawJson, options);
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
                        responseReasoningSummaryDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryDoneEvent>(__rawJson, options);
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
                    responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseAudioDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseAudioDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseAudioTranscriptDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseAudioTranscriptDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCodeInterpreterCallCodeDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCodeInterpreterCallCodeDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCodeInterpreterCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCodeInterpreterCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCodeInterpreterCallInterpretingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseContentPartAddedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseContentPartDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseCreatedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    error = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseErrorEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFileSearchCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFileSearchCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFileSearchCallSearchingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFunctionCallArgumentsDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFunctionCallArgumentsDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseFailedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseIncompleteEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseOutputItemAddedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseOutputItemDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryPartAddedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryPartDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryTextDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryTextDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseRefusalDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseRefusalDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseTextDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseTextDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseWebSearchCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseWebSearchCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseWebSearchCallSearchingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseImageGenerationCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseImageGenCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseImageGenerationCallGenerating = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseImageGenCallGeneratingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseImageGenerationCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseImageGenCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseImageGenerationCallPartialImage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseImageGenCallPartialImageEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPCallArgumentsDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPCallArgumentsDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPCallFailedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPListToolsCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPListToolsFailedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseMCPListToolsInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseOutputTextAnnotationAddedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseQueued = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseQueuedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningSummaryDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningSummaryDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseReasoningSummaryDoneEvent>(__rawJson, options);
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

            if (value.IsResponseAudioDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta, typeof(global::G.ResponseAudioDeltaEvent), options);
            }
            else if (value.IsResponseAudioDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone, typeof(global::G.ResponseAudioDoneEvent), options);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta, typeof(global::G.ResponseAudioTranscriptDeltaEvent), options);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone, typeof(global::G.ResponseAudioTranscriptDoneEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDelta, typeof(global::G.ResponseCodeInterpreterCallCodeDeltaEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDone, typeof(global::G.ResponseCodeInterpreterCallCodeDoneEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCompleted, typeof(global::G.ResponseCodeInterpreterCallCompletedEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInProgress, typeof(global::G.ResponseCodeInterpreterCallInProgressEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallInterpreting)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInterpreting, typeof(global::G.ResponseCodeInterpreterCallInterpretingEvent), options);
            }
            else if (value.IsResponseCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCompleted, typeof(global::G.ResponseCompletedEvent), options);
            }
            else if (value.IsResponseContentPartAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded, typeof(global::G.ResponseContentPartAddedEvent), options);
            }
            else if (value.IsResponseContentPartDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone, typeof(global::G.ResponseContentPartDoneEvent), options);
            }
            else if (value.IsResponseCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeof(global::G.ResponseCreatedEvent), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::G.ResponseErrorEvent), options);
            }
            else if (value.IsResponseFileSearchCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallCompleted, typeof(global::G.ResponseFileSearchCallCompletedEvent), options);
            }
            else if (value.IsResponseFileSearchCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallInProgress, typeof(global::G.ResponseFileSearchCallInProgressEvent), options);
            }
            else if (value.IsResponseFileSearchCallSearching)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallSearching, typeof(global::G.ResponseFileSearchCallSearchingEvent), options);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta, typeof(global::G.ResponseFunctionCallArgumentsDeltaEvent), options);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeof(global::G.ResponseFunctionCallArgumentsDoneEvent), options);
            }
            else if (value.IsResponseInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseInProgress, typeof(global::G.ResponseInProgressEvent), options);
            }
            else if (value.IsResponseFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFailed, typeof(global::G.ResponseFailedEvent), options);
            }
            else if (value.IsResponseIncomplete)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseIncomplete, typeof(global::G.ResponseIncompleteEvent), options);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeof(global::G.ResponseOutputItemAddedEvent), options);
            }
            else if (value.IsResponseOutputItemDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone, typeof(global::G.ResponseOutputItemDoneEvent), options);
            }
            else if (value.IsResponseReasoningSummaryPartAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryPartAdded, typeof(global::G.ResponseReasoningSummaryPartAddedEvent), options);
            }
            else if (value.IsResponseReasoningSummaryPartDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryPartDone, typeof(global::G.ResponseReasoningSummaryPartDoneEvent), options);
            }
            else if (value.IsResponseReasoningSummaryTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryTextDelta, typeof(global::G.ResponseReasoningSummaryTextDeltaEvent), options);
            }
            else if (value.IsResponseReasoningSummaryTextDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryTextDone, typeof(global::G.ResponseReasoningSummaryTextDoneEvent), options);
            }
            else if (value.IsResponseRefusalDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDelta, typeof(global::G.ResponseRefusalDeltaEvent), options);
            }
            else if (value.IsResponseRefusalDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDone, typeof(global::G.ResponseRefusalDoneEvent), options);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDelta, typeof(global::G.ResponseTextDeltaEvent), options);
            }
            else if (value.IsResponseOutputTextDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDone, typeof(global::G.ResponseTextDoneEvent), options);
            }
            else if (value.IsResponseWebSearchCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallCompleted, typeof(global::G.ResponseWebSearchCallCompletedEvent), options);
            }
            else if (value.IsResponseWebSearchCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallInProgress, typeof(global::G.ResponseWebSearchCallInProgressEvent), options);
            }
            else if (value.IsResponseWebSearchCallSearching)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallSearching, typeof(global::G.ResponseWebSearchCallSearchingEvent), options);
            }
            else if (value.IsResponseImageGenerationCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallCompleted, typeof(global::G.ResponseImageGenCallCompletedEvent), options);
            }
            else if (value.IsResponseImageGenerationCallGenerating)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallGenerating, typeof(global::G.ResponseImageGenCallGeneratingEvent), options);
            }
            else if (value.IsResponseImageGenerationCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallInProgress, typeof(global::G.ResponseImageGenCallInProgressEvent), options);
            }
            else if (value.IsResponseImageGenerationCallPartialImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallPartialImage, typeof(global::G.ResponseImageGenCallPartialImageEvent), options);
            }
            else if (value.IsResponseMcpCallArgumentsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDelta, typeof(global::G.ResponseMCPCallArgumentsDeltaEvent), options);
            }
            else if (value.IsResponseMcpCallArgumentsDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDone, typeof(global::G.ResponseMCPCallArgumentsDoneEvent), options);
            }
            else if (value.IsResponseMcpCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallCompleted, typeof(global::G.ResponseMCPCallCompletedEvent), options);
            }
            else if (value.IsResponseMcpCallFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallFailed, typeof(global::G.ResponseMCPCallFailedEvent), options);
            }
            else if (value.IsResponseMcpCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallInProgress, typeof(global::G.ResponseMCPCallInProgressEvent), options);
            }
            else if (value.IsResponseMcpListToolsCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsCompleted, typeof(global::G.ResponseMCPListToolsCompletedEvent), options);
            }
            else if (value.IsResponseMcpListToolsFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsFailed, typeof(global::G.ResponseMCPListToolsFailedEvent), options);
            }
            else if (value.IsResponseMcpListToolsInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsInProgress, typeof(global::G.ResponseMCPListToolsInProgressEvent), options);
            }
            else if (value.IsResponseOutputTextAnnotationAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextAnnotationAdded, typeof(global::G.ResponseOutputTextAnnotationAddedEvent), options);
            }
            else if (value.IsResponseQueued)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseQueued, typeof(global::G.ResponseQueuedEvent), options);
            }
            else if (value.IsResponseReasoningDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningDelta, typeof(global::G.ResponseReasoningDeltaEvent), options);
            }
            else if (value.IsResponseReasoningDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningDone, typeof(global::G.ResponseReasoningDoneEvent), options);
            }
            else if (value.IsResponseReasoningSummaryDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryDelta, typeof(global::G.ResponseReasoningSummaryDeltaEvent), options);
            }
            else if (value.IsResponseReasoningSummaryDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryDone, typeof(global::G.ResponseReasoningSummaryDoneEvent), options);
            }
        }
    }
}