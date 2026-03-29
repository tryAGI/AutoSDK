//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice : global::System.IEquatable<ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// An object representing the tool to be chosen
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1? ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 { get; init; }
#else
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1? ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1))]
#endif
        public bool IsResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 => ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice(string value) => new ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice(global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 value) => new ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice((global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1?(ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice @this) => @this.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice(global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1? value)
        {
            ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice(
            string? value1,
            global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1? responsesPostRequestBodyContentApplicationJsonSchemaToolChoice1
            )
        {
            Value1 = value1;
            ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 = responsesPostRequestBodyContentApplicationJsonSchemaToolChoice1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 || !IsValue1 && IsResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1?, TResult>? responsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 && responsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 != null)
            {
                return responsesPostRequestBodyContentApplicationJsonSchemaToolChoice1(ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1?>? responsesPostRequestBodyContentApplicationJsonSchemaToolChoice1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1)
            {
                responsesPostRequestBodyContentApplicationJsonSchemaToolChoice1?.Invoke(ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(string),
                ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1,
                typeof(global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1),
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
        public bool Equals(ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1?>.Default.Equals(ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1, other.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice obj1, ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice obj1, ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice o && Equals(o);
        }
    }
}
