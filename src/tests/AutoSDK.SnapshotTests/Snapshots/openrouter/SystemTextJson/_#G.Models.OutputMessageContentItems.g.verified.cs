//HintName: G.Models.OutputMessageContentItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputMessageContentItems : global::System.IEquatable<OutputMessageContentItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputText? ResponseOutputText { get; init; }
#else
        public global::G.ResponseOutputText? ResponseOutputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputText))]
#endif
        public bool IsResponseOutputText => ResponseOutputText != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAIResponsesRefusalContent? OpenAIResponsesRefusalContent { get; init; }
#else
        public global::G.OpenAIResponsesRefusalContent? OpenAIResponsesRefusalContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponsesRefusalContent))]
#endif
        public bool IsOpenAIResponsesRefusalContent => OpenAIResponsesRefusalContent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageContentItems(global::G.ResponseOutputText value) => new OutputMessageContentItems((global::G.ResponseOutputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputText?(OutputMessageContentItems @this) => @this.ResponseOutputText;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageContentItems(global::G.ResponseOutputText? value)
        {
            ResponseOutputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageContentItems(global::G.OpenAIResponsesRefusalContent value) => new OutputMessageContentItems((global::G.OpenAIResponsesRefusalContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAIResponsesRefusalContent?(OutputMessageContentItems @this) => @this.OpenAIResponsesRefusalContent;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageContentItems(global::G.OpenAIResponsesRefusalContent? value)
        {
            OpenAIResponsesRefusalContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageContentItems(
            global::G.ResponseOutputText? responseOutputText,
            global::G.OpenAIResponsesRefusalContent? openAIResponsesRefusalContent
            )
        {
            ResponseOutputText = responseOutputText;
            OpenAIResponsesRefusalContent = openAIResponsesRefusalContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAIResponsesRefusalContent as object ??
            ResponseOutputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseOutputText?.ToString() ??
            OpenAIResponsesRefusalContent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseOutputText && !IsOpenAIResponsesRefusalContent || !IsResponseOutputText && IsOpenAIResponsesRefusalContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseOutputText?, TResult>? responseOutputText = null,
            global::System.Func<global::G.OpenAIResponsesRefusalContent?, TResult>? openAIResponsesRefusalContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseOutputText && responseOutputText != null)
            {
                return responseOutputText(ResponseOutputText!);
            }
            else if (IsOpenAIResponsesRefusalContent && openAIResponsesRefusalContent != null)
            {
                return openAIResponsesRefusalContent(OpenAIResponsesRefusalContent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseOutputText?>? responseOutputText = null,
            global::System.Action<global::G.OpenAIResponsesRefusalContent?>? openAIResponsesRefusalContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseOutputText)
            {
                responseOutputText?.Invoke(ResponseOutputText!);
            }
            else if (IsOpenAIResponsesRefusalContent)
            {
                openAIResponsesRefusalContent?.Invoke(OpenAIResponsesRefusalContent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseOutputText,
                typeof(global::G.ResponseOutputText),
                OpenAIResponsesRefusalContent,
                typeof(global::G.OpenAIResponsesRefusalContent),
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
        public bool Equals(OutputMessageContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputText?>.Default.Equals(ResponseOutputText, other.ResponseOutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAIResponsesRefusalContent?>.Default.Equals(OpenAIResponsesRefusalContent, other.OpenAIResponsesRefusalContent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputMessageContentItems obj1, OutputMessageContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputMessageContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputMessageContentItems obj1, OutputMessageContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputMessageContentItems o && Equals(o);
        }
    }
}
