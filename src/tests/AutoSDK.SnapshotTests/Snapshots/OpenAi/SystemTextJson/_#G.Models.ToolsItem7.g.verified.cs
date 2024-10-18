//HintName: G.Models.ToolsItem7.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem7 : global::System.IEquatable<ToolsItem7>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageObjectAttachmentToolDiscriminatorType? Type { get; }

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
        public static implicit operator ToolsItem7(global::G.AssistantToolsCode value) => new ToolsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantToolsCode?(ToolsItem7 @this) => @this.AssistantCode;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem7(global::G.AssistantToolsCode? value)
        {
            AssistantCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantToolsFileSearchTypeOnly? AssistantFileSearchTypeOnly { get; init; }
#else
        public global::G.AssistantToolsFileSearchTypeOnly? AssistantFileSearchTypeOnly { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantFileSearchTypeOnly))]
#endif
        public bool IsAssistantFileSearchTypeOnly => AssistantFileSearchTypeOnly != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem7(global::G.AssistantToolsFileSearchTypeOnly value) => new ToolsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantToolsFileSearchTypeOnly?(ToolsItem7 @this) => @this.AssistantFileSearchTypeOnly;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem7(global::G.AssistantToolsFileSearchTypeOnly? value)
        {
            AssistantFileSearchTypeOnly = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem7(
            global::G.MessageObjectAttachmentToolDiscriminatorType? type,
            global::G.AssistantToolsCode? assistantCode,
            global::G.AssistantToolsFileSearchTypeOnly? assistantFileSearchTypeOnly
            )
        {
            Type = type;

            AssistantCode = assistantCode;
            AssistantFileSearchTypeOnly = assistantFileSearchTypeOnly;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AssistantFileSearchTypeOnly as object ??
            AssistantCode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAssistantCode && !IsAssistantFileSearchTypeOnly || !IsAssistantCode && IsAssistantFileSearchTypeOnly;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AssistantToolsCode?, TResult>? assistantCode = null,
            global::System.Func<global::G.AssistantToolsFileSearchTypeOnly?, TResult>? assistantFileSearchTypeOnly = null,
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
            else if (IsAssistantFileSearchTypeOnly && assistantFileSearchTypeOnly != null)
            {
                return assistantFileSearchTypeOnly(AssistantFileSearchTypeOnly!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AssistantToolsCode?>? assistantCode = null,
            global::System.Action<global::G.AssistantToolsFileSearchTypeOnly?>? assistantFileSearchTypeOnly = null,
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
            else if (IsAssistantFileSearchTypeOnly)
            {
                assistantFileSearchTypeOnly?.Invoke(AssistantFileSearchTypeOnly!);
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
                AssistantFileSearchTypeOnly,
                typeof(global::G.AssistantToolsFileSearchTypeOnly),
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
        public bool Equals(ToolsItem7 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantToolsCode?>.Default.Equals(AssistantCode, other.AssistantCode) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantToolsFileSearchTypeOnly?>.Default.Equals(AssistantFileSearchTypeOnly, other.AssistantFileSearchTypeOnly) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem7 obj1, ToolsItem7 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem7>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem7 obj1, ToolsItem7 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem7 o && Equals(o);
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
        public static global::G.ToolsItem7? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ToolsItem7),
                jsonSerializerContext) as global::G.ToolsItem7?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ToolsItem7? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolsItem7>(
                json,
                jsonSerializerOptions);
        }

    }
}
