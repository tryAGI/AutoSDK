//HintName: G.Models.RunStreamEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStreamEvent : global::System.IEquatable<RunStreamEvent>
    {
        /// <summary>
        /// Occurs when a new [run](/docs/api-reference/runs/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant1? Value1 { get; init; }
#else
        public global::G.RunStreamEventVariant1? Value1 { get; }
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
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant1 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant1?(RunStreamEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `queued` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant2? Value2 { get; init; }
#else
        public global::G.RunStreamEventVariant2? Value2 { get; }
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
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant2 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant2?(RunStreamEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to an `in_progress` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant3? Value3 { get; init; }
#else
        public global::G.RunStreamEventVariant3? Value3 { get; }
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
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant3 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant3?(RunStreamEvent @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `requires_action` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant4? Value4 { get; init; }
#else
        public global::G.RunStreamEventVariant4? Value4 { get; }
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
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant4 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant4?(RunStreamEvent @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant5? Value5 { get; init; }
#else
        public global::G.RunStreamEventVariant5? Value5 { get; }
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
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant5 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant5?(RunStreamEvent @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) ends with status `incomplete`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant6? Value6 { get; init; }
#else
        public global::G.RunStreamEventVariant6? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant6 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant6?(RunStreamEvent @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant6? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant7? Value7 { get; init; }
#else
        public global::G.RunStreamEventVariant7? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant7 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant7?(RunStreamEvent @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant7? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `cancelling` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant8? Value8 { get; init; }
#else
        public global::G.RunStreamEventVariant8? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant8 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant8?(RunStreamEvent @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant8? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) is cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant9? Value9 { get; init; }
#else
        public global::G.RunStreamEventVariant9? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant9 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant9?(RunStreamEvent @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant9? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) expires.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant10? Value10 { get; init; }
#else
        public global::G.RunStreamEventVariant10? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant10 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant10?(RunStreamEvent @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant10? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(
            global::G.RunStreamEventVariant1? value1,
            global::G.RunStreamEventVariant2? value2,
            global::G.RunStreamEventVariant3? value3,
            global::G.RunStreamEventVariant4? value4,
            global::G.RunStreamEventVariant5? value5,
            global::G.RunStreamEventVariant6? value6,
            global::G.RunStreamEventVariant7? value7,
            global::G.RunStreamEventVariant8? value8,
            global::G.RunStreamEventVariant9? value9,
            global::G.RunStreamEventVariant10? value10
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
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
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RunStreamEventVariant1?, TResult>? value1 = null,
            global::System.Func<global::G.RunStreamEventVariant2?, TResult>? value2 = null,
            global::System.Func<global::G.RunStreamEventVariant3?, TResult>? value3 = null,
            global::System.Func<global::G.RunStreamEventVariant4?, TResult>? value4 = null,
            global::System.Func<global::G.RunStreamEventVariant5?, TResult>? value5 = null,
            global::System.Func<global::G.RunStreamEventVariant6?, TResult>? value6 = null,
            global::System.Func<global::G.RunStreamEventVariant7?, TResult>? value7 = null,
            global::System.Func<global::G.RunStreamEventVariant8?, TResult>? value8 = null,
            global::System.Func<global::G.RunStreamEventVariant9?, TResult>? value9 = null,
            global::System.Func<global::G.RunStreamEventVariant10?, TResult>? value10 = null,
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
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RunStreamEventVariant1?>? value1 = null,
            global::System.Action<global::G.RunStreamEventVariant2?>? value2 = null,
            global::System.Action<global::G.RunStreamEventVariant3?>? value3 = null,
            global::System.Action<global::G.RunStreamEventVariant4?>? value4 = null,
            global::System.Action<global::G.RunStreamEventVariant5?>? value5 = null,
            global::System.Action<global::G.RunStreamEventVariant6?>? value6 = null,
            global::System.Action<global::G.RunStreamEventVariant7?>? value7 = null,
            global::System.Action<global::G.RunStreamEventVariant8?>? value8 = null,
            global::System.Action<global::G.RunStreamEventVariant9?>? value9 = null,
            global::System.Action<global::G.RunStreamEventVariant10?>? value10 = null,
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
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
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
                typeof(global::G.RunStreamEventVariant1),
                Value2,
                typeof(global::G.RunStreamEventVariant2),
                Value3,
                typeof(global::G.RunStreamEventVariant3),
                Value4,
                typeof(global::G.RunStreamEventVariant4),
                Value5,
                typeof(global::G.RunStreamEventVariant5),
                Value6,
                typeof(global::G.RunStreamEventVariant6),
                Value7,
                typeof(global::G.RunStreamEventVariant7),
                Value8,
                typeof(global::G.RunStreamEventVariant8),
                Value9,
                typeof(global::G.RunStreamEventVariant9),
                Value10,
                typeof(global::G.RunStreamEventVariant10),
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
        public bool Equals(RunStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant6?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant7?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant8?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant9?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant10?>.Default.Equals(Value10, other.Value10) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStreamEvent obj1, RunStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStreamEvent obj1, RunStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStreamEvent o && Equals(o);
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
        public static global::G.RunStreamEvent? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.RunStreamEvent),
                jsonSerializerContext) as global::G.RunStreamEvent?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RunStreamEvent? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStreamEvent>(
                json,
                jsonSerializerOptions);
        }

    }
}
