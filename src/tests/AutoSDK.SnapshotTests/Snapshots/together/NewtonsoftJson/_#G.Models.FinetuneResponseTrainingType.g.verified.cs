//HintName: G.Models.FinetuneResponseTrainingType.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FinetuneResponseTrainingType : global::System.IEquatable<FinetuneResponseTrainingType>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.FinetuneResponseTrainingTypeDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FullTrainingType? Full { get; init; }
#else
        public global::G.FullTrainingType? Full { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Full))]
#endif
        public bool IsFull => Full != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FinetuneResponseTrainingType(global::G.FullTrainingType value) => new FinetuneResponseTrainingType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FullTrainingType?(FinetuneResponseTrainingType @this) => @this.Full;

        /// <summary>
        /// 
        /// </summary>
        public FinetuneResponseTrainingType(global::G.FullTrainingType? value)
        {
            Full = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LoRATrainingType? Lora { get; init; }
#else
        public global::G.LoRATrainingType? Lora { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lora))]
#endif
        public bool IsLora => Lora != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FinetuneResponseTrainingType(global::G.LoRATrainingType value) => new FinetuneResponseTrainingType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LoRATrainingType?(FinetuneResponseTrainingType @this) => @this.Lora;

        /// <summary>
        /// 
        /// </summary>
        public FinetuneResponseTrainingType(global::G.LoRATrainingType? value)
        {
            Lora = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FinetuneResponseTrainingType(
            global::G.FinetuneResponseTrainingTypeDiscriminatorType? type,
            global::G.FullTrainingType? full,
            global::G.LoRATrainingType? lora
            )
        {
            Type = type;

            Full = full;
            Lora = lora;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Lora as object ??
            Full as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Full?.ToString() ??
            Lora?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFull && !IsLora || !IsFull && IsLora;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FullTrainingType?, TResult>? full = null,
            global::System.Func<global::G.LoRATrainingType?, TResult>? lora = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFull && full != null)
            {
                return full(Full!);
            }
            else if (IsLora && lora != null)
            {
                return lora(Lora!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FullTrainingType?>? full = null,
            global::System.Action<global::G.LoRATrainingType?>? lora = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFull)
            {
                full?.Invoke(Full!);
            }
            else if (IsLora)
            {
                lora?.Invoke(Lora!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Full,
                typeof(global::G.FullTrainingType),
                Lora,
                typeof(global::G.LoRATrainingType),
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
        public bool Equals(FinetuneResponseTrainingType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FullTrainingType?>.Default.Equals(Full, other.Full) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LoRATrainingType?>.Default.Equals(Lora, other.Lora) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FinetuneResponseTrainingType obj1, FinetuneResponseTrainingType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FinetuneResponseTrainingType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FinetuneResponseTrainingType obj1, FinetuneResponseTrainingType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FinetuneResponseTrainingType o && Equals(o);
        }
    }
}
