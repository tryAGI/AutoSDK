//HintName: G.Models.ChatSearchQueriesGenerationEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatSearchQueriesGenerationEvent : global::System.IEquatable<ChatSearchQueriesGenerationEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEvent? Value1 { get; init; }
#else
        public global::G.ChatStreamEvent? Value1 { get; }
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
        public static implicit operator ChatSearchQueriesGenerationEvent(global::G.ChatStreamEvent value) => new ChatSearchQueriesGenerationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEvent?(ChatSearchQueriesGenerationEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatSearchQueriesGenerationEvent(global::G.ChatStreamEvent? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatSearchQueriesGenerationEventVariant2? Value2 { get; init; }
#else
        public global::G.ChatSearchQueriesGenerationEventVariant2? Value2 { get; }
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
        public static implicit operator ChatSearchQueriesGenerationEvent(global::G.ChatSearchQueriesGenerationEventVariant2 value) => new ChatSearchQueriesGenerationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatSearchQueriesGenerationEventVariant2?(ChatSearchQueriesGenerationEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatSearchQueriesGenerationEvent(global::G.ChatSearchQueriesGenerationEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatSearchQueriesGenerationEvent(
            global::G.ChatStreamEvent? value1,
            global::G.ChatSearchQueriesGenerationEventVariant2? value2
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
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatStreamEvent?, TResult>? value1 = null,
            global::System.Func<global::G.ChatSearchQueriesGenerationEventVariant2?, TResult>? value2 = null,
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
            global::System.Action<global::G.ChatStreamEvent?>? value1 = null,
            global::System.Action<global::G.ChatSearchQueriesGenerationEventVariant2?>? value2 = null,
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
                typeof(global::G.ChatStreamEvent),
                Value2,
                typeof(global::G.ChatSearchQueriesGenerationEventVariant2),
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
        public bool Equals(ChatSearchQueriesGenerationEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEvent?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatSearchQueriesGenerationEventVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatSearchQueriesGenerationEvent obj1, ChatSearchQueriesGenerationEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatSearchQueriesGenerationEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatSearchQueriesGenerationEvent obj1, ChatSearchQueriesGenerationEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatSearchQueriesGenerationEvent o && Equals(o);
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
        public static global::G.ChatSearchQueriesGenerationEvent? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ChatSearchQueriesGenerationEvent>(
                json,
                jsonSerializerOptions);
        }

    }
}
