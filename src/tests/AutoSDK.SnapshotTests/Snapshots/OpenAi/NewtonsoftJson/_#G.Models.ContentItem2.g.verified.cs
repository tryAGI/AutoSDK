//HintName: G.Models.ContentItem2.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentItem2 : global::System.IEquatable<ContentItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageDeltaObjectDeltaContentItemDiscriminatorType? Type { get; }

        /// <summary>
        /// References an image [File](/docs/api-reference/files) in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaContentImageFileObject? MessageDeltaImageFileObject { get; init; }
#else
        public global::G.MessageDeltaContentImageFileObject? MessageDeltaImageFileObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDeltaImageFileObject))]
#endif
        public bool IsMessageDeltaImageFileObject => MessageDeltaImageFileObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem2(global::G.MessageDeltaContentImageFileObject value) => new ContentItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaContentImageFileObject?(ContentItem2 @this) => @this.MessageDeltaImageFileObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem2(global::G.MessageDeltaContentImageFileObject? value)
        {
            MessageDeltaImageFileObject = value;
        }

        /// <summary>
        /// The text content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaContentTextObject? MessageDeltaTextObject { get; init; }
#else
        public global::G.MessageDeltaContentTextObject? MessageDeltaTextObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDeltaTextObject))]
#endif
        public bool IsMessageDeltaTextObject => MessageDeltaTextObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem2(global::G.MessageDeltaContentTextObject value) => new ContentItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaContentTextObject?(ContentItem2 @this) => @this.MessageDeltaTextObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem2(global::G.MessageDeltaContentTextObject? value)
        {
            MessageDeltaTextObject = value;
        }

        /// <summary>
        /// The refusal content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaContentRefusalObject? MessageDeltaRefusalObject { get; init; }
#else
        public global::G.MessageDeltaContentRefusalObject? MessageDeltaRefusalObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDeltaRefusalObject))]
#endif
        public bool IsMessageDeltaRefusalObject => MessageDeltaRefusalObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem2(global::G.MessageDeltaContentRefusalObject value) => new ContentItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaContentRefusalObject?(ContentItem2 @this) => @this.MessageDeltaRefusalObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem2(global::G.MessageDeltaContentRefusalObject? value)
        {
            MessageDeltaRefusalObject = value;
        }

        /// <summary>
        /// References an image URL in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageDeltaContentImageUrlObject? MessageDeltaImageUrlObject { get; init; }
#else
        public global::G.MessageDeltaContentImageUrlObject? MessageDeltaImageUrlObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDeltaImageUrlObject))]
