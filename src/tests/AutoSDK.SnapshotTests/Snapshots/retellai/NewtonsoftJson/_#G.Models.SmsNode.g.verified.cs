//HintName: G.Models.SmsNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SmsNode : global::System.IEquatable<SmsNode>
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
        public global::G.SmsNodeVariant2? SmsNodeVariant2 { get; init; }
#else
        public global::G.SmsNodeVariant2? SmsNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmsNodeVariant2))]
#endif
        public bool IsSmsNodeVariant2 => SmsNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsNode(global::G.NodeBase value) => new SmsNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(SmsNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SmsNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsNode(global::G.SmsNodeVariant2 value) => new SmsNode((global::G.SmsNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SmsNodeVariant2?(SmsNode @this) => @this.SmsNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SmsNode(global::G.SmsNodeVariant2? value)
        {
            SmsNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SmsNode(
            global::G.NodeBase? @base,
            global::G.SmsNodeVariant2? smsNodeVariant2
            )
        {
            Base = @base;
            SmsNodeVariant2 = smsNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SmsNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SmsNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSmsNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.SmsNodeVariant2?, TResult>? smsNodeVariant2 = null,
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
            else if (IsSmsNodeVariant2 && smsNodeVariant2 != null)
            {
                return smsNodeVariant2(SmsNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.SmsNodeVariant2?>? smsNodeVariant2 = null,
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
            else if (IsSmsNodeVariant2)
            {
                smsNodeVariant2?.Invoke(SmsNodeVariant2!);
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
                SmsNodeVariant2,
                typeof(global::G.SmsNodeVariant2),
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
        public bool Equals(SmsNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SmsNodeVariant2?>.Default.Equals(SmsNodeVariant2, other.SmsNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SmsNode obj1, SmsNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmsNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SmsNode obj1, SmsNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmsNode o && Equals(o);
        }
    }
}
