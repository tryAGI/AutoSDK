//HintName: G.Models.ResultVariant12.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultVariant12 : global::System.IEquatable<ResultVariant12>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType? ResultType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EndCallToolResultModel? EndCallSuccess { get; init; }
#else
        public global::G.EndCallToolResultModel? EndCallSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndCallSuccess))]
#endif
        public bool IsEndCallSuccess => EndCallSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LanguageDetectionToolResultModel? LanguageDetectionSuccess { get; init; }
#else
        public global::G.LanguageDetectionToolResultModel? LanguageDetectionSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LanguageDetectionSuccess))]
#endif
        public bool IsLanguageDetectionSuccess => LanguageDetectionSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferToAgentToolResultSuccessModel? TransferToAgentSuccess { get; init; }
#else
        public global::G.TransferToAgentToolResultSuccessModel? TransferToAgentSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToAgentSuccess))]
#endif
        public bool IsTransferToAgentSuccess => TransferToAgentSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferToAgentToolResultErrorModel? TransferToAgentError { get; init; }
#else
        public global::G.TransferToAgentToolResultErrorModel? TransferToAgentError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToAgentError))]
#endif
        public bool IsTransferToAgentError => TransferToAgentError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferToNumberResultTwilioSuccessModel? TransferToNumberTwilioSuccess { get; init; }
#else
        public global::G.TransferToNumberResultTwilioSuccessModel? TransferToNumberTwilioSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToNumberTwilioSuccess))]
#endif
        public bool IsTransferToNumberTwilioSuccess => TransferToNumberTwilioSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferToNumberResultSipSuccessModel? TransferToNumberSipSuccess { get; init; }
#else
        public global::G.TransferToNumberResultSipSuccessModel? TransferToNumberSipSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToNumberSipSuccess))]
#endif
        public bool IsTransferToNumberSipSuccess => TransferToNumberSipSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferToNumberResultErrorModel? TransferToNumberError { get; init; }
#else
        public global::G.TransferToNumberResultErrorModel? TransferToNumberError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferToNumberError))]
#endif
        public bool IsTransferToNumberError => TransferToNumberError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SkipTurnToolResponseModel? SkipTurnSuccess { get; init; }
#else
        public global::G.SkipTurnToolResponseModel? SkipTurnSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkipTurnSuccess))]
#endif
        public bool IsSkipTurnSuccess => SkipTurnSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PlayDTMFResultSuccessModel? PlayDtmfSuccess { get; init; }
#else
        public global::G.PlayDTMFResultSuccessModel? PlayDtmfSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlayDtmfSuccess))]
#endif
        public bool IsPlayDtmfSuccess => PlayDtmfSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PlayDTMFResultErrorModel? PlayDtmfError { get; init; }
#else
        public global::G.PlayDTMFResultErrorModel? PlayDtmfError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlayDtmfError))]
#endif
        public bool IsPlayDtmfError => PlayDtmfError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VoiceMailDetectionResultSuccessModel? VoicemailDetectionSuccess { get; init; }
#else
        public global::G.VoiceMailDetectionResultSuccessModel? VoicemailDetectionSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoicemailDetectionSuccess))]
#endif
        public bool IsVoicemailDetectionSuccess => VoicemailDetectionSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TestToolResultModel? TestingToolResult { get; init; }
#else
        public global::G.TestToolResultModel? TestingToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestingToolResult))]
