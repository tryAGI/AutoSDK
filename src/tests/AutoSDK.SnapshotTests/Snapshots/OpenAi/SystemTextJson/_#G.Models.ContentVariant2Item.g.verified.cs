//HintName: G.Models.ContentVariant2Item.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant2Item : global::System.IEquatable<ContentVariant2Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMessageRequestContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// References an image [File](/docs/api-reference/files) in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageContentImageFileObject? MessageImageFileObject { get; init; }
#else
        public global::G.MessageContentImageFileObject? MessageImageFileObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageImageFileObject))]
#endif
        public bool IsMessageImageFileObject => MessageImageFileObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::G.MessageContentImageFileObject value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageContentImageFileObject?(ContentVariant2Item @this) => @this.MessageImageFileObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.MessageContentImageFileObject? value)
        {
            MessageImageFileObject = value;
        }

        /// <summary>
        /// References an image URL in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageContentImageUrlObject? MessageImageUrlObject { get; init; }
#else
        public global::G.MessageContentImageUrlObject? MessageImageUrlObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageImageUrlObject))]
#endif
        public bool IsMessageImageUrlObject => MessageImageUrlObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::G.MessageContentImageUrlObject value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageContentImageUrlObject?(ContentVariant2Item @this) => @this.MessageImageUrlObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.MessageContentImageUrlObject? value)
        {
            MessageImageUrlObject = value;
        }

        /// <summary>
        /// The text content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageRequestContentTextObject? MessageRequestTextObject { get; init; }
#else
        public global::G.MessageRequestContentTextObject? MessageRequestTextObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageRequestTextObject))]
#endif
        public bool IsMessageRequestTextObject => MessageRequestTextObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::G.MessageRequestContentTextObject value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageRequestContentTextObject?(ContentVariant2Item @this) => @this.MessageRequestTextObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::G.MessageRequestContentTextObject? value)
        {
            MessageRequestTextObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(
            global::G.CreateMessageRequestContentVariant2ItemDiscriminatorType? type,
            global::G.MessageContentImageFileObject? messageImageFileObject,
            global::G.MessageContentImageUrlObject? messageImageUrlObject,
            global::G.MessageRequestContentTextObject? messageRequestTextObject
            )
        {
            Type = type;

            MessageImageFileObject = messageImageFileObject;
            MessageImageUrlObject = messageImageUrlObject;
            MessageRequestTextObject = messageRequestTextObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageRequestTextObject as object ??
            MessageImageUrlObject as object ??
            MessageImageFileObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageImageFileObject && !IsMessageImageUrlObject && !IsMessageRequestTextObject || !IsMessageImageFileObject && IsMessageImageUrlObject && !IsMessageRequestTextObject || !IsMessageImageFileObject && !IsMessageImageUrlObject && IsMessageRequestTextObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessageContentImageFileObject?, TResult>? messageImageFileObject = null,
            global::System.Func<global::G.MessageContentImageUrlObject?, TResult>? messageImageUrlObject = null,
            global::System.Func<global::G.MessageRequestContentTextObject?, TResult>? messageRequestTextObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageImageFileObject && messageImageFileObject != null)
            {
                return messageImageFileObject(MessageImageFileObject!);
            }
            else if (IsMessageImageUrlObject && messageImageUrlObject != null)
            {
                return messageImageUrlObject(MessageImageUrlObject!);
            }
            else if (IsMessageRequestTextObject && messageRequestTextObject != null)
            {
                return messageRequestTextObject(MessageRequestTextObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessageContentImageFileObject?>? messageImageFileObject = null,
            global::System.Action<global::G.MessageContentImageUrlObject?>? messageImageUrlObject = null,
            global::System.Action<global::G.MessageRequestContentTextObject?>? messageRequestTextObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageImageFileObject)
            {
                messageImageFileObject?.Invoke(MessageImageFileObject!);
            }
            else if (IsMessageImageUrlObject)
            {
                messageImageUrlObject?.Invoke(MessageImageUrlObject!);
            }
            else if (IsMessageRequestTextObject)
            {
                messageRequestTextObject?.Invoke(MessageRequestTextObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageImageFileObject,
                typeof(global::G.MessageContentImageFileObject),
                MessageImageUrlObject,
                typeof(global::G.MessageContentImageUrlObject),
                MessageRequestTextObject,
                typeof(global::G.MessageRequestContentTextObject),
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
        public bool Equals(ContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageContentImageFileObject?>.Default.Equals(MessageImageFileObject, other.MessageImageFileObject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageContentImageUrlObject?>.Default.Equals(MessageImageUrlObject, other.MessageImageUrlObject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageRequestContentTextObject?>.Default.Equals(MessageRequestTextObject, other.MessageRequestTextObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item o && Equals(o);
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
        public static global::G.ContentVariant2Item? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ContentVariant2Item),
                jsonSerializerContext) as global::G.ContentVariant2Item?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ContentVariant2Item? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContentVariant2Item>(
                json,
                jsonSerializerOptions);
        }

    }
}
