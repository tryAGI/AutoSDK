//HintName: G.Models.CreateEncoderRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a new encoder
    /// </summary>
    public readonly partial struct CreateEncoderRequest : global::System.IEquatable<CreateEncoderRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateEncoderRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Configuration for an OpenAI-compatible encoder
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateOpenAIEncoderRequest? OpenaiCompatible { get; init; }
#else
        public global::G.CreateOpenAIEncoderRequest? OpenaiCompatible { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiCompatible))]
#endif
        public bool IsOpenaiCompatible => OpenaiCompatible != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEncoderRequest(global::G.CreateOpenAIEncoderRequest value) => new CreateEncoderRequest((global::G.CreateOpenAIEncoderRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateOpenAIEncoderRequest?(CreateEncoderRequest @this) => @this.OpenaiCompatible;

        /// <summary>
        /// 
        /// </summary>
        public CreateEncoderRequest(global::G.CreateOpenAIEncoderRequest? value)
        {
            OpenaiCompatible = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateEncoderRequest(
            global::G.CreateEncoderRequestDiscriminatorType? type,
            global::G.CreateOpenAIEncoderRequest? openaiCompatible
            )
        {
            Type = type;

            OpenaiCompatible = openaiCompatible;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenaiCompatible as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenaiCompatible?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenaiCompatible;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateOpenAIEncoderRequest?, TResult>? openaiCompatible = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenaiCompatible && openaiCompatible != null)
            {
                return openaiCompatible(OpenaiCompatible!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateOpenAIEncoderRequest?>? openaiCompatible = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenaiCompatible)
            {
                openaiCompatible?.Invoke(OpenaiCompatible!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenaiCompatible,
                typeof(global::G.CreateOpenAIEncoderRequest),
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
        public bool Equals(CreateEncoderRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateOpenAIEncoderRequest?>.Default.Equals(OpenaiCompatible, other.OpenaiCompatible) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateEncoderRequest obj1, CreateEncoderRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEncoderRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateEncoderRequest obj1, CreateEncoderRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEncoderRequest o && Equals(o);
        }
    }
}
