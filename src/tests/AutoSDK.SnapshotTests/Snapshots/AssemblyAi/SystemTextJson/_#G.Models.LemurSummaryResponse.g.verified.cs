//HintName: G.Models.LemurSummaryResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LemurSummaryResponse : global::System.IEquatable<LemurSummaryResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurStringResponse? String { get; init; }
#else
        public global::G.LemurStringResponse? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurSummaryResponse(global::G.LemurStringResponse value) => new LemurSummaryResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurStringResponse?(LemurSummaryResponse @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public LemurSummaryResponse(global::G.LemurStringResponse? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LemurStringResponse?, TResult>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LemurStringResponse?>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::G.LemurStringResponse),
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
        public bool Equals(LemurSummaryResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LemurStringResponse?>.Default.Equals(String, other.String) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurSummaryResponse obj1, LemurSummaryResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurSummaryResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurSummaryResponse obj1, LemurSummaryResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurSummaryResponse o && Equals(o);
        }
    }
}
