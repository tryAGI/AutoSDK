//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaInput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesPostRequestBodyContentApplicationJsonSchemaInput : global::System.IEquatable<ResponsesPostRequestBodyContentApplicationJsonSchemaInput>
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
        /// An array of input items used for generating completions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>? ResponsesPostRequestBodyContentApplicationJsonSchemaInput1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>? ResponsesPostRequestBodyContentApplicationJsonSchemaInput1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesPostRequestBodyContentApplicationJsonSchemaInput1))]
#endif
        public bool IsResponsesPostRequestBodyContentApplicationJsonSchemaInput1 => ResponsesPostRequestBodyContentApplicationJsonSchemaInput1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesPostRequestBodyContentApplicationJsonSchemaInput(string value) => new ResponsesPostRequestBodyContentApplicationJsonSchemaInput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesPostRequestBodyContentApplicationJsonSchemaInput @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaInput(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaInput(
            string? value1,
            global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>? responsesPostRequestBodyContentApplicationJsonSchemaInput1
            )
        {
            Value1 = value1;
            ResponsesPostRequestBodyContentApplicationJsonSchemaInput1 = responsesPostRequestBodyContentApplicationJsonSchemaInput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesPostRequestBodyContentApplicationJsonSchemaInput1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            ResponsesPostRequestBodyContentApplicationJsonSchemaInput1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsResponsesPostRequestBodyContentApplicationJsonSchemaInput1 || !IsValue1 && IsResponsesPostRequestBodyContentApplicationJsonSchemaInput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>?, TResult>? responsesPostRequestBodyContentApplicationJsonSchemaInput1 = null,
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
            else if (IsResponsesPostRequestBodyContentApplicationJsonSchemaInput1 && responsesPostRequestBodyContentApplicationJsonSchemaInput1 != null)
            {
                return responsesPostRequestBodyContentApplicationJsonSchemaInput1(ResponsesPostRequestBodyContentApplicationJsonSchemaInput1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>?>? responsesPostRequestBodyContentApplicationJsonSchemaInput1 = null,
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
            else if (IsResponsesPostRequestBodyContentApplicationJsonSchemaInput1)
            {
                responsesPostRequestBodyContentApplicationJsonSchemaInput1?.Invoke(ResponsesPostRequestBodyContentApplicationJsonSchemaInput1!);
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
                ResponsesPostRequestBodyContentApplicationJsonSchemaInput1,
                typeof(global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>),
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
        public bool Equals(ResponsesPostRequestBodyContentApplicationJsonSchemaInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>?>.Default.Equals(ResponsesPostRequestBodyContentApplicationJsonSchemaInput1, other.ResponsesPostRequestBodyContentApplicationJsonSchemaInput1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesPostRequestBodyContentApplicationJsonSchemaInput obj1, ResponsesPostRequestBodyContentApplicationJsonSchemaInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesPostRequestBodyContentApplicationJsonSchemaInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesPostRequestBodyContentApplicationJsonSchemaInput obj1, ResponsesPostRequestBodyContentApplicationJsonSchemaInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesPostRequestBodyContentApplicationJsonSchemaInput o && Equals(o);
        }
    }
}