#endif
        public bool IsTestingToolResult => TestingToolResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.EndCallToolResultModel value) => new ResultVariant12((global::G.EndCallToolResultModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EndCallToolResultModel?(ResultVariant12 @this) => @this.EndCallSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.EndCallToolResultModel? value)
        {
            EndCallSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.LanguageDetectionToolResultModel value) => new ResultVariant12((global::G.LanguageDetectionToolResultModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LanguageDetectionToolResultModel?(ResultVariant12 @this) => @this.LanguageDetectionSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.LanguageDetectionToolResultModel? value)
        {
            LanguageDetectionSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.TransferToAgentToolResultSuccessModel value) => new ResultVariant12((global::G.TransferToAgentToolResultSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferToAgentToolResultSuccessModel?(ResultVariant12 @this) => @this.TransferToAgentSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.TransferToAgentToolResultSuccessModel? value)
        {
            TransferToAgentSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.TransferToAgentToolResultErrorModel value) => new ResultVariant12((global::G.TransferToAgentToolResultErrorModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferToAgentToolResultErrorModel?(ResultVariant12 @this) => @this.TransferToAgentError;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.TransferToAgentToolResultErrorModel? value)
        {
            TransferToAgentError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.TransferToNumberResultTwilioSuccessModel value) => new ResultVariant12((global::G.TransferToNumberResultTwilioSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferToNumberResultTwilioSuccessModel?(ResultVariant12 @this) => @this.TransferToNumberTwilioSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.TransferToNumberResultTwilioSuccessModel? value)
        {
            TransferToNumberTwilioSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.TransferToNumberResultSipSuccessModel value) => new ResultVariant12((global::G.TransferToNumberResultSipSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferToNumberResultSipSuccessModel?(ResultVariant12 @this) => @this.TransferToNumberSipSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.TransferToNumberResultSipSuccessModel? value)
        {
            TransferToNumberSipSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.TransferToNumberResultErrorModel value) => new ResultVariant12((global::G.TransferToNumberResultErrorModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferToNumberResultErrorModel?(ResultVariant12 @this) => @this.TransferToNumberError;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.TransferToNumberResultErrorModel? value)
        {
            TransferToNumberError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.SkipTurnToolResponseModel value) => new ResultVariant12((global::G.SkipTurnToolResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SkipTurnToolResponseModel?(ResultVariant12 @this) => @this.SkipTurnSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.SkipTurnToolResponseModel? value)
        {
            SkipTurnSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.PlayDTMFResultSuccessModel value) => new ResultVariant12((global::G.PlayDTMFResultSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PlayDTMFResultSuccessModel?(ResultVariant12 @this) => @this.PlayDtmfSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.PlayDTMFResultSuccessModel? value)
        {
            PlayDtmfSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.PlayDTMFResultErrorModel value) => new ResultVariant12((global::G.PlayDTMFResultErrorModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PlayDTMFResultErrorModel?(ResultVariant12 @this) => @this.PlayDtmfError;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.PlayDTMFResultErrorModel? value)
        {
            PlayDtmfError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.VoiceMailDetectionResultSuccessModel value) => new ResultVariant12((global::G.VoiceMailDetectionResultSuccessModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VoiceMailDetectionResultSuccessModel?(ResultVariant12 @this) => @this.VoicemailDetectionSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.VoiceMailDetectionResultSuccessModel? value)
        {
            VoicemailDetectionSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultVariant12(global::G.TestToolResultModel value) => new ResultVariant12((global::G.TestToolResultModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TestToolResultModel?(ResultVariant12 @this) => @this.TestingToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(global::G.TestToolResultModel? value)
        {
            TestingToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultVariant12(
            global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType? resultType,
            global::G.EndCallToolResultModel? endCallSuccess,
            global::G.LanguageDetectionToolResultModel? languageDetectionSuccess,
            global::G.TransferToAgentToolResultSuccessModel? transferToAgentSuccess,
            global::G.TransferToAgentToolResultErrorModel? transferToAgentError,
            global::G.TransferToNumberResultTwilioSuccessModel? transferToNumberTwilioSuccess,
            global::G.TransferToNumberResultSipSuccessModel? transferToNumberSipSuccess,
            global::G.TransferToNumberResultErrorModel? transferToNumberError,
            global::G.SkipTurnToolResponseModel? skipTurnSuccess,
            global::G.PlayDTMFResultSuccessModel? playDtmfSuccess,
            global::G.PlayDTMFResultErrorModel? playDtmfError,
            global::G.VoiceMailDetectionResultSuccessModel? voicemailDetectionSuccess,
            global::G.TestToolResultModel? testingToolResult
            )
        {
            ResultType = resultType;

            EndCallSuccess = endCallSuccess;
            LanguageDetectionSuccess = languageDetectionSuccess;
            TransferToAgentSuccess = transferToAgentSuccess;
            TransferToAgentError = transferToAgentError;
            TransferToNumberTwilioSuccess = transferToNumberTwilioSuccess;
            TransferToNumberSipSuccess = transferToNumberSipSuccess;
            TransferToNumberError = transferToNumberError;
            SkipTurnSuccess = skipTurnSuccess;
            PlayDtmfSuccess = playDtmfSuccess;
            PlayDtmfError = playDtmfError;
            VoicemailDetectionSuccess = voicemailDetectionSuccess;
            TestingToolResult = testingToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TestingToolResult as object ??
            VoicemailDetectionSuccess as object ??
            PlayDtmfError as object ??
            PlayDtmfSuccess as object ??
            SkipTurnSuccess as object ??
            TransferToNumberError as object ??
            TransferToNumberSipSuccess as object ??
            TransferToNumberTwilioSuccess as object ??
            TransferToAgentError as object ??
            TransferToAgentSuccess as object ??
            LanguageDetectionSuccess as object ??
            EndCallSuccess as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EndCallSuccess?.ToString() ??
            LanguageDetectionSuccess?.ToString() ??
            TransferToAgentSuccess?.ToString() ??
            TransferToAgentError?.ToString() ??
            TransferToNumberTwilioSuccess?.ToString() ??
            TransferToNumberSipSuccess?.ToString() ??
            TransferToNumberError?.ToString() ??
            SkipTurnSuccess?.ToString() ??
            PlayDtmfSuccess?.ToString() ??
            PlayDtmfError?.ToString() ??
            VoicemailDetectionSuccess?.ToString() ??
            TestingToolResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && IsPlayDtmfError && !IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && IsVoicemailDetectionSuccess && !IsTestingToolResult || !IsEndCallSuccess && !IsLanguageDetectionSuccess && !IsTransferToAgentSuccess && !IsTransferToAgentError && !IsTransferToNumberTwilioSuccess && !IsTransferToNumberSipSuccess && !IsTransferToNumberError && !IsSkipTurnSuccess && !IsPlayDtmfSuccess && !IsPlayDtmfError && !IsVoicemailDetectionSuccess && IsTestingToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.EndCallToolResultModel?, TResult>? endCallSuccess = null,
            global::System.Func<global::G.LanguageDetectionToolResultModel?, TResult>? languageDetectionSuccess = null,
            global::System.Func<global::G.TransferToAgentToolResultSuccessModel?, TResult>? transferToAgentSuccess = null,
            global::System.Func<global::G.TransferToAgentToolResultErrorModel?, TResult>? transferToAgentError = null,
            global::System.Func<global::G.TransferToNumberResultTwilioSuccessModel?, TResult>? transferToNumberTwilioSuccess = null,
            global::System.Func<global::G.TransferToNumberResultSipSuccessModel?, TResult>? transferToNumberSipSuccess = null,
            global::System.Func<global::G.TransferToNumberResultErrorModel?, TResult>? transferToNumberError = null,
            global::System.Func<global::G.SkipTurnToolResponseModel?, TResult>? skipTurnSuccess = null,
            global::System.Func<global::G.PlayDTMFResultSuccessModel?, TResult>? playDtmfSuccess = null,
            global::System.Func<global::G.PlayDTMFResultErrorModel?, TResult>? playDtmfError = null,
            global::System.Func<global::G.VoiceMailDetectionResultSuccessModel?, TResult>? voicemailDetectionSuccess = null,
            global::System.Func<global::G.TestToolResultModel?, TResult>? testingToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCallSuccess && endCallSuccess != null)
            {
                return endCallSuccess(EndCallSuccess!);
            }
            else if (IsLanguageDetectionSuccess && languageDetectionSuccess != null)
            {
                return languageDetectionSuccess(LanguageDetectionSuccess!);
            }
            else if (IsTransferToAgentSuccess && transferToAgentSuccess != null)
            {
                return transferToAgentSuccess(TransferToAgentSuccess!);
            }
            else if (IsTransferToAgentError && transferToAgentError != null)
            {
                return transferToAgentError(TransferToAgentError!);
            }
            else if (IsTransferToNumberTwilioSuccess && transferToNumberTwilioSuccess != null)
            {
                return transferToNumberTwilioSuccess(TransferToNumberTwilioSuccess!);
            }
            else if (IsTransferToNumberSipSuccess && transferToNumberSipSuccess != null)
            {
                return transferToNumberSipSuccess(TransferToNumberSipSuccess!);
            }
            else if (IsTransferToNumberError && transferToNumberError != null)
            {
                return transferToNumberError(TransferToNumberError!);
            }
            else if (IsSkipTurnSuccess && skipTurnSuccess != null)
            {
                return skipTurnSuccess(SkipTurnSuccess!);
            }
            else if (IsPlayDtmfSuccess && playDtmfSuccess != null)
            {
                return playDtmfSuccess(PlayDtmfSuccess!);
            }
            else if (IsPlayDtmfError && playDtmfError != null)
            {
                return playDtmfError(PlayDtmfError!);
            }
            else if (IsVoicemailDetectionSuccess && voicemailDetectionSuccess != null)
            {
                return voicemailDetectionSuccess(VoicemailDetectionSuccess!);
            }
            else if (IsTestingToolResult && testingToolResult != null)
            {
                return testingToolResult(TestingToolResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.EndCallToolResultModel?>? endCallSuccess = null,
            global::System.Action<global::G.LanguageDetectionToolResultModel?>? languageDetectionSuccess = null,
            global::System.Action<global::G.TransferToAgentToolResultSuccessModel?>? transferToAgentSuccess = null,
            global::System.Action<global::G.TransferToAgentToolResultErrorModel?>? transferToAgentError = null,
            global::System.Action<global::G.TransferToNumberResultTwilioSuccessModel?>? transferToNumberTwilioSuccess = null,
            global::System.Action<global::G.TransferToNumberResultSipSuccessModel?>? transferToNumberSipSuccess = null,
            global::System.Action<global::G.TransferToNumberResultErrorModel?>? transferToNumberError = null,
            global::System.Action<global::G.SkipTurnToolResponseModel?>? skipTurnSuccess = null,
            global::System.Action<global::G.PlayDTMFResultSuccessModel?>? playDtmfSuccess = null,
            global::System.Action<global::G.PlayDTMFResultErrorModel?>? playDtmfError = null,
            global::System.Action<global::G.VoiceMailDetectionResultSuccessModel?>? voicemailDetectionSuccess = null,
            global::System.Action<global::G.TestToolResultModel?>? testingToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndCallSuccess)
            {
                endCallSuccess?.Invoke(EndCallSuccess!);
            }
            else if (IsLanguageDetectionSuccess)
            {
                languageDetectionSuccess?.Invoke(LanguageDetectionSuccess!);
            }
            else if (IsTransferToAgentSuccess)
            {
                transferToAgentSuccess?.Invoke(TransferToAgentSuccess!);
            }
            else if (IsTransferToAgentError)
            {
                transferToAgentError?.Invoke(TransferToAgentError!);
            }
            else if (IsTransferToNumberTwilioSuccess)
            {
                transferToNumberTwilioSuccess?.Invoke(TransferToNumberTwilioSuccess!);
            }
            else if (IsTransferToNumberSipSuccess)
            {
                transferToNumberSipSuccess?.Invoke(TransferToNumberSipSuccess!);
            }
            else if (IsTransferToNumberError)
            {
                transferToNumberError?.Invoke(TransferToNumberError!);
            }
            else if (IsSkipTurnSuccess)
            {
                skipTurnSuccess?.Invoke(SkipTurnSuccess!);
            }
            else if (IsPlayDtmfSuccess)
            {
                playDtmfSuccess?.Invoke(PlayDtmfSuccess!);
            }
            else if (IsPlayDtmfError)
            {
                playDtmfError?.Invoke(PlayDtmfError!);
            }
            else if (IsVoicemailDetectionSuccess)
            {
                voicemailDetectionSuccess?.Invoke(VoicemailDetectionSuccess!);
            }
            else if (IsTestingToolResult)
            {
                testingToolResult?.Invoke(TestingToolResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EndCallSuccess,
                typeof(global::G.EndCallToolResultModel),
                LanguageDetectionSuccess,
                typeof(global::G.LanguageDetectionToolResultModel),
                TransferToAgentSuccess,
                typeof(global::G.TransferToAgentToolResultSuccessModel),
                TransferToAgentError,
                typeof(global::G.TransferToAgentToolResultErrorModel),
                TransferToNumberTwilioSuccess,
                typeof(global::G.TransferToNumberResultTwilioSuccessModel),
                TransferToNumberSipSuccess,
                typeof(global::G.TransferToNumberResultSipSuccessModel),
                TransferToNumberError,
                typeof(global::G.TransferToNumberResultErrorModel),
                SkipTurnSuccess,
                typeof(global::G.SkipTurnToolResponseModel),
                PlayDtmfSuccess,
                typeof(global::G.PlayDTMFResultSuccessModel),
                PlayDtmfError,
                typeof(global::G.PlayDTMFResultErrorModel),
                VoicemailDetectionSuccess,
                typeof(global::G.VoiceMailDetectionResultSuccessModel),
                TestingToolResult,
                typeof(global::G.TestToolResultModel),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResultVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.EndCallToolResultModel?>.Default.Equals(EndCallSuccess, other.EndCallSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LanguageDetectionToolResultModel?>.Default.Equals(LanguageDetectionSuccess, other.LanguageDetectionSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferToAgentToolResultSuccessModel?>.Default.Equals(TransferToAgentSuccess, other.TransferToAgentSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferToAgentToolResultErrorModel?>.Default.Equals(TransferToAgentError, other.TransferToAgentError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferToNumberResultTwilioSuccessModel?>.Default.Equals(TransferToNumberTwilioSuccess, other.TransferToNumberTwilioSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferToNumberResultSipSuccessModel?>.Default.Equals(TransferToNumberSipSuccess, other.TransferToNumberSipSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferToNumberResultErrorModel?>.Default.Equals(TransferToNumberError, other.TransferToNumberError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SkipTurnToolResponseModel?>.Default.Equals(SkipTurnSuccess, other.SkipTurnSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PlayDTMFResultSuccessModel?>.Default.Equals(PlayDtmfSuccess, other.PlayDtmfSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PlayDTMFResultErrorModel?>.Default.Equals(PlayDtmfError, other.PlayDtmfError) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VoiceMailDetectionResultSuccessModel?>.Default.Equals(VoicemailDetectionSuccess, other.VoicemailDetectionSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TestToolResultModel?>.Default.Equals(TestingToolResult, other.TestingToolResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultVariant12 obj1, ResultVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultVariant12 obj1, ResultVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultVariant12 o && Equals(o);
        }
    }
}
