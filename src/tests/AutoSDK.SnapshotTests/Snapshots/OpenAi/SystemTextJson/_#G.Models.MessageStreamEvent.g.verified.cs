//HintName: G.Models.MessageStreamEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageStreamEvent : global::System.IEquatable<MessageStreamEvent>
    {
        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant1? Value1 { get; init; }
#else
        public global::G.MessageStreamEventVariant1? Value1 { get; }
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
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant1 value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant1?(MessageStreamEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) moves to an `in_progress` state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant2? Value2 { get; init; }
#else
        public global::G.MessageStreamEventVariant2? Value2 { get; }
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
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant2 value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant2?(MessageStreamEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// Occurs when parts of a [Message](/docs/api-reference/messages/object) are being streamed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant3? Value3 { get; init; }
#else
        public global::G.MessageStreamEventVariant3? Value3 { get; }
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
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant3 value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant3?(MessageStreamEvent @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant4? Value4 { get; init; }
#else
        public global::G.MessageStreamEventVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant4 value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant4?(MessageStreamEvent @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) ends before it is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageStreamEventVariant5? Value5 { get; init; }
#else
        public global::G.MessageStreamEventVariant5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::G.MessageStreamEventVariant5 value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageStreamEventVariant5?(MessageStreamEvent @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::G.MessageStreamEventVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(
            global::G.MessageStreamEventVariant1? value1,
            global::G.MessageStreamEventVariant2? value2,
            global::G.MessageStreamEventVariant3? value3,
            global::G.MessageStreamEventVariant4? value4,
            global::G.MessageStreamEventVariant5? value5
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessageStreamEventVariant1?, TResult>? value1 = null,
            global::System.Func<global::G.MessageStreamEventVariant2?, TResult>? value2 = null,
            global::System.Func<global::G.MessageStreamEventVariant3?, TResult>? value3 = null,
            global::System.Func<global::G.MessageStreamEventVariant4?, TResult>? value4 = null,
            global::System.Func<global::G.MessageStreamEventVariant5?, TResult>? value5 = null,
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
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessageStreamEventVariant1?>? value1 = null,
            global::System.Action<global::G.MessageStreamEventVariant2?>? value2 = null,
            global::System.Action<global::G.MessageStreamEventVariant3?>? value3 = null,
            global::System.Action<global::G.MessageStreamEventVariant4?>? value4 = null,
            global::System.Action<global::G.MessageStreamEventVariant5?>? value5 = null,
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
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
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
                typeof(global::G.MessageStreamEventVariant1),
                Value2,
                typeof(global::G.MessageStreamEventVariant2),
                Value3,
                typeof(global::G.MessageStreamEventVariant3),
                Value4,
                typeof(global::G.MessageStreamEventVariant4),
                Value5,
                typeof(global::G.MessageStreamEventVariant5),
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
        public bool Equals(MessageStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageStreamEventVariant5?>.Default.Equals(Value5, other.Value5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageStreamEvent obj1, MessageStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageStreamEvent obj1, MessageStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageStreamEvent o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.MessageStreamEvent? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.MessageStreamEvent),
                jsonSerializerContext) as global::G.MessageStreamEvent?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.MessageStreamEvent? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.MessageStreamEvent>(
                json,
                jsonSerializerOptions);
        }

    }
}
