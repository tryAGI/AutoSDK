//HintName: G.Models.ChatCompletionToolChoiceOption.g.cs
using System.Linq;
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
    public readonly partial struct ChatCompletionToolChoiceOption : global::System.IEquatable<ChatCompletionToolChoiceOption>
    {
        /// <summary>
        /// `none` means the model will not call any tool and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionToolChoiceOptionEnum? Value1 { get; init; }
#else
        public global::G.ChatCompletionToolChoiceOptionEnum? Value1 { get; }
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
        public static implicit operator ChatCompletionToolChoiceOption(global::G.ChatCompletionToolChoiceOptionEnum value) => new ChatCompletionToolChoiceOption(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionToolChoiceOptionEnum?(ChatCompletionToolChoiceOption @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::G.ChatCompletionToolChoiceOptionEnum? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific function.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionNamedToolChoice? Value2 { get; init; }
#else
        public global::G.ChatCompletionNamedToolChoice? Value2 { get; }
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
        public static implicit operator ChatCompletionToolChoiceOption(global::G.ChatCompletionNamedToolChoice value) => new ChatCompletionToolChoiceOption(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionNamedToolChoice?(ChatCompletionToolChoiceOption @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::G.ChatCompletionNamedToolChoice? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(
            global::G.ChatCompletionToolChoiceOptionEnum? value1,
            global::G.ChatCompletionNamedToolChoice? value2
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
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionToolChoiceOptionEnum?, TResult>? value1 = null,
            global::System.Func<global::G.ChatCompletionNamedToolChoice?, TResult>? value2 = null,
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
            global::System.Action<global::G.ChatCompletionToolChoiceOptionEnum?>? value1 = null,
            global::System.Action<global::G.ChatCompletionNamedToolChoice?>? value2 = null,
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
                typeof(global::G.ChatCompletionToolChoiceOptionEnum),
                Value2,
                typeof(global::G.ChatCompletionNamedToolChoice),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChatCompletionToolChoiceOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionToolChoiceOptionEnum?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionNamedToolChoice?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionToolChoiceOption obj1, ChatCompletionToolChoiceOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionToolChoiceOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionToolChoiceOption obj1, ChatCompletionToolChoiceOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionToolChoiceOption o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ChatCompletionToolChoiceOption? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ChatCompletionToolChoiceOption>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ChatCompletionToolChoiceOption?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ChatCompletionToolChoiceOption?>(serializer.Deserialize<global::G.ChatCompletionToolChoiceOption>(jsonReader));
        }

    }
}
