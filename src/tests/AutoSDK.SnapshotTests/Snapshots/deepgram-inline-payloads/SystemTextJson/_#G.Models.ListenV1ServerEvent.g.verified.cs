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
        public global::G.ListenV1ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Transcription result from the server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListenV1Results? Results { get; init; }
#else
        public global::G.ListenV1Results? Results { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Results))]
#endif
        public bool IsResults => Results != null;

        /// <summary>
        /// Metadata about the transcription session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListenV1Metadata? Metadata { get; init; }
#else
        public global::G.ListenV1Metadata? Metadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Metadata))]
#endif
        public bool IsMetadata => Metadata != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::G.ListenV1Results value) => new ListenV1ServerEvent((global::G.ListenV1Results?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListenV1Results?(ListenV1ServerEvent @this) => @this.Results;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::G.ListenV1Results? value)
        {
            Results = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::G.ListenV1Metadata value) => new ListenV1ServerEvent((global::G.ListenV1Metadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListenV1Metadata?(ListenV1ServerEvent @this) => @this.Metadata;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::G.ListenV1Metadata? value)
        {
            Metadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(
            global::G.ListenV1ServerEventDiscriminatorType? type,
            global::G.ListenV1Results? results,
            global::G.ListenV1Metadata? metadata
            )
        {
            Type = type;

            Results = results;
            Metadata = metadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Metadata as object ??
            Results as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Results?.ToString() ??
            Metadata?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResults && !IsMetadata || !IsResults && IsMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ListenV1Results?, TResult>? results = null,
            global::System.Func<global::G.ListenV1Metadata?, TResult>? metadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResults && results != null)
            {
                return results(Results!);
            }
            else if (IsMetadata && metadata != null)
            {
                return metadata(Metadata!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ListenV1Results?>? results = null,
            global::System.Action<global::G.ListenV1Metadata?>? metadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResults)
            {
                results?.Invoke(Results!);
            }
            else if (IsMetadata)
            {
                metadata?.Invoke(Metadata!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Results,
                typeof(global::G.ListenV1Results),
                Metadata,
                typeof(global::G.ListenV1Metadata),
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
                global::System.Collections.Generic.EqualityComparer<global::G.ListenV1Results?>.Default.Equals(Results, other.Results) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListenV1Metadata?>.Default.Equals(Metadata, other.Metadata) 
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
