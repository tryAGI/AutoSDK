//HintName: G.Models.ResultWithContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultWithContent : global::System.IEquatable<ResultWithContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Result? Result { get; init; }
#else
        public global::G.Result? Result { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Result))]
#endif
        public bool IsResult => Result != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultWithContentVariant2? ResultWithContentVariant2 { get; init; }
#else
        public global::G.ResultWithContentVariant2? ResultWithContentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResultWithContentVariant2))]
#endif
        public bool IsResultWithContentVariant2 => ResultWithContentVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultWithContent(global::G.Result value) => new ResultWithContent((global::G.Result?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Result?(ResultWithContent @this) => @this.Result;

        /// <summary>
        /// 
        /// </summary>
        public ResultWithContent(global::G.Result? value)
        {
            Result = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultWithContent(global::G.ResultWithContentVariant2 value) => new ResultWithContent((global::G.ResultWithContentVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultWithContentVariant2?(ResultWithContent @this) => @this.ResultWithContentVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ResultWithContent(global::G.ResultWithContentVariant2? value)
        {
            ResultWithContentVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultWithContent(
            global::G.Result? result,
            global::G.ResultWithContentVariant2? resultWithContentVariant2
            )
        {
            Result = result;
            ResultWithContentVariant2 = resultWithContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResultWithContentVariant2 as object ??
            Result as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Result?.ToString() ??
            ResultWithContentVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResult && IsResultWithContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Result?, TResult>? result = null,
            global::System.Func<global::G.ResultWithContentVariant2?, TResult>? resultWithContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResult && result != null)
            {
                return result(Result!);
            }
            else if (IsResultWithContentVariant2 && resultWithContentVariant2 != null)
            {
                return resultWithContentVariant2(ResultWithContentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Result?>? result = null,
            global::System.Action<global::G.ResultWithContentVariant2?>? resultWithContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResult)
            {
                result?.Invoke(Result!);
            }
            else if (IsResultWithContentVariant2)
            {
                resultWithContentVariant2?.Invoke(ResultWithContentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Result,
                typeof(global::G.Result),
                ResultWithContentVariant2,
                typeof(global::G.ResultWithContentVariant2),
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
        public bool Equals(ResultWithContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Result?>.Default.Equals(Result, other.Result) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultWithContentVariant2?>.Default.Equals(ResultWithContentVariant2, other.ResultWithContentVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultWithContent obj1, ResultWithContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultWithContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultWithContent obj1, ResultWithContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultWithContent o && Equals(o);
        }
    }
}
