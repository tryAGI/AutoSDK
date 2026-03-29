//HintName: G.Models.InputMessageItemRole.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputMessageItemRole : global::System.IEquatable<InputMessageItemRole>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputMessageItemRole0? InputMessageItemRole0 { get; init; }
#else
        public global::G.InputMessageItemRole0? InputMessageItemRole0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageItemRole0))]
#endif
        public bool IsInputMessageItemRole0 => InputMessageItemRole0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputMessageItemRole1? InputMessageItemRole1 { get; init; }
#else
        public global::G.InputMessageItemRole1? InputMessageItemRole1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageItemRole1))]
#endif
        public bool IsInputMessageItemRole1 => InputMessageItemRole1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputMessageItemRole2? InputMessageItemRole2 { get; init; }
#else
        public global::G.InputMessageItemRole2? InputMessageItemRole2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageItemRole2))]
#endif
        public bool IsInputMessageItemRole2 => InputMessageItemRole2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemRole(global::G.InputMessageItemRole0 value) => new InputMessageItemRole((global::G.InputMessageItemRole0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessageItemRole0?(InputMessageItemRole @this) => @this.InputMessageItemRole0;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemRole(global::G.InputMessageItemRole0? value)
        {
            InputMessageItemRole0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemRole(global::G.InputMessageItemRole1 value) => new InputMessageItemRole((global::G.InputMessageItemRole1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessageItemRole1?(InputMessageItemRole @this) => @this.InputMessageItemRole1;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemRole(global::G.InputMessageItemRole1? value)
        {
            InputMessageItemRole1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemRole(global::G.InputMessageItemRole2 value) => new InputMessageItemRole((global::G.InputMessageItemRole2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessageItemRole2?(InputMessageItemRole @this) => @this.InputMessageItemRole2;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemRole(global::G.InputMessageItemRole2? value)
        {
            InputMessageItemRole2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemRole(
            global::G.InputMessageItemRole0? inputMessageItemRole0,
            global::G.InputMessageItemRole1? inputMessageItemRole1,
            global::G.InputMessageItemRole2? inputMessageItemRole2
            )
        {
            InputMessageItemRole0 = inputMessageItemRole0;
            InputMessageItemRole1 = inputMessageItemRole1;
            InputMessageItemRole2 = inputMessageItemRole2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputMessageItemRole2 as object ??
            InputMessageItemRole1 as object ??
            InputMessageItemRole0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessageItemRole0?.ToValueString() ??
            InputMessageItemRole1?.ToValueString() ??
            InputMessageItemRole2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessageItemRole0 && !IsInputMessageItemRole1 && !IsInputMessageItemRole2 || !IsInputMessageItemRole0 && IsInputMessageItemRole1 && !IsInputMessageItemRole2 || !IsInputMessageItemRole0 && !IsInputMessageItemRole1 && IsInputMessageItemRole2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputMessageItemRole0?, TResult>? inputMessageItemRole0 = null,
            global::System.Func<global::G.InputMessageItemRole1?, TResult>? inputMessageItemRole1 = null,
            global::System.Func<global::G.InputMessageItemRole2?, TResult>? inputMessageItemRole2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessageItemRole0 && inputMessageItemRole0 != null)
            {
                return inputMessageItemRole0(InputMessageItemRole0!);
            }
            else if (IsInputMessageItemRole1 && inputMessageItemRole1 != null)
            {
                return inputMessageItemRole1(InputMessageItemRole1!);
            }
            else if (IsInputMessageItemRole2 && inputMessageItemRole2 != null)
            {
                return inputMessageItemRole2(InputMessageItemRole2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputMessageItemRole0?>? inputMessageItemRole0 = null,
            global::System.Action<global::G.InputMessageItemRole1?>? inputMessageItemRole1 = null,
            global::System.Action<global::G.InputMessageItemRole2?>? inputMessageItemRole2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessageItemRole0)
            {
                inputMessageItemRole0?.Invoke(InputMessageItemRole0!);
            }
            else if (IsInputMessageItemRole1)
            {
                inputMessageItemRole1?.Invoke(InputMessageItemRole1!);
            }
            else if (IsInputMessageItemRole2)
            {
                inputMessageItemRole2?.Invoke(InputMessageItemRole2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessageItemRole0,
                typeof(global::G.InputMessageItemRole0),
                InputMessageItemRole1,
                typeof(global::G.InputMessageItemRole1),
                InputMessageItemRole2,
                typeof(global::G.InputMessageItemRole2),
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
        public bool Equals(InputMessageItemRole other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessageItemRole0?>.Default.Equals(InputMessageItemRole0, other.InputMessageItemRole0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessageItemRole1?>.Default.Equals(InputMessageItemRole1, other.InputMessageItemRole1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessageItemRole2?>.Default.Equals(InputMessageItemRole2, other.InputMessageItemRole2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputMessageItemRole obj1, InputMessageItemRole obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputMessageItemRole>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputMessageItemRole obj1, InputMessageItemRole obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputMessageItemRole o && Equals(o);
        }
    }
}
