//HintName: G.Models.CreateScoreValue.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The value of the score. Must be passed as string for categorical scores, and numeric for boolean and numeric scores
    /// </summary>
    public readonly partial struct CreateScoreValue : global::System.IEquatable<CreateScoreValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? CreateScoreValueVariant1 { get; init; }
#else
        public double? CreateScoreValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateScoreValueVariant1))]
#endif
        public bool IsCreateScoreValueVariant1 => CreateScoreValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? CreateScoreValueVariant2 { get; init; }
#else
        public string? CreateScoreValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateScoreValueVariant2))]
#endif
        public bool IsCreateScoreValueVariant2 => CreateScoreValueVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateScoreValue(double value) => new CreateScoreValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(CreateScoreValue @this) => @this.CreateScoreValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CreateScoreValue(double? value)
        {
            CreateScoreValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateScoreValue(string value) => new CreateScoreValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(CreateScoreValue @this) => @this.CreateScoreValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateScoreValue(string? value)
        {
            CreateScoreValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateScoreValue(
            double? createScoreValueVariant1,
            string? createScoreValueVariant2
            )
        {
            CreateScoreValueVariant1 = createScoreValueVariant1;
            CreateScoreValueVariant2 = createScoreValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateScoreValueVariant2 as object ??
            CreateScoreValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateScoreValueVariant1?.ToString() ??
            CreateScoreValueVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateScoreValueVariant1 && !IsCreateScoreValueVariant2 || !IsCreateScoreValueVariant1 && IsCreateScoreValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? createScoreValueVariant1 = null,
            global::System.Func<string?, TResult>? createScoreValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateScoreValueVariant1 && createScoreValueVariant1 != null)
            {
                return createScoreValueVariant1(CreateScoreValueVariant1!);
            }
            else if (IsCreateScoreValueVariant2 && createScoreValueVariant2 != null)
            {
                return createScoreValueVariant2(CreateScoreValueVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<double?>? createScoreValueVariant1 = null,
            global::System.Action<string?>? createScoreValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateScoreValueVariant1)
            {
                createScoreValueVariant1?.Invoke(CreateScoreValueVariant1!);
            }
            else if (IsCreateScoreValueVariant2)
            {
                createScoreValueVariant2?.Invoke(CreateScoreValueVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateScoreValueVariant1,
                typeof(double),
                CreateScoreValueVariant2,
                typeof(string),
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
        public bool Equals(CreateScoreValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(CreateScoreValueVariant1, other.CreateScoreValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(CreateScoreValueVariant2, other.CreateScoreValueVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateScoreValue obj1, CreateScoreValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateScoreValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateScoreValue obj1, CreateScoreValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateScoreValue o && Equals(o);
        }
    }
}
