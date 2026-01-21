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
#if NET6_0_OR_GREATER
        public global::G.LoRATrainingType? LoRA { get; init; }
#else
        public global::G.LoRATrainingType? LoRA { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LoRA))]
#endif
        public bool IsLoRA => LoRA != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FinetuneResponseTrainingType(global::G.FullTrainingType value) => new FinetuneResponseTrainingType((global::G.FullTrainingType?)value);

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
        public static implicit operator FinetuneResponseTrainingType(global::G.LoRATrainingType value) => new FinetuneResponseTrainingType((global::G.LoRATrainingType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LoRATrainingType?(FinetuneResponseTrainingType @this) => @this.LoRA;

        /// <summary>
        /// 
        /// </summary>
        public FinetuneResponseTrainingType(global::G.LoRATrainingType? value)
        {
            LoRA = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FinetuneResponseTrainingType(
            global::G.FullTrainingType? full,
            global::G.LoRATrainingType? loRA
            )
        {
            Full = full;
            LoRA = loRA;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LoRA as object ??
            Full as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Full?.ToString() ??
            LoRA?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFull && !IsLoRA || !IsFull && IsLoRA;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FullTrainingType?, TResult>? full = null,
            global::System.Func<global::G.LoRATrainingType?, TResult>? loRA = null,
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
            else if (IsLoRA && loRA != null)
            {
                return loRA(LoRA!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FullTrainingType?>? full = null,
            global::System.Action<global::G.LoRATrainingType?>? loRA = null,
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
            else if (IsLoRA)
            {
                loRA?.Invoke(LoRA!);
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
                LoRA,
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
                global::System.Collections.Generic.EqualityComparer<global::G.LoRATrainingType?>.Default.Equals(LoRA, other.LoRA) 
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
