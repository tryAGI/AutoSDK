//HintName: G.Models.ToolsItem5.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem5 : global::System.IEquatable<ToolsItem5>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateRunRequestToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantToolsCode? AssistantCode { get; init; }
#else
        public global::G.AssistantToolsCode? AssistantCode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantCode))]
#endif
        public bool IsAssistantCode => AssistantCode != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::G.AssistantToolsCode value) => new ToolsItem5(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantToolsCode?(ToolsItem5 @this) => @this.AssistantCode;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::G.AssistantToolsCode? value)
        {
            AssistantCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantToolsFileSearch? AssistantFileSearch { get; init; }
#else
        public global::G.AssistantToolsFileSearch? AssistantFileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantFileSearch))]
#endif
        public bool IsAssistantFileSearch => AssistantFileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::G.AssistantToolsFileSearch value) => new ToolsItem5(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantToolsFileSearch?(ToolsItem5 @this) => @this.AssistantFileSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::G.AssistantToolsFileSearch? value)
        {
            AssistantFileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantToolsFunction? AssistantFunction { get; init; }
#else
        public global::G.AssistantToolsFunction? AssistantFunction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantFunction))]
#endif
        public bool IsAssistantFunction => AssistantFunction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::G.AssistantToolsFunction value) => new ToolsItem5(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantToolsFunction?(ToolsItem5 @this) => @this.AssistantFunction;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::G.AssistantToolsFunction? value)
        {
            AssistantFunction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(
            global::G.CreateRunRequestToolDiscriminatorType? type,
            global::G.AssistantToolsCode? assistantCode,
            global::G.AssistantToolsFileSearch? assistantFileSearch,
            global::G.AssistantToolsFunction? assistantFunction
            )
        {
            Type = type;

            AssistantCode = assistantCode;
            AssistantFileSearch = assistantFileSearch;
            AssistantFunction = assistantFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AssistantFunction as object ??
            AssistantFileSearch as object ??
            AssistantCode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAssistantCode && !IsAssistantFileSearch && !IsAssistantFunction || !IsAssistantCode && IsAssistantFileSearch && !IsAssistantFunction || !IsAssistantCode && !IsAssistantFileSearch && IsAssistantFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AssistantToolsCode?, TResult>? assistantCode = null,
            global::System.Func<global::G.AssistantToolsFileSearch?, TResult>? assistantFileSearch = null,
            global::System.Func<global::G.AssistantToolsFunction?, TResult>? assistantFunction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistantCode && assistantCode != null)
            {
                return assistantCode(AssistantCode!);
            }
            else if (IsAssistantFileSearch && assistantFileSearch != null)
            {
                return assistantFileSearch(AssistantFileSearch!);
            }
            else if (IsAssistantFunction && assistantFunction != null)
            {
                return assistantFunction(AssistantFunction!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AssistantToolsCode?>? assistantCode = null,
            global::System.Action<global::G.AssistantToolsFileSearch?>? assistantFileSearch = null,
            global::System.Action<global::G.AssistantToolsFunction?>? assistantFunction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistantCode)
            {
                assistantCode?.Invoke(AssistantCode!);
            }
            else if (IsAssistantFileSearch)
            {
                assistantFileSearch?.Invoke(AssistantFileSearch!);
            }
            else if (IsAssistantFunction)
            {
                assistantFunction?.Invoke(AssistantFunction!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AssistantCode,
                typeof(global::G.AssistantToolsCode),
                AssistantFileSearch,
                typeof(global::G.AssistantToolsFileSearch),
                AssistantFunction,
                typeof(global::G.AssistantToolsFunction),
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
        public bool Equals(ToolsItem5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantToolsCode?>.Default.Equals(AssistantCode, other.AssistantCode) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantToolsFileSearch?>.Default.Equals(AssistantFileSearch, other.AssistantFileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantToolsFunction?>.Default.Equals(AssistantFunction, other.AssistantFunction) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem5 obj1, ToolsItem5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem5 obj1, ToolsItem5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem5 o && Equals(o);
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
        public static global::G.ToolsItem5? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ToolsItem5),
                jsonSerializerContext) as global::G.ToolsItem5?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ToolsItem5? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolsItem5>(
                json,
                jsonSerializerOptions);
        }

    }
}
