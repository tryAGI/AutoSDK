//HintName: G.Models.EasyInputMessageRole.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EasyInputMessageRole : global::System.IEquatable<EasyInputMessageRole>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EasyInputMessageRole0? EasyInputMessageRole0 { get; init; }
#else
        public global::G.EasyInputMessageRole0? EasyInputMessageRole0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessageRole0))]
#endif
        public bool IsEasyInputMessageRole0 => EasyInputMessageRole0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EasyInputMessageRole1? EasyInputMessageRole1 { get; init; }
#else
        public global::G.EasyInputMessageRole1? EasyInputMessageRole1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessageRole1))]
#endif
        public bool IsEasyInputMessageRole1 => EasyInputMessageRole1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EasyInputMessageRole2? EasyInputMessageRole2 { get; init; }
#else
        public global::G.EasyInputMessageRole2? EasyInputMessageRole2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessageRole2))]
#endif
        public bool IsEasyInputMessageRole2 => EasyInputMessageRole2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EasyInputMessageRole3? EasyInputMessageRole3 { get; init; }
#else
        public global::G.EasyInputMessageRole3? EasyInputMessageRole3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessageRole3))]
#endif
        public bool IsEasyInputMessageRole3 => EasyInputMessageRole3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessageRole(global::G.EasyInputMessageRole0 value) => new EasyInputMessageRole((global::G.EasyInputMessageRole0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EasyInputMessageRole0?(EasyInputMessageRole @this) => @this.EasyInputMessageRole0;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageRole(global::G.EasyInputMessageRole0? value)
        {
            EasyInputMessageRole0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessageRole(global::G.EasyInputMessageRole1 value) => new EasyInputMessageRole((global::G.EasyInputMessageRole1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EasyInputMessageRole1?(EasyInputMessageRole @this) => @this.EasyInputMessageRole1;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageRole(global::G.EasyInputMessageRole1? value)
        {
            EasyInputMessageRole1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessageRole(global::G.EasyInputMessageRole2 value) => new EasyInputMessageRole((global::G.EasyInputMessageRole2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EasyInputMessageRole2?(EasyInputMessageRole @this) => @this.EasyInputMessageRole2;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageRole(global::G.EasyInputMessageRole2? value)
        {
            EasyInputMessageRole2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessageRole(global::G.EasyInputMessageRole3 value) => new EasyInputMessageRole((global::G.EasyInputMessageRole3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EasyInputMessageRole3?(EasyInputMessageRole @this) => @this.EasyInputMessageRole3;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageRole(global::G.EasyInputMessageRole3? value)
        {
            EasyInputMessageRole3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageRole(
            global::G.EasyInputMessageRole0? easyInputMessageRole0,
            global::G.EasyInputMessageRole1? easyInputMessageRole1,
            global::G.EasyInputMessageRole2? easyInputMessageRole2,
            global::G.EasyInputMessageRole3? easyInputMessageRole3
            )
        {
            EasyInputMessageRole0 = easyInputMessageRole0;
            EasyInputMessageRole1 = easyInputMessageRole1;
            EasyInputMessageRole2 = easyInputMessageRole2;
            EasyInputMessageRole3 = easyInputMessageRole3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EasyInputMessageRole3 as object ??
            EasyInputMessageRole2 as object ??
            EasyInputMessageRole1 as object ??
            EasyInputMessageRole0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EasyInputMessageRole0?.ToValueString() ??
            EasyInputMessageRole1?.ToValueString() ??
            EasyInputMessageRole2?.ToValueString() ??
            EasyInputMessageRole3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEasyInputMessageRole0 && !IsEasyInputMessageRole1 && !IsEasyInputMessageRole2 && !IsEasyInputMessageRole3 || !IsEasyInputMessageRole0 && IsEasyInputMessageRole1 && !IsEasyInputMessageRole2 && !IsEasyInputMessageRole3 || !IsEasyInputMessageRole0 && !IsEasyInputMessageRole1 && IsEasyInputMessageRole2 && !IsEasyInputMessageRole3 || !IsEasyInputMessageRole0 && !IsEasyInputMessageRole1 && !IsEasyInputMessageRole2 && IsEasyInputMessageRole3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.EasyInputMessageRole0?, TResult>? easyInputMessageRole0 = null,
            global::System.Func<global::G.EasyInputMessageRole1?, TResult>? easyInputMessageRole1 = null,
            global::System.Func<global::G.EasyInputMessageRole2?, TResult>? easyInputMessageRole2 = null,
            global::System.Func<global::G.EasyInputMessageRole3?, TResult>? easyInputMessageRole3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEasyInputMessageRole0 && easyInputMessageRole0 != null)
            {
                return easyInputMessageRole0(EasyInputMessageRole0!);
            }
            else if (IsEasyInputMessageRole1 && easyInputMessageRole1 != null)
            {
                return easyInputMessageRole1(EasyInputMessageRole1!);
            }
            else if (IsEasyInputMessageRole2 && easyInputMessageRole2 != null)
            {
                return easyInputMessageRole2(EasyInputMessageRole2!);
            }
            else if (IsEasyInputMessageRole3 && easyInputMessageRole3 != null)
            {
                return easyInputMessageRole3(EasyInputMessageRole3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.EasyInputMessageRole0?>? easyInputMessageRole0 = null,
            global::System.Action<global::G.EasyInputMessageRole1?>? easyInputMessageRole1 = null,
            global::System.Action<global::G.EasyInputMessageRole2?>? easyInputMessageRole2 = null,
            global::System.Action<global::G.EasyInputMessageRole3?>? easyInputMessageRole3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEasyInputMessageRole0)
            {
                easyInputMessageRole0?.Invoke(EasyInputMessageRole0!);
            }
            else if (IsEasyInputMessageRole1)
            {
                easyInputMessageRole1?.Invoke(EasyInputMessageRole1!);
            }
            else if (IsEasyInputMessageRole2)
            {
                easyInputMessageRole2?.Invoke(EasyInputMessageRole2!);
            }
            else if (IsEasyInputMessageRole3)
            {
                easyInputMessageRole3?.Invoke(EasyInputMessageRole3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EasyInputMessageRole0,
                typeof(global::G.EasyInputMessageRole0),
                EasyInputMessageRole1,
                typeof(global::G.EasyInputMessageRole1),
                EasyInputMessageRole2,
                typeof(global::G.EasyInputMessageRole2),
                EasyInputMessageRole3,
                typeof(global::G.EasyInputMessageRole3),
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
        public bool Equals(EasyInputMessageRole other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.EasyInputMessageRole0?>.Default.Equals(EasyInputMessageRole0, other.EasyInputMessageRole0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EasyInputMessageRole1?>.Default.Equals(EasyInputMessageRole1, other.EasyInputMessageRole1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EasyInputMessageRole2?>.Default.Equals(EasyInputMessageRole2, other.EasyInputMessageRole2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EasyInputMessageRole3?>.Default.Equals(EasyInputMessageRole3, other.EasyInputMessageRole3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EasyInputMessageRole obj1, EasyInputMessageRole obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EasyInputMessageRole>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EasyInputMessageRole obj1, EasyInputMessageRole obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EasyInputMessageRole o && Equals(o);
        }
    }
}
