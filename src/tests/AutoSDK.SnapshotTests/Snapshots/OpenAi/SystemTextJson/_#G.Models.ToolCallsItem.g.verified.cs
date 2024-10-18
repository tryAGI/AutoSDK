//HintName: G.Models.ToolCallsItem.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolCallsItem : global::System.IEquatable<ToolCallsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsObjectToolCallDiscriminatorType? Type { get; }

        /// <summary>
        /// Details of the Code Interpreter tool call the run step was involved in.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDetailsToolCallsCodeObject? RunStepDetailsCodeObject { get; init; }
#else
        public global::G.RunStepDetailsToolCallsCodeObject? RunStepDetailsCodeObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepDetailsCodeObject))]
#endif
        public bool IsRunStepDetailsCodeObject => RunStepDetailsCodeObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem(global::G.RunStepDetailsToolCallsCodeObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDetailsToolCallsCodeObject?(ToolCallsItem @this) => @this.RunStepDetailsCodeObject;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::G.RunStepDetailsToolCallsCodeObject? value)
        {
            RunStepDetailsCodeObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDetailsToolCallsFileSearchObject? RunStepDetailsFileSearchObject { get; init; }
#else
        public global::G.RunStepDetailsToolCallsFileSearchObject? RunStepDetailsFileSearchObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepDetailsFileSearchObject))]
#endif
        public bool IsRunStepDetailsFileSearchObject => RunStepDetailsFileSearchObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem(global::G.RunStepDetailsToolCallsFileSearchObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDetailsToolCallsFileSearchObject?(ToolCallsItem @this) => @this.RunStepDetailsFileSearchObject;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::G.RunStepDetailsToolCallsFileSearchObject? value)
        {
            RunStepDetailsFileSearchObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDetailsToolCallsFunctionObject? RunStepDetailsFunctionObject { get; init; }
#else
        public global::G.RunStepDetailsToolCallsFunctionObject? RunStepDetailsFunctionObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepDetailsFunctionObject))]
#endif
        public bool IsRunStepDetailsFunctionObject => RunStepDetailsFunctionObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem(global::G.RunStepDetailsToolCallsFunctionObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDetailsToolCallsFunctionObject?(ToolCallsItem @this) => @this.RunStepDetailsFunctionObject;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::G.RunStepDetailsToolCallsFunctionObject? value)
        {
            RunStepDetailsFunctionObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(
            global::G.RunStepDetailsToolCallsObjectToolCallDiscriminatorType? type,
            global::G.RunStepDetailsToolCallsCodeObject? runStepDetailsCodeObject,
            global::G.RunStepDetailsToolCallsFileSearchObject? runStepDetailsFileSearchObject,
            global::G.RunStepDetailsToolCallsFunctionObject? runStepDetailsFunctionObject
            )
        {
            Type = type;

            RunStepDetailsCodeObject = runStepDetailsCodeObject;
            RunStepDetailsFileSearchObject = runStepDetailsFileSearchObject;
            RunStepDetailsFunctionObject = runStepDetailsFunctionObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunStepDetailsFunctionObject as object ??
            RunStepDetailsFileSearchObject as object ??
            RunStepDetailsCodeObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRunStepDetailsCodeObject && !IsRunStepDetailsFileSearchObject && !IsRunStepDetailsFunctionObject || !IsRunStepDetailsCodeObject && IsRunStepDetailsFileSearchObject && !IsRunStepDetailsFunctionObject || !IsRunStepDetailsCodeObject && !IsRunStepDetailsFileSearchObject && IsRunStepDetailsFunctionObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RunStepDetailsToolCallsCodeObject?, TResult>? runStepDetailsCodeObject = null,
            global::System.Func<global::G.RunStepDetailsToolCallsFileSearchObject?, TResult>? runStepDetailsFileSearchObject = null,
            global::System.Func<global::G.RunStepDetailsToolCallsFunctionObject?, TResult>? runStepDetailsFunctionObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepDetailsCodeObject && runStepDetailsCodeObject != null)
            {
                return runStepDetailsCodeObject(RunStepDetailsCodeObject!);
            }
            else if (IsRunStepDetailsFileSearchObject && runStepDetailsFileSearchObject != null)
            {
                return runStepDetailsFileSearchObject(RunStepDetailsFileSearchObject!);
            }
            else if (IsRunStepDetailsFunctionObject && runStepDetailsFunctionObject != null)
            {
                return runStepDetailsFunctionObject(RunStepDetailsFunctionObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RunStepDetailsToolCallsCodeObject?>? runStepDetailsCodeObject = null,
            global::System.Action<global::G.RunStepDetailsToolCallsFileSearchObject?>? runStepDetailsFileSearchObject = null,
            global::System.Action<global::G.RunStepDetailsToolCallsFunctionObject?>? runStepDetailsFunctionObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepDetailsCodeObject)
            {
                runStepDetailsCodeObject?.Invoke(RunStepDetailsCodeObject!);
            }
            else if (IsRunStepDetailsFileSearchObject)
            {
                runStepDetailsFileSearchObject?.Invoke(RunStepDetailsFileSearchObject!);
            }
            else if (IsRunStepDetailsFunctionObject)
            {
                runStepDetailsFunctionObject?.Invoke(RunStepDetailsFunctionObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunStepDetailsCodeObject,
                typeof(global::G.RunStepDetailsToolCallsCodeObject),
                RunStepDetailsFileSearchObject,
                typeof(global::G.RunStepDetailsToolCallsFileSearchObject),
                RunStepDetailsFunctionObject,
                typeof(global::G.RunStepDetailsToolCallsFunctionObject),
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
        public bool Equals(ToolCallsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDetailsToolCallsCodeObject?>.Default.Equals(RunStepDetailsCodeObject, other.RunStepDetailsCodeObject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDetailsToolCallsFileSearchObject?>.Default.Equals(RunStepDetailsFileSearchObject, other.RunStepDetailsFileSearchObject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDetailsToolCallsFunctionObject?>.Default.Equals(RunStepDetailsFunctionObject, other.RunStepDetailsFunctionObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallsItem obj1, ToolCallsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallsItem obj1, ToolCallsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallsItem o && Equals(o);
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
        public static global::G.ToolCallsItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ToolCallsItem),
                jsonSerializerContext) as global::G.ToolCallsItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ToolCallsItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolCallsItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
