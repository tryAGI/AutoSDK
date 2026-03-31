//HintName: G.Models.ChatCompletionDocumentSource.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The source of the document. Only text and JSON sources are currently supported.
    /// </summary>
    public readonly partial struct ChatCompletionDocumentSource : global::System.IEquatable<ChatCompletionDocumentSource>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ChatCompletionDocumentSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A document whose contents are provided inline as text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionDocumentSourceText? Text { get; init; }
#else
        public global::G.ChatCompletionDocumentSourceText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// A document whose contents are provided inline as JSON data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionDocumentSourceJSON? Json { get; init; }
#else
        public global::G.ChatCompletionDocumentSourceJSON? Json { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Json))]
#endif
        public bool IsJson => Json != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionDocumentSource(global::G.ChatCompletionDocumentSourceText value) => new ChatCompletionDocumentSource((global::G.ChatCompletionDocumentSourceText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionDocumentSourceText?(ChatCompletionDocumentSource @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionDocumentSource(global::G.ChatCompletionDocumentSourceText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionDocumentSource(global::G.ChatCompletionDocumentSourceJSON value) => new ChatCompletionDocumentSource((global::G.ChatCompletionDocumentSourceJSON?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionDocumentSourceJSON?(ChatCompletionDocumentSource @this) => @this.Json;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionDocumentSource(global::G.ChatCompletionDocumentSourceJSON? value)
        {
            Json = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionDocumentSource(
            global::G.ChatCompletionDocumentSourceDiscriminatorType? type,
            global::G.ChatCompletionDocumentSourceText? text,
            global::G.ChatCompletionDocumentSourceJSON? json
            )
        {
            Type = type;

            Text = text;
            Json = json;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Json as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Json?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJson || !IsText && IsJson;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionDocumentSourceText?, TResult>? text = null,
            global::System.Func<global::G.ChatCompletionDocumentSourceJSON?, TResult>? json = null,
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
            else if (IsJson && json != null)
            {
                return json(Json!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionDocumentSourceText?>? text = null,
            global::System.Action<global::G.ChatCompletionDocumentSourceJSON?>? json = null,
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
            else if (IsJson)
            {
                json?.Invoke(Json!);
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
                typeof(global::G.ChatCompletionDocumentSourceText),
                Json,
                typeof(global::G.ChatCompletionDocumentSourceJSON),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChatCompletionDocumentSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionDocumentSourceText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionDocumentSourceJSON?>.Default.Equals(Json, other.Json) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionDocumentSource obj1, ChatCompletionDocumentSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionDocumentSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionDocumentSource obj1, ChatCompletionDocumentSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionDocumentSource o && Equals(o);
        }
    }
}
