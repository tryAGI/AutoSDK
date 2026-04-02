//HintName: G.Models.ResultErrorOverTimeArrayString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultErrorOverTimeArrayString : global::System.IEquatable<ResultErrorOverTimeArrayString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessErrorOverTimeArray? Success { get; init; }
#else
        public global::G.ResultSuccessErrorOverTimeArray? Success { get; }
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
        public global::G.ResultErrorString? ResultErrorString { get; init; }
#else
        public global::G.ResultErrorString? ResultErrorString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResultErrorString))]
#endif
        public bool IsResultErrorString => ResultErrorString != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultErrorOverTimeArrayString(global::G.ResultSuccessErrorOverTimeArray value) => new ResultErrorOverTimeArrayString((global::G.ResultSuccessErrorOverTimeArray?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessErrorOverTimeArray?(ResultErrorOverTimeArrayString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultErrorOverTimeArrayString(global::G.ResultSuccessErrorOverTimeArray? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultErrorOverTimeArrayString(global::G.ResultErrorString value) => new ResultErrorOverTimeArrayString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultErrorOverTimeArrayString @this) => @this.ResultErrorString;

        /// <summary>
        /// 
        /// </summary>
        public ResultErrorOverTimeArrayString(global::G.ResultErrorString? value)
        {
            ResultErrorString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultErrorOverTimeArrayString(
            global::G.ResultSuccessErrorOverTimeArray? success,
            global::G.ResultErrorString? resultErrorString
            )
        {
            Success = success;
            ResultErrorString = resultErrorString;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResultErrorString as object ??
            Success as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            ResultErrorString?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSuccess || IsResultErrorString;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResultSuccessErrorOverTimeArray?, TResult>? success = null,
            global::System.Func<global::G.ResultErrorString?, TResult>? resultErrorString = null,
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
            else if (IsResultErrorString && resultErrorString != null)
            {
                return resultErrorString(ResultErrorString!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResultSuccessErrorOverTimeArray?>? success = null,
            global::System.Action<global::G.ResultErrorString?>? resultErrorString = null,
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
            else if (IsResultErrorString)
            {
                resultErrorString?.Invoke(ResultErrorString!);
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
                typeof(global::G.ResultSuccessErrorOverTimeArray),
                ResultErrorString,
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
        public bool Equals(ResultErrorOverTimeArrayString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessErrorOverTimeArray?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(ResultErrorString, other.ResultErrorString) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultErrorOverTimeArrayString obj1, ResultErrorOverTimeArrayString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultErrorOverTimeArrayString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultErrorOverTimeArrayString obj1, ResultErrorOverTimeArrayString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultErrorOverTimeArrayString o && Equals(o);
        }
    }
}
