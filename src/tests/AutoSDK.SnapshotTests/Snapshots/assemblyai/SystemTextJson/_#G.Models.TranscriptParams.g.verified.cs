//HintName: G.Models.TranscriptParams.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The parameters for creating a transcript<br/>
    /// Example: {"speech_model":"","language_code":"en_us","language_detection":true,"language_confidence_threshold":0.7,"audio_url":"https://github.com/AssemblyAI-Examples/audio-examples/raw/main/20230607_me_canadian_wildfires.mp3","punctuate":true,"format_text":true,"dual_channel":true,"webhook_url":"https://your-webhook-url/path","webhook_auth_header_name":"webhook-secret","webhook_auth_header_value":"webhook-secret-value","auto_highlights":true,"audio_start_from":10,"audio_end_at":280,"word_boost":["aws","azure","google cloud"],"boost_param":"high","filter_profanity":true,"redact_pii":true,"redact_pii_audio":true,"redact_pii_audio_quality":"mp3","redact_pii_policies":["us_social_security_number","credit_card_number"],"redact_pii_sub":"hash","speaker_labels":true,"speakers_expected":2,"content_safety":true,"iab_categories":true,"custom_spelling":[],"disfluencies":false,"sentiment_analysis":true,"auto_chapters":true,"entity_detection":true,"speech_threshold":0.5,"summarization":true,"summary_model":"informative","summary_type":"bullets","custom_topics":true,"topics":[]}
    /// </summary>
    public readonly partial struct TranscriptParams : global::System.IEquatable<TranscriptParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranscriptParamsVariant1? TranscriptParamsVariant1 { get; init; }
#else
        public global::G.TranscriptParamsVariant1? TranscriptParamsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptParamsVariant1))]
#endif
        public bool IsTranscriptParamsVariant1 => TranscriptParamsVariant1 != null;

        /// <summary>
        /// The parameters for creating a transcript<br/>
        /// Example: {"speech_model":"","language_code":"en_us","language_detection":true,"language_confidence_threshold":0.7,"punctuate":true,"format_text":true,"dual_channel":true,"webhook_url":"https://your-webhook-url.tld/path","webhook_auth_header_name":"webhook-secret","webhook_auth_header_value":"webhook-secret-value","auto_highlights":true,"audio_start_from":10,"audio_end_at":280,"word_boost":["aws","azure","google cloud"],"boost_param":"high","filter_profanity":true,"redact_pii":true,"redact_pii_audio":true,"redact_pii_audio_quality":"mp3","redact_pii_policies":["us_social_security_number","credit_card_number"],"redact_pii_sub":"hash","speaker_labels":true,"speakers_expected":2,"content_safety":true,"iab_categories":true,"custom_spelling":[],"disfluencies":false,"sentiment_analysis":true,"auto_chapters":true,"entity_detection":true,"speech_threshold":0.5,"summarization":true,"summary_model":"informative","summary_type":"bullets","custom_topics":true,"topics":[]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranscriptOptionalParams? Optional { get; init; }
#else
        public global::G.TranscriptOptionalParams? Optional { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Optional))]
#endif
        public bool IsOptional => Optional != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptParams(global::G.TranscriptParamsVariant1 value) => new TranscriptParams((global::G.TranscriptParamsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranscriptParamsVariant1?(TranscriptParams @this) => @this.TranscriptParamsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptParams(global::G.TranscriptParamsVariant1? value)
        {
            TranscriptParamsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptParams(global::G.TranscriptOptionalParams value) => new TranscriptParams((global::G.TranscriptOptionalParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranscriptOptionalParams?(TranscriptParams @this) => @this.Optional;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptParams(global::G.TranscriptOptionalParams? value)
        {
            Optional = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptParams(
            global::G.TranscriptParamsVariant1? transcriptParamsVariant1,
            global::G.TranscriptOptionalParams? optional
            )
        {
            TranscriptParamsVariant1 = transcriptParamsVariant1;
            Optional = optional;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Optional as object ??
            TranscriptParamsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranscriptParamsVariant1?.ToString() ??
            Optional?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranscriptParamsVariant1 && IsOptional;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TranscriptParamsVariant1?, TResult>? transcriptParamsVariant1 = null,
            global::System.Func<global::G.TranscriptOptionalParams?, TResult>? optional = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptParamsVariant1 && transcriptParamsVariant1 != null)
            {
                return transcriptParamsVariant1(TranscriptParamsVariant1!);
            }
            else if (IsOptional && optional != null)
            {
                return optional(Optional!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TranscriptParamsVariant1?>? transcriptParamsVariant1 = null,
            global::System.Action<global::G.TranscriptOptionalParams?>? optional = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptParamsVariant1)
            {
                transcriptParamsVariant1?.Invoke(TranscriptParamsVariant1!);
            }
            else if (IsOptional)
            {
                optional?.Invoke(Optional!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranscriptParamsVariant1,
                typeof(global::G.TranscriptParamsVariant1),
                Optional,
                typeof(global::G.TranscriptOptionalParams),
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
        public bool Equals(TranscriptParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TranscriptParamsVariant1?>.Default.Equals(TranscriptParamsVariant1, other.TranscriptParamsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TranscriptOptionalParams?>.Default.Equals(Optional, other.Optional) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TranscriptParams obj1, TranscriptParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranscriptParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TranscriptParams obj1, TranscriptParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranscriptParams o && Equals(o);
        }
    }
}
