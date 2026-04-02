//HintName: G.Models.PressDigitNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PressDigitNode : global::System.IEquatable<PressDigitNode>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NodeBase? Base { get; init; }
#else
        public global::G.NodeBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PressDigitNodeVariant2? PressDigitNodeVariant2 { get; init; }
#else
        public global::G.PressDigitNodeVariant2? PressDigitNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PressDigitNodeVariant2))]
#endif
        public bool IsPressDigitNodeVariant2 => PressDigitNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PressDigitNode(global::G.NodeBase value) => new PressDigitNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(PressDigitNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public PressDigitNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PressDigitNode(global::G.PressDigitNodeVariant2 value) => new PressDigitNode((global::G.PressDigitNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PressDigitNodeVariant2?(PressDigitNode @this) => @this.PressDigitNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PressDigitNode(global::G.PressDigitNodeVariant2? value)
        {
            PressDigitNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PressDigitNode(
            global::G.NodeBase? @base,
            global::G.PressDigitNodeVariant2? pressDigitNodeVariant2
            )
        {
            Base = @base;
            PressDigitNodeVariant2 = pressDigitNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PressDigitNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            PressDigitNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsPressDigitNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.PressDigitNodeVariant2?, TResult>? pressDigitNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsPressDigitNodeVariant2 && pressDigitNodeVariant2 != null)
            {
                return pressDigitNodeVariant2(PressDigitNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.PressDigitNodeVariant2?>? pressDigitNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsPressDigitNodeVariant2)
            {
                pressDigitNodeVariant2?.Invoke(PressDigitNodeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.NodeBase),
                PressDigitNodeVariant2,
                typeof(global::G.PressDigitNodeVariant2),
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
        public bool Equals(PressDigitNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PressDigitNodeVariant2?>.Default.Equals(PressDigitNodeVariant2, other.PressDigitNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PressDigitNode obj1, PressDigitNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PressDigitNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PressDigitNode obj1, PressDigitNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PressDigitNode o && Equals(o);
        }
    }
}
