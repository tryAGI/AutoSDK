//HintName: G.Models.ModelParams.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ModelParams : global::System.IEquatable<ModelParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelParamsOpenAIModelParams? OpenAIModelParams { get; init; }
#else
        public global::G.ModelParamsOpenAIModelParams? OpenAIModelParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIModelParams))]
#endif
        public bool IsOpenAIModelParams => OpenAIModelParams != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelParamsAnthropicModelParams? AnthropicModelParams { get; init; }
#else
        public global::G.ModelParamsAnthropicModelParams? AnthropicModelParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicModelParams))]
#endif
        public bool IsAnthropicModelParams => AnthropicModelParams != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelParamsGoogleModelParams? GoogleModelParams { get; init; }
#else
        public global::G.ModelParamsGoogleModelParams? GoogleModelParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleModelParams))]
#endif
        public bool IsGoogleModelParams => GoogleModelParams != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelParamsWindowAIModelParams? WindowAIModelParams { get; init; }
#else
        public global::G.ModelParamsWindowAIModelParams? WindowAIModelParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WindowAIModelParams))]
#endif
        public bool IsWindowAIModelParams => WindowAIModelParams != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelParamsJsCompletionParams? JsCompletionParams { get; init; }
#else
        public global::G.ModelParamsJsCompletionParams? JsCompletionParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsCompletionParams))]
#endif
        public bool IsJsCompletionParams => JsCompletionParams != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelParams(global::G.ModelParamsOpenAIModelParams value) => new ModelParams((global::G.ModelParamsOpenAIModelParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelParamsOpenAIModelParams?(ModelParams @this) => @this.OpenAIModelParams;

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(global::G.ModelParamsOpenAIModelParams? value)
        {
            OpenAIModelParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelParams(global::G.ModelParamsAnthropicModelParams value) => new ModelParams((global::G.ModelParamsAnthropicModelParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelParamsAnthropicModelParams?(ModelParams @this) => @this.AnthropicModelParams;

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(global::G.ModelParamsAnthropicModelParams? value)
        {
            AnthropicModelParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelParams(global::G.ModelParamsGoogleModelParams value) => new ModelParams((global::G.ModelParamsGoogleModelParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelParamsGoogleModelParams?(ModelParams @this) => @this.GoogleModelParams;

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(global::G.ModelParamsGoogleModelParams? value)
        {
            GoogleModelParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelParams(global::G.ModelParamsWindowAIModelParams value) => new ModelParams((global::G.ModelParamsWindowAIModelParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelParamsWindowAIModelParams?(ModelParams @this) => @this.WindowAIModelParams;

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(global::G.ModelParamsWindowAIModelParams? value)
        {
            WindowAIModelParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelParams(global::G.ModelParamsJsCompletionParams value) => new ModelParams((global::G.ModelParamsJsCompletionParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelParamsJsCompletionParams?(ModelParams @this) => @this.JsCompletionParams;

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(global::G.ModelParamsJsCompletionParams? value)
        {
            JsCompletionParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelParams(
            global::G.ModelParamsOpenAIModelParams? openAIModelParams,
            global::G.ModelParamsAnthropicModelParams? anthropicModelParams,
            global::G.ModelParamsGoogleModelParams? googleModelParams,
            global::G.ModelParamsWindowAIModelParams? windowAIModelParams,
            global::G.ModelParamsJsCompletionParams? jsCompletionParams
            )
        {
            OpenAIModelParams = openAIModelParams;
            AnthropicModelParams = anthropicModelParams;
            GoogleModelParams = googleModelParams;
            WindowAIModelParams = windowAIModelParams;
            JsCompletionParams = jsCompletionParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsCompletionParams as object ??
            WindowAIModelParams as object ??
            GoogleModelParams as object ??
            AnthropicModelParams as object ??
            OpenAIModelParams as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAIModelParams?.ToString() ??
            AnthropicModelParams?.ToString() ??
            GoogleModelParams?.ToString() ??
            WindowAIModelParams?.ToString() ??
            JsCompletionParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIModelParams || IsAnthropicModelParams || IsGoogleModelParams || IsWindowAIModelParams || IsJsCompletionParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ModelParamsOpenAIModelParams?, TResult>? openAIModelParams = null,
            global::System.Func<global::G.ModelParamsAnthropicModelParams?, TResult>? anthropicModelParams = null,
            global::System.Func<global::G.ModelParamsGoogleModelParams?, TResult>? googleModelParams = null,
            global::System.Func<global::G.ModelParamsWindowAIModelParams?, TResult>? windowAIModelParams = null,
            global::System.Func<global::G.ModelParamsJsCompletionParams?, TResult>? jsCompletionParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIModelParams && openAIModelParams != null)
            {
                return openAIModelParams(OpenAIModelParams!);
            }
            else if (IsAnthropicModelParams && anthropicModelParams != null)
            {
                return anthropicModelParams(AnthropicModelParams!);
            }
            else if (IsGoogleModelParams && googleModelParams != null)
            {
                return googleModelParams(GoogleModelParams!);
            }
            else if (IsWindowAIModelParams && windowAIModelParams != null)
            {
                return windowAIModelParams(WindowAIModelParams!);
            }
            else if (IsJsCompletionParams && jsCompletionParams != null)
            {
                return jsCompletionParams(JsCompletionParams!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ModelParamsOpenAIModelParams?>? openAIModelParams = null,
            global::System.Action<global::G.ModelParamsAnthropicModelParams?>? anthropicModelParams = null,
            global::System.Action<global::G.ModelParamsGoogleModelParams?>? googleModelParams = null,
            global::System.Action<global::G.ModelParamsWindowAIModelParams?>? windowAIModelParams = null,
            global::System.Action<global::G.ModelParamsJsCompletionParams?>? jsCompletionParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIModelParams)
            {
                openAIModelParams?.Invoke(OpenAIModelParams!);
            }
            else if (IsAnthropicModelParams)
            {
                anthropicModelParams?.Invoke(AnthropicModelParams!);
            }
            else if (IsGoogleModelParams)
            {
                googleModelParams?.Invoke(GoogleModelParams!);
            }
            else if (IsWindowAIModelParams)
            {
                windowAIModelParams?.Invoke(WindowAIModelParams!);
            }
            else if (IsJsCompletionParams)
            {
                jsCompletionParams?.Invoke(JsCompletionParams!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIModelParams,
                typeof(global::G.ModelParamsOpenAIModelParams),
                AnthropicModelParams,
                typeof(global::G.ModelParamsAnthropicModelParams),
                GoogleModelParams,
                typeof(global::G.ModelParamsGoogleModelParams),
                WindowAIModelParams,
                typeof(global::G.ModelParamsWindowAIModelParams),
                JsCompletionParams,
                typeof(global::G.ModelParamsJsCompletionParams),
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
        public bool Equals(ModelParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ModelParamsOpenAIModelParams?>.Default.Equals(OpenAIModelParams, other.OpenAIModelParams) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelParamsAnthropicModelParams?>.Default.Equals(AnthropicModelParams, other.AnthropicModelParams) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelParamsGoogleModelParams?>.Default.Equals(GoogleModelParams, other.GoogleModelParams) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelParamsWindowAIModelParams?>.Default.Equals(WindowAIModelParams, other.WindowAIModelParams) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelParamsJsCompletionParams?>.Default.Equals(JsCompletionParams, other.JsCompletionParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelParams obj1, ModelParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelParams obj1, ModelParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelParams o && Equals(o);
        }
    }
}
