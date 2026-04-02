//HintName: G.Models.PullModelStatus.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Status pulling the model.<br/>
    /// Example: pulling manifest
    /// </summary>
    public readonly partial struct PullModelStatus : global::System.IEquatable<PullModelStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? PullModelStatusVariant1 { get; init; }
#else
        public string? PullModelStatusVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullModelStatusVariant1))]
#endif
        public bool IsPullModelStatusVariant1 => PullModelStatusVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PullModelStatusEnum? Enum { get; init; }
#else
        public global::G.PullModelStatusEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PullModelStatus(string value) => new PullModelStatus((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(PullModelStatus @this) => @this.PullModelStatusVariant1;

        /// <summary>
        /// 
        /// </summary>
        public PullModelStatus(string? value)
        {
            PullModelStatusVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PullModelStatus(global::G.PullModelStatusEnum value) => new PullModelStatus((global::G.PullModelStatusEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PullModelStatusEnum?(PullModelStatus @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public PullModelStatus(global::G.PullModelStatusEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PullModelStatus(
            string? pullModelStatusVariant1,
            global::G.PullModelStatusEnum? @enum
            )
        {
            PullModelStatusVariant1 = pullModelStatusVariant1;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            PullModelStatusVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PullModelStatusVariant1?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPullModelStatusVariant1 || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? pullModelStatusVariant1 = null,
            global::System.Func<global::G.PullModelStatusEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPullModelStatusVariant1 && pullModelStatusVariant1 != null)
            {
                return pullModelStatusVariant1(PullModelStatusVariant1!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? pullModelStatusVariant1 = null,
            global::System.Action<global::G.PullModelStatusEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPullModelStatusVariant1)
            {
                pullModelStatusVariant1?.Invoke(PullModelStatusVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PullModelStatusVariant1,
                typeof(string),
                Enum,
                typeof(global::G.PullModelStatusEnum),
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
        public bool Equals(PullModelStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(PullModelStatusVariant1, other.PullModelStatusVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PullModelStatusEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PullModelStatus obj1, PullModelStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PullModelStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PullModelStatus obj1, PullModelStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PullModelStatus o && Equals(o);
        }
    }
}
