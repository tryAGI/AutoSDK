//HintName: G.Models.MessageStreamEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageStreamEvent : global::System.IEquatable<MessageStreamEvent>
    {
        /// <summary>
        /// Occurs when a [message](https://platform.openai.com/docs/api-reference/messages/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant1? MessageStreamEventVariant1 { get; init; }
#else
        public global::G.MessageStreamEventVariant1? MessageStreamEventVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStreamEventVariant1))]
#endif
        public bool IsMessageStreamEventVariant1 => MessageStreamEventVariant1 != null;

        /// <summary>
        /// Occurs when a [message](https://platform.openai.com/docs/api-reference/messages/object) moves to an `in_progress` state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant2? MessageStreamEventVariant2 { get; init; }
#else
        public global::G.MessageStreamEventVariant2? MessageStreamEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStreamEventVariant2))]
#endif
        public bool IsMessageStreamEventVariant2 => MessageStreamEventVariant2 != null;

        /// <summary>
        /// Occurs when parts of a [Message](https://platform.openai.com/docs/api-reference/messages/object) are being streamed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant3? MessageStreamEventVariant3 { get; init; }
#else
        public global::G.MessageStreamEventVariant3? MessageStreamEventVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStreamEventVariant3))]
#endif
        public bool IsMessageStreamEventVariant3 => MessageStreamEventVariant3 != null;

        /// <summary>
        /// Occurs when a [message](https://platform.openai.com/docs/api-reference/messages/object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant4? MessageStreamEventVariant4 { get; init; }
#else
        public global::G.MessageStreamEventVariant4? MessageStreamEventVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStreamEventVariant4))]
#endif
        public bool IsMessageStreamEventVariant4 => MessageStreamEventVariant4 != null;

        /// <summary>
        /// Occurs when a [message](https://platform.openai.com/docs/api-reference/messages/object) ends before it is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant5? MessageStreamEventVariant5 { get; init; }
#else
        public global::G.MessageStreamEventVariant5? MessageStreamEventVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStreamEventVariant5))]
