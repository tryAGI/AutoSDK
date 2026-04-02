//HintName: G.JsonConverters.ResultVariant12.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResultVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResultVariant12>
    {
        /// <inheritdoc />
        public override global::G.ResultVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator>(ref readerCopy, options);

            global::G.EndCallToolResultModel? endCallSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.EndCallSuccess)
            {
                endCallSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EndCallToolResultModel>(ref reader, options);
            }
            global::G.LanguageDetectionToolResultModel? languageDetectionSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.LanguageDetectionSuccess)
            {
                languageDetectionSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LanguageDetectionToolResultModel>(ref reader, options);
            }
            global::G.TransferToAgentToolResultSuccessModel? transferToAgentSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToAgentSuccess)
            {
                transferToAgentSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferToAgentToolResultSuccessModel>(ref reader, options);
            }
            global::G.TransferToAgentToolResultErrorModel? transferToAgentError = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToAgentError)
            {
                transferToAgentError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferToAgentToolResultErrorModel>(ref reader, options);
            }
            global::G.TransferToNumberResultTwilioSuccessModel? transferToNumberTwilioSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberTwilioSuccess)
            {
                transferToNumberTwilioSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferToNumberResultTwilioSuccessModel>(ref reader, options);
            }
            global::G.TransferToNumberResultSipSuccessModel? transferToNumberSipSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberSipSuccess)
            {
                transferToNumberSipSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferToNumberResultSipSuccessModel>(ref reader, options);
            }
            global::G.TransferToNumberResultErrorModel? transferToNumberError = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberError)
            {
                transferToNumberError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TransferToNumberResultErrorModel>(ref reader, options);
            }
            global::G.SkipTurnToolResponseModel? skipTurnSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.SkipTurnSuccess)
            {
                skipTurnSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SkipTurnToolResponseModel>(ref reader, options);
            }
            global::G.PlayDTMFResultSuccessModel? playDtmfSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.PlayDtmfSuccess)
            {
                playDtmfSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PlayDTMFResultSuccessModel>(ref reader, options);
            }
            global::G.PlayDTMFResultErrorModel? playDtmfError = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.PlayDtmfError)
            {
                playDtmfError = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PlayDTMFResultErrorModel>(ref reader, options);
            }
            global::G.VoiceMailDetectionResultSuccessModel? voicemailDetectionSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.VoicemailDetectionSuccess)
            {
                voicemailDetectionSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VoiceMailDetectionResultSuccessModel>(ref reader, options);
            }
            global::G.TestToolResultModel? testingToolResult = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TestingToolResult)
            {
                testingToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TestToolResultModel>(ref reader, options);
            }

            var __value = new global::G.ResultVariant12(
                discriminator?.ResultType,
                endCallSuccess,

                languageDetectionSuccess,

                transferToAgentSuccess,

                transferToAgentError,

                transferToNumberTwilioSuccess,

                transferToNumberSipSuccess,

                transferToNumberError,

                skipTurnSuccess,

                playDtmfSuccess,

                playDtmfError,

                voicemailDetectionSuccess,

                testingToolResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResultVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEndCallSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCallSuccess, typeof(global::G.EndCallToolResultModel), options);
            }
            else if (value.IsLanguageDetectionSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LanguageDetectionSuccess, typeof(global::G.LanguageDetectionToolResultModel), options);
            }
            else if (value.IsTransferToAgentSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgentSuccess, typeof(global::G.TransferToAgentToolResultSuccessModel), options);
            }
            else if (value.IsTransferToAgentError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgentError, typeof(global::G.TransferToAgentToolResultErrorModel), options);
            }
            else if (value.IsTransferToNumberTwilioSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberTwilioSuccess, typeof(global::G.TransferToNumberResultTwilioSuccessModel), options);
            }
            else if (value.IsTransferToNumberSipSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberSipSuccess, typeof(global::G.TransferToNumberResultSipSuccessModel), options);
            }
            else if (value.IsTransferToNumberError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberError, typeof(global::G.TransferToNumberResultErrorModel), options);
            }
            else if (value.IsSkipTurnSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkipTurnSuccess, typeof(global::G.SkipTurnToolResponseModel), options);
            }
            else if (value.IsPlayDtmfSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayDtmfSuccess, typeof(global::G.PlayDTMFResultSuccessModel), options);
            }
            else if (value.IsPlayDtmfError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayDtmfError, typeof(global::G.PlayDTMFResultErrorModel), options);
            }
            else if (value.IsVoicemailDetectionSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoicemailDetectionSuccess, typeof(global::G.VoiceMailDetectionResultSuccessModel), options);
            }
            else if (value.IsTestingToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestingToolResult, typeof(global::G.TestToolResultModel), options);
            }
        }
    }
}