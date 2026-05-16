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
        public global::G.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Detected language event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranscriptionStreamLanguage? TranscriptionLanguage { get; init; }
#else
        public global::G.TranscriptionStreamLanguage? TranscriptionLanguage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionLanguage))]
#endif
        public bool IsTranscriptionLanguage => TranscriptionLanguage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscriptionLanguage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TranscriptionStreamLanguage? value)
        {
            value = TranscriptionLanguage;
            return IsTranscriptionLanguage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TranscriptionStreamLanguage PickTranscriptionLanguage() => IsTranscriptionLanguage
            ? TranscriptionLanguage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TranscriptionLanguage' but the value was {ToString()}.");

        /// <summary>
        /// A delta of transcribed text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranscriptionStreamTextDelta? TranscriptionTextDelta { get; init; }
#else
        public global::G.TranscriptionStreamTextDelta? TranscriptionTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionTextDelta))]
#endif
        public bool IsTranscriptionTextDelta => TranscriptionTextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscriptionTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TranscriptionStreamTextDelta? value)
        {
            value = TranscriptionTextDelta;
            return IsTranscriptionTextDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TranscriptionStreamTextDelta PickTranscriptionTextDelta() => IsTranscriptionTextDelta
            ? TranscriptionTextDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TranscriptionTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// session.created server event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeTranscriptionSessionCreated? SessionCreated { get; init; }
#else
        public global::G.RealtimeTranscriptionSessionCreated? SessionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RealtimeTranscriptionSessionCreated? value)
        {
            value = SessionCreated;
            return IsSessionCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RealtimeTranscriptionSessionCreated PickSessionCreated() => IsSessionCreated
            ? SessionCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionCreated' but the value was {ToString()}.");

        /// <summary>
        /// error server event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RealtimeTranscriptionError? Error { get; init; }
#else
        public global::G.RealtimeTranscriptionError? Error { get; }
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
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RealtimeTranscriptionError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RealtimeTranscriptionError PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.TranscriptionStreamLanguage value) => new ServerEvent((global::G.TranscriptionStreamLanguage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranscriptionStreamLanguage?(ServerEvent @this) => @this.TranscriptionLanguage;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.TranscriptionStreamLanguage? value)
        {
            TranscriptionLanguage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTranscriptionLanguage(global::G.TranscriptionStreamLanguage? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.TranscriptionStreamTextDelta value) => new ServerEvent((global::G.TranscriptionStreamTextDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranscriptionStreamTextDelta?(ServerEvent @this) => @this.TranscriptionTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.TranscriptionStreamTextDelta? value)
        {
            TranscriptionTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTranscriptionTextDelta(global::G.TranscriptionStreamTextDelta? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.RealtimeTranscriptionSessionCreated value) => new ServerEvent((global::G.RealtimeTranscriptionSessionCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeTranscriptionSessionCreated?(ServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.RealtimeTranscriptionSessionCreated? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromSessionCreated(global::G.RealtimeTranscriptionSessionCreated? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::G.RealtimeTranscriptionError value) => new ServerEvent((global::G.RealtimeTranscriptionError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RealtimeTranscriptionError?(ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::G.RealtimeTranscriptionError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromError(global::G.RealtimeTranscriptionError? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::G.ServerEventDiscriminatorType? type,
            global::G.TranscriptionStreamLanguage? transcriptionLanguage,
            global::G.TranscriptionStreamTextDelta? transcriptionTextDelta,
            global::G.RealtimeTranscriptionSessionCreated? sessionCreated,
            global::G.RealtimeTranscriptionError? error
            )
        {
            Type = type;

            TranscriptionLanguage = transcriptionLanguage;
            TranscriptionTextDelta = transcriptionTextDelta;
            SessionCreated = sessionCreated;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            SessionCreated as object ??
            TranscriptionTextDelta as object ??
            TranscriptionLanguage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranscriptionLanguage?.ToString() ??
            TranscriptionTextDelta?.ToString() ??
            SessionCreated?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranscriptionLanguage && !IsTranscriptionTextDelta && !IsSessionCreated && !IsError || !IsTranscriptionLanguage && IsTranscriptionTextDelta && !IsSessionCreated && !IsError || !IsTranscriptionLanguage && !IsTranscriptionTextDelta && IsSessionCreated && !IsError || !IsTranscriptionLanguage && !IsTranscriptionTextDelta && !IsSessionCreated && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TranscriptionStreamLanguage, TResult>? transcriptionLanguage = null,
            global::System.Func<global::G.TranscriptionStreamTextDelta, TResult>? transcriptionTextDelta = null,
            global::System.Func<global::G.RealtimeTranscriptionSessionCreated, TResult>? sessionCreated = null,
            global::System.Func<global::G.RealtimeTranscriptionError, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionLanguage && transcriptionLanguage != null)
            {
                return transcriptionLanguage(TranscriptionLanguage!);
            }
            else if (IsTranscriptionTextDelta && transcriptionTextDelta != null)
            {
                return transcriptionTextDelta(TranscriptionTextDelta!);
            }
            else if (IsSessionCreated && sessionCreated != null)
            {
                return sessionCreated(SessionCreated!);
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
            global::System.Action<global::G.TranscriptionStreamLanguage>? transcriptionLanguage = null,

            global::System.Action<global::G.TranscriptionStreamTextDelta>? transcriptionTextDelta = null,

            global::System.Action<global::G.RealtimeTranscriptionSessionCreated>? sessionCreated = null,

            global::System.Action<global::G.RealtimeTranscriptionError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionLanguage)
            {
                transcriptionLanguage?.Invoke(TranscriptionLanguage!);
            }
            else if (IsTranscriptionTextDelta)
            {
                transcriptionTextDelta?.Invoke(TranscriptionTextDelta!);
            }
            else if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.TranscriptionStreamLanguage>? transcriptionLanguage = null,
            global::System.Action<global::G.TranscriptionStreamTextDelta>? transcriptionTextDelta = null,
            global::System.Action<global::G.RealtimeTranscriptionSessionCreated>? sessionCreated = null,
            global::System.Action<global::G.RealtimeTranscriptionError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionLanguage)
            {
                transcriptionLanguage?.Invoke(TranscriptionLanguage!);
            }
            else if (IsTranscriptionTextDelta)
            {
                transcriptionTextDelta?.Invoke(TranscriptionTextDelta!);
            }
            else if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
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
                TranscriptionLanguage,
                typeof(global::G.TranscriptionStreamLanguage),
                TranscriptionTextDelta,
                typeof(global::G.TranscriptionStreamTextDelta),
                SessionCreated,
                typeof(global::G.RealtimeTranscriptionSessionCreated),
                Error,
                typeof(global::G.RealtimeTranscriptionError),
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
                global::System.Collections.Generic.EqualityComparer<global::G.TranscriptionStreamLanguage?>.Default.Equals(TranscriptionLanguage, other.TranscriptionLanguage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TranscriptionStreamTextDelta?>.Default.Equals(TranscriptionTextDelta, other.TranscriptionTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeTranscriptionSessionCreated?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RealtimeTranscriptionError?>.Default.Equals(Error, other.Error) 
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
