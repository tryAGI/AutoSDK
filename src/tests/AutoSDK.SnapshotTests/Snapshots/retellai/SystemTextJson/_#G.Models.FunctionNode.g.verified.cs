//HintName: G.Models.FunctionNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionNode : global::System.IEquatable<FunctionNode>
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
        public global::G.FunctionNodeVariant2? FunctionNodeVariant2 { get; init; }
#else
        public global::G.FunctionNodeVariant2? FunctionNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionNodeVariant2))]
#endif
        public bool IsFunctionNodeVariant2 => FunctionNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionNode(global::G.NodeBase value) => new FunctionNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(FunctionNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public FunctionNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionNode(global::G.FunctionNodeVariant2 value) => new FunctionNode((global::G.FunctionNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionNodeVariant2?(FunctionNode @this) => @this.FunctionNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FunctionNode(global::G.FunctionNodeVariant2? value)
        {
            FunctionNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionNode(
            global::G.NodeBase? @base,
            global::G.FunctionNodeVariant2? functionNodeVariant2
            )
        {
            Base = @base;
            FunctionNodeVariant2 = functionNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            FunctionNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsFunctionNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.FunctionNodeVariant2?, TResult>? functionNodeVariant2 = null,
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
            else if (IsFunctionNodeVariant2 && functionNodeVariant2 != null)
            {
                return functionNodeVariant2(FunctionNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.FunctionNodeVariant2?>? functionNodeVariant2 = null,
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
            else if (IsFunctionNodeVariant2)
            {
                functionNodeVariant2?.Invoke(FunctionNodeVariant2!);
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
                FunctionNodeVariant2,
                typeof(global::G.FunctionNodeVariant2),
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
        public bool Equals(FunctionNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionNodeVariant2?>.Default.Equals(FunctionNodeVariant2, other.FunctionNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionNode obj1, FunctionNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionNode obj1, FunctionNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionNode o && Equals(o);
        }
    }
}
