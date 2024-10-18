//HintName: G.Models.AnnotationsItem2.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnnotationsItem2 : global::System.IEquatable<AnnotationsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType? Type { get; }

        /// <summary>
        /// A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the "file_search" tool to search files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaContentTextAnnotationsFileCitationObject? MessageDeltaContentTextFileCitationObject { get; init; }
#else
        public global::G.MessageDeltaContentTextAnnotationsFileCitationObject? MessageDeltaContentTextFileCitationObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDeltaContentTextFileCitationObject))]
#endif
        public bool IsMessageDeltaContentTextFileCitationObject => MessageDeltaContentTextFileCitationObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem2(global::G.MessageDeltaContentTextAnnotationsFileCitationObject value) => new AnnotationsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaContentTextAnnotationsFileCitationObject?(AnnotationsItem2 @this) => @this.MessageDeltaContentTextFileCitationObject;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem2(global::G.MessageDeltaContentTextAnnotationsFileCitationObject? value)
        {
            MessageDeltaContentTextFileCitationObject = value;
        }

        /// <summary>
        /// A URL for the file that's generated when the assistant used the `code_interpreter` tool to generate a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaContentTextAnnotationsFilePathObject? MessageDeltaContentTextFilePathObject { get; init; }
#else
        public global::G.MessageDeltaContentTextAnnotationsFilePathObject? MessageDeltaContentTextFilePathObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDeltaContentTextFilePathObject))]
#endif
        public bool IsMessageDeltaContentTextFilePathObject => MessageDeltaContentTextFilePathObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem2(global::G.MessageDeltaContentTextAnnotationsFilePathObject value) => new AnnotationsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaContentTextAnnotationsFilePathObject?(AnnotationsItem2 @this) => @this.MessageDeltaContentTextFilePathObject;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem2(global::G.MessageDeltaContentTextAnnotationsFilePathObject? value)
        {
            MessageDeltaContentTextFilePathObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem2(
            global::G.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType? type,
            global::G.MessageDeltaContentTextAnnotationsFileCitationObject? messageDeltaContentTextFileCitationObject,
            global::G.MessageDeltaContentTextAnnotationsFilePathObject? messageDeltaContentTextFilePathObject
            )
        {
            Type = type;

            MessageDeltaContentTextFileCitationObject = messageDeltaContentTextFileCitationObject;
            MessageDeltaContentTextFilePathObject = messageDeltaContentTextFilePathObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageDeltaContentTextFilePathObject as object ??
            MessageDeltaContentTextFileCitationObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageDeltaContentTextFileCitationObject && !IsMessageDeltaContentTextFilePathObject || !IsMessageDeltaContentTextFileCitationObject && IsMessageDeltaContentTextFilePathObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessageDeltaContentTextAnnotationsFileCitationObject?, TResult>? messageDeltaContentTextFileCitationObject = null,
            global::System.Func<global::G.MessageDeltaContentTextAnnotationsFilePathObject?, TResult>? messageDeltaContentTextFilePathObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageDeltaContentTextFileCitationObject && messageDeltaContentTextFileCitationObject != null)
            {
                return messageDeltaContentTextFileCitationObject(MessageDeltaContentTextFileCitationObject!);
            }
            else if (IsMessageDeltaContentTextFilePathObject && messageDeltaContentTextFilePathObject != null)
            {
                return messageDeltaContentTextFilePathObject(MessageDeltaContentTextFilePathObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessageDeltaContentTextAnnotationsFileCitationObject?>? messageDeltaContentTextFileCitationObject = null,
            global::System.Action<global::G.MessageDeltaContentTextAnnotationsFilePathObject?>? messageDeltaContentTextFilePathObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageDeltaContentTextFileCitationObject)
            {
                messageDeltaContentTextFileCitationObject?.Invoke(MessageDeltaContentTextFileCitationObject!);
            }
            else if (IsMessageDeltaContentTextFilePathObject)
            {
                messageDeltaContentTextFilePathObject?.Invoke(MessageDeltaContentTextFilePathObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageDeltaContentTextFileCitationObject,
                typeof(global::G.MessageDeltaContentTextAnnotationsFileCitationObject),
                MessageDeltaContentTextFilePathObject,
                typeof(global::G.MessageDeltaContentTextAnnotationsFilePathObject),
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
        public bool Equals(AnnotationsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaContentTextAnnotationsFileCitationObject?>.Default.Equals(MessageDeltaContentTextFileCitationObject, other.MessageDeltaContentTextFileCitationObject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaContentTextAnnotationsFilePathObject?>.Default.Equals(MessageDeltaContentTextFilePathObject, other.MessageDeltaContentTextFilePathObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnnotationsItem2 obj1, AnnotationsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnnotationsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnnotationsItem2 obj1, AnnotationsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnnotationsItem2 o && Equals(o);
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
        public static global::G.AnnotationsItem2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.AnnotationsItem2),
                jsonSerializerContext) as global::G.AnnotationsItem2?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.AnnotationsItem2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnnotationsItem2>(
                json,
                jsonSerializerOptions);
        }

    }
}
