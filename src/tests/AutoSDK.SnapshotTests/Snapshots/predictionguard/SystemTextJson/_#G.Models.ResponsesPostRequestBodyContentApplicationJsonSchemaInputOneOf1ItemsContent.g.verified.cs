//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent : global::System.IEquatable<ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent>
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
        /// The content of the message, used for file inputs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items>? ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items>? ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1))]
#endif
        public bool IsResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 => ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent(string value) => new ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent(
            string? value1,
            global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items>? responsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1
            )
        {
            Value1 = value1;
            ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 = responsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 || !IsValue1 && IsResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items>?, TResult>? responsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 = null,
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
            else if (IsResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 && responsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 != null)
            {
                return responsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1(ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items>?>? responsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1 = null,
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
            else if (IsResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1)
            {
                responsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1?.Invoke(ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1!);
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
                ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1,
                typeof(global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items>),
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
        public bool Equals(ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items>?>.Default.Equals(ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1, other.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent obj1, ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent obj1, ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent o && Equals(o);
        }
    }
}
