//HintName: G.Models.ResultHeliconeRequestAssetString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultHeliconeRequestAssetString : global::System.IEquatable<ResultHeliconeRequestAssetString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessHeliconeRequestAsset? Success { get; init; }
#else
        public global::G.ResultSuccessHeliconeRequestAsset? Success { get; }
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
        public static implicit operator ResultHeliconeRequestAssetString(global::G.ResultSuccessHeliconeRequestAsset value) => new ResultHeliconeRequestAssetString((global::G.ResultSuccessHeliconeRequestAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessHeliconeRequestAsset?(ResultHeliconeRequestAssetString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultHeliconeRequestAssetString(global::G.ResultSuccessHeliconeRequestAsset? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultHeliconeRequestAssetString(global::G.ResultErrorString value) => new ResultHeliconeRequestAssetString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultHeliconeRequestAssetString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultHeliconeRequestAssetString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultHeliconeRequestAssetString(
            global::G.ResultSuccessHeliconeRequestAsset? success,
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
            global::System.Func<global::G.ResultSuccessHeliconeRequestAsset?, TResult>? success = null,
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
            global::System.Action<global::G.ResultSuccessHeliconeRequestAsset?>? success = null,
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
                typeof(global::G.ResultSuccessHeliconeRequestAsset),
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
        public bool Equals(ResultHeliconeRequestAssetString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessHeliconeRequestAsset?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultHeliconeRequestAssetString obj1, ResultHeliconeRequestAssetString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultHeliconeRequestAssetString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultHeliconeRequestAssetString obj1, ResultHeliconeRequestAssetString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultHeliconeRequestAssetString o && Equals(o);
        }
    }
}
