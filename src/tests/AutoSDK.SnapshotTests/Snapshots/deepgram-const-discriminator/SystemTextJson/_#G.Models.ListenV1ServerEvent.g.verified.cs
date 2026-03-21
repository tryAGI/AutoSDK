//HintName: G.Models.ListenV1ServerEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListenV1ServerEvent : global::System.IEquatable<ListenV1ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListenV1ServerEventDiscriminatorMessageType? MessageType { get; }

        /// <summary>
        /// Transcript result from the server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranscriptResultPayload? TranscriptResult { get; init; }
#else
        public global::G.TranscriptResultPayload? TranscriptResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptResult))]
#endif
        public bool IsTranscriptResult => TranscriptResult != null;

        /// <summary>
        /// Metadata for the listen session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListenMetadataPayload? ListenMetadata { get; init; }
#else
        public global::G.ListenMetadataPayload? ListenMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenMetadata))]
#endif
        public bool IsListenMetadata => ListenMetadata != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::G.TranscriptResultPayload value) => new ListenV1ServerEvent((global::G.TranscriptResultPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranscriptResultPayload?(ListenV1ServerEvent @this) => @this.TranscriptResult;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::G.TranscriptResultPayload? value)
        {
            TranscriptResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::G.ListenMetadataPayload value) => new ListenV1ServerEvent((global::G.ListenMetadataPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListenMetadataPayload?(ListenV1ServerEvent @this) => @this.ListenMetadata;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::G.ListenMetadataPayload? value)
        {
            ListenMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(
            global::G.ListenV1ServerEventDiscriminatorMessageType? messageType,
            global::G.TranscriptResultPayload? transcriptResult,
            global::G.ListenMetadataPayload? listenMetadata
            )
        {
            MessageType = messageType;

            TranscriptResult = transcriptResult;
            ListenMetadata = listenMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListenMetadata as object ??
            TranscriptResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranscriptResult?.ToString() ??
            ListenMetadata?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranscriptResult && !IsListenMetadata || !IsTranscriptResult && IsListenMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TranscriptResultPayload?, TResult>? transcriptResult = null,
            global::System.Func<global::G.ListenMetadataPayload?, TResult>? listenMetadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptResult && transcriptResult != null)
            {
                return transcriptResult(TranscriptResult!);
            }
            else if (IsListenMetadata && listenMetadata != null)
            {
                return listenMetadata(ListenMetadata!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TranscriptResultPayload?>? transcriptResult = null,
            global::System.Action<global::G.ListenMetadataPayload?>? listenMetadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptResult)
            {
                transcriptResult?.Invoke(TranscriptResult!);
            }
            else if (IsListenMetadata)
            {
                listenMetadata?.Invoke(ListenMetadata!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranscriptResult,
                typeof(global::G.TranscriptResultPayload),
                ListenMetadata,
                typeof(global::G.ListenMetadataPayload),
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
        public bool Equals(ListenV1ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TranscriptResultPayload?>.Default.Equals(TranscriptResult, other.TranscriptResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListenMetadataPayload?>.Default.Equals(ListenMetadata, other.ListenMetadata) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListenV1ServerEvent obj1, ListenV1ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListenV1ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListenV1ServerEvent obj1, ListenV1ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListenV1ServerEvent o && Equals(o);
        }
    }
}