#endif
        public bool IsMessageDeltaImageUrlObject => MessageDeltaImageUrlObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem2(global::G.MessageDeltaContentImageUrlObject value) => new ContentItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageDeltaContentImageUrlObject?(ContentItem2 @this) => @this.MessageDeltaImageUrlObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem2(global::G.MessageDeltaContentImageUrlObject? value)
        {
            MessageDeltaImageUrlObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentItem2(
            global::G.MessageDeltaObjectDeltaContentItemDiscriminatorType? type,
            global::G.MessageDeltaContentImageFileObject? messageDeltaImageFileObject,
            global::G.MessageDeltaContentTextObject? messageDeltaTextObject,
            global::G.MessageDeltaContentRefusalObject? messageDeltaRefusalObject,
            global::G.MessageDeltaContentImageUrlObject? messageDeltaImageUrlObject
            )
        {
            Type = type;

            MessageDeltaImageFileObject = messageDeltaImageFileObject;
            MessageDeltaTextObject = messageDeltaTextObject;
            MessageDeltaRefusalObject = messageDeltaRefusalObject;
            MessageDeltaImageUrlObject = messageDeltaImageUrlObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageDeltaImageUrlObject as object ??
            MessageDeltaRefusalObject as object ??
            MessageDeltaTextObject as object ??
            MessageDeltaImageFileObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageDeltaImageFileObject && !IsMessageDeltaTextObject && !IsMessageDeltaRefusalObject && !IsMessageDeltaImageUrlObject || !IsMessageDeltaImageFileObject && IsMessageDeltaTextObject && !IsMessageDeltaRefusalObject && !IsMessageDeltaImageUrlObject || !IsMessageDeltaImageFileObject && !IsMessageDeltaTextObject && IsMessageDeltaRefusalObject && !IsMessageDeltaImageUrlObject || !IsMessageDeltaImageFileObject && !IsMessageDeltaTextObject && !IsMessageDeltaRefusalObject && IsMessageDeltaImageUrlObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessageDeltaContentImageFileObject?, TResult>? messageDeltaImageFileObject = null,
            global::System.Func<global::G.MessageDeltaContentTextObject?, TResult>? messageDeltaTextObject = null,
            global::System.Func<global::G.MessageDeltaContentRefusalObject?, TResult>? messageDeltaRefusalObject = null,
            global::System.Func<global::G.MessageDeltaContentImageUrlObject?, TResult>? messageDeltaImageUrlObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageDeltaImageFileObject && messageDeltaImageFileObject != null)
            {
                return messageDeltaImageFileObject(MessageDeltaImageFileObject!);
            }
            else if (IsMessageDeltaTextObject && messageDeltaTextObject != null)
            {
                return messageDeltaTextObject(MessageDeltaTextObject!);
            }
            else if (IsMessageDeltaRefusalObject && messageDeltaRefusalObject != null)
            {
                return messageDeltaRefusalObject(MessageDeltaRefusalObject!);
            }
            else if (IsMessageDeltaImageUrlObject && messageDeltaImageUrlObject != null)
            {
                return messageDeltaImageUrlObject(MessageDeltaImageUrlObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessageDeltaContentImageFileObject?>? messageDeltaImageFileObject = null,
            global::System.Action<global::G.MessageDeltaContentTextObject?>? messageDeltaTextObject = null,
            global::System.Action<global::G.MessageDeltaContentRefusalObject?>? messageDeltaRefusalObject = null,
            global::System.Action<global::G.MessageDeltaContentImageUrlObject?>? messageDeltaImageUrlObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageDeltaImageFileObject)
            {
                messageDeltaImageFileObject?.Invoke(MessageDeltaImageFileObject!);
            }
            else if (IsMessageDeltaTextObject)
            {
                messageDeltaTextObject?.Invoke(MessageDeltaTextObject!);
            }
            else if (IsMessageDeltaRefusalObject)
            {
                messageDeltaRefusalObject?.Invoke(MessageDeltaRefusalObject!);
            }
            else if (IsMessageDeltaImageUrlObject)
            {
                messageDeltaImageUrlObject?.Invoke(MessageDeltaImageUrlObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageDeltaImageFileObject,
                typeof(global::G.MessageDeltaContentImageFileObject),
                MessageDeltaTextObject,
                typeof(global::G.MessageDeltaContentTextObject),
                MessageDeltaRefusalObject,
                typeof(global::G.MessageDeltaContentRefusalObject),
                MessageDeltaImageUrlObject,
                typeof(global::G.MessageDeltaContentImageUrlObject),
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
        public bool Equals(ContentItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaContentImageFileObject?>.Default.Equals(MessageDeltaImageFileObject, other.MessageDeltaImageFileObject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaContentTextObject?>.Default.Equals(MessageDeltaTextObject, other.MessageDeltaTextObject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaContentRefusalObject?>.Default.Equals(MessageDeltaRefusalObject, other.MessageDeltaRefusalObject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageDeltaContentImageUrlObject?>.Default.Equals(MessageDeltaImageUrlObject, other.MessageDeltaImageUrlObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentItem2 obj1, ContentItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentItem2 obj1, ContentItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem2 o && Equals(o);
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
        public static global::G.ContentItem2? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ContentItem2>(
                json,
                jsonSerializerOptions);
        }

    }
}
