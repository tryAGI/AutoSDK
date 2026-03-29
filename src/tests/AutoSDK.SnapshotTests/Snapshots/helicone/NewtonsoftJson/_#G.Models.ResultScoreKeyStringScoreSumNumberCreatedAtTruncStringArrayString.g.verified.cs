//HintName: G.Models.ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString : global::System.IEquatable<ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray? Success { get; init; }
#else
        public global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray? Success { get; }
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
        public static implicit operator ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString(global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray value) => new ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString((global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray?(ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString(global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString(global::G.ResultErrorString value) => new ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString(
            global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray? success,
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
            global::System.Func<global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray?, TResult>? success = null,
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
            global::System.Action<global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray?>? success = null,
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
                typeof(global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray),
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
        public bool Equals(ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString obj1, ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString obj1, ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString o && Equals(o);
        }
    }
}
