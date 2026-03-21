//HintName: G.Models.SpeakV1ServerEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SpeakV1ServerEvent : global::System.IEquatable<SpeakV1ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.SpeakV1ServerEventDiscriminatorMessageType? MessageType { get; }

        /// <summary>
        /// Synthesized audio response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AudioResponsePayload? AudioResponse { get; init; }
#else
        public global::G.AudioResponsePayload? AudioResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioResponse))]
#endif
        public bool IsAudioResponse => AudioResponse != null;

        /// <summary>
        /// Metadata for the speak session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SpeakMetadataPayload? SpeakMetadata { get; init; }
#else
        public global::G.SpeakMetadataPayload? SpeakMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakMetadata))]
#endif
        public bool IsSpeakMetadata => SpeakMetadata != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakV1ServerEvent(global::G.AudioResponsePayload value) => new SpeakV1ServerEvent((global::G.AudioResponsePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AudioResponsePayload?(SpeakV1ServerEvent @this) => @this.AudioResponse;

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(global::G.AudioResponsePayload? value)
        {
            AudioResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakV1ServerEvent(global::G.SpeakMetadataPayload value) => new SpeakV1ServerEvent((global::G.SpeakMetadataPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SpeakMetadataPayload?(SpeakV1ServerEvent @this) => @this.SpeakMetadata;

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(global::G.SpeakMetadataPayload? value)
        {
            SpeakMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(
            global::G.SpeakV1ServerEventDiscriminatorMessageType? messageType,
            global::G.AudioResponsePayload? audioResponse,
            global::G.SpeakMetadataPayload? speakMetadata
            )
        {
            MessageType = messageType;

            AudioResponse = audioResponse;
            SpeakMetadata = speakMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SpeakMetadata as object ??
            AudioResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AudioResponse?.ToString() ??
            SpeakMetadata?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudioResponse && !IsSpeakMetadata || !IsAudioResponse && IsSpeakMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AudioResponsePayload?, TResult>? audioResponse = null,
            global::System.Func<global::G.SpeakMetadataPayload?, TResult>? speakMetadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioResponse && audioResponse != null)
            {
                return audioResponse(AudioResponse!);
            }
            else if (IsSpeakMetadata && speakMetadata != null)
            {
                return speakMetadata(SpeakMetadata!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AudioResponsePayload?>? audioResponse = null,
            global::System.Action<global::G.SpeakMetadataPayload?>? speakMetadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioResponse)
            {
                audioResponse?.Invoke(AudioResponse!);
            }
            else if (IsSpeakMetadata)
            {
                speakMetadata?.Invoke(SpeakMetadata!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AudioResponse,
                typeof(global::G.AudioResponsePayload),
                SpeakMetadata,
                typeof(global::G.SpeakMetadataPayload),
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
        public bool Equals(SpeakV1ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AudioResponsePayload?>.Default.Equals(AudioResponse, other.AudioResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SpeakMetadataPayload?>.Default.Equals(SpeakMetadata, other.SpeakMetadata) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SpeakV1ServerEvent obj1, SpeakV1ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpeakV1ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SpeakV1ServerEvent obj1, SpeakV1ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeakV1ServerEvent o && Equals(o);
        }
    }
}
