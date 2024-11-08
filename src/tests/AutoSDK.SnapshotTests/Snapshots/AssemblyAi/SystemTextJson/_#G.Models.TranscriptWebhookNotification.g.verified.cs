//HintName: G.Models.TranscriptWebhookNotification.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The notifications sent to the webhook URL.
    /// </summary>
    public readonly partial struct TranscriptWebhookNotification : global::System.IEquatable<TranscriptWebhookNotification>
    {
        /// <summary>
        /// The notification when the transcript status is completed or error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranscriptReadyNotification? Ready { get; init; }
#else
        public global::G.TranscriptReadyNotification? Ready { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ready))]
#endif
        public bool IsReady => Ready != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptWebhookNotification(global::G.TranscriptReadyNotification value) => new TranscriptWebhookNotification(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranscriptReadyNotification?(TranscriptWebhookNotification @this) => @this.Ready;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptWebhookNotification(global::G.TranscriptReadyNotification? value)
        {
            Ready = value;
        }

        /// <summary>
        /// The notification when the redacted audio is ready.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RedactedAudioNotification? RedactedAudio { get; init; }
#else
        public global::G.RedactedAudioNotification? RedactedAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RedactedAudio))]
#endif
        public bool IsRedactedAudio => RedactedAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptWebhookNotification(global::G.RedactedAudioNotification value) => new TranscriptWebhookNotification(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RedactedAudioNotification?(TranscriptWebhookNotification @this) => @this.RedactedAudio;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptWebhookNotification(global::G.RedactedAudioNotification? value)
        {
            RedactedAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptWebhookNotification(
            global::G.TranscriptReadyNotification? ready,
            global::G.RedactedAudioNotification? redactedAudio
            )
        {
            Ready = ready;
            RedactedAudio = redactedAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RedactedAudio as object ??
            Ready as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReady && !IsRedactedAudio || !IsReady && IsRedactedAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TranscriptReadyNotification?, TResult>? ready = null,
            global::System.Func<global::G.RedactedAudioNotification?, TResult>? redactedAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReady && ready != null)
            {
                return ready(Ready!);
            }
            else if (IsRedactedAudio && redactedAudio != null)
            {
                return redactedAudio(RedactedAudio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TranscriptReadyNotification?>? ready = null,
            global::System.Action<global::G.RedactedAudioNotification?>? redactedAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReady)
            {
                ready?.Invoke(Ready!);
            }
            else if (IsRedactedAudio)
            {
                redactedAudio?.Invoke(RedactedAudio!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Ready,
                typeof(global::G.TranscriptReadyNotification),
                RedactedAudio,
                typeof(global::G.RedactedAudioNotification),
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
        public bool Equals(TranscriptWebhookNotification other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TranscriptReadyNotification?>.Default.Equals(Ready, other.Ready) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RedactedAudioNotification?>.Default.Equals(RedactedAudio, other.RedactedAudio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TranscriptWebhookNotification obj1, TranscriptWebhookNotification obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranscriptWebhookNotification>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TranscriptWebhookNotification obj1, TranscriptWebhookNotification obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranscriptWebhookNotification o && Equals(o);
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
        public static global::G.TranscriptWebhookNotification? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.TranscriptWebhookNotification),
                jsonSerializerContext) as global::G.TranscriptWebhookNotification?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.TranscriptWebhookNotification? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranscriptWebhookNotification>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.TranscriptWebhookNotification?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.TranscriptWebhookNotification),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.TranscriptWebhookNotification?;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.TranscriptWebhookNotification?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.TranscriptWebhookNotification?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
