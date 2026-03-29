//HintName: G.Models.LettaMessageContentUnion.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LettaMessageContentUnion : global::System.IEquatable<LettaMessageContentUnion>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.LettaMessageContentUnionDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextContent? Text { get; init; }
#else
        public global::G.TextContent? Text { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ImageContent? Image { get; init; }
#else
        public global::G.ImageContent? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolCallContent? ToolCall { get; init; }
#else
        public global::G.ToolCallContent? ToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCall))]
#endif
        public bool IsToolCall => ToolCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolReturnContent? ToolReturn { get; init; }
#else
        public global::G.ToolReturnContent? ToolReturn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolReturn))]
#endif
        public bool IsToolReturn => ToolReturn != null;

        /// <summary>
        /// Sent via the Anthropic Messages API
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReasoningContent? Reasoning { get; init; }
#else
        public global::G.ReasoningContent? Reasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reasoning))]
#endif
        public bool IsReasoning => Reasoning != null;

        /// <summary>
        /// Sent via the Anthropic Messages API
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RedactedReasoningContent? RedactedReasoning { get; init; }
#else
        public global::G.RedactedReasoningContent? RedactedReasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RedactedReasoning))]
#endif
        public bool IsRedactedReasoning => RedactedReasoning != null;

        /// <summary>
        /// A placeholder for reasoning content we know is present, but isn't returned by the provider (e.g. OpenAI GPT-5 on ChatCompletions)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OmittedReasoningContent? OmittedReasoning { get; init; }
#else
        public global::G.OmittedReasoningContent? OmittedReasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OmittedReasoning))]
