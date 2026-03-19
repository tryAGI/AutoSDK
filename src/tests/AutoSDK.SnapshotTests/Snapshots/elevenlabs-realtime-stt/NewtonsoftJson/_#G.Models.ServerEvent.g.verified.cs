//HintName: G.Models.ServerEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerEventDiscriminatorMessageType? MessageType { get; }

        /// <summary>
        /// Event sent when a session is started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SessionStartedPayload? SessionStarted { get; init; }
#else
        public global::G.SessionStartedPayload? SessionStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStarted))]
#endif
        public bool IsSessionStarted => SessionStarted != null;

        /// <summary>
        /// Event sent when a partial transcript is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PartialTranscriptPayload? PartialTranscript { get; init; }
#else
        public global::G.PartialTranscriptPayload? PartialTranscript { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PartialTranscript))]
#endif
        public bool IsPartialTranscript => PartialTranscript != null;

        /// <summary>
        /// Event sent when a transcript is committed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CommittedTranscriptPayload? CommittedTranscript { get; init; }
#else
        public global::G.CommittedTranscriptPayload? CommittedTranscript { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommittedTranscript))]
#endif
        public bool IsCommittedTranscript => CommittedTranscript != null;

        /// <summary>
        /// Error event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ErrorPayload? Error { get; init; }
#else
        public global::G.ErrorPayload? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.SessionStartedPayload value) => new ServerEvent((global::G.SessionStartedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SessionStartedPayload?(ServerEvent @this) => @this.SessionStarted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.SessionStartedPayload? value)
        {
            SessionStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.PartialTranscriptPayload value) => new ServerEvent((global::G.PartialTranscriptPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PartialTranscriptPayload?(ServerEvent @this) => @this.PartialTranscript;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.PartialTranscriptPayload? value)
        {
            PartialTranscript = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.CommittedTranscriptPayload value) => new ServerEvent((global::G.CommittedTranscriptPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CommittedTranscriptPayload?(ServerEvent @this) => @this.CommittedTranscript;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.CommittedTranscriptPayload? value)
        {
            CommittedTranscript = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.ErrorPayload value) => new ServerEvent((global::G.ErrorPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ErrorPayload?(ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.ErrorPayload? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::G.ServerEventDiscriminatorMessageType? messageType,
            global::G.SessionStartedPayload? sessionStarted,
            global::G.PartialTranscriptPayload? partialTranscript,
            global::G.CommittedTranscriptPayload? committedTranscript,
            global::G.ErrorPayload? error
            )
        {
            MessageType = messageType;

            SessionStarted = sessionStarted;
            PartialTranscript = partialTranscript;
            CommittedTranscript = committedTranscript;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            CommittedTranscript as object ??
            PartialTranscript as object ??
            SessionStarted as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SessionStarted?.ToString() ??
            PartialTranscript?.ToString() ??
            CommittedTranscript?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionStarted && !IsPartialTranscript && !IsCommittedTranscript && !IsError || !IsSessionStarted && IsPartialTranscript && !IsCommittedTranscript && !IsError || !IsSessionStarted && !IsPartialTranscript && IsCommittedTranscript && !IsError || !IsSessionStarted && !IsPartialTranscript && !IsCommittedTranscript && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SessionStartedPayload?, TResult>? sessionStarted = null,
            global::System.Func<global::G.PartialTranscriptPayload?, TResult>? partialTranscript = null,
            global::System.Func<global::G.CommittedTranscriptPayload?, TResult>? committedTranscript = null,
            global::System.Func<global::G.ErrorPayload?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionStarted && sessionStarted != null)
            {
                return sessionStarted(SessionStarted!);
            }
            else if (IsPartialTranscript && partialTranscript != null)
            {
                return partialTranscript(PartialTranscript!);
            }
            else if (IsCommittedTranscript && committedTranscript != null)
            {
                return committedTranscript(CommittedTranscript!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SessionStartedPayload?>? sessionStarted = null,
            global::System.Action<global::G.PartialTranscriptPayload?>? partialTranscript = null,
            global::System.Action<global::G.CommittedTranscriptPayload?>? committedTranscript = null,
            global::System.Action<global::G.ErrorPayload?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionStarted)
            {
                sessionStarted?.Invoke(SessionStarted!);
            }
            else if (IsPartialTranscript)
            {
                partialTranscript?.Invoke(PartialTranscript!);
            }
            else if (IsCommittedTranscript)
            {
                committedTranscript?.Invoke(CommittedTranscript!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionStarted,
                typeof(global::G.SessionStartedPayload),
                PartialTranscript,
                typeof(global::G.PartialTranscriptPayload),
                CommittedTranscript,
                typeof(global::G.CommittedTranscriptPayload),
                Error,
                typeof(global::G.ErrorPayload),
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
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SessionStartedPayload?>.Default.Equals(SessionStarted, other.SessionStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PartialTranscriptPayload?>.Default.Equals(PartialTranscript, other.PartialTranscript) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CommittedTranscriptPayload?>.Default.Equals(CommittedTranscript, other.CommittedTranscript) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ErrorPayload?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
