//HintName: G.Models.InputMessageResource.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputMessageResource : global::System.IEquatable<InputMessageResource>
    {
        /// <summary>
        /// A message input to the model with a role indicating instruction following<br/>
        /// hierarchy. Instructions given with the `developer` or `system` role take<br/>
        /// precedence over instructions given with the `user` role.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputMessage? InputMessage { get; init; }
#else
        public global::G.InputMessage? InputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputMessageResourceVariant2? InputMessageResourceVariant2 { get; init; }
#else
        public global::G.InputMessageResourceVariant2? InputMessageResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageResourceVariant2))]
#endif
        public bool IsInputMessageResourceVariant2 => InputMessageResourceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageResource(global::G.InputMessage value) => new InputMessageResource((global::G.InputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessage?(InputMessageResource @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageResource(global::G.InputMessage? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageResource(global::G.InputMessageResourceVariant2 value) => new InputMessageResource((global::G.InputMessageResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessageResourceVariant2?(InputMessageResource @this) => @this.InputMessageResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageResource(global::G.InputMessageResourceVariant2? value)
        {
            InputMessageResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputMessageResource(
            global::G.InputMessage? inputMessage,
            global::G.InputMessageResourceVariant2? inputMessageResourceVariant2
            )
        {
            InputMessage = inputMessage;
            InputMessageResourceVariant2 = inputMessageResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputMessageResourceVariant2 as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            InputMessageResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && IsInputMessageResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputMessage?, TResult>? inputMessage = null,
            global::System.Func<global::G.InputMessageResourceVariant2?, TResult>? inputMessageResourceVariant2 = null,
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
            else if (IsInputMessageResourceVariant2 && inputMessageResourceVariant2 != null)
            {
                return inputMessageResourceVariant2(InputMessageResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputMessage?>? inputMessage = null,
            global::System.Action<global::G.InputMessageResourceVariant2?>? inputMessageResourceVariant2 = null,
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
            else if (IsInputMessageResourceVariant2)
            {
                inputMessageResourceVariant2?.Invoke(InputMessageResourceVariant2!);
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
                typeof(global::G.InputMessage),
                InputMessageResourceVariant2,
                typeof(global::G.InputMessageResourceVariant2),
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
        public bool Equals(InputMessageResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessage?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessageResourceVariant2?>.Default.Equals(InputMessageResourceVariant2, other.InputMessageResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputMessageResource obj1, InputMessageResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputMessageResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputMessageResource obj1, InputMessageResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputMessageResource o && Equals(o);
        }
    }
}
