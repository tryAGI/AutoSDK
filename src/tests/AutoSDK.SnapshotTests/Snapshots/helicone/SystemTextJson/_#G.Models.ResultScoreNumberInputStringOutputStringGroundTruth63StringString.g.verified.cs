//HintName: G.Models.ResultScoreNumberInputStringOutputStringGroundTruth63StringString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultScoreNumberInputStringOutputStringGroundTruth63StringString : global::System.IEquatable<ResultScoreNumberInputStringOutputStringGroundTruth63StringString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String? Success { get; init; }
#else
        public global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultErrorString? Error { get; init; }
#else
        public global::G.ResultErrorString? Error { get; }
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
        public static implicit operator ResultScoreNumberInputStringOutputStringGroundTruth63StringString(global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String value) => new ResultScoreNumberInputStringOutputStringGroundTruth63StringString((global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String?(ResultScoreNumberInputStringOutputStringGroundTruth63StringString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultScoreNumberInputStringOutputStringGroundTruth63StringString(global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultScoreNumberInputStringOutputStringGroundTruth63StringString(global::G.ResultErrorString value) => new ResultScoreNumberInputStringOutputStringGroundTruth63StringString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultScoreNumberInputStringOutputStringGroundTruth63StringString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultScoreNumberInputStringOutputStringGroundTruth63StringString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultScoreNumberInputStringOutputStringGroundTruth63StringString(
            global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String? success,
            global::G.ResultErrorString? error
            )
        {
            Success = success;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Success as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSuccess || IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String?, TResult>? success = null,
            global::System.Func<global::G.ResultErrorString?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess && success != null)
            {
                return success(Success!);
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
            global::System.Action<global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String?>? success = null,
            global::System.Action<global::G.ResultErrorString?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess)
            {
                success?.Invoke(Success!);
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
                Success,
                typeof(global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String),
                Error,
                typeof(global::G.ResultErrorString),
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
        public bool Equals(ResultScoreNumberInputStringOutputStringGroundTruth63StringString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessScoreNumberInputStringOutputStringGroundTruth63String?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultScoreNumberInputStringOutputStringGroundTruth63StringString obj1, ResultScoreNumberInputStringOutputStringGroundTruth63StringString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultScoreNumberInputStringOutputStringGroundTruth63StringString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultScoreNumberInputStringOutputStringGroundTruth63StringString obj1, ResultScoreNumberInputStringOutputStringGroundTruth63StringString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultScoreNumberInputStringOutputStringGroundTruth63StringString o && Equals(o);
        }
    }
}
