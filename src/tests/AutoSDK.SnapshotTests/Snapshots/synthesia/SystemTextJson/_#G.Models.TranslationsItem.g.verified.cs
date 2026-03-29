//HintName: G.Models.TranslationsItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TranslationsItem : global::System.IEquatable<TranslationsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus? Status { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranslationStatusApiItemSuccess? Complete { get; init; }
#else
        public global::G.TranslationStatusApiItemSuccess? Complete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Complete))]
#endif
        public bool IsComplete => Complete != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranslationStatusApiItemError? Error { get; init; }
#else
        public global::G.TranslationStatusApiItemError? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranslationsItem(global::G.TranslationStatusApiItemSuccess value) => new TranslationsItem((global::G.TranslationStatusApiItemSuccess?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranslationStatusApiItemSuccess?(TranslationsItem @this) => @this.Complete;

        /// <summary>
        /// 
        /// </summary>
        public TranslationsItem(global::G.TranslationStatusApiItemSuccess? value)
        {
            Complete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranslationsItem(global::G.TranslationStatusApiItemError value) => new TranslationsItem((global::G.TranslationStatusApiItemError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranslationStatusApiItemError?(TranslationsItem @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public TranslationsItem(global::G.TranslationStatusApiItemError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranslationsItem(
            global::G.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus? status,
            global::G.TranslationStatusApiItemSuccess? complete,
            global::G.TranslationStatusApiItemError? error
            )
        {
            Status = status;

            Complete = complete;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Complete as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Complete?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsComplete && !IsError || !IsComplete && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TranslationStatusApiItemSuccess?, TResult>? complete = null,
            global::System.Func<global::G.TranslationStatusApiItemError?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComplete && complete != null)
            {
                return complete(Complete!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TranslationStatusApiItemSuccess?>? complete = null,
            global::System.Action<global::G.TranslationStatusApiItemError?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComplete)
            {
                complete?.Invoke(Complete!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Complete,
                typeof(global::G.TranslationStatusApiItemSuccess),
                Error,
                typeof(global::G.TranslationStatusApiItemError),
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
        public bool Equals(TranslationsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TranslationStatusApiItemSuccess?>.Default.Equals(Complete, other.Complete) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TranslationStatusApiItemError?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TranslationsItem obj1, TranslationsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranslationsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TranslationsItem obj1, TranslationsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranslationsItem o && Equals(o);
        }
    }
}
