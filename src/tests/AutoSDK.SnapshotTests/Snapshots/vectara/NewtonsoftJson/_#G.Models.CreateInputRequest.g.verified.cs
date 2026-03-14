//HintName: G.Models.CreateInputRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A request to create input for an agent session.
    /// </summary>
    public readonly partial struct CreateInputRequest : global::System.IEquatable<CreateInputRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateInputRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// A user input message with text or other content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateInputMessageRequest? InputMessage { get; init; }
#else
        public global::G.CreateInputMessageRequest? InputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        /// Cancels the current agent operation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateInterruptRequest? Interrupt { get; init; }
#else
        public global::G.CreateInterruptRequest? Interrupt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Interrupt))]
#endif
        public bool IsInterrupt => Interrupt != null;

        /// <summary>
        /// Requests compaction of the session history. Can be sent while the session is processing<br/>
        /// (queued as a follow-up) or when idle.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateCompactRequest? Compact { get; init; }
#else
        public global::G.CreateCompactRequest? Compact { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compact))]
#endif
        public bool IsCompact => Compact != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInputRequest(global::G.CreateInputMessageRequest value) => new CreateInputRequest((global::G.CreateInputMessageRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateInputMessageRequest?(CreateInputRequest @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public CreateInputRequest(global::G.CreateInputMessageRequest? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInputRequest(global::G.CreateInterruptRequest value) => new CreateInputRequest((global::G.CreateInterruptRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateInterruptRequest?(CreateInputRequest @this) => @this.Interrupt;

        /// <summary>
        /// 
        /// </summary>
        public CreateInputRequest(global::G.CreateInterruptRequest? value)
        {
            Interrupt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInputRequest(global::G.CreateCompactRequest value) => new CreateInputRequest((global::G.CreateCompactRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateCompactRequest?(CreateInputRequest @this) => @this.Compact;

        /// <summary>
        /// 
        /// </summary>
        public CreateInputRequest(global::G.CreateCompactRequest? value)
        {
            Compact = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateInputRequest(
            global::G.CreateInputRequestDiscriminatorType? type,
            global::G.CreateInputMessageRequest? inputMessage,
            global::G.CreateInterruptRequest? interrupt,
            global::G.CreateCompactRequest? compact
            )
        {
            Type = type;

            InputMessage = inputMessage;
            Interrupt = interrupt;
            Compact = compact;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Compact as object ??
            Interrupt as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            Interrupt?.ToString() ??
            Compact?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsInterrupt && !IsCompact || !IsInputMessage && IsInterrupt && !IsCompact || !IsInputMessage && !IsInterrupt && IsCompact;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateInputMessageRequest?, TResult>? inputMessage = null,
            global::System.Func<global::G.CreateInterruptRequest?, TResult>? interrupt = null,
            global::System.Func<global::G.CreateCompactRequest?, TResult>? compact = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage && inputMessage != null)
            {
                return inputMessage(InputMessage!);
            }
            else if (IsInterrupt && interrupt != null)
            {
                return interrupt(Interrupt!);
            }
            else if (IsCompact && compact != null)
            {
                return compact(Compact!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateInputMessageRequest?>? inputMessage = null,
            global::System.Action<global::G.CreateInterruptRequest?>? interrupt = null,
            global::System.Action<global::G.CreateCompactRequest?>? compact = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsInterrupt)
            {
                interrupt?.Invoke(Interrupt!);
            }
            else if (IsCompact)
            {
                compact?.Invoke(Compact!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessage,
                typeof(global::G.CreateInputMessageRequest),
                Interrupt,
                typeof(global::G.CreateInterruptRequest),
                Compact,
                typeof(global::G.CreateCompactRequest),
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
        public bool Equals(CreateInputRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateInputMessageRequest?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateInterruptRequest?>.Default.Equals(Interrupt, other.Interrupt) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateCompactRequest?>.Default.Equals(Compact, other.Compact) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateInputRequest obj1, CreateInputRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateInputRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateInputRequest obj1, CreateInputRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateInputRequest o && Equals(o);
        }
    }
}
