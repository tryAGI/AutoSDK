//HintName: G.Models.SageMakerConfiguration.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SageMakerConfiguration : global::System.IEquatable<SageMakerConfiguration>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BedrockConfiguration? Bedrock { get; init; }
#else
        public global::G.BedrockConfiguration? Bedrock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bedrock))]
#endif
        public bool IsBedrock => Bedrock != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SageMakerConfigurationVariant2? SageMakerConfigurationVariant2 { get; init; }
#else
        public global::G.SageMakerConfigurationVariant2? SageMakerConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SageMakerConfigurationVariant2))]
#endif
        public bool IsSageMakerConfigurationVariant2 => SageMakerConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SageMakerConfiguration(global::G.BedrockConfiguration value) => new SageMakerConfiguration((global::G.BedrockConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BedrockConfiguration?(SageMakerConfiguration @this) => @this.Bedrock;

        /// <summary>
        /// 
        /// </summary>
        public SageMakerConfiguration(global::G.BedrockConfiguration? value)
        {
            Bedrock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SageMakerConfiguration(global::G.SageMakerConfigurationVariant2 value) => new SageMakerConfiguration((global::G.SageMakerConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SageMakerConfigurationVariant2?(SageMakerConfiguration @this) => @this.SageMakerConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SageMakerConfiguration(global::G.SageMakerConfigurationVariant2? value)
        {
            SageMakerConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SageMakerConfiguration(
            global::G.BedrockConfiguration? bedrock,
            global::G.SageMakerConfigurationVariant2? sageMakerConfigurationVariant2
            )
        {
            Bedrock = bedrock;
            SageMakerConfigurationVariant2 = sageMakerConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SageMakerConfigurationVariant2 as object ??
            Bedrock as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Bedrock?.ToString() ??
            SageMakerConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBedrock && IsSageMakerConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BedrockConfiguration?, TResult>? bedrock = null,
            global::System.Func<global::G.SageMakerConfigurationVariant2?, TResult>? sageMakerConfigurationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBedrock && bedrock != null)
            {
                return bedrock(Bedrock!);
            }
            else if (IsSageMakerConfigurationVariant2 && sageMakerConfigurationVariant2 != null)
            {
                return sageMakerConfigurationVariant2(SageMakerConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BedrockConfiguration?>? bedrock = null,
            global::System.Action<global::G.SageMakerConfigurationVariant2?>? sageMakerConfigurationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBedrock)
            {
                bedrock?.Invoke(Bedrock!);
            }
            else if (IsSageMakerConfigurationVariant2)
            {
                sageMakerConfigurationVariant2?.Invoke(SageMakerConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Bedrock,
                typeof(global::G.BedrockConfiguration),
                SageMakerConfigurationVariant2,
                typeof(global::G.SageMakerConfigurationVariant2),
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
        public bool Equals(SageMakerConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BedrockConfiguration?>.Default.Equals(Bedrock, other.Bedrock) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SageMakerConfigurationVariant2?>.Default.Equals(SageMakerConfigurationVariant2, other.SageMakerConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SageMakerConfiguration obj1, SageMakerConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SageMakerConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SageMakerConfiguration obj1, SageMakerConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SageMakerConfiguration o && Equals(o);
        }
    }
}
