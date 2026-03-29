//HintName: G.Models.ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString : global::System.IEquatable<ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray? Success { get; init; }
#else
        public global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray? Success { get; }
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
        public static implicit operator ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString(global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray value) => new ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString((global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray?(ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString(global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString(global::G.ResultErrorString value) => new ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString(
            global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray? success,
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
            global::System.Func<global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray?, TResult>? success = null,
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
            global::System.Action<global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray?>? success = null,
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
                typeof(global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray),
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
        public bool Equals(ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArray?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString obj1, ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString obj1, ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayString o && Equals(o);
        }
    }
}
