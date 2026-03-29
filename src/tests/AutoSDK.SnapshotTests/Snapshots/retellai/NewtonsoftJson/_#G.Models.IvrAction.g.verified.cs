//HintName: G.Models.IvrAction.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IvrAction : global::System.IEquatable<IvrAction>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.IvrActionHangup? Hangup { get; init; }
#else
        public global::G.IvrActionHangup? Hangup { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hangup))]
#endif
        public bool IsHangup => Hangup != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IvrAction(global::G.IvrActionHangup value) => new IvrAction((global::G.IvrActionHangup?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.IvrActionHangup?(IvrAction @this) => @this.Hangup;

        /// <summary>
        /// 
        /// </summary>
        public IvrAction(global::G.IvrActionHangup? value)
        {
            Hangup = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Hangup as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Hangup?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsHangup;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.IvrActionHangup?, TResult>? hangup = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHangup && hangup != null)
            {
                return hangup(Hangup!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.IvrActionHangup?>? hangup = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHangup)
            {
                hangup?.Invoke(Hangup!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Hangup,
                typeof(global::G.IvrActionHangup),
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
        public bool Equals(IvrAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.IvrActionHangup?>.Default.Equals(Hangup, other.Hangup) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IvrAction obj1, IvrAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IvrAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IvrAction obj1, IvrAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IvrAction o && Equals(o);
        }
    }
}
