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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.EndCallToolResultModel? endCallSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.EndCallSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EndCallToolResultModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EndCallToolResultModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EndCallToolResultModel)}");
                endCallSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LanguageDetectionToolResultModel? languageDetectionSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.LanguageDetectionSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LanguageDetectionToolResultModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LanguageDetectionToolResultModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LanguageDetectionToolResultModel)}");
                languageDetectionSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TransferToAgentToolResultSuccessModel? transferToAgentSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToAgentSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToAgentToolResultSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToAgentToolResultSuccessModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferToAgentToolResultSuccessModel)}");
                transferToAgentSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TransferToAgentToolResultErrorModel? transferToAgentError = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToAgentError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToAgentToolResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToAgentToolResultErrorModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferToAgentToolResultErrorModel)}");
                transferToAgentError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TransferToNumberResultTwilioSuccessModel? transferToNumberTwilioSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberTwilioSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToNumberResultTwilioSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToNumberResultTwilioSuccessModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferToNumberResultTwilioSuccessModel)}");
                transferToNumberTwilioSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TransferToNumberResultSipSuccessModel? transferToNumberSipSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberSipSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToNumberResultSipSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToNumberResultSipSuccessModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferToNumberResultSipSuccessModel)}");
                transferToNumberSipSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TransferToNumberResultErrorModel? transferToNumberError = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToNumberResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToNumberResultErrorModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferToNumberResultErrorModel)}");
                transferToNumberError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SkipTurnToolResponseModel? skipTurnSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.SkipTurnSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SkipTurnToolResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SkipTurnToolResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SkipTurnToolResponseModel)}");
                skipTurnSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PlayDTMFResultSuccessModel? playDtmfSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.PlayDtmfSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PlayDTMFResultSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PlayDTMFResultSuccessModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PlayDTMFResultSuccessModel)}");
                playDtmfSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PlayDTMFResultErrorModel? playDtmfError = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.PlayDtmfError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PlayDTMFResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PlayDTMFResultErrorModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PlayDTMFResultErrorModel)}");
                playDtmfError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VoiceMailDetectionResultSuccessModel? voicemailDetectionSuccess = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.VoicemailDetectionSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoiceMailDetectionResultSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoiceMailDetectionResultSuccessModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VoiceMailDetectionResultSuccessModel)}");
                voicemailDetectionSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TestToolResultModel? testingToolResult = default;
            if (discriminator?.ResultType == global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TestingToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TestToolResultModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TestToolResultModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TestToolResultModel)}");
                testingToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEndCallSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EndCallToolResultModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EndCallToolResultModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EndCallToolResultModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCallSuccess, typeInfo);
            }
            else if (value.IsLanguageDetectionSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LanguageDetectionToolResultModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LanguageDetectionToolResultModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LanguageDetectionToolResultModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LanguageDetectionSuccess, typeInfo);
            }
            else if (value.IsTransferToAgentSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToAgentToolResultSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToAgentToolResultSuccessModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferToAgentToolResultSuccessModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgentSuccess, typeInfo);
            }
            else if (value.IsTransferToAgentError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToAgentToolResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToAgentToolResultErrorModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferToAgentToolResultErrorModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgentError, typeInfo);
            }
            else if (value.IsTransferToNumberTwilioSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToNumberResultTwilioSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToNumberResultTwilioSuccessModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferToNumberResultTwilioSuccessModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberTwilioSuccess, typeInfo);
            }
            else if (value.IsTransferToNumberSipSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToNumberResultSipSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToNumberResultSipSuccessModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferToNumberResultSipSuccessModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberSipSuccess, typeInfo);
            }
            else if (value.IsTransferToNumberError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToNumberResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToNumberResultErrorModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferToNumberResultErrorModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberError, typeInfo);
            }
            else if (value.IsSkipTurnSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SkipTurnToolResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SkipTurnToolResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SkipTurnToolResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkipTurnSuccess, typeInfo);
            }
            else if (value.IsPlayDtmfSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PlayDTMFResultSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PlayDTMFResultSuccessModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PlayDTMFResultSuccessModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayDtmfSuccess, typeInfo);
            }
            else if (value.IsPlayDtmfError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PlayDTMFResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PlayDTMFResultErrorModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PlayDTMFResultErrorModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayDtmfError, typeInfo);
            }
            else if (value.IsVoicemailDetectionSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VoiceMailDetectionResultSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VoiceMailDetectionResultSuccessModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VoiceMailDetectionResultSuccessModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoicemailDetectionSuccess, typeInfo);
            }
            else if (value.IsTestingToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TestToolResultModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TestToolResultModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TestToolResultModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestingToolResult, typeInfo);
            }
        }
    }
}