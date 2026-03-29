//HintName: G.Models.ReasoningDetailUnion.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Reasoning detail union schema
    /// </summary>
    public readonly partial struct ReasoningDetailUnion : global::System.IEquatable<ReasoningDetailUnion>
    {
        /// <summary>
        /// Reasoning detail summary schema
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReasoningDetailSummary? ReasoningDetailSummary { get; init; }
#else
        public global::G.ReasoningDetailSummary? ReasoningDetailSummary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningDetailSummary))]
#endif
        public bool IsReasoningDetailSummary => ReasoningDetailSummary != null;

        /// <summary>
        /// Reasoning detail encrypted schema
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReasoningDetailEncrypted? ReasoningDetailEncrypted { get; init; }
#else
        public global::G.ReasoningDetailEncrypted? ReasoningDetailEncrypted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningDetailEncrypted))]
#endif
        public bool IsReasoningDetailEncrypted => ReasoningDetailEncrypted != null;

        /// <summary>
        /// Reasoning detail text schema
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReasoningDetailText? ReasoningDetailText { get; init; }
#else
        public global::G.ReasoningDetailText? ReasoningDetailText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningDetailText))]
#endif
        public bool IsReasoningDetailText => ReasoningDetailText != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningDetailUnion(global::G.ReasoningDetailSummary value) => new ReasoningDetailUnion((global::G.ReasoningDetailSummary?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReasoningDetailSummary?(ReasoningDetailUnion @this) => @this.ReasoningDetailSummary;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningDetailUnion(global::G.ReasoningDetailSummary? value)
        {
            ReasoningDetailSummary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningDetailUnion(global::G.ReasoningDetailEncrypted value) => new ReasoningDetailUnion((global::G.ReasoningDetailEncrypted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReasoningDetailEncrypted?(ReasoningDetailUnion @this) => @this.ReasoningDetailEncrypted;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningDetailUnion(global::G.ReasoningDetailEncrypted? value)
        {
            ReasoningDetailEncrypted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningDetailUnion(global::G.ReasoningDetailText value) => new ReasoningDetailUnion((global::G.ReasoningDetailText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReasoningDetailText?(ReasoningDetailUnion @this) => @this.ReasoningDetailText;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningDetailUnion(global::G.ReasoningDetailText? value)
        {
            ReasoningDetailText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReasoningDetailUnion(
            global::G.ReasoningDetailSummary? reasoningDetailSummary,
            global::G.ReasoningDetailEncrypted? reasoningDetailEncrypted,
            global::G.ReasoningDetailText? reasoningDetailText
            )
        {
            ReasoningDetailSummary = reasoningDetailSummary;
            ReasoningDetailEncrypted = reasoningDetailEncrypted;
            ReasoningDetailText = reasoningDetailText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReasoningDetailText as object ??
            ReasoningDetailEncrypted as object ??
            ReasoningDetailSummary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReasoningDetailSummary?.ToString() ??
            ReasoningDetailEncrypted?.ToString() ??
            ReasoningDetailText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReasoningDetailSummary && !IsReasoningDetailEncrypted && !IsReasoningDetailText || !IsReasoningDetailSummary && IsReasoningDetailEncrypted && !IsReasoningDetailText || !IsReasoningDetailSummary && !IsReasoningDetailEncrypted && IsReasoningDetailText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ReasoningDetailSummary?, TResult>? reasoningDetailSummary = null,
            global::System.Func<global::G.ReasoningDetailEncrypted?, TResult>? reasoningDetailEncrypted = null,
            global::System.Func<global::G.ReasoningDetailText?, TResult>? reasoningDetailText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningDetailSummary && reasoningDetailSummary != null)
            {
                return reasoningDetailSummary(ReasoningDetailSummary!);
            }
            else if (IsReasoningDetailEncrypted && reasoningDetailEncrypted != null)
            {
                return reasoningDetailEncrypted(ReasoningDetailEncrypted!);
            }
            else if (IsReasoningDetailText && reasoningDetailText != null)
            {
                return reasoningDetailText(ReasoningDetailText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ReasoningDetailSummary?>? reasoningDetailSummary = null,
            global::System.Action<global::G.ReasoningDetailEncrypted?>? reasoningDetailEncrypted = null,
            global::System.Action<global::G.ReasoningDetailText?>? reasoningDetailText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningDetailSummary)
            {
                reasoningDetailSummary?.Invoke(ReasoningDetailSummary!);
            }
            else if (IsReasoningDetailEncrypted)
            {
                reasoningDetailEncrypted?.Invoke(ReasoningDetailEncrypted!);
            }
            else if (IsReasoningDetailText)
            {
                reasoningDetailText?.Invoke(ReasoningDetailText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReasoningDetailSummary,
                typeof(global::G.ReasoningDetailSummary),
                ReasoningDetailEncrypted,
                typeof(global::G.ReasoningDetailEncrypted),
                ReasoningDetailText,
                typeof(global::G.ReasoningDetailText),
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
        public bool Equals(ReasoningDetailUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningDetailSummary?>.Default.Equals(ReasoningDetailSummary, other.ReasoningDetailSummary) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningDetailEncrypted?>.Default.Equals(ReasoningDetailEncrypted, other.ReasoningDetailEncrypted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningDetailText?>.Default.Equals(ReasoningDetailText, other.ReasoningDetailText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReasoningDetailUnion obj1, ReasoningDetailUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningDetailUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReasoningDetailUnion obj1, ReasoningDetailUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningDetailUnion o && Equals(o);
        }
    }
}
