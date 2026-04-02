//HintName: G.Models.ResponsesRequestImageConfig.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesRequestImageConfig : global::System.IEquatable<ResponsesRequestImageConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ResponsesRequestImageConfigVariant1 { get; init; }
#else
        public string? ResponsesRequestImageConfigVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestImageConfigVariant1))]
#endif
        public bool IsResponsesRequestImageConfigVariant1 => ResponsesRequestImageConfigVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? ResponsesRequestImageConfigVariant2 { get; init; }
#else
        public double? ResponsesRequestImageConfigVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestImageConfigVariant2))]
#endif
        public bool IsResponsesRequestImageConfigVariant2 => ResponsesRequestImageConfigVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestImageConfig(string value) => new ResponsesRequestImageConfig((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesRequestImageConfig @this) => @this.ResponsesRequestImageConfigVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestImageConfig(string? value)
        {
            ResponsesRequestImageConfigVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestImageConfig(double value) => new ResponsesRequestImageConfig((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(ResponsesRequestImageConfig @this) => @this.ResponsesRequestImageConfigVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestImageConfig(double? value)
        {
            ResponsesRequestImageConfigVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestImageConfig(
            string? responsesRequestImageConfigVariant1,
            double? responsesRequestImageConfigVariant2
            )
        {
            ResponsesRequestImageConfigVariant1 = responsesRequestImageConfigVariant1;
            ResponsesRequestImageConfigVariant2 = responsesRequestImageConfigVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesRequestImageConfigVariant2 as object ??
            ResponsesRequestImageConfigVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponsesRequestImageConfigVariant1?.ToString() ??
            ResponsesRequestImageConfigVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponsesRequestImageConfigVariant1 && !IsResponsesRequestImageConfigVariant2 || !IsResponsesRequestImageConfigVariant1 && IsResponsesRequestImageConfigVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? responsesRequestImageConfigVariant1 = null,
            global::System.Func<double?, TResult>? responsesRequestImageConfigVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesRequestImageConfigVariant1 && responsesRequestImageConfigVariant1 != null)
            {
                return responsesRequestImageConfigVariant1(ResponsesRequestImageConfigVariant1!);
            }
            else if (IsResponsesRequestImageConfigVariant2 && responsesRequestImageConfigVariant2 != null)
            {
                return responsesRequestImageConfigVariant2(ResponsesRequestImageConfigVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? responsesRequestImageConfigVariant1 = null,
            global::System.Action<double?>? responsesRequestImageConfigVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesRequestImageConfigVariant1)
            {
                responsesRequestImageConfigVariant1?.Invoke(ResponsesRequestImageConfigVariant1!);
            }
            else if (IsResponsesRequestImageConfigVariant2)
            {
                responsesRequestImageConfigVariant2?.Invoke(ResponsesRequestImageConfigVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponsesRequestImageConfigVariant1,
                typeof(string),
                ResponsesRequestImageConfigVariant2,
                typeof(double),
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
        public bool Equals(ResponsesRequestImageConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ResponsesRequestImageConfigVariant1, other.ResponsesRequestImageConfigVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(ResponsesRequestImageConfigVariant2, other.ResponsesRequestImageConfigVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesRequestImageConfig obj1, ResponsesRequestImageConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesRequestImageConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesRequestImageConfig obj1, ResponsesRequestImageConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestImageConfig o && Equals(o);
        }
    }
}
