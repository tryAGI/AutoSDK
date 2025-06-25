//HintName: G.Models.TextResponseFormatConfiguration.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An object specifying the format that the model must output.<br/>
    /// Configuring `{ "type": "json_schema" }` enables Structured Outputs, <br/>
    /// which ensures the model will match your supplied JSON schema. Learn more in the <br/>
    /// [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
    /// The default format is `{ "type": "text" }` with no additional options.<br/>
    /// **Not recommended for gpt-4o and newer models:**<br/>
    /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
    /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
    /// is preferred for models that support it.
    /// </summary>
    public readonly partial struct TextResponseFormatConfiguration : global::System.IEquatable<TextResponseFormatConfiguration>
    {
        /// <summary>
        /// Default response format. Used to generate text responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFormatText? Value1 { get; init; }
#else
        public global::G.ResponseFormatText? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextResponseFormatConfiguration(global::G.ResponseFormatText value) => new TextResponseFormatConfiguration((global::G.ResponseFormatText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatText?(TextResponseFormatConfiguration @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(global::G.ResponseFormatText? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// JSON Schema response format. Used to generate structured JSON responses.<br/>
        /// Learn more about [Structured Outputs](/docs/guides/structured-outputs).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextResponseFormatJsonSchema? Value2 { get; init; }
#else
        public global::G.TextResponseFormatJsonSchema? Value2 { get; }
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
        public static implicit operator TextResponseFormatConfiguration(global::G.TextResponseFormatJsonSchema value) => new TextResponseFormatConfiguration((global::G.TextResponseFormatJsonSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextResponseFormatJsonSchema?(TextResponseFormatConfiguration @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(global::G.TextResponseFormatJsonSchema? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// JSON object response format. An older method of generating JSON responses.<br/>
        /// Using `json_schema` is recommended for models that support it. Note that the<br/>
        /// model will not generate JSON without a system or user message instructing it<br/>
        /// to do so.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFormatJsonObject? Value3 { get; init; }
#else
        public global::G.ResponseFormatJsonObject? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextResponseFormatConfiguration(global::G.ResponseFormatJsonObject value) => new TextResponseFormatConfiguration((global::G.ResponseFormatJsonObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatJsonObject?(TextResponseFormatConfiguration @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(global::G.ResponseFormatJsonObject? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(
            global::G.ResponseFormatText? value1,
            global::G.TextResponseFormatJsonSchema? value2,
            global::G.ResponseFormatJsonObject? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 || !IsValue1 && IsValue2 && !IsValue3 || !IsValue1 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseFormatText?, TResult>? value1 = null,
            global::System.Func<global::G.TextResponseFormatJsonSchema?, TResult>? value2 = null,
            global::System.Func<global::G.ResponseFormatJsonObject?, TResult>? value3 = null,
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
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseFormatText?>? value1 = null,
            global::System.Action<global::G.TextResponseFormatJsonSchema?>? value2 = null,
            global::System.Action<global::G.ResponseFormatJsonObject?>? value3 = null,
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
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
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
                typeof(global::G.ResponseFormatText),
                Value2,
                typeof(global::G.TextResponseFormatJsonSchema),
                Value3,
                typeof(global::G.ResponseFormatJsonObject),
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
        public bool Equals(TextResponseFormatConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatText?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextResponseFormatJsonSchema?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatJsonObject?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextResponseFormatConfiguration obj1, TextResponseFormatConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextResponseFormatConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextResponseFormatConfiguration obj1, TextResponseFormatConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextResponseFormatConfiguration o && Equals(o);
        }
    }
}
