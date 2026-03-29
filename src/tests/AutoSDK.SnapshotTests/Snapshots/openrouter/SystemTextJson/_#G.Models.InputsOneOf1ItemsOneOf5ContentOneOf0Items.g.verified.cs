//HintName: G.Models.InputsOneOf1ItemsOneOf5ContentOneOf0Items.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputsOneOf1ItemsOneOf5ContentOneOf0Items : global::System.IEquatable<InputsOneOf1ItemsOneOf5ContentOneOf0Items>
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
        public static implicit operator InputsOneOf1ItemsOneOf5ContentOneOf0Items(global::G.ResponseOutputText value) => new InputsOneOf1ItemsOneOf5ContentOneOf0Items((global::G.ResponseOutputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputText?(InputsOneOf1ItemsOneOf5ContentOneOf0Items @this) => @this.ResponseOutputText;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1ItemsOneOf5ContentOneOf0Items(global::G.ResponseOutputText? value)
        {
            ResponseOutputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1ItemsOneOf5ContentOneOf0Items(global::G.OpenAIResponsesRefusalContent value) => new InputsOneOf1ItemsOneOf5ContentOneOf0Items((global::G.OpenAIResponsesRefusalContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAIResponsesRefusalContent?(InputsOneOf1ItemsOneOf5ContentOneOf0Items @this) => @this.OpenAIResponsesRefusalContent;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1ItemsOneOf5ContentOneOf0Items(global::G.OpenAIResponsesRefusalContent? value)
        {
            OpenAIResponsesRefusalContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1ItemsOneOf5ContentOneOf0Items(
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
        public bool Equals(InputsOneOf1ItemsOneOf5ContentOneOf0Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputText?>.Default.Equals(ResponseOutputText, other.ResponseOutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAIResponsesRefusalContent?>.Default.Equals(OpenAIResponsesRefusalContent, other.OpenAIResponsesRefusalContent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputsOneOf1ItemsOneOf5ContentOneOf0Items obj1, InputsOneOf1ItemsOneOf5ContentOneOf0Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputsOneOf1ItemsOneOf5ContentOneOf0Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputsOneOf1ItemsOneOf5ContentOneOf0Items obj1, InputsOneOf1ItemsOneOf5ContentOneOf0Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputsOneOf1ItemsOneOf5ContentOneOf0Items o && Equals(o);
        }
    }
}
