//HintName: G.Models.ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString : global::System.IEquatable<ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray? ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray { get; init; }
#else
        public global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray? ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray))]
#endif
        public bool IsResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray => ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray != null;

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
        public static implicit operator ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString(global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray value) => new ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString((global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray?(ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString @this) => @this.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString(global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray? value)
        {
            ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString(global::G.ResultErrorString value) => new ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString(
            global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray? resultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray,
            global::G.ResultErrorString? error
            )
        {
            ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray = resultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray || IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray?, TResult>? resultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray = null,
            global::System.Func<global::G.ResultErrorString?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray && resultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray != null)
            {
                return resultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray(ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray!);
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
            global::System.Action<global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray?>? resultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray = null,
            global::System.Action<global::G.ResultErrorString?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray)
            {
                resultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray?.Invoke(ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray!);
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
                ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray,
                typeof(global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray),
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
        public bool Equals(ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray?>.Default.Equals(ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray, other.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString obj1, ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString obj1, ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayString o && Equals(o);
        }
    }
}
