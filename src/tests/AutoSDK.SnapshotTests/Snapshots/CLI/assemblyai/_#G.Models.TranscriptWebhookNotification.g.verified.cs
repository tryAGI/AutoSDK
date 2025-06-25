//HintName: G.Models.TranscriptWebhookNotification.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The notifications sent to the webhook URL.
    /// </summary>
    public readonly partial struct TranscriptWebhookNotification : global::System.IEquatable<TranscriptWebhookNotification>
    {
        /// <summary>
        /// The notification when the transcript status is completed or error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranscriptReadyNotification? Ready { get; init; }
#else
        public global::G.TranscriptReadyNotification? Ready { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ready))]
#endif
        public bool IsReady => Ready != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptWebhookNotification(global::G.TranscriptReadyNotification value) => new TranscriptWebhookNotification((global::G.TranscriptReadyNotification?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranscriptReadyNotification?(TranscriptWebhookNotification @this) => @this.Ready;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptWebhookNotification(global::G.TranscriptReadyNotification? value)
        {
            Ready = value;
        }

        /// <summary>
        /// The notification when the redacted audio is ready.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RedactedAudioNotification? RedactedAudio { get; init; }
#else
        public global::G.RedactedAudioNotification? RedactedAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RedactedAudio))]
#endif
        public bool IsRedactedAudio => RedactedAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptWebhookNotification(global::G.RedactedAudioNotification value) => new TranscriptWebhookNotification((global::G.RedactedAudioNotification?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RedactedAudioNotification?(TranscriptWebhookNotification @this) => @this.RedactedAudio;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptWebhookNotification(global::G.RedactedAudioNotification? value)
        {
            RedactedAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptWebhookNotification(
            global::G.TranscriptReadyNotification? ready,
            global::G.RedactedAudioNotification? redactedAudio
            )
        {
            Ready = ready;
            RedactedAudio = redactedAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RedactedAudio as object ??
            Ready as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Ready?.ToString() ??
            RedactedAudio?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReady && !IsRedactedAudio || !IsReady && IsRedactedAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TranscriptReadyNotification?, TResult>? ready = null,
            global::System.Func<global::G.RedactedAudioNotification?, TResult>? redactedAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReady && ready != null)
            {
                return ready(Ready!);
            }
            else if (IsRedactedAudio && redactedAudio != null)
            {
                return redactedAudio(RedactedAudio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TranscriptReadyNotification?>? ready = null,
            global::System.Action<global::G.RedactedAudioNotification?>? redactedAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReady)
            {
                ready?.Invoke(Ready!);
            }
            else if (IsRedactedAudio)
            {
                redactedAudio?.Invoke(RedactedAudio!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Ready,
                typeof(global::G.TranscriptReadyNotification),
                RedactedAudio,
                typeof(global::G.RedactedAudioNotification),
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
        public bool Equals(TranscriptWebhookNotification other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TranscriptReadyNotification?>.Default.Equals(Ready, other.Ready) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RedactedAudioNotification?>.Default.Equals(RedactedAudio, other.RedactedAudio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TranscriptWebhookNotification obj1, TranscriptWebhookNotification obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranscriptWebhookNotification>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TranscriptWebhookNotification obj1, TranscriptWebhookNotification obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranscriptWebhookNotification o && Equals(o);
        }
    }
}
