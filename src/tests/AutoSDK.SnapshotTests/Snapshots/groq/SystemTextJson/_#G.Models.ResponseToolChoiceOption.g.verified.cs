//HintName: G.Models.ResponseToolChoiceOption.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.<br/>
    /// `none` means the model will not call any tool and instead generates a message.<br/>
    /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
    /// `required` means the model must call one or more tools.<br/>
    /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
    /// `none` is the default when no tools are present. `auto` is the default if tools are present.
    /// </summary>
    public readonly partial struct ResponseToolChoiceOption : global::System.IEquatable<ResponseToolChoiceOption>
    {
        /// <summary>
        /// `none` means the model will not call any tool and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseToolChoiceOptionEnum? Value1 { get; init; }
#else
        public global::G.ResponseToolChoiceOptionEnum? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific function.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseNamedToolChoice? Value2 { get; init; }
#else
        public global::G.ResponseNamedToolChoice? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseToolChoiceOption(global::G.ResponseToolChoiceOptionEnum value) => new ResponseToolChoiceOption((global::G.ResponseToolChoiceOptionEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseToolChoiceOptionEnum?(ResponseToolChoiceOption @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ResponseToolChoiceOption(global::G.ResponseToolChoiceOptionEnum? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseToolChoiceOption(global::G.ResponseNamedToolChoice value) => new ResponseToolChoiceOption((global::G.ResponseNamedToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseNamedToolChoice?(ResponseToolChoiceOption @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ResponseToolChoiceOption(global::G.ResponseNamedToolChoice? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseToolChoiceOption(
            global::G.ResponseToolChoiceOptionEnum? value1,
            global::G.ResponseNamedToolChoice? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToValueString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseToolChoiceOptionEnum?, TResult>? value1 = null,
            global::System.Func<global::G.ResponseNamedToolChoice?, TResult>? value2 = null,
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
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseToolChoiceOptionEnum?>? value1 = null,
            global::System.Action<global::G.ResponseNamedToolChoice?>? value2 = null,
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
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
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
                typeof(global::G.ResponseToolChoiceOptionEnum),
                Value2,
                typeof(global::G.ResponseNamedToolChoice),
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
        public bool Equals(ResponseToolChoiceOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseToolChoiceOptionEnum?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseNamedToolChoice?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseToolChoiceOption obj1, ResponseToolChoiceOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseToolChoiceOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseToolChoiceOption obj1, ResponseToolChoiceOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseToolChoiceOption o && Equals(o);
        }
    }
}
