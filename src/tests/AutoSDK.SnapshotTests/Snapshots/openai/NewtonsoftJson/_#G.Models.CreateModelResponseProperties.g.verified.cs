//HintName: G.Models.CreateModelResponseProperties.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateModelResponseProperties : global::System.IEquatable<CreateModelResponseProperties>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelResponseProperties? ModelResponseProperties { get; init; }
#else
        public global::G.ModelResponseProperties? ModelResponseProperties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelResponseProperties))]
#endif
        public bool IsModelResponseProperties => ModelResponseProperties != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateModelResponseProperties(global::G.ModelResponseProperties value) => new CreateModelResponseProperties((global::G.ModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelResponseProperties?(CreateModelResponseProperties @this) => @this.ModelResponseProperties;

        /// <summary>
        /// 
        /// </summary>
        public CreateModelResponseProperties(global::G.ModelResponseProperties? value)
        {
            ModelResponseProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ModelResponseProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelResponseProperties?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelResponseProperties;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ModelResponseProperties?, TResult>? modelResponseProperties = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelResponseProperties && modelResponseProperties != null)
            {
                return modelResponseProperties(ModelResponseProperties!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ModelResponseProperties?>? modelResponseProperties = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelResponseProperties)
            {
                modelResponseProperties?.Invoke(ModelResponseProperties!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelResponseProperties,
                typeof(global::G.ModelResponseProperties),
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
        public bool Equals(CreateModelResponseProperties other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ModelResponseProperties?>.Default.Equals(ModelResponseProperties, other.ModelResponseProperties) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateModelResponseProperties obj1, CreateModelResponseProperties obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateModelResponseProperties>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateModelResponseProperties obj1, CreateModelResponseProperties obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateModelResponseProperties o && Equals(o);
        }
    }
}