#endif
        public bool IsOmittedReasoning => OmittedReasoning != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LettaMessageContentUnion(global::G.TextContent value) => new LettaMessageContentUnion((global::G.TextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextContent?(LettaMessageContentUnion @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public LettaMessageContentUnion(global::G.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LettaMessageContentUnion(global::G.ImageContent value) => new LettaMessageContentUnion((global::G.ImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageContent?(LettaMessageContentUnion @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public LettaMessageContentUnion(global::G.ImageContent? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LettaMessageContentUnion(global::G.ToolCallContent value) => new LettaMessageContentUnion((global::G.ToolCallContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallContent?(LettaMessageContentUnion @this) => @this.ToolCall;

        /// <summary>
        /// 
        /// </summary>
        public LettaMessageContentUnion(global::G.ToolCallContent? value)
        {
            ToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LettaMessageContentUnion(global::G.ToolReturnContent value) => new LettaMessageContentUnion((global::G.ToolReturnContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolReturnContent?(LettaMessageContentUnion @this) => @this.ToolReturn;

        /// <summary>
        /// 
        /// </summary>
        public LettaMessageContentUnion(global::G.ToolReturnContent? value)
        {
            ToolReturn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LettaMessageContentUnion(global::G.ReasoningContent value) => new LettaMessageContentUnion((global::G.ReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReasoningContent?(LettaMessageContentUnion @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public LettaMessageContentUnion(global::G.ReasoningContent? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LettaMessageContentUnion(global::G.RedactedReasoningContent value) => new LettaMessageContentUnion((global::G.RedactedReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RedactedReasoningContent?(LettaMessageContentUnion @this) => @this.RedactedReasoning;

        /// <summary>
        /// 
        /// </summary>
        public LettaMessageContentUnion(global::G.RedactedReasoningContent? value)
        {
            RedactedReasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LettaMessageContentUnion(global::G.OmittedReasoningContent value) => new LettaMessageContentUnion((global::G.OmittedReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OmittedReasoningContent?(LettaMessageContentUnion @this) => @this.OmittedReasoning;

        /// <summary>
        /// 
        /// </summary>
        public LettaMessageContentUnion(global::G.OmittedReasoningContent? value)
        {
            OmittedReasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LettaMessageContentUnion(
            global::G.LettaMessageContentUnionDiscriminatorType? type,
            global::G.TextContent? text,
            global::G.ImageContent? image,
            global::G.ToolCallContent? toolCall,
            global::G.ToolReturnContent? toolReturn,
            global::G.ReasoningContent? reasoning,
            global::G.RedactedReasoningContent? redactedReasoning,
            global::G.OmittedReasoningContent? omittedReasoning
            )
        {
            Type = type;

            Text = text;
            Image = image;
            ToolCall = toolCall;
            ToolReturn = toolReturn;
            Reasoning = reasoning;
            RedactedReasoning = redactedReasoning;
            OmittedReasoning = omittedReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OmittedReasoning as object ??
            RedactedReasoning as object ??
            Reasoning as object ??
            ToolReturn as object ??
            ToolCall as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            ToolCall?.ToString() ??
            ToolReturn?.ToString() ??
            Reasoning?.ToString() ??
            RedactedReasoning?.ToString() ??
            OmittedReasoning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsReasoning && !IsRedactedReasoning && !IsOmittedReasoning || !IsText && IsImage && !IsToolCall && !IsToolReturn && !IsReasoning && !IsRedactedReasoning && !IsOmittedReasoning || !IsText && !IsImage && IsToolCall && !IsToolReturn && !IsReasoning && !IsRedactedReasoning && !IsOmittedReasoning || !IsText && !IsImage && !IsToolCall && IsToolReturn && !IsReasoning && !IsRedactedReasoning && !IsOmittedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && IsReasoning && !IsRedactedReasoning && !IsOmittedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsReasoning && IsRedactedReasoning && !IsOmittedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsReasoning && !IsRedactedReasoning && IsOmittedReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextContent?, TResult>? text = null,
            global::System.Func<global::G.ImageContent?, TResult>? image = null,
            global::System.Func<global::G.ToolCallContent?, TResult>? toolCall = null,
            global::System.Func<global::G.ToolReturnContent?, TResult>? toolReturn = null,
            global::System.Func<global::G.ReasoningContent?, TResult>? reasoning = null,
            global::System.Func<global::G.RedactedReasoningContent?, TResult>? redactedReasoning = null,
            global::System.Func<global::G.OmittedReasoningContent?, TResult>? omittedReasoning = null,
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
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsToolCall && toolCall != null)
            {
                return toolCall(ToolCall!);
            }
            else if (IsToolReturn && toolReturn != null)
            {
                return toolReturn(ToolReturn!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsRedactedReasoning && redactedReasoning != null)
            {
                return redactedReasoning(RedactedReasoning!);
            }
            else if (IsOmittedReasoning && omittedReasoning != null)
            {
                return omittedReasoning(OmittedReasoning!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextContent?>? text = null,
            global::System.Action<global::G.ImageContent?>? image = null,
            global::System.Action<global::G.ToolCallContent?>? toolCall = null,
            global::System.Action<global::G.ToolReturnContent?>? toolReturn = null,
            global::System.Action<global::G.ReasoningContent?>? reasoning = null,
            global::System.Action<global::G.RedactedReasoningContent?>? redactedReasoning = null,
            global::System.Action<global::G.OmittedReasoningContent?>? omittedReasoning = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsToolCall)
            {
                toolCall?.Invoke(ToolCall!);
            }
            else if (IsToolReturn)
            {
                toolReturn?.Invoke(ToolReturn!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsRedactedReasoning)
            {
                redactedReasoning?.Invoke(RedactedReasoning!);
            }
            else if (IsOmittedReasoning)
            {
                omittedReasoning?.Invoke(OmittedReasoning!);
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
                typeof(global::G.TextContent),
                Image,
                typeof(global::G.ImageContent),
                ToolCall,
                typeof(global::G.ToolCallContent),
                ToolReturn,
                typeof(global::G.ToolReturnContent),
                Reasoning,
                typeof(global::G.ReasoningContent),
                RedactedReasoning,
                typeof(global::G.RedactedReasoningContent),
                OmittedReasoning,
                typeof(global::G.OmittedReasoningContent),
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
        public bool Equals(LettaMessageContentUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageContent?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallContent?>.Default.Equals(ToolCall, other.ToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolReturnContent?>.Default.Equals(ToolReturn, other.ToolReturn) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningContent?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RedactedReasoningContent?>.Default.Equals(RedactedReasoning, other.RedactedReasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OmittedReasoningContent?>.Default.Equals(OmittedReasoning, other.OmittedReasoning) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LettaMessageContentUnion obj1, LettaMessageContentUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LettaMessageContentUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LettaMessageContentUnion obj1, LettaMessageContentUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LettaMessageContentUnion o && Equals(o);
        }
    }
}