#endif
        public bool IsMessageStreamEventVariant5 => MessageStreamEventVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant1 value) => new MessageStreamEvent((global::G.MessageStreamEventVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant1?(MessageStreamEvent @this) => @this.MessageStreamEventVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant1? value)
        {
            MessageStreamEventVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant2 value) => new MessageStreamEvent((global::G.MessageStreamEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant2?(MessageStreamEvent @this) => @this.MessageStreamEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant2? value)
        {
            MessageStreamEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant3 value) => new MessageStreamEvent((global::G.MessageStreamEventVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant3?(MessageStreamEvent @this) => @this.MessageStreamEventVariant3;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant3? value)
        {
            MessageStreamEventVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant4 value) => new MessageStreamEvent((global::G.MessageStreamEventVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant4?(MessageStreamEvent @this) => @this.MessageStreamEventVariant4;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant4? value)
        {
            MessageStreamEventVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant5 value) => new MessageStreamEvent((global::G.MessageStreamEventVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant5?(MessageStreamEvent @this) => @this.MessageStreamEventVariant5;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant5? value)
        {
            MessageStreamEventVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(
            global::G.MessageStreamEventVariant1? messageStreamEventVariant1,
            global::G.MessageStreamEventVariant2? messageStreamEventVariant2,
            global::G.MessageStreamEventVariant3? messageStreamEventVariant3,
            global::G.MessageStreamEventVariant4? messageStreamEventVariant4,
            global::G.MessageStreamEventVariant5? messageStreamEventVariant5
            )
        {
            MessageStreamEventVariant1 = messageStreamEventVariant1;
            MessageStreamEventVariant2 = messageStreamEventVariant2;
            MessageStreamEventVariant3 = messageStreamEventVariant3;
            MessageStreamEventVariant4 = messageStreamEventVariant4;
            MessageStreamEventVariant5 = messageStreamEventVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageStreamEventVariant5 as object ??
            MessageStreamEventVariant4 as object ??
            MessageStreamEventVariant3 as object ??
            MessageStreamEventVariant2 as object ??
            MessageStreamEventVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessageStreamEventVariant1?.ToString() ??
            MessageStreamEventVariant2?.ToString() ??
            MessageStreamEventVariant3?.ToString() ??
            MessageStreamEventVariant4?.ToString() ??
            MessageStreamEventVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageStreamEventVariant1 && !IsMessageStreamEventVariant2 && !IsMessageStreamEventVariant3 && !IsMessageStreamEventVariant4 && !IsMessageStreamEventVariant5 || !IsMessageStreamEventVariant1 && IsMessageStreamEventVariant2 && !IsMessageStreamEventVariant3 && !IsMessageStreamEventVariant4 && !IsMessageStreamEventVariant5 || !IsMessageStreamEventVariant1 && !IsMessageStreamEventVariant2 && IsMessageStreamEventVariant3 && !IsMessageStreamEventVariant4 && !IsMessageStreamEventVariant5 || !IsMessageStreamEventVariant1 && !IsMessageStreamEventVariant2 && !IsMessageStreamEventVariant3 && IsMessageStreamEventVariant4 && !IsMessageStreamEventVariant5 || !IsMessageStreamEventVariant1 && !IsMessageStreamEventVariant2 && !IsMessageStreamEventVariant3 && !IsMessageStreamEventVariant4 && IsMessageStreamEventVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessageStreamEventVariant1?, TResult>? messageStreamEventVariant1 = null,
            global::System.Func<global::G.MessageStreamEventVariant2?, TResult>? messageStreamEventVariant2 = null,
            global::System.Func<global::G.MessageStreamEventVariant3?, TResult>? messageStreamEventVariant3 = null,
            global::System.Func<global::G.MessageStreamEventVariant4?, TResult>? messageStreamEventVariant4 = null,
            global::System.Func<global::G.MessageStreamEventVariant5?, TResult>? messageStreamEventVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStreamEventVariant1 && messageStreamEventVariant1 != null)
            {
                return messageStreamEventVariant1(MessageStreamEventVariant1!);
            }
            else if (IsMessageStreamEventVariant2 && messageStreamEventVariant2 != null)
            {
                return messageStreamEventVariant2(MessageStreamEventVariant2!);
            }
            else if (IsMessageStreamEventVariant3 && messageStreamEventVariant3 != null)
            {
                return messageStreamEventVariant3(MessageStreamEventVariant3!);
            }
            else if (IsMessageStreamEventVariant4 && messageStreamEventVariant4 != null)
            {
                return messageStreamEventVariant4(MessageStreamEventVariant4!);
            }
            else if (IsMessageStreamEventVariant5 && messageStreamEventVariant5 != null)
            {
                return messageStreamEventVariant5(MessageStreamEventVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessageStreamEventVariant1?>? messageStreamEventVariant1 = null,
            global::System.Action<global::G.MessageStreamEventVariant2?>? messageStreamEventVariant2 = null,
            global::System.Action<global::G.MessageStreamEventVariant3?>? messageStreamEventVariant3 = null,
            global::System.Action<global::G.MessageStreamEventVariant4?>? messageStreamEventVariant4 = null,
            global::System.Action<global::G.MessageStreamEventVariant5?>? messageStreamEventVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStreamEventVariant1)
            {
                messageStreamEventVariant1?.Invoke(MessageStreamEventVariant1!);
            }
            else if (IsMessageStreamEventVariant2)
            {
                messageStreamEventVariant2?.Invoke(MessageStreamEventVariant2!);
            }
            else if (IsMessageStreamEventVariant3)
            {
                messageStreamEventVariant3?.Invoke(MessageStreamEventVariant3!);
            }
            else if (IsMessageStreamEventVariant4)
            {
                messageStreamEventVariant4?.Invoke(MessageStreamEventVariant4!);
            }
            else if (IsMessageStreamEventVariant5)
            {
                messageStreamEventVariant5?.Invoke(MessageStreamEventVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageStreamEventVariant1,
                typeof(global::G.MessageStreamEventVariant1),
                MessageStreamEventVariant2,
                typeof(global::G.MessageStreamEventVariant2),
                MessageStreamEventVariant3,
                typeof(global::G.MessageStreamEventVariant3),
                MessageStreamEventVariant4,
                typeof(global::G.MessageStreamEventVariant4),
                MessageStreamEventVariant5,
                typeof(global::G.MessageStreamEventVariant5),
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
        public bool Equals(MessageStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant1?>.Default.Equals(MessageStreamEventVariant1, other.MessageStreamEventVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant2?>.Default.Equals(MessageStreamEventVariant2, other.MessageStreamEventVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant3?>.Default.Equals(MessageStreamEventVariant3, other.MessageStreamEventVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant4?>.Default.Equals(MessageStreamEventVariant4, other.MessageStreamEventVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant5?>.Default.Equals(MessageStreamEventVariant5, other.MessageStreamEventVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageStreamEvent obj1, MessageStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageStreamEvent obj1, MessageStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageStreamEvent o && Equals(o);
        }
    }
}
