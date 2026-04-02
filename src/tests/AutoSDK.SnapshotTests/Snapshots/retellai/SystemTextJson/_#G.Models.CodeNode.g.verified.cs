//HintName: G.Models.CodeNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CodeNode : global::System.IEquatable<CodeNode>
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
        public global::G.CodeNodeVariant2? CodeNodeVariant2 { get; init; }
#else
        public global::G.CodeNodeVariant2? CodeNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeNodeVariant2))]
#endif
        public bool IsCodeNodeVariant2 => CodeNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeNode(global::G.NodeBase value) => new CodeNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(CodeNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CodeNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeNode(global::G.CodeNodeVariant2 value) => new CodeNode((global::G.CodeNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeNodeVariant2?(CodeNode @this) => @this.CodeNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CodeNode(global::G.CodeNodeVariant2? value)
        {
            CodeNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CodeNode(
            global::G.NodeBase? @base,
            global::G.CodeNodeVariant2? codeNodeVariant2
            )
        {
            Base = @base;
            CodeNodeVariant2 = codeNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CodeNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CodeNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCodeNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.CodeNodeVariant2?, TResult>? codeNodeVariant2 = null,
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
            else if (IsCodeNodeVariant2 && codeNodeVariant2 != null)
            {
                return codeNodeVariant2(CodeNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.CodeNodeVariant2?>? codeNodeVariant2 = null,
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
            else if (IsCodeNodeVariant2)
            {
                codeNodeVariant2?.Invoke(CodeNodeVariant2!);
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
                CodeNodeVariant2,
                typeof(global::G.CodeNodeVariant2),
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
        public bool Equals(CodeNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeNodeVariant2?>.Default.Equals(CodeNodeVariant2, other.CodeNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CodeNode obj1, CodeNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CodeNode obj1, CodeNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeNode o && Equals(o);
        }
    }
}
