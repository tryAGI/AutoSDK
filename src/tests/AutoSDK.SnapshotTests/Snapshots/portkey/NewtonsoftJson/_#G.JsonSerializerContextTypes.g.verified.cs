//HintName: G.JsonSerializerContextTypes.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelPricingConfig? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelPayAsYouGo? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelCalculateConfig? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelPricingConfigCurrency? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelFinetuneConfig? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelTokenPrice? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::G.ModelTokenPrice>? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.ModelTokenPrice>>? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelCalculateOperation? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelCalculateOperationOperation? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ModelCalculateOperation, global::G.ModelValueReference>>? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.ModelCalculateOperation, global::G.ModelValueReference>? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelValueReference? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Error? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ErrorResponse? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateInvite? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.WorkspaceInvite>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceInvite? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InviteRole? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateInviteWorkspaceApiKeyDetails? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceInviteRole? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceInviteType? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SuccessInvite? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListModelsResponse? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListModelsResponseObject? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Model11>? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Model11? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteModelResponse? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCompletionRequest? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateCompletionRequestModel?>? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCompletionRequestModel? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionStreamOptions? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCompletionResponse? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateCompletionResponseChoice>? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCompletionResponseChoice? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCompletionResponseChoiceFinishReason? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCompletionResponseChoiceLogprobs? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTimeOffset? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCompletionResponseObject? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CompletionUsage? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestMessageContentPart? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestMessageContentPartText? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestMessageContentPartImage? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestMessageContentPartImageType? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestMessageContentPartImageImageUrl? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestMessageContentPartTextType? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageContentPartThinking? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageContentPartThinkingType? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageContentPartRedactedThinking? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageContentPartRedactedThinkingType? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestMessage? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestSystemMessage? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestDeveloperMessage? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestUserMessage? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestAssistantMessage? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestToolMessage? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestFunctionMessage? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestSystemMessageRole? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestDeveloperMessageRole? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessageContentPart>>? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessageContentPart>? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestUserMessageRole? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestAssistantMessageRole? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCall>? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestAssistantMessageFunctionCall? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FileSearchTool? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FileSearchToolType? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.ComparisonFilter, global::G.CompoundFilter>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComparisonFilter? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CompoundFilter? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FileSearchToolRankingOptions? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FileSearchToolRankingOptionsRanker? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FileSearchToolCall? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FileSearchToolCallType? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FileSearchToolCallStatus? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.FileSearchToolCallResult>? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FileSearchToolCallResult? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileAttributes? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuneChatCompletionRequestAssistantMessage? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuneChatCompletionRequestAssistantMessageRole? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuneChatCompletionRequestAssistantMessageFunctionCall? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestToolMessageRole? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRequestFunctionMessageRole? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuneChatCompletionRequestFunctionMessage? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionParameters? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionFunctions? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionFunctionCallOption? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionTool? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionToolType? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionObject? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionToolChoiceOption? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionToolChoiceOptionEnum? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionNamedToolChoice? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionNamedToolChoiceType? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionNamedToolChoiceFunction? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputAudio? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputAudioType? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputContent? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputText? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Refusal? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputItem? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputMessage? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolCall? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSearchToolCall? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolCall? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ReasoningItem? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputItemDiscriminator? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputItemDiscriminatorType? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputMessageType? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputMessageRole? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OutputContent>? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputMessageStatus? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputTextType? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Annotation>? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Annotation? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageToolCall? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageToolCallType? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageToolCallFunction? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageToolCallChunk? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageToolCallChunkType? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageToolCallChunkFunction? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionRole? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionMessageContentBlock? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionResponseMessage? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionResponseMessageRole? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionResponseMessageFunctionCall? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageContentBlock>? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionStreamResponseDelta? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionStreamResponseDeltaFunctionCall? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCallChunk>? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionStreamResponseDeltaRole? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionRequest? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage>? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateChatCompletionRequestModel?>? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionRequestModel? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFormatText? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFormatJsonSchema? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFormatJsonObject? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionRequestThinking? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionRequestThinkingType? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.CreateChatCompletionRequestFunctionCall?, global::G.ChatCompletionFunctionCallOption>? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionRequestFunctionCall? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ChatCompletionFunctions>? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponseChoice>? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionResponseChoice? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionResponseChoiceFinishReason? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionResponseChoiceLogprobs? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionTokenLogprob? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionResponseObject? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionFunctionResponse? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateChatCompletionFunctionResponseChoice>? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionFunctionResponseChoice? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionFunctionResponseChoiceFinishReason? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionFunctionResponseObject? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprobTopLogprob>? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionTokenLogprobTopLogprob? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListPaginatedFineTuningJobsResponse? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.FineTuningJob>? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJob? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListPaginatedFineTuningJobsResponseObject? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionStreamResponse? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateChatCompletionStreamResponseChoice>? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionStreamResponseChoice? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionStreamResponseChoiceLogprobs? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionStreamResponseChoiceFinishReason? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionStreamResponseObject? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionStreamResponseUsage? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateChatCompletionImageResponse? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageRequest? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateImageRequestModel?>? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageRequestModel? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageRequestQuality? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageRequestResponseFormat? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageRequestSize? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageRequestStyle? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ImagesResponse? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Image>? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Image? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Includable? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionTool? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolType? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolCallType? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolCallStatus? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolCallOutput? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolCallOutputType? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolCallOutputStatus? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolCallOutputResource? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolCallOutputResourceVariant2? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolCallResource? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FunctionToolCallResourceVariant2? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputAudio? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputAudioType? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputAudioFormat? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputContent? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputText? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputImage? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputFile? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputFileType? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputImageType? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputImageDetail? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputItem? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EasyInputMessage? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Item? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ItemReference? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputItemDiscriminator? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputItemDiscriminatorType? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputMessage? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputMessageType? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputMessageRole? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputMessageStatus? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.InputContent>? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputMessageResource? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputMessageResourceVariant2? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InputTextType? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageEditRequest? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateImageEditRequestModel?>? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageEditRequestModel? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageEditRequestSize? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageEditRequestResponseFormat? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageVariationRequest? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateImageVariationRequestModel?>? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageVariationRequestModel? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageVariationRequestResponseFormat? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateImageVariationRequestSize? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateModelResponseProperties? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelResponseProperties? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateModerationRequest? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateModerationRequestModel?>? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateModerationRequestModel? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateModerationResponse? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResult>? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateModerationResponseResult? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateModerationResponseResultCategories? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateModerationResponseResultCategoryScores? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateResponse? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseProperties? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateResponseVariant3? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.InputItem>>? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.InputItem>? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Includable>? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListFilesResponse? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OpenAIFile>? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFile? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListFilesResponseObject? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateFileRequest? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateFileRequestPurpose? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteFileResponse? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteFileResponseObject? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BedrockFinetuneJob? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFinetuneJob? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFinetuneJobMethod? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFinetuneJobMethodType? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFinetuneJobMethodSupervised? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFinetuneJobMethodSupervisedHyperparameters? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFinetuneJobMethodDpo? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFinetuneJobMethodDpoHyperparameters? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BedrockParams? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyFinetuneJob? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyOptions? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VertexFinetuneJob? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListFineTuningJobEventsResponse? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.FineTuningJobEvent>? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobEvent? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListFineTuningJobEventsResponseObject? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListFineTuningJobCheckpointsResponse? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.FineTuningJobCheckpoint>? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobCheckpoint? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListFineTuningJobCheckpointsResponseObject? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateEmbeddingRequest? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateEmbeddingRequestModel?>? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateEmbeddingRequestModel? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateEmbeddingRequestEncodingFormat? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateEmbeddingResponse? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Embedding>? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Embedding? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateEmbeddingResponseObject? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateEmbeddingResponseUsage? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTranscriptionRequest? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateTranscriptionRequestModel?>? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTranscriptionRequestModel? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTranscriptionRequestResponseFormat? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateTranscriptionRequestTimestampGranularitie>? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTranscriptionRequestTimestampGranularitie? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTranscriptionResponseJson? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.TranscriptionSegment? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.TranscriptionWord? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTranscriptionResponseVerboseJson? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.TranscriptionWord>? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.TranscriptionSegment>? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTranslationRequest? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateTranslationRequestModel?>? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTranslationRequestModel? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTranslationResponseJson? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTranslationResponseVerboseJson? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSpeechRequest? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateSpeechRequestModel?>? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSpeechRequestModel? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSpeechRequestVoice? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSpeechRequestResponseFormat? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelObject? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Move? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MoveType? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFileObject? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFilePurpose? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIFileStatus? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DoubleClick? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DoubleClickType? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Drag? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DragType? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Coordinate>? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Coordinate? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EasyInputMessageRole? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.InputContent>>? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EasyInputMessageType? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EmbeddingObject? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobError? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobHyperparameters? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.FineTuningJobHyperparametersNEpochs?, int?>? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobHyperparametersNEpochs? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobObject? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobStatus? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.FineTuningIntegration>? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningIntegration? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningIntegrationType? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningIntegrationWandb? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobEventLevel? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobEventObject? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobCheckpointMetrics? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FineTuningJobCheckpointObject? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FinetuneChatRequestInput? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FinetuneCompletionRequestInput? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Click? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ClickType? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ClickButton? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterFileOutput? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterFileOutputType? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CodeInterpreterFileOutputFile>? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterFileOutputFile? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterTextOutput? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterTextOutputType? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterTool? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterToolType? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterToolCall? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterToolCallType? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterToolCallStatus? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CodeInterpreterToolOutput>? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterToolOutput? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComparisonFilterType? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, double?, bool?>? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CompleteUploadRequest? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CompletionUsageCompletionTokensDetails? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CompletionUsagePromptTokensDetails? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CompoundFilterType? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ComparisonFilter, object>>? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.ComparisonFilter, object>? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerAction? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.KeyPress? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Screenshot? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Scroll? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Type? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Wait? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerScreenshotImage? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerScreenshotImageType? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerTool? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolType? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolEnvironment? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolCallType? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ComputerToolCallSafetyCheck>? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolCallSafetyCheck? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolCallStatus? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolCallOutput? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolCallOutputType? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolCallOutputStatus? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolCallOutputResource? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerToolCallOutputResourceVariant2? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Content3? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CostsResult? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CostsResultObject? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CostsResultAmount? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Reasoning? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ReasoningEffort? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ReasoningGenerateSummary? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ReasoningItemType? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ReasoningItemSummaryItem>? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ReasoningItemSummaryItem? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ReasoningItemSummaryItemType? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ReasoningItemStatus? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RefusalType? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Response? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseVariant3? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseVariant3Object? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseVariant3Status? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseError? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseVariant3IncompleteDetails? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseVariant3IncompleteDetailsReason? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OutputItem>? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseUsage? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioDeltaEvent? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioDeltaEventType? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioDoneEvent? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioDoneEventType? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioTranscriptDeltaEvent? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioTranscriptDeltaEventType? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioTranscriptDoneEvent? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAudioTranscriptDoneEventType? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCodeInterpreterCallCodeDeltaEvent? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCodeInterpreterCallCodeDeltaEventType? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCodeInterpreterCallCodeDoneEvent? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCodeInterpreterCallCodeDoneEventType? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCodeInterpreterCallCompletedEvent? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCodeInterpreterCallCompletedEventType? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCodeInterpreterCallInProgressEvent? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCodeInterpreterCallInProgressEventType? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCodeInterpreterCallInterpretingEvent? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCodeInterpreterCallInterpretingEventType? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCompletedEvent? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCompletedEventType? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseContentPartAddedEvent? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseContentPartAddedEventType? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseContentPartDoneEvent? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseContentPartDoneEventType? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCreatedEvent? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseCreatedEventType? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseErrorCode? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseErrorEvent? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseErrorEventType? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFailedEvent? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFailedEventType? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFileSearchCallCompletedEvent? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFileSearchCallCompletedEventType? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFileSearchCallInProgressEvent? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFileSearchCallInProgressEventType? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFileSearchCallSearchingEvent? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFileSearchCallSearchingEventType? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFormatJsonObjectType? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFormatJsonSchemaType? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFormatJsonSchemaJsonSchema? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFormatJsonSchemaSchema? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFormatTextType? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFunctionCallArgumentsDeltaEvent? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFunctionCallArgumentsDeltaEventType? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFunctionCallArgumentsDoneEvent? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFunctionCallArgumentsDoneEventType? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseInProgressEvent? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseInProgressEventType? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseIncompleteEvent? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseIncompleteEventType? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseItemList? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseItemListObject? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ItemResource>? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ItemResource? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ResponseModalitie>? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseModalitie? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ResponseModalitiesTextOnlyItem>? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseModalitiesTextOnlyItem? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseOutputItemAddedEvent? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseOutputItemAddedEventType? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseOutputItemDoneEvent? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseOutputItemDoneEventType? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponsePropertiesText? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.TextResponseFormatConfiguration? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Tool>? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Tool? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.ToolChoiceOptions?, global::G.ToolChoiceTypes, global::G.ToolChoiceFunction>? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolChoiceOptions? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolChoiceTypes? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolChoiceFunction? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponsePropertiesTruncation? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseRefusalDeltaEvent? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseRefusalDeltaEventType? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseRefusalDoneEvent? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseRefusalDoneEventType? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseStreamEvent? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseTextAnnotationDeltaEvent? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseTextDeltaEvent? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseTextDoneEvent? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseWebSearchCallCompletedEvent? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseWebSearchCallInProgressEvent? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseWebSearchCallSearchingEvent? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseStreamEventDiscriminator? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseStreamEventDiscriminatorType? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseTextAnnotationDeltaEventType? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseTextDeltaEventType? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseTextDoneEventType? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseUsageInputTokensDetails? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseUsageOutputTokensDetails? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseWebSearchCallCompletedEventType? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseWebSearchCallInProgressEventType? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseWebSearchCallSearchingEventType? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunCompletionUsage? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepCompletionUsage? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantsApiResponseFormatOption? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantsApiResponseFormatOptionEnum? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantsApiResponseFormat? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantsApiResponseFormatType? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FileCitation? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UrlCitation? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FilePath? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantObject? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantObjectObject? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>>? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantToolsCode? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantToolsFileSearch? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantToolsFunction? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantObjectToolResources? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantObjectToolResourcesCodeInterpreter? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantObjectToolResourcesFileSearch? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequest? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateAssistantRequestModel?>? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestModel? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestToolResources? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestToolResourcesCodeInterpreter? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestToolResourcesFileSearch? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStore>? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStore? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelIdsResponses? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelIdsResponsesEnum? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModifyAssistantRequest? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModifyAssistantRequestToolResources? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModifyAssistantRequestToolResourcesCodeInterpreter? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModifyAssistantRequestToolResourcesFileSearch? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteAssistantResponse? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteAssistantResponseObject? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ItemDiscriminator? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ItemDiscriminatorType? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ItemReferenceType? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ItemResourceDiscriminator? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ItemResourceDiscriminatorType? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.KeyPressType? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListAssistantsResponse? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.AssistantObject>? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantToolsCodeType? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantToolsFileSearchType? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantToolsFileSearchFileSearch? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantToolsFileSearchTypeOnly? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantToolsFileSearchTypeOnlyType? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantToolsFunctionType? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.TruncationObject? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.TruncationObjectType? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantsApiToolChoiceOption? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantsApiToolChoiceOptionEnum? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantsNamedToolChoice? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantsNamedToolChoiceType? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantsNamedToolChoiceFunction? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunObject? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunObjectObject? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunObjectStatus? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunObjectRequiredAction? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunObjectRequiredActionType? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunObjectRequiredActionSubmitToolOutputs? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.RunToolCallObject>? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunToolCallObject? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunObjectLastError? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunObjectLastErrorCode? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunObjectIncompleteDetails? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunObjectIncompleteDetailsReason? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateRunRequest? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateRunRequestModel?>? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateRunRequestModel? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateMessageRequest>? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMessageRequest? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRunsResponse? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.RunObject>? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModifyRunRequest? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SubmitToolOutputsRunRequest? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.SubmitToolOutputsRunRequestToolOutput>? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SubmitToolOutputsRunRequestToolOutput? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.TextResponseFormatJsonSchema? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.TextResponseFormatJsonSchemaType? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunToolCallObjectType? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunToolCallObjectFunction? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ScreenshotType? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ScrollType? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadAndRunRequest? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequest? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::G.CreateThreadAndRunRequestModel?>? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadAndRunRequestModel? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadAndRunRequestToolResources? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadAndRunRequestToolResourcesCodeInterpreter? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadAndRunRequestToolResourcesFileSearch? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ThreadObject? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ThreadObjectObject? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ThreadObjectToolResources? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ThreadObjectToolResourcesCodeInterpreter? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ThreadObjectToolResourcesFileSearch? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequestToolResources? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequestToolResourcesCodeInterpreter? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequestToolResourcesFileSearch? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateThreadRequestToolResourcesFileSearchVectorStore>? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStore? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModifyThreadRequest? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModifyThreadRequestToolResources? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModifyThreadRequestToolResourcesCodeInterpreter? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModifyThreadRequestToolResourcesFileSearch? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteThreadResponse? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteThreadResponseObject? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListThreadsResponse? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ThreadObject>? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageObject? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageObjectObject? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageObjectStatus? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageObjectIncompleteDetails? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageObjectIncompleteDetailsReason? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageObjectRole? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageContentTextObject>>? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageContentTextObject>? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentImageFileObject? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentImageUrlObject? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentTextObject? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.MessageObjectAttachment>? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageObjectAttachment? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearchTypeOnly>>? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearchTypeOnly>? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaObject? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaObjectObject? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaObjectDelta? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaObjectDeltaRole? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageDeltaContentImageFileObject, global::G.MessageDeltaContentTextObject, global::G.MessageDeltaContentImageUrlObject>>? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.MessageDeltaContentImageFileObject, global::G.MessageDeltaContentTextObject, global::G.MessageDeltaContentImageUrlObject>? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentImageFileObject? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentTextObject? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentImageUrlObject? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMessageRequestRole? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageRequestContentTextObject>>>? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageRequestContentTextObject>>? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageRequestContentTextObject>? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageRequestContentTextObject? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateMessageRequestAttachment>? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMessageRequestAttachment? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModifyMessageRequest? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteMessageResponse? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteMessageResponseObject? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListMessagesResponse? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.MessageObject>? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentImageFileObjectType? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentImageFileObjectImageFile? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentImageFileObjectImageFileDetail? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentImageFileObjectType? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentImageFileObjectImageFile? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentImageFileObjectImageFileDetail? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentImageUrlObjectType? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentImageUrlObjectImageUrl? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentImageUrlObjectImageUrlDetail? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentImageUrlObjectType? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentImageUrlObjectImageUrl? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentImageUrlObjectImageUrlDetail? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentTextObjectType? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentTextObjectText? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentTextAnnotationsFileCitationObject, global::G.MessageContentTextAnnotationsFilePathObject>>? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.MessageContentTextAnnotationsFileCitationObject, global::G.MessageContentTextAnnotationsFilePathObject>? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentTextAnnotationsFileCitationObject? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentTextAnnotationsFilePathObject? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageRequestContentTextObjectType? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentTextAnnotationsFileCitationObjectType? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentTextAnnotationsFileCitationObjectFileCitation? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentTextAnnotationsFilePathObjectType? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageContentTextAnnotationsFilePathObjectFilePath? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentTextObjectType? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentTextObjectText? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageDeltaContentTextAnnotationsFileCitationObject, global::G.MessageDeltaContentTextAnnotationsFilePathObject>>? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.MessageDeltaContentTextAnnotationsFileCitationObject, global::G.MessageDeltaContentTextAnnotationsFilePathObject>? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentTextAnnotationsFileCitationObject? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentTextAnnotationsFilePathObject? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentTextAnnotationsFileCitationObjectType? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentTextAnnotationsFilePathObjectType? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepObject? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepObjectObject? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepObjectType? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepObjectStatus? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.RunStepDetailsMessageCreationObject, global::G.RunStepDetailsToolCallsObject>? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsMessageCreationObject? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsObject? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepObjectLastError? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepObjectLastErrorCode? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaObject? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaObjectObject? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaObjectDelta? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.RunStepDeltaStepDetailsMessageCreationObject, global::G.RunStepDeltaStepDetailsToolCallsObject>? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsMessageCreationObject? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsObject? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRunStepsResponse? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.RunStepObject>? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsMessageCreationObjectType? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsMessageCreationObjectMessageCreation? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsMessageCreationObjectType? Type720 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation? Type721 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsObjectType? Type722 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsCodeObject? Type723 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsFileSearchObject? Type724 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsFunctionObject? Type725 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsObjectType? Type726 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsCodeObject? Type727 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject? Type728 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsFunctionObject? Type729 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsCodeObjectType? Type730 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsCodeObjectCodeInterpreter? Type731 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.RunStepDetailsToolCallsCodeOutputLogsObject, global::G.RunStepDetailsToolCallsCodeOutputImageObject>>? Type732 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.RunStepDetailsToolCallsCodeOutputLogsObject, global::G.RunStepDetailsToolCallsCodeOutputImageObject>? Type733 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsCodeOutputLogsObject? Type734 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsCodeOutputImageObject? Type735 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsCodeObjectType? Type736 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? Type737 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>? Type738 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Type739 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Type740 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsCodeOutputLogsObjectType? Type741 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType? Type742 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsCodeOutputImageObjectType? Type743 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsCodeOutputImageObjectImage? Type744 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType? Type745 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Type746 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsFileSearchObjectType? Type747 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsFileSearchObjectType? Type748 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsFunctionObjectType? Type749 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsFunctionObjectFunction? Type750 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsFunctionObjectType? Type751 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Type752 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreExpirationAfter? Type753 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreExpirationAfterAnchor? Type754 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreObject? Type755 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreObjectObject? Type756 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreObjectFileCounts? Type757 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreObjectStatus? Type758 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreSearchRequest? Type759 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreSearchRequestRankingOptions? Type760 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreSearchRequestRankingOptionsRanker? Type761 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreSearchResultContentObject? Type762 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreSearchResultContentObjectType? Type763 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreSearchResultItem? Type764 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.VectorStoreSearchResultContentObject>? Type765 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreSearchResultsPage? Type766 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreSearchResultsPageObject? Type767 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.VectorStoreSearchResultItem>? Type768 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VoiceIdsShared? Type769 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VoiceIdsSharedEnum? Type770 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WaitType? Type771 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSearchContextSize? Type772 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSearchLocation? Type773 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSearchTool? Type774 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSearchToolType? Type775 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AllOf<global::G.WebSearchLocation, global::G.WebSearchToolUserLocation>? Type776 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSearchToolUserLocation? Type777 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSearchToolUserLocationType? Type778 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSearchToolCallType? Type779 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSearchToolCallStatus? Type780 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVectorStoreRequest? Type781 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.AutoChunkingStrategyRequestParam, global::G.StaticChunkingStrategyRequestParam>? Type782 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AutoChunkingStrategyRequestParam? Type783 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.StaticChunkingStrategyRequestParam? Type784 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.TypeType1? Type785 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateVectorStoreRequest? Type786 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UrlCitationType? Type787 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListVectorStoresResponse? Type788 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.VectorStoreObject>? Type789 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteVectorStoreResponse? Type790 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteVectorStoreResponseObject? Type791 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileObject? Type792 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileObjectObject? Type793 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileObjectStatus? Type794 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileObjectLastError? Type795 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileObjectLastErrorCode? Type796 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.StaticChunkingStrategyResponseParam, global::G.OtherChunkingStrategyResponseParam>? Type797 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.StaticChunkingStrategyResponseParam? Type798 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OtherChunkingStrategyResponseParam? Type799 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OtherChunkingStrategyResponseParamType? Type800 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.StaticChunkingStrategyResponseParamType? Type801 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.StaticChunkingStrategy? Type802 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AutoChunkingStrategyRequestParamType? Type803 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.StaticChunkingStrategyRequestParamType? Type804 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChunkingStrategyRequestParam? Type805 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVectorStoreFileRequest? Type806 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListVectorStoreFilesResponse? Type807 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.VectorStoreFileObject>? Type808 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteVectorStoreFileResponse? Type809 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteVectorStoreFileResponseObject? Type810 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileBatchObject? Type811 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileBatchObjectObject? Type812 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileBatchObjectStatus? Type813 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileBatchObjectFileCounts? Type814 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVectorStoreFileBatchRequest? Type815 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantStreamEvent? Type816 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ThreadStreamEvent? Type817 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEvent? Type818 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEvent? Type819 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEvent? Type820 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ErrorEvent? Type821 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DoneEvent? Type822 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ThreadStreamEventVariant1? Type823 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ThreadStreamEventVariant1Event? Type824 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolChoiceFunctionType? Type825 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolChoiceTypesType? Type826 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant1? Type827 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant1Event? Type828 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant2? Type829 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant2Event? Type830 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant3? Type831 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant3Event? Type832 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant4? Type833 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant4Event? Type834 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant5? Type835 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant5Event? Type836 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant6? Type837 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant6Event? Type838 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant7? Type839 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant7Event? Type840 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant8? Type841 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant8Event? Type842 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant9? Type843 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant9Event? Type844 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant10? Type845 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStreamEventVariant10Event? Type846 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant1? Type847 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant1Event? Type848 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant2? Type849 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant2Event? Type850 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant3? Type851 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant3Event? Type852 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant4? Type853 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant4Event? Type854 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant5? Type855 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant5Event? Type856 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant6? Type857 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant6Event? Type858 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant7? Type859 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepStreamEventVariant7Event? Type860 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventVariant1? Type861 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventVariant1Event? Type862 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventVariant2? Type863 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventVariant2Event? Type864 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventVariant3? Type865 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventVariant3Event? Type866 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventVariant4? Type867 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventVariant4Event? Type868 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventVariant5? Type869 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageStreamEventVariant5Event? Type870 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ErrorEventEvent? Type871 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FileCitationType? Type872 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FilePathType? Type873 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DoneEventEvent? Type874 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DoneEventData? Type875 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Batch? Type876 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BatchObject? Type877 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BatchErrors? Type878 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.BatchErrorsDataItem>? Type879 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BatchErrorsDataItem? Type880 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BatchStatus? Type881 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BatchRequestCounts? Type882 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BatchRequestInput? Type883 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BatchRequestInputMethod? Type884 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BatchRequestOutput? Type885 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BatchRequestOutputResponse? Type886 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BatchRequestOutputError? Type887 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListBatchesResponse? Type888 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Batch>? Type889 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListBatchesResponseObject? Type890 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FeedbackRequest? Type891 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FeedbackResponse? Type892 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.FeedbackUpdateRequest? Type893 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimits? Type894 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimitsType? Type895 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimitsUnit? Type896 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimits? Type897 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsType? Type898 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsPeriodicReset? Type899 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateIntegrationRequest? Type900 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIConfiguration? Type901 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureOpenAIConfiguration? Type902 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BedrockConfiguration? Type903 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VertexAIConfiguration? Type904 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureAIConfiguration? Type905 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkersAIConfiguration? Type906 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SageMakerConfiguration? Type907 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.HuggingFaceConfiguration? Type908 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CortexConfiguration? Type909 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CustomHostConfiguration? Type910 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.SecretMapping>? Type911 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SecretMapping? Type912 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateIntegrationRequest? Type913 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.IntegrationDetailResponse? Type914 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.IntegrationList? Type915 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.IntegrationDetailResponseVariant2? Type916 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GlobalWorkspaceAccess? Type917 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.UsageLimits>? Type918 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.RateLimits>? Type919 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureOpenAIConfigurationAzureAuthMode? Type920 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.AzureDeploymentConfig>? Type921 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureDeploymentConfig? Type922 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BedrockConfigurationAwsAuthType? Type923 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SageMakerConfigurationVariant2? Type924 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VertexAIConfigurationVertexAuthType? Type925 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureAIConfigurationAzureAuthMode? Type926 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSecretReferenceRequest? Type927 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type928 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSecretReferenceRequestManagerType? Type929 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AuthConfig? Type930 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AwsAccessKeyAuthConfig? Type931 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AwsAssumedRoleAuthConfig? Type932 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AwsServiceRoleAuthConfig? Type933 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureEntraAuthConfig? Type934 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureManagedAuthConfig? Type935 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureDefaultAuthConfig? Type936 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.HashicorpTokenAuthConfig? Type937 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.HashicorpAppRoleAuthConfig? Type938 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.HashicorpKubernetesAuthConfig? Type939 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSecretReferenceRequestAuthConfigDiscriminator? Type940 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType? Type941 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateSecretReferenceRequest? Type942 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SecretReferenceListItem? Type943 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SecretReferenceListItemManagerType? Type944 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SecretReferenceListItemStatus? Type945 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type946 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SecretReferenceListItemObject? Type947 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SecretReferenceDetailResponse? Type948 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SecretReferenceDetailResponseManagerType? Type949 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SecretReferenceDetailResponseStatus? Type950 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SecretReferenceDetailResponseObject? Type951 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AwsAccessKeyAuthConfigAwsAuthType? Type952 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AwsAssumedRoleAuthConfigAwsAuthType? Type953 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AwsServiceRoleAuthConfigAwsAuthType? Type954 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureEntraAuthConfigAzureAuthMode? Type955 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureManagedAuthConfigAzureAuthMode? Type956 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureDefaultAuthConfigAzureAuthMode? Type957 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.HashicorpTokenAuthConfigVaultAuthType? Type958 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.HashicorpAppRoleAuthConfigVaultAuthType? Type959 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.HashicorpKubernetesAuthConfigVaultAuthType? Type960 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.IntegrationListStatus? Type961 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.IntegrationListObject? Type962 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.IntegrationModelsResponse? Type963 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.IntegrationModel>? Type964 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.IntegrationModel? Type965 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PricingConfig? Type966 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PricingConfigType? Type967 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PayAsYouGoPricing? Type968 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.TokenPricing? Type969 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateModelsRequest? Type970 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ModelUpdateRequest>? Type971 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelUpdateRequest? Type972 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.IntegrationWorkspacesResponse? Type973 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.IntegrationWorkspace>? Type974 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.IntegrationWorkspace? Type975 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateWorkspacesRequest? Type976 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.WorkspaceUpdateRequest>? Type977 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceUpdateRequest? Type978 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Providers? Type979 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ProvidersStatus? Type980 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ProvidersObject? Type981 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VirtualKeys? Type982 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VirtualKeysStatus? Type983 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VirtualKeysObject? Type984 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Invite? Type985 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InviteRole2? Type986 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InviteStatus? Type987 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InviteList? Type988 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.InviteListObject? Type989 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Invite>? Type990 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.User? Type991 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UserObject? Type992 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UserRole? Type993 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UserList? Type994 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UserListObject? Type995 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.User>? Type996 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceMember? Type997 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceMemberObject? Type998 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceMemberOrgRole? Type999 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceMemberRole? Type1000 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceMemberStatus? Type1001 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceMemberList? Type1002 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceMemberListObject? Type1003 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.WorkspaceMember>? Type1004 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Workspace? Type1005 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceDefaults? Type1006 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceDefaultsObject? Type1007 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceList? Type1008 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceListObject? Type1009 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Workspace>? Type1010 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceWithUsers? Type1011 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceWithUsersDefaults? Type1012 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkspaceWithUsersDefaultsObject? Type1013 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Collection? Type1014 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CollectionStatus? Type1015 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CollectionDetails? Type1016 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CollectionWithDetails? Type1017 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CollectionWithDetailsVariant2? Type1018 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChildCollection? Type1019 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CollectionWithChildCollections? Type1020 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CollectionWithChildCollectionsVariant2? Type1021 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ChildCollection>? Type1022 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Label? Type1023 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateLabelRequest? Type1024 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateLabelRequest? Type1025 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateLabelResponse? Type1026 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListLabelsResponse? Type1027 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Label>? Type1028 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptSummary? Type1029 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptSummaryObject? Type1030 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Prompt2? Type1031 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptPromptVersionStatus? Type1032 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type1033 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptVersionSummary? Type1034 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptVersionSummaryStatus? Type1035 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptVersionSummaryObject? Type1036 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptPartialSummary? Type1037 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptPartialSummaryStatus? Type1038 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptPartialSummaryObject? Type1039 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptPartial? Type1040 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptPartialStatus? Type1041 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptPartialVersion? Type1042 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptPartialVersionPromptVersionStatus? Type1043 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptPartialVersionObject? Type1044 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CustomLog? Type1045 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CustomLogRequest? Type1046 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CustomLogResponse? Type1047 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CustomLogMetadata? Type1048 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ExportListResponse? Type1049 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ExportListResponseObject? Type1050 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ExportItem>? Type1051 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ExportItem? Type1052 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GenerationsFilterSchema? Type1053 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem>? Type1054 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ExportItemStatus? Type1055 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ExportItemObject? Type1056 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateExportResponse? Type1057 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateExportResponseObject? Type1058 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ExportTaskResponse? Type1059 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ExportTaskResponseObject? Type1060 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DownloadLogsResponse? Type1061 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.LogObject? Type1062 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.LogRequest? Type1063 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.LogResponse? Type1064 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnalyticsMetrics? Type1065 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RequestResponseObject? Type1066 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.LogRequestMethod? Type1067 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.LogExportsRequestedDataItem? Type1068 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AuditLogObjectList? Type1069 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.AuditLogObjectListRecord>? Type1070 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AuditLogObjectListRecord? Type1071 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AuditLogObjectListRecordMethod? Type1072 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AuditLogObjectListRecordUserType? Type1073 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AuditLogObjectListObject? Type1074 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApiKeyObject? Type1075 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApiKeyObjectType? Type1076 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApiKeyObjectStatus? Type1077 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApiKeyObjectCreationMode? Type1078 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ApiKeyObjectRateLimit>? Type1079 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApiKeyObjectRateLimit? Type1080 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApiKeyObjectDefaults? Type1081 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApiKeyObjectObject? Type1082 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApiKeyObjectList? Type1083 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApiKeyObjectListObject? Type1084 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ApiKeyObject>? Type1085 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyObject? Type1086 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateApiKeyObjectRateLimit>? Type1087 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyObjectRateLimit? Type1088 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyObjectDefaults? Type1089 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateApiKeyObject? Type1090 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.UpdateApiKeyObjectRateLimit>? Type1091 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateApiKeyObjectRateLimit? Type1092 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateApiKeyObjectDefaults? Type1093 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptRenderResponse? Type1094 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.CreateChatCompletionRequest, global::G.CreateCompletionRequest>? Type1095 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGuardrailRequest? Type1096 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GuardrailCheck>? Type1097 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailCheck? Type1098 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailActions? Type1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateGuardrailRequest? Type1100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailActionsOnSuccess? Type1101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailActionsOnSuccessFeedback? Type1102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailActionsOnFail? Type1103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailActionsOnFailFeedback? Type1104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailCheckId? Type1105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.JWTParameters? Type1106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelWhitelistParameters? Type1107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RegexMatchParameters? Type1108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SentenceCountParameters? Type1109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WordCountParameters? Type1110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CharacterCountParameters? Type1111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.JSONSchemaParameters? Type1112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.JSONKeysParameters? Type1113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ContainsParameters? Type1114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ValidUrlsParameters? Type1115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ContainsCodeParameters? Type1116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.WebhookParameters? Type1117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EndsWithParameters? Type1118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UppercaseParameters? Type1119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RequiredMetadataKeysParameters? Type1120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AllowedRequestTypesParameters? Type1121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SydeGuardParameters? Type1122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AporiaParameters? Type1123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PillarScanParameters? Type1124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PatronusParameters? Type1125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PatronusCustomParameters? Type1126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyModerationParameters? Type1127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyLanguageParameters? Type1128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyPIIParameters? Type1129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MistralModerationParameters? Type1130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BedrockGuardParameters? Type1131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptfooParameters? Type1132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AcuvityScanParameters? Type1133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureContentSafetyParameters? Type1134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzurePIIParameters? Type1135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PANWPrismaParameters? Type1136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BasicParameters? Type1137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGuardrailResponse? Type1138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateGuardrailResponse? Type1139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListGuardrailsResponse? Type1140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GuardrailSummary>? Type1141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailSummary? Type1142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailSummaryStatus? Type1143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailDetails? Type1144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GuardrailDetailsVariant2? Type1145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.JSONKeysParametersOperator? Type1146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ContainsParametersOperator? Type1147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ContainsCodeParametersFormat? Type1148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RequiredMetadataKeysParametersOperator? Type1149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.AllowedRequestTypesParametersAllowedType>? Type1150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AllowedRequestTypesParametersAllowedType? Type1151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.AllowedRequestTypesParametersBlockedType>? Type1152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AllowedRequestTypesParametersBlockedType? Type1153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.PillarScanParametersScanner>? Type1154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PillarScanParametersScanner? Type1155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.PortkeyModerationParametersCategorie>? Type1156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyModerationParametersCategorie? Type1157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyLanguageParametersLanguage? Type1158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.PortkeyPIIParametersCategorie>? Type1159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyPIIParametersCategorie? Type1160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.MistralModerationParametersCategorie>? Type1161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.MistralModerationParametersCategorie? Type1162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AcuvityScanParametersLanguageValues? Type1163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.AcuvityScanParametersPiiCategorie>? Type1164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AcuvityScanParametersPiiCategorie? Type1165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.AcuvityScanParametersSecretsCategorie>? Type1166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AcuvityScanParametersSecretsCategorie? Type1167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.AzureContentSafetyParametersCategorie>? Type1168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureContentSafetyParametersCategorie? Type1169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AzurePIIParametersDomain? Type1170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BedrockBatchJob? Type1171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIBatchJob? Type1172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BedrockBatchParams? Type1173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CommonBatchParams? Type1174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIBatchJobCompletionWindow? Type1175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIBatchJobEndpoint? Type1176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyBatchJob? Type1177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyBatchOptions? Type1178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<global::G.PortkeyBatchJobProviderOptionsBedrockOptions, global::G.PortkeyBatchJobProviderOptionsVertexOptions>? Type1179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyBatchJobProviderOptionsBedrockOptions? Type1180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PortkeyBatchJobProviderOptionsVertexOptions? Type1181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VertexBatchJob? Type1182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.VertexBatchParams? Type1183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.Condition? Type1184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GroupBy? Type1185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateUsageLimitsPolicyRequest? Type1186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Condition>? Type1187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GroupBy>? Type1188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateUsageLimitsPolicyRequestType? Type1189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateUsageLimitsPolicyRequestPeriodicReset? Type1190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateUsageLimitsPolicyRequest? Type1191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateUsageLimitsPolicyRequestPeriodicReset? Type1192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateRateLimitsPolicyRequest? Type1193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateRateLimitsPolicyRequestType? Type1194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateRateLimitsPolicyRequestUnit? Type1195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateRateLimitsPolicyRequest? Type1196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateRateLimitsPolicyRequestUnit? Type1197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsPolicy? Type1198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsPolicyType? Type1199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsPolicyPeriodicReset? Type1200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsPolicyStatus? Type1201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::G.ValueKeyUsage>? Type1202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ValueKeyUsage? Type1203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ValueKeyUsageStatus? Type1204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimitsPolicy? Type1205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimitsPolicyType? Type1206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimitsPolicyUnit? Type1207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimitsPolicyStatus? Type1208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePolicyResponse? Type1209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsPolicyListResponse? Type1210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.UsageLimitsPolicy>? Type1211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsPolicyResponse? Type1212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsPolicyResponseVariant2? Type1213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsPolicyEntity? Type1214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UsageLimitsPolicyEntityListResponse? Type1215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.UsageLimitsPolicyEntity>? Type1216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimitsPolicyListResponse? Type1217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.RateLimitsPolicy>? Type1218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimitsPolicyResponse? Type1219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.RateLimitsPolicyResponseVariant2? Type1220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMcpIntegration? Type1221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMcpIntegrationConfigurations? Type1222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMcpIntegrationAuthType? Type1223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMcpIntegrationTransport? Type1224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCreateResponse? Type1225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegration? Type1226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationAuthType? Type1227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationTransport? Type1228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationType? Type1229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationListItem? Type1230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationListItemType? Type1231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationListItemAuthType? Type1232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationListItemTransport? Type1233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationListResponse? Type1234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.McpIntegrationListItem>? Type1235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateMcpIntegration? Type1236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateMcpIntegrationConfigurations? Type1237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateMcpIntegrationAuthType? Type1238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateMcpIntegrationTransport? Type1239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationWorkspaceItem? Type1240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationWorkspacesListResponse? Type1241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.McpIntegrationWorkspaceItem>? Type1242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationWorkspacesLegacyResponse? Type1243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpIntegrationWorkspaces? Type1244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.BulkUpdateMcpIntegrationWorkspacesWorkspace>? Type1245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpIntegrationWorkspacesWorkspace? Type1246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? Type1247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCapabilityItem? Type1248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCapabilityItemType? Type1249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCapabilitiesCounts? Type1250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCapabilitiesCountsTools? Type1251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCapabilitiesCountsPrompts? Type1252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCapabilitiesCountsResources? Type1253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCapabilitiesCountsResourceTemplates? Type1254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCapabilitiesListResponse? Type1255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.McpIntegrationCapabilityItem>? Type1256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpIntegrationCapabilities? Type1257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? Type1258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpIntegrationCapabilitiesCapabilitie? Type1259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpIntegrationCapabilitiesCapabilitieType? Type1260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCapabilitiesBulkUpdateResponse? Type1261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationMetadata? Type1262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMcpServer? Type1263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCreateResponse? Type1264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServer? Type1265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerMcpIntegrationDetails? Type1266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerListItem? Type1267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerListResponse? Type1268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.McpServerListItem>? Type1269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateMcpServer? Type1270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerTestResponse? Type1271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCapabilityItem? Type1272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCapabilityItemType? Type1273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCapabilitiesCounts? Type1274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCapabilitiesCountsTools? Type1275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCapabilitiesCountsPrompts? Type1276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCapabilitiesCountsResources? Type1277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCapabilitiesCountsResourceTemplates? Type1278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCapabilitiesListResponse? Type1279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.McpServerCapabilityItem>? Type1280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpServerCapabilities? Type1281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.BulkUpdateMcpServerCapabilitiesCapabilitie>? Type1282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpServerCapabilitiesCapabilitie? Type1283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpServerCapabilitiesCapabilitieType? Type1284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCapabilitiesBulkUpdateResponse? Type1285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerUserAccessItem? Type1286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerUserAccessItemConnectionStatus? Type1287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerUserAccessListResponse? Type1288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.McpServerUserAccessItem>? Type1289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerUserAccessListResponseDefaultUserAccess? Type1290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpServerUserAccess? Type1291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.BulkUpdateMcpServerUserAccessUserAcces>? Type1292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpServerUserAccessUserAcces? Type1293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.BulkUpdateMcpServerUserAccessDefaultUserAccess? Type1294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerUserAccessBulkUpdateResponse? Type1295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCollectionsRequest? Type1296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutCollectionsRequest? Type1297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePromptRequest? Type1298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdatePromptRequest? Type1299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdatePromptVersionRequest? Type1300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdatePromptDefaultRequest? Type1301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePromptPartialRequest? Type1302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdatePromptPartialRequest? Type1303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdatePromptPartialDefaultRequest? Type1304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePromptCompletionRequest2? Type1305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePromptRenderRequest2? Type1306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<global::G.OpenAIFinetuneJob, global::G.BedrockFinetuneJob, global::G.PortkeyFinetuneJob>? Type1307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<global::G.OpenAIBatchJob, global::G.BedrockBatchJob, global::G.VertexBatchJob, global::G.PortkeyBatchJob>? Type1308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateConfigRequest? Type1309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateConfigRequest? Type1310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateConfigRequestConfig? Type1311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateProvidersRequest? Type1312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutProvidersRequest? Type1313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVirtualKeysRequest? Type1314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVirtualKeysRequestProvider? Type1315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateVirtualKeysRequestDeploymentConfigItem>? Type1316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVirtualKeysRequestDeploymentConfigItem? Type1317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutVirtualKeysRequest? Type1318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.PutVirtualKeysRequestDeploymentConfigItem>? Type1319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutVirtualKeysRequestDeploymentConfigItem? Type1320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutAdminUsersRequest? Type1321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutAdminUsersRequestRole? Type1322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAdminWorkspacesUsersRequest? Type1323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CreateAdminWorkspacesUsersRequestUser>? Type1324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAdminWorkspacesUsersRequestUser? Type1325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAdminWorkspacesUsersRequestUserRole? Type1326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutAdminWorkspacesUsersRequest? Type1327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutAdminWorkspacesUsersRequestRole? Type1328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAdminWorkspacesRequest? Type1329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAdminWorkspacesRequestDefaults? Type1330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutAdminWorkspacesRequest? Type1331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutAdminWorkspacesRequestDefaults? Type1332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.CustomLog, global::System.Collections.Generic.IList<global::G.CustomLog>>? Type1333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CustomLog>? Type1334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutLogsExportsRequest? Type1335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateLogsExportsRequest? Type1336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListModelsSort? Type1337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListModelsOrder? Type1338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListAssistantsOrder? Type1339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListInputItemsOrder? Type1340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListMessagesOrder? Type1341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRunsOrder? Type1342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRunStepsOrder? Type1343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListVectorStoresOrder? Type1344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListVectorStoreFilesOrder? Type1345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListVectorStoreFilesFilter? Type1346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListFilesInVectorStoreBatchOrder? Type1347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListFilesInVectorStoreBatchFilter? Type1348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetIntegrationsType? Type1349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAdminUsersInvitesRole? Type1350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAdminUsersInvitesStatus? Type1351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAdminUsersRole? Type1352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAdminWorkspacesUsersRole? Type1353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAdminWorkspacesStatus? Type1354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationsListType? Type1355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpIntegrationCapabilitiesListType? Type1356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerCapabilitiesListType? Type1357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAuditLogsMethod? Type1358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAuditLogsUserType? Type1359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateKeysType? Type1360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateKeysSubType? Type1361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListUsageLimitsPoliciesStatus? Type1362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListUsageLimitsPoliciesType? Type1363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageLimitsPolicyStatus? Type1364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListUsageLimitsPolicyEntitiesStatus? Type1365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRateLimitsPoliciesStatus? Type1366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRateLimitsPoliciesType? Type1367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRateLimitsPoliciesUnit? Type1368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetRateLimitsPolicyStatus? Type1369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListSecretReferencesManagerType? Type1370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCollectionsResponse? Type1371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetCollectionsResponse? Type1372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.CollectionWithDetails>? Type1373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePromptResponse? Type1374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePromptResponseObject? Type1375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListPromptsResponse? Type1376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.PromptSummary>? Type1377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdatePromptResponse? Type1378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.PromptVersionSummary>? Type1379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePromptPartialResponse? Type1380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.PromptPartialSummary>? Type1381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdatePromptPartialResponse? Type1382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.PromptPartialVersion>? Type1383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePromptCompletionResponse? Type1384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.CreateChatCompletionResponse, global::G.CreateCompletionResponse>? Type1385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.CreateTranscriptionResponseJson, global::G.CreateTranscriptionResponseVerboseJson>? Type1386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.CreateTranslationResponseJson, global::G.CreateTranslationResponseVerboseJson>? Type1387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListConfigsResponse? Type1388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ListConfigsResponseDataItem>? Type1389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListConfigsResponseDataItem? Type1390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateConfigResponse? Type1391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateConfigResponseData? Type1392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetConfigResponse? Type1393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetConfigResponseData? Type1394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetConfigResponseDataConfig? Type1395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetConfigResponseDataConfigRetry? Type1396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetConfigResponseDataConfigCache? Type1397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetConfigResponseDataConfigStrategy? Type1398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetConfigResponseDataConfigTarget>? Type1399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetConfigResponseDataConfigTarget? Type1400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateConfigResponse? Type1401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateConfigResponseData? Type1402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListConfigVersionsResponse? Type1403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ListConfigVersionsResponseDataItem>? Type1404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListConfigVersionsResponseDataItem? Type1405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetIntegrationsResponse? Type1406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetIntegrationsResponseObject? Type1407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.IntegrationList>? Type1408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateIntegrationsResponse? Type1409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetProvidersResponse? Type1410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetProvidersResponseObject? Type1411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.Providers>? Type1412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateProvidersResponse? Type1413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutProvidersResponse? Type1414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetVirtualKeysResponse? Type1415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetVirtualKeysResponseObject? Type1416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.VirtualKeys>? Type1417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetVirtualKeysResponse2? Type1418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetVirtualKeysResponseData? Type1419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVirtualKeysResponse? Type1420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVirtualKeysResponseData? Type1421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVirtualKeysResponse2? Type1422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVirtualKeysResponseData2? Type1423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetVirtualKeysResponse3? Type1424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetVirtualKeysResponseData2? Type1425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutVirtualKeysResponse2? Type1426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.PutVirtualKeysResponseData? Type1427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteVirtualKeysResponse2? Type1428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteVirtualKeysResponseData? Type1429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAdminUsersInvitesResendResponse? Type1430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.McpIntegrationWorkspacesListResponse, global::G.McpIntegrationWorkspacesLegacyResponse>? Type1431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateKeysResponse? Type1432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateKeysResponseObject? Type1433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsRequestsResponse? Type1434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsRequestsResponseSummary? Type1435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsRequestsResponseDataPoint>? Type1436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsRequestsResponseDataPoint? Type1437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsRequestsResponseObject? Type1438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCostResponse? Type1439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCostResponseSummary? Type1440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsCostResponseDataPoint>? Type1441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCostResponseDataPoint? Type1442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCostResponseObject? Type1443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsLatencyResponse? Type1444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsLatencyResponseSummary? Type1445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsLatencyResponseDataPoint>? Type1446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsLatencyResponseDataPoint? Type1447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsLatencyResponseObject? Type1448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsTokensResponse? Type1449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsTokensResponseSummary? Type1450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsTokensResponseDataPoint>? Type1451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsTokensResponseDataPoint? Type1452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsTokensResponseObject? Type1453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsUsersResponse? Type1454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsUsersResponseSummary? Type1455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsUsersResponseDataPoint>? Type1456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsUsersResponseDataPoint? Type1457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsUsersResponseObject? Type1458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsUsersRequestsResponse? Type1459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsUsersRequestsResponseSummary? Type1460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? Type1461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsUsersRequestsResponseDataPoint? Type1462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsUsersRequestsResponseObject? Type1463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsResponse? Type1464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsResponseSummary? Type1465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsErrorsResponseDataPoint>? Type1466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsResponseDataPoint? Type1467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsResponseObject? Type1468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsRateResponse? Type1469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsRateResponseSummary? Type1470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsErrorsRateResponseDataPoint>? Type1471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsRateResponseDataPoint? Type1472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsRateResponseObject? Type1473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsStacksResponse? Type1474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsStacksResponseSummary? Type1475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? Type1476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsStacksResponseDataPoint? Type1477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? Type1478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsStacksResponseDataPointStat? Type1479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsStacksResponseObject? Type1480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsStatusCodesResponse? Type1481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsStatusCodesResponseSummary? Type1482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? Type1483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint? Type1484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsErrorsStatusCodesResponseObject? Type1485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsRequestsRescuedResponse? Type1486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsRequestsRescuedResponseSummary? Type1487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? Type1488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsRequestsRescuedResponseDataPoint? Type1489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? Type1490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem? Type1491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsRequestsRescuedResponseObject? Type1492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCacheHitRateResponse? Type1493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCacheHitRateResponseSummary? Type1494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? Type1495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCacheHitRateResponseDataPoint? Type1496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCacheHitRateResponseObject? Type1497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCacheLatencyResponse? Type1498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? Type1499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCacheLatencyResponseDataPoint? Type1500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsCacheLatencyResponseObject? Type1501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksResponse? Type1502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksResponseSummary? Type1503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsFeedbacksResponseDataPoint>? Type1504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksResponseDataPoint? Type1505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksResponseObject? Type1506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksScoresResponse? Type1507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksScoresResponseSummary? Type1508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? Type1509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint? Type1510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksScoresResponseObject? Type1511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksWeightedResponse? Type1512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksWeightedResponseSummary? Type1513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? Type1514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint? Type1515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksWeightedResponseObject? Type1516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksAiModelsResponse? Type1517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? Type1518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint? Type1519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObject? Type1520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsSummaryCacheResponse? Type1521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsSummaryCacheResponseSummary? Type1522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsSummaryCacheResponseObject? Type1523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsUsersResponse? Type1524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsUsersResponseObject? Type1525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGroupsUsersResponseDataItem>? Type1526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsUsersResponseDataItem? Type1527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsUsersResponseDataItemObject? Type1528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsAiModelsResponse? Type1529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsAiModelsResponseObject? Type1530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGroupsAiModelsResponseDataItem>? Type1531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsAiModelsResponseDataItem? Type1532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsAiModelsResponseDataItemObject? Type1533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsMetadataResponse? Type1534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsMetadataResponseObject? Type1535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGroupsMetadataResponseDataItem>? Type1536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsMetadataResponseDataItem? Type1537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsGroupsMetadataResponseDataItemObject? Type1538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelPricingResponse? Type1539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListSecretReferencesResponse? Type1540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListSecretReferencesResponseObject? Type1541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.SecretReferenceListItem>? Type1542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSecretReferenceResponse? Type1543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSecretReferenceResponseObject? Type1544 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OneOf<global::G.ModelCalculateOperation, global::G.ModelValueReference>>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.WorkspaceInvite>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Model11>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.List<string>>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateCompletionResponseChoice>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.List<global::G.ChatCompletionRequestMessageContentPart>>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ChatCompletionRequestMessageContentPart>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ChatCompletionMessageToolCall>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.FileSearchToolCallResult>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OutputContent>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Annotation>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ChatCompletionMessageContentBlock>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ChatCompletionMessageToolCallChunk>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ChatCompletionRequestMessage>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ChatCompletionTool>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ChatCompletionFunctions>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateChatCompletionResponseChoice>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ChatCompletionTokenLogprob>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateChatCompletionFunctionResponseChoice>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ChatCompletionTokenLogprobTopLogprob>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.FineTuningJob>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateChatCompletionStreamResponseChoice>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Image>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.InputContent>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateModerationResponseResult>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.List<global::G.InputItem>>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.InputItem>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Includable>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OpenAIFile>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.FineTuningJobEvent>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.FineTuningJobCheckpoint>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Embedding>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateTranscriptionRequestTimestampGranularitie>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.TranscriptionWord>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.TranscriptionSegment>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Coordinate>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.List<global::G.InputContent>>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.FineTuningIntegration>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CodeInterpreterFileOutputFile>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CodeInterpreterToolOutput>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OneOf<global::G.ComparisonFilter, object>>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ComputerToolCallSafetyCheck>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ReasoningItemSummaryItem>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OutputItem>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ItemResource>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ResponseModalitie>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ResponseModalitiesTextOnlyItem>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Tool>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>>? ListType54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStore>? ListType55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.AssistantObject>? ListType56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.RunToolCallObject>? ListType57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateMessageRequest>? ListType58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.RunObject>? ListType59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.SubmitToolOutputsRunRequestToolOutput>? ListType60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateThreadRequestToolResourcesFileSearchVectorStore>? ListType61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ThreadObject>? ListType62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageContentTextObject>>? ListType63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.MessageObjectAttachment>? ListType64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearchTypeOnly>>? ListType65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OneOf<global::G.MessageDeltaContentImageFileObject, global::G.MessageDeltaContentTextObject, global::G.MessageDeltaContentImageUrlObject>>? ListType66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<string, global::System.Collections.Generic.List<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageRequestContentTextObject>>>? ListType67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageRequestContentTextObject>>? ListType68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateMessageRequestAttachment>? ListType69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.MessageObject>? ListType70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OneOf<global::G.MessageContentTextAnnotationsFileCitationObject, global::G.MessageContentTextAnnotationsFilePathObject>>? ListType71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OneOf<global::G.MessageDeltaContentTextAnnotationsFileCitationObject, global::G.MessageDeltaContentTextAnnotationsFilePathObject>>? ListType72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.RunStepObject>? ListType73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.OneOf<global::G.RunStepDetailsToolCallsCodeOutputLogsObject, global::G.RunStepDetailsToolCallsCodeOutputImageObject>>? ListType74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.VectorStoreSearchResultContentObject>? ListType75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.VectorStoreSearchResultItem>? ListType76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.VectorStoreObject>? ListType77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.VectorStoreFileObject>? ListType78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.BatchErrorsDataItem>? ListType79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Batch>? ListType80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.SecretMapping>? ListType81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.UsageLimits>? ListType82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.RateLimits>? ListType83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.AzureDeploymentConfig>? ListType84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.IntegrationModel>? ListType85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ModelUpdateRequest>? ListType86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.IntegrationWorkspace>? ListType87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.WorkspaceUpdateRequest>? ListType88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Invite>? ListType89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.User>? ListType90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.WorkspaceMember>? ListType91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Workspace>? ListType92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ChildCollection>? ListType93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Label>? ListType94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ExportItem>? ListType96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.LogExportsRequestedDataItem>? ListType97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.AuditLogObjectListRecord>? ListType98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ApiKeyObjectRateLimit>? ListType99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ApiKeyObject>? ListType100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateApiKeyObjectRateLimit>? ListType101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.UpdateApiKeyObjectRateLimit>? ListType102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GuardrailCheck>? ListType103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GuardrailSummary>? ListType104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.AllowedRequestTypesParametersAllowedType>? ListType105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.AllowedRequestTypesParametersBlockedType>? ListType106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.PillarScanParametersScanner>? ListType107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.PortkeyModerationParametersCategorie>? ListType108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.PortkeyPIIParametersCategorie>? ListType109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.MistralModerationParametersCategorie>? ListType110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.AcuvityScanParametersPiiCategorie>? ListType111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.AcuvityScanParametersSecretsCategorie>? ListType112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.AzureContentSafetyParametersCategorie>? ListType113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Condition>? ListType114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GroupBy>? ListType115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.UsageLimitsPolicy>? ListType116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.UsageLimitsPolicyEntity>? ListType117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.RateLimitsPolicy>? ListType118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.McpIntegrationListItem>? ListType119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.McpIntegrationWorkspaceItem>? ListType120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.BulkUpdateMcpIntegrationWorkspacesWorkspace>? ListType121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.McpIntegrationCapabilityItem>? ListType122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.BulkUpdateMcpIntegrationCapabilitiesCapabilitie>? ListType123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.McpServerListItem>? ListType124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.McpServerCapabilityItem>? ListType125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.BulkUpdateMcpServerCapabilitiesCapabilitie>? ListType126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.McpServerUserAccessItem>? ListType127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.BulkUpdateMcpServerUserAccessUserAcces>? ListType128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateVirtualKeysRequestDeploymentConfigItem>? ListType129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.PutVirtualKeysRequestDeploymentConfigItem>? ListType130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CreateAdminWorkspacesUsersRequestUser>? ListType131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.CustomLog, global::System.Collections.Generic.List<global::G.CustomLog>>? ListType132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CustomLog>? ListType133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.CollectionWithDetails>? ListType134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.PromptSummary>? ListType135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.PromptVersionSummary>? ListType136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.PromptPartialSummary>? ListType137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.PromptPartialVersion>? ListType138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ListConfigsResponseDataItem>? ListType139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetConfigResponseDataConfigTarget>? ListType140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ListConfigVersionsResponseDataItem>? ListType141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.IntegrationList>? ListType142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.Providers>? ListType143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.VirtualKeys>? ListType144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsRequestsResponseDataPoint>? ListType145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsCostResponseDataPoint>? ListType146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsLatencyResponseDataPoint>? ListType147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsTokensResponseDataPoint>? ListType148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsUsersResponseDataPoint>? ListType149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsUsersRequestsResponseDataPoint>? ListType150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsErrorsResponseDataPoint>? ListType151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsErrorsRateResponseDataPoint>? ListType152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsErrorsStacksResponseDataPoint>? ListType153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsErrorsStacksResponseDataPointStat>? ListType154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint>? ListType155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsRequestsRescuedResponseDataPoint>? ListType156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem>? ListType157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsCacheHitRateResponseDataPoint>? ListType158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsCacheLatencyResponseDataPoint>? ListType159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsFeedbacksResponseDataPoint>? ListType160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint>? ListType161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsFeedbacksWeightedResponseDataPoint>? ListType162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint>? ListType163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGroupsUsersResponseDataItem>? ListType164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGroupsAiModelsResponseDataItem>? ListType165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsGroupsMetadataResponseDataItem>? ListType166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.SecretReferenceListItem>? ListType167 { get; set; }
    }
}