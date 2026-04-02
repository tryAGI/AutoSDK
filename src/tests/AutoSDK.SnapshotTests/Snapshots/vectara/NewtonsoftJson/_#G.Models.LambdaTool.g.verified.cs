//HintName: G.Models.LambdaTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A user-defined function that can be executed as a tool by agents.<br/>
    /// Lambda tools run in a secure, sandboxed environment with resource limits.<br/>
    /// Currently supports Python 3.12 with a curated set of libraries.
    /// </summary>
    public readonly partial struct LambdaTool : global::System.IEquatable<LambdaTool>
    {
        /// <summary>
        /// Base properties shared by all tool types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolBase? Base { get; init; }
#else
        public global::G.ToolBase? Base { get; }
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
        public global::G.LambdaToolVariant2? LambdaToolVariant2 { get; init; }
#else
        public global::G.LambdaToolVariant2? LambdaToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LambdaToolVariant2))]
#endif
        public bool IsLambdaToolVariant2 => LambdaToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LambdaTool(global::G.ToolBase value) => new LambdaTool((global::G.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBase?(LambdaTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public LambdaTool(global::G.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LambdaTool(global::G.LambdaToolVariant2 value) => new LambdaTool((global::G.LambdaToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LambdaToolVariant2?(LambdaTool @this) => @this.LambdaToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LambdaTool(global::G.LambdaToolVariant2? value)
        {
            LambdaToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LambdaTool(
            global::G.ToolBase? @base,
            global::G.LambdaToolVariant2? lambdaToolVariant2
            )
        {
            Base = @base;
            LambdaToolVariant2 = lambdaToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LambdaToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            LambdaToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsLambdaToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolBase?, TResult>? @base = null,
            global::System.Func<global::G.LambdaToolVariant2?, TResult>? lambdaToolVariant2 = null,
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
            else if (IsLambdaToolVariant2 && lambdaToolVariant2 != null)
            {
                return lambdaToolVariant2(LambdaToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolBase?>? @base = null,
            global::System.Action<global::G.LambdaToolVariant2?>? lambdaToolVariant2 = null,
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
            else if (IsLambdaToolVariant2)
            {
                lambdaToolVariant2?.Invoke(LambdaToolVariant2!);
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
                typeof(global::G.ToolBase),
                LambdaToolVariant2,
                typeof(global::G.LambdaToolVariant2),
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
        public bool Equals(LambdaTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LambdaToolVariant2?>.Default.Equals(LambdaToolVariant2, other.LambdaToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LambdaTool obj1, LambdaTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LambdaTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LambdaTool obj1, LambdaTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LambdaTool o && Equals(o);
        }
    }
}
