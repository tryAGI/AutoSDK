//HintName: G.Models.ResultOutputStringTracesStringArrayStatusCode63NumberString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultOutputStringTracesStringArrayStatusCode63NumberString : global::System.IEquatable<ResultOutputStringTracesStringArrayStatusCode63NumberString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number? Success { get; init; }
#else
        public global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number? Success { get; }
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
        public static implicit operator ResultOutputStringTracesStringArrayStatusCode63NumberString(global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number value) => new ResultOutputStringTracesStringArrayStatusCode63NumberString((global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number?(ResultOutputStringTracesStringArrayStatusCode63NumberString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultOutputStringTracesStringArrayStatusCode63NumberString(global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultOutputStringTracesStringArrayStatusCode63NumberString(global::G.ResultErrorString value) => new ResultOutputStringTracesStringArrayStatusCode63NumberString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultOutputStringTracesStringArrayStatusCode63NumberString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultOutputStringTracesStringArrayStatusCode63NumberString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultOutputStringTracesStringArrayStatusCode63NumberString(
            global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number? success,
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
            global::System.Func<global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number?, TResult>? success = null,
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
            global::System.Action<global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number?>? success = null,
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
                typeof(global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number),
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
        public bool Equals(ResultOutputStringTracesStringArrayStatusCode63NumberString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessOutputStringTracesStringArrayStatusCode63Number?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultOutputStringTracesStringArrayStatusCode63NumberString obj1, ResultOutputStringTracesStringArrayStatusCode63NumberString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultOutputStringTracesStringArrayStatusCode63NumberString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultOutputStringTracesStringArrayStatusCode63NumberString obj1, ResultOutputStringTracesStringArrayStatusCode63NumberString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultOutputStringTracesStringArrayStatusCode63NumberString o && Equals(o);
        }
    }
}
