//HintName: G.Models.ToolResultOutput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolResultOutput : global::System.IEquatable<ToolResultOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolResultOutputVariant1? ToolResultOutputVariant1 { get; init; }
#else
        public global::G.ToolResultOutputVariant1? ToolResultOutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolResultOutputVariant1))]
#endif
        public bool IsToolResultOutputVariant1 => ToolResultOutputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolResultOutputVariant2? ToolResultOutputVariant2 { get; init; }
#else
        public global::G.ToolResultOutputVariant2? ToolResultOutputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolResultOutputVariant2))]
#endif
        public bool IsToolResultOutputVariant2 => ToolResultOutputVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolResultOutput(global::G.ToolResultOutputVariant1 value) => new ToolResultOutput((global::G.ToolResultOutputVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolResultOutputVariant1?(ToolResultOutput @this) => @this.ToolResultOutputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ToolResultOutput(global::G.ToolResultOutputVariant1? value)
        {
            ToolResultOutputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolResultOutput(global::G.ToolResultOutputVariant2 value) => new ToolResultOutput((global::G.ToolResultOutputVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolResultOutputVariant2?(ToolResultOutput @this) => @this.ToolResultOutputVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ToolResultOutput(global::G.ToolResultOutputVariant2? value)
        {
            ToolResultOutputVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolResultOutput(
            global::G.ToolResultOutputVariant1? toolResultOutputVariant1,
            global::G.ToolResultOutputVariant2? toolResultOutputVariant2
            )
        {
            ToolResultOutputVariant1 = toolResultOutputVariant1;
            ToolResultOutputVariant2 = toolResultOutputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolResultOutputVariant2 as object ??
            ToolResultOutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolResultOutputVariant1?.ToString() ??
            ToolResultOutputVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolResultOutputVariant1 || IsToolResultOutputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolResultOutputVariant1?, TResult>? toolResultOutputVariant1 = null,
            global::System.Func<global::G.ToolResultOutputVariant2?, TResult>? toolResultOutputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolResultOutputVariant1 && toolResultOutputVariant1 != null)
            {
                return toolResultOutputVariant1(ToolResultOutputVariant1!);
            }
            else if (IsToolResultOutputVariant2 && toolResultOutputVariant2 != null)
            {
                return toolResultOutputVariant2(ToolResultOutputVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolResultOutputVariant1?>? toolResultOutputVariant1 = null,
            global::System.Action<global::G.ToolResultOutputVariant2?>? toolResultOutputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolResultOutputVariant1)
            {
                toolResultOutputVariant1?.Invoke(ToolResultOutputVariant1!);
            }
            else if (IsToolResultOutputVariant2)
            {
                toolResultOutputVariant2?.Invoke(ToolResultOutputVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolResultOutputVariant1,
                typeof(global::G.ToolResultOutputVariant1),
                ToolResultOutputVariant2,
                typeof(global::G.ToolResultOutputVariant2),
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
        public bool Equals(ToolResultOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolResultOutputVariant1?>.Default.Equals(ToolResultOutputVariant1, other.ToolResultOutputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolResultOutputVariant2?>.Default.Equals(ToolResultOutputVariant2, other.ToolResultOutputVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolResultOutput obj1, ToolResultOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolResultOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolResultOutput obj1, ToolResultOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolResultOutput o && Equals(o);
        }
    }
}
