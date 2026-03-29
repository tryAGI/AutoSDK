//HintName: G.Models.IngestionUsage.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IngestionUsage : global::System.IEquatable<IngestionUsage>
    {
        /// <summary>
        /// (Deprecated. Use usageDetails and costDetails instead.) Standard interface for usage and cost
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Usage? Usage { get; init; }
#else
        public global::G.Usage? Usage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Usage))]
#endif
        public bool IsUsage => Usage != null;

        /// <summary>
        /// Usage interface of OpenAI for improved compatibility.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAIUsage? OpenAIUsage { get; init; }
#else
        public global::G.OpenAIUsage? OpenAIUsage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIUsage))]
#endif
        public bool IsOpenAIUsage => OpenAIUsage != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionUsage(global::G.Usage value) => new IngestionUsage((global::G.Usage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Usage?(IngestionUsage @this) => @this.Usage;

        /// <summary>
        /// 
        /// </summary>
        public IngestionUsage(global::G.Usage? value)
        {
            Usage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionUsage(global::G.OpenAIUsage value) => new IngestionUsage((global::G.OpenAIUsage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAIUsage?(IngestionUsage @this) => @this.OpenAIUsage;

        /// <summary>
        /// 
        /// </summary>
        public IngestionUsage(global::G.OpenAIUsage? value)
        {
            OpenAIUsage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IngestionUsage(
            global::G.Usage? usage,
            global::G.OpenAIUsage? openAIUsage
            )
        {
            Usage = usage;
            OpenAIUsage = openAIUsage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAIUsage as object ??
            Usage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Usage?.ToString() ??
            OpenAIUsage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUsage && !IsOpenAIUsage || !IsUsage && IsOpenAIUsage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Usage?, TResult>? usage = null,
            global::System.Func<global::G.OpenAIUsage?, TResult>? openAIUsage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsage && usage != null)
            {
                return usage(Usage!);
            }
            else if (IsOpenAIUsage && openAIUsage != null)
            {
                return openAIUsage(OpenAIUsage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Usage?>? usage = null,
            global::System.Action<global::G.OpenAIUsage?>? openAIUsage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsage)
            {
                usage?.Invoke(Usage!);
            }
            else if (IsOpenAIUsage)
            {
                openAIUsage?.Invoke(OpenAIUsage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Usage,
                typeof(global::G.Usage),
                OpenAIUsage,
                typeof(global::G.OpenAIUsage),
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
        public bool Equals(IngestionUsage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Usage?>.Default.Equals(Usage, other.Usage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAIUsage?>.Default.Equals(OpenAIUsage, other.OpenAIUsage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IngestionUsage obj1, IngestionUsage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IngestionUsage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IngestionUsage obj1, IngestionUsage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IngestionUsage o && Equals(o);
        }
    }
}
