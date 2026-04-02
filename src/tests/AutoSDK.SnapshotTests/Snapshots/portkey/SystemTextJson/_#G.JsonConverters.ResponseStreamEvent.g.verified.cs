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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("delta")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("delta")) __score4++;
            if (__jsonProps.Contains("output_index")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("code")) __score5++;
            if (__jsonProps.Contains("output_index")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("code_interpreter_call")) __score6++;
            if (__jsonProps.Contains("output_index")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("code_interpreter_call")) __score7++;
            if (__jsonProps.Contains("output_index")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("code_interpreter_call")) __score8++;
            if (__jsonProps.Contains("output_index")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("response")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("content_index")) __score10++;
            if (__jsonProps.Contains("item_id")) __score10++;
            if (__jsonProps.Contains("output_index")) __score10++;
            if (__jsonProps.Contains("part")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("content_index")) __score11++;
            if (__jsonProps.Contains("item_id")) __score11++;
            if (__jsonProps.Contains("output_index")) __score11++;
            if (__jsonProps.Contains("part")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("response")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("code")) __score13++;
            if (__jsonProps.Contains("message")) __score13++;
            if (__jsonProps.Contains("param")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("item_id")) __score14++;
            if (__jsonProps.Contains("output_index")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("item_id")) __score15++;
            if (__jsonProps.Contains("output_index")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("item_id")) __score16++;
            if (__jsonProps.Contains("output_index")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("delta")) __score17++;
            if (__jsonProps.Contains("item_id")) __score17++;
            if (__jsonProps.Contains("output_index")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("arguments")) __score18++;
            if (__jsonProps.Contains("item_id")) __score18++;
            if (__jsonProps.Contains("output_index")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("response")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("response")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("response")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("item")) __score22++;
            if (__jsonProps.Contains("output_index")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("item")) __score23++;
            if (__jsonProps.Contains("output_index")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("content_index")) __score24++;
            if (__jsonProps.Contains("delta")) __score24++;
            if (__jsonProps.Contains("item_id")) __score24++;
            if (__jsonProps.Contains("output_index")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("content_index")) __score25++;
            if (__jsonProps.Contains("item_id")) __score25++;
            if (__jsonProps.Contains("output_index")) __score25++;
            if (__jsonProps.Contains("refusal")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("annotation")) __score26++;
            if (__jsonProps.Contains("annotation_index")) __score26++;
            if (__jsonProps.Contains("content_index")) __score26++;
            if (__jsonProps.Contains("item_id")) __score26++;
            if (__jsonProps.Contains("output_index")) __score26++;
            if (__jsonProps.Contains("type")) __score26++;
            var __score27 = 0;
            if (__jsonProps.Contains("content_index")) __score27++;
            if (__jsonProps.Contains("delta")) __score27++;
            if (__jsonProps.Contains("item_id")) __score27++;
            if (__jsonProps.Contains("output_index")) __score27++;
            if (__jsonProps.Contains("type")) __score27++;
            var __score28 = 0;
            if (__jsonProps.Contains("content_index")) __score28++;
            if (__jsonProps.Contains("item_id")) __score28++;
            if (__jsonProps.Contains("output_index")) __score28++;
            if (__jsonProps.Contains("text")) __score28++;
            if (__jsonProps.Contains("type")) __score28++;
            var __score29 = 0;
            if (__jsonProps.Contains("item_id")) __score29++;
            if (__jsonProps.Contains("output_index")) __score29++;
            if (__jsonProps.Contains("type")) __score29++;
            var __score30 = 0;
            if (__jsonProps.Contains("item_id")) __score30++;
            if (__jsonProps.Contains("output_index")) __score30++;
            if (__jsonProps.Contains("type")) __score30++;
            var __score31 = 0;
            if (__jsonProps.Contains("item_id")) __score31++;
            if (__jsonProps.Contains("output_index")) __score31++;
            if (__jsonProps.Contains("type")) __score31++;
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
            global::G.ResponseRefusalDeltaEvent? responseRefusalDelta = default;
            global::G.ResponseRefusalDoneEvent? responseRefusalDone = default;
            global::G.ResponseTextAnnotationDeltaEvent? responseOutputTextAnnotationAdded = default;
            global::G.ResponseTextDeltaEvent? responseOutputTextDelta = default;
            global::G.ResponseTextDoneEvent? responseOutputTextDone = default;
            global::G.ResponseWebSearchCallCompletedEvent? responseWebSearchCallCompleted = default;
            global::G.ResponseWebSearchCallInProgressEvent? responseWebSearchCallInProgress = default;
            global::G.ResponseWebSearchCallSearchingEvent? responseWebSearchCallSearching = default;
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
                        responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseRefusalDeltaEvent>(__rawJson, options);
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
                        responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseRefusalDoneEvent>(__rawJson, options);
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
                        responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseTextAnnotationDeltaEvent>(__rawJson, options);
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
                        responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseTextDeltaEvent>(__rawJson, options);
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
                        responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseTextDoneEvent>(__rawJson, options);
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
                        responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseWebSearchCallCompletedEvent>(__rawJson, options);
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
                        responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseWebSearchCallInProgressEvent>(__rawJson, options);
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
                        responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseWebSearchCallSearchingEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responseAudioDelta == null && responseAudioDone == null && responseAudioTranscriptDelta == null && responseAudioTranscriptDone == null && responseCodeInterpreterCallCodeDelta == null && responseCodeInterpreterCallCodeDone == null && responseCodeInterpreterCallCompleted == null && responseCodeInterpreterCallInProgress == null && responseCodeInterpreterCallInterpreting == null && responseCompleted == null && responseContentPartAdded == null && responseContentPartDone == null && responseCreated == null && error == null && responseFileSearchCallCompleted == null && responseFileSearchCallInProgress == null && responseFileSearchCallSearching == null && responseFunctionCallArgumentsDelta == null && responseFunctionCallArgumentsDone == null && responseInProgress == null && responseFailed == null && responseIncomplete == null && responseOutputItemAdded == null && responseOutputItemDone == null && responseRefusalDelta == null && responseRefusalDone == null && responseOutputTextAnnotationAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseWebSearchCallCompleted == null && responseWebSearchCallInProgress == null && responseWebSearchCallSearching == null)
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
                    responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseTextAnnotationDeltaEvent>(__rawJson, options);
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

                responseRefusalDelta,

                responseRefusalDone,

                responseOutputTextAnnotationAdded,

                responseOutputTextDelta,

                responseOutputTextDone,

                responseWebSearchCallCompleted,

                responseWebSearchCallInProgress,

                responseWebSearchCallSearching
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
            else if (value.IsResponseRefusalDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDelta, typeof(global::G.ResponseRefusalDeltaEvent), options);
            }
            else if (value.IsResponseRefusalDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDone, typeof(global::G.ResponseRefusalDoneEvent), options);
            }
            else if (value.IsResponseOutputTextAnnotationAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextAnnotationAdded, typeof(global::G.ResponseTextAnnotationDeltaEvent), options);
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
        }
    }
}