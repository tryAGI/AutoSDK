//HintName: G.Models.InputVariant2Item3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputVariant2Item3 : global::System.IEquatable<InputVariant2Item3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType? Type { get; }

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
        public global::G.ReasoningContent? OmittedReasoning1 { get; init; }
#else
        public global::G.ReasoningContent? OmittedReasoning1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OmittedReasoning1))]
#endif
        public bool IsOmittedReasoning1 => OmittedReasoning1 != null;

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
        public global::G.OmittedReasoningContent? OmittedReasoning2 { get; init; }
#else
        public global::G.OmittedReasoningContent? OmittedReasoning2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OmittedReasoning2))]
#endif
        public bool IsOmittedReasoning2 => OmittedReasoning2 != null;

        /// <summary>
        /// The style of reasoning content returned by the OpenAI Responses API
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SummarizedReasoningContent? SummarizedReasoning { get; init; }
#else
        public global::G.SummarizedReasoningContent? SummarizedReasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SummarizedReasoning))]
#endif
        public bool IsSummarizedReasoning => SummarizedReasoning != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant2Item3(global::G.TextContent value) => new InputVariant2Item3((global::G.TextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextContent?(InputVariant2Item3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant2Item3(global::G.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant2Item3(global::G.ImageContent value) => new InputVariant2Item3((global::G.ImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageContent?(InputVariant2Item3 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant2Item3(global::G.ImageContent? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant2Item3(global::G.ToolCallContent value) => new InputVariant2Item3((global::G.ToolCallContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallContent?(InputVariant2Item3 @this) => @this.ToolCall;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant2Item3(global::G.ToolCallContent? value)
        {
            ToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant2Item3(global::G.ToolReturnContent value) => new InputVariant2Item3((global::G.ToolReturnContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolReturnContent?(InputVariant2Item3 @this) => @this.ToolReturn;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant2Item3(global::G.ToolReturnContent? value)
        {
            ToolReturn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant2Item3(global::G.ReasoningContent value) => new InputVariant2Item3((global::G.ReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReasoningContent?(InputVariant2Item3 @this) => @this.OmittedReasoning1;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant2Item3(global::G.ReasoningContent? value)
        {
            OmittedReasoning1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant2Item3(global::G.RedactedReasoningContent value) => new InputVariant2Item3((global::G.RedactedReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RedactedReasoningContent?(InputVariant2Item3 @this) => @this.RedactedReasoning;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant2Item3(global::G.RedactedReasoningContent? value)
        {
            RedactedReasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant2Item3(global::G.OmittedReasoningContent value) => new InputVariant2Item3((global::G.OmittedReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OmittedReasoningContent?(InputVariant2Item3 @this) => @this.OmittedReasoning2;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant2Item3(global::G.OmittedReasoningContent? value)
        {
            OmittedReasoning2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant2Item3(global::G.SummarizedReasoningContent value) => new InputVariant2Item3((global::G.SummarizedReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SummarizedReasoningContent?(InputVariant2Item3 @this) => @this.SummarizedReasoning;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant2Item3(global::G.SummarizedReasoningContent? value)
        {
            SummarizedReasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputVariant2Item3(
            global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType? type,
            global::G.TextContent? text,
            global::G.ImageContent? image,
            global::G.ToolCallContent? toolCall,
            global::G.ToolReturnContent? toolReturn,
            global::G.ReasoningContent? omittedReasoning1,
            global::G.RedactedReasoningContent? redactedReasoning,
            global::G.OmittedReasoningContent? omittedReasoning2,
            global::G.SummarizedReasoningContent? summarizedReasoning
            )
        {
            Type = type;

            Text = text;
            Image = image;
            ToolCall = toolCall;
            ToolReturn = toolReturn;
            OmittedReasoning1 = omittedReasoning1;
            RedactedReasoning = redactedReasoning;
            OmittedReasoning2 = omittedReasoning2;
            SummarizedReasoning = summarizedReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SummarizedReasoning as object ??
            OmittedReasoning2 as object ??
            RedactedReasoning as object ??
            OmittedReasoning1 as object ??
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
            OmittedReasoning1?.ToString() ??
            RedactedReasoning?.ToString() ??
            OmittedReasoning2?.ToString() ??
            SummarizedReasoning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && IsImage && !IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && !IsToolCall && IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && IsSummarizedReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextContent?, TResult>? text = null,
            global::System.Func<global::G.ImageContent?, TResult>? image = null,
            global::System.Func<global::G.ToolCallContent?, TResult>? toolCall = null,
            global::System.Func<global::G.ToolReturnContent?, TResult>? toolReturn = null,
            global::System.Func<global::G.ReasoningContent?, TResult>? omittedReasoning1 = null,
            global::System.Func<global::G.RedactedReasoningContent?, TResult>? redactedReasoning = null,
            global::System.Func<global::G.OmittedReasoningContent?, TResult>? omittedReasoning2 = null,
            global::System.Func<global::G.SummarizedReasoningContent?, TResult>? summarizedReasoning = null,
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
            else if (IsOmittedReasoning1 && omittedReasoning1 != null)
            {
                return omittedReasoning1(OmittedReasoning1!);
            }
            else if (IsRedactedReasoning && redactedReasoning != null)
            {
                return redactedReasoning(RedactedReasoning!);
            }
            else if (IsOmittedReasoning2 && omittedReasoning2 != null)
            {
                return omittedReasoning2(OmittedReasoning2!);
            }
            else if (IsSummarizedReasoning && summarizedReasoning != null)
            {
                return summarizedReasoning(SummarizedReasoning!);
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
            global::System.Action<global::G.ReasoningContent?>? omittedReasoning1 = null,
            global::System.Action<global::G.RedactedReasoningContent?>? redactedReasoning = null,
            global::System.Action<global::G.OmittedReasoningContent?>? omittedReasoning2 = null,
            global::System.Action<global::G.SummarizedReasoningContent?>? summarizedReasoning = null,
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
            else if (IsOmittedReasoning1)
            {
                omittedReasoning1?.Invoke(OmittedReasoning1!);
            }
            else if (IsRedactedReasoning)
            {
                redactedReasoning?.Invoke(RedactedReasoning!);
            }
            else if (IsOmittedReasoning2)
            {
                omittedReasoning2?.Invoke(OmittedReasoning2!);
            }
            else if (IsSummarizedReasoning)
            {
                summarizedReasoning?.Invoke(SummarizedReasoning!);
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
                OmittedReasoning1,
                typeof(global::G.ReasoningContent),
                RedactedReasoning,
                typeof(global::G.RedactedReasoningContent),
                OmittedReasoning2,
                typeof(global::G.OmittedReasoningContent),
                SummarizedReasoning,
                typeof(global::G.SummarizedReasoningContent),
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
        public bool Equals(InputVariant2Item3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageContent?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallContent?>.Default.Equals(ToolCall, other.ToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolReturnContent?>.Default.Equals(ToolReturn, other.ToolReturn) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningContent?>.Default.Equals(OmittedReasoning1, other.OmittedReasoning1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RedactedReasoningContent?>.Default.Equals(RedactedReasoning, other.RedactedReasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OmittedReasoningContent?>.Default.Equals(OmittedReasoning2, other.OmittedReasoning2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SummarizedReasoningContent?>.Default.Equals(SummarizedReasoning, other.SummarizedReasoning) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputVariant2Item3 obj1, InputVariant2Item3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputVariant2Item3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputVariant2Item3 obj1, InputVariant2Item3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputVariant2Item3 o && Equals(o);
        }
    }
}
