//HintName: G.Models.BlockDelta.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A delta in a streaming message.
    /// </summary>
    public readonly partial struct BlockDelta : global::System.IEquatable<BlockDelta>
    {
        /// <summary>
        /// A delta in a streaming text block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextBlockDelta? Text { get; init; }
#else
        public global::G.TextBlockDelta? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlockDelta(global::G.TextBlockDelta value) => new BlockDelta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextBlockDelta?(BlockDelta @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BlockDelta(global::G.TextBlockDelta? value)
        {
            Text = value;
        }

        /// <summary>
        /// A delta in a streaming input JSON.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputJsonBlockDelta? InputJson { get; init; }
#else
        public global::G.InputJsonBlockDelta? InputJson { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputJson))]
#endif
        public bool IsInputJson => InputJson != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlockDelta(global::G.InputJsonBlockDelta value) => new BlockDelta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputJsonBlockDelta?(BlockDelta @this) => @this.InputJson;

        /// <summary>
        /// 
        /// </summary>
        public BlockDelta(global::G.InputJsonBlockDelta? value)
        {
            InputJson = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BlockDelta(
            global::G.TextBlockDelta? text,
            global::G.InputJsonBlockDelta? inputJson
            )
        {
            Text = text;
            InputJson = inputJson;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputJson as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsInputJson || !IsText && IsInputJson;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextBlockDelta?, TResult>? text = null,
            global::System.Func<global::G.InputJsonBlockDelta?, TResult>? inputJson = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsInputJson && inputJson != null)
            {
                return inputJson(InputJson!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextBlockDelta?>? text = null,
            global::System.Action<global::G.InputJsonBlockDelta?>? inputJson = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsInputJson)
            {
                inputJson?.Invoke(InputJson!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.TextBlockDelta),
                InputJson,
                typeof(global::G.InputJsonBlockDelta),
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
        public bool Equals(BlockDelta other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextBlockDelta?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputJsonBlockDelta?>.Default.Equals(InputJson, other.InputJson) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BlockDelta obj1, BlockDelta obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BlockDelta>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BlockDelta obj1, BlockDelta obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BlockDelta o && Equals(o);
        }


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
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

        public static global::G.BlockDelta? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.BlockDelta),
                jsonSerializerContext) as global::G.BlockDelta?;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BlockDelta? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.BlockDelta>(
                json,
                jsonSerializerOptions);
        }

    }
}
