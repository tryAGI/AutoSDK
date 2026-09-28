//HintName: G.Models.InvocationParameters.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InvocationParameters : global::System.IEquatable<InvocationParameters>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptVersionInvocationParametersDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptOpenAIInvocationParameters? Openai { get; init; }
#else
        public global::G.PromptOpenAIInvocationParameters? Openai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openai))]
#endif
        public bool IsOpenai => Openai != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenai(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptOpenAIInvocationParameters? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptOpenAIInvocationParameters PickOpenai() => Openai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptAzureOpenAIInvocationParameters? AzureOpenai { get; init; }
#else
        public global::G.PromptAzureOpenAIInvocationParameters? AzureOpenai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureOpenai))]
#endif
        public bool IsAzureOpenai => AzureOpenai != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAzureOpenai(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptAzureOpenAIInvocationParameters? value)
        {
            value = AzureOpenai;
            return IsAzureOpenai;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptAzureOpenAIInvocationParameters PickAzureOpenai() => AzureOpenai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AzureOpenai' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptAnthropicInvocationParameters? Anthropic { get; init; }
#else
        public global::G.PromptAnthropicInvocationParameters? Anthropic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anthropic))]
#endif
        public bool IsAnthropic => Anthropic != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptAnthropicInvocationParameters? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptAnthropicInvocationParameters PickAnthropic() => Anthropic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptGoogleInvocationParameters? Google { get; init; }
#else
        public global::G.PromptGoogleInvocationParameters? Google { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Google))]
#endif
        public bool IsGoogle => Google != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptGoogleInvocationParameters? value)
        {
            value = Google;
            return IsGoogle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptGoogleInvocationParameters PickGoogle() => Google is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Google' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptDeepSeekInvocationParameters? Deepseek { get; init; }
#else
        public global::G.PromptDeepSeekInvocationParameters? Deepseek { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deepseek))]
#endif
        public bool IsDeepseek => Deepseek != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeepseek(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptDeepSeekInvocationParameters? value)
        {
            value = Deepseek;
            return IsDeepseek;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptDeepSeekInvocationParameters PickDeepseek() => Deepseek is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Deepseek' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptXAIInvocationParameters? Xai { get; init; }
#else
        public global::G.PromptXAIInvocationParameters? Xai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Xai))]
#endif
        public bool IsXai => Xai != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickXai(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptXAIInvocationParameters? value)
        {
            value = Xai;
            return IsXai;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptXAIInvocationParameters PickXai() => Xai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Xai' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptOllamaInvocationParameters? Ollama { get; init; }
#else
        public global::G.PromptOllamaInvocationParameters? Ollama { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ollama))]
#endif
        public bool IsOllama => Ollama != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOllama(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptOllamaInvocationParameters? value)
        {
            value = Ollama;
            return IsOllama;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptOllamaInvocationParameters PickOllama() => Ollama is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ollama' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptAwsInvocationParameters? Aws { get; init; }
#else
        public global::G.PromptAwsInvocationParameters? Aws { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Aws))]
#endif
        public bool IsAws => Aws != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAws(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptAwsInvocationParameters? value)
        {
            value = Aws;
            return IsAws;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptAwsInvocationParameters PickAws() => Aws is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aws' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptCerebrasInvocationParameters? Cerebras { get; init; }
#else
        public global::G.PromptCerebrasInvocationParameters? Cerebras { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cerebras))]
#endif
        public bool IsCerebras => Cerebras != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCerebras(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptCerebrasInvocationParameters? value)
        {
            value = Cerebras;
            return IsCerebras;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptCerebrasInvocationParameters PickCerebras() => Cerebras is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cerebras' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptFireworksInvocationParameters? Fireworks { get; init; }
#else
        public global::G.PromptFireworksInvocationParameters? Fireworks { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fireworks))]
#endif
        public bool IsFireworks => Fireworks != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFireworks(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptFireworksInvocationParameters? value)
        {
            value = Fireworks;
            return IsFireworks;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptFireworksInvocationParameters PickFireworks() => Fireworks is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fireworks' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptGroqInvocationParameters? Groq { get; init; }
#else
        public global::G.PromptGroqInvocationParameters? Groq { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Groq))]
#endif
        public bool IsGroq => Groq != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGroq(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptGroqInvocationParameters? value)
        {
            value = Groq;
            return IsGroq;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptGroqInvocationParameters PickGroq() => Groq is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Groq' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptMoonshotInvocationParameters? Moonshot { get; init; }
#else
        public global::G.PromptMoonshotInvocationParameters? Moonshot { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Moonshot))]
#endif
        public bool IsMoonshot => Moonshot != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMoonshot(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptMoonshotInvocationParameters? value)
        {
            value = Moonshot;
            return IsMoonshot;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptMoonshotInvocationParameters PickMoonshot() => Moonshot is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Moonshot' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptPerplexityInvocationParameters? Perplexity { get; init; }
#else
        public global::G.PromptPerplexityInvocationParameters? Perplexity { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Perplexity))]
#endif
        public bool IsPerplexity => Perplexity != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPerplexity(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptPerplexityInvocationParameters? value)
        {
            value = Perplexity;
            return IsPerplexity;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptPerplexityInvocationParameters PickPerplexity() => Perplexity is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Perplexity' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptTogetherInvocationParameters? Together { get; init; }
#else
        public global::G.PromptTogetherInvocationParameters? Together { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Together))]
#endif
        public bool IsTogether => Together != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTogether(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PromptTogetherInvocationParameters? value)
        {
            value = Together;
            return IsTogether;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptTogetherInvocationParameters PickTogether() => Together is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Together' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptOpenAIInvocationParameters value) => new InvocationParameters((global::G.PromptOpenAIInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptOpenAIInvocationParameters?(InvocationParameters @this) => @this.Openai;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptOpenAIInvocationParameters? value)
        {
            Openai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromOpenai(global::G.PromptOpenAIInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptAzureOpenAIInvocationParameters value) => new InvocationParameters((global::G.PromptAzureOpenAIInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptAzureOpenAIInvocationParameters?(InvocationParameters @this) => @this.AzureOpenai;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptAzureOpenAIInvocationParameters? value)
        {
            AzureOpenai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromAzureOpenai(global::G.PromptAzureOpenAIInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptAnthropicInvocationParameters value) => new InvocationParameters((global::G.PromptAnthropicInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptAnthropicInvocationParameters?(InvocationParameters @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptAnthropicInvocationParameters? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromAnthropic(global::G.PromptAnthropicInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptGoogleInvocationParameters value) => new InvocationParameters((global::G.PromptGoogleInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptGoogleInvocationParameters?(InvocationParameters @this) => @this.Google;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptGoogleInvocationParameters? value)
        {
            Google = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromGoogle(global::G.PromptGoogleInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptDeepSeekInvocationParameters value) => new InvocationParameters((global::G.PromptDeepSeekInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptDeepSeekInvocationParameters?(InvocationParameters @this) => @this.Deepseek;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptDeepSeekInvocationParameters? value)
        {
            Deepseek = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromDeepseek(global::G.PromptDeepSeekInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptXAIInvocationParameters value) => new InvocationParameters((global::G.PromptXAIInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptXAIInvocationParameters?(InvocationParameters @this) => @this.Xai;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptXAIInvocationParameters? value)
        {
            Xai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromXai(global::G.PromptXAIInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptOllamaInvocationParameters value) => new InvocationParameters((global::G.PromptOllamaInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptOllamaInvocationParameters?(InvocationParameters @this) => @this.Ollama;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptOllamaInvocationParameters? value)
        {
            Ollama = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromOllama(global::G.PromptOllamaInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptAwsInvocationParameters value) => new InvocationParameters((global::G.PromptAwsInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptAwsInvocationParameters?(InvocationParameters @this) => @this.Aws;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptAwsInvocationParameters? value)
        {
            Aws = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromAws(global::G.PromptAwsInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptCerebrasInvocationParameters value) => new InvocationParameters((global::G.PromptCerebrasInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptCerebrasInvocationParameters?(InvocationParameters @this) => @this.Cerebras;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptCerebrasInvocationParameters? value)
        {
            Cerebras = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromCerebras(global::G.PromptCerebrasInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptFireworksInvocationParameters value) => new InvocationParameters((global::G.PromptFireworksInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptFireworksInvocationParameters?(InvocationParameters @this) => @this.Fireworks;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptFireworksInvocationParameters? value)
        {
            Fireworks = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromFireworks(global::G.PromptFireworksInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptGroqInvocationParameters value) => new InvocationParameters((global::G.PromptGroqInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptGroqInvocationParameters?(InvocationParameters @this) => @this.Groq;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptGroqInvocationParameters? value)
        {
            Groq = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromGroq(global::G.PromptGroqInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptMoonshotInvocationParameters value) => new InvocationParameters((global::G.PromptMoonshotInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptMoonshotInvocationParameters?(InvocationParameters @this) => @this.Moonshot;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptMoonshotInvocationParameters? value)
        {
            Moonshot = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromMoonshot(global::G.PromptMoonshotInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptPerplexityInvocationParameters value) => new InvocationParameters((global::G.PromptPerplexityInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptPerplexityInvocationParameters?(InvocationParameters @this) => @this.Perplexity;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptPerplexityInvocationParameters? value)
        {
            Perplexity = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromPerplexity(global::G.PromptPerplexityInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters(global::G.PromptTogetherInvocationParameters value) => new InvocationParameters((global::G.PromptTogetherInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptTogetherInvocationParameters?(InvocationParameters @this) => @this.Together;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(global::G.PromptTogetherInvocationParameters? value)
        {
            Together = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InvocationParameters FromTogether(global::G.PromptTogetherInvocationParameters? value) => new InvocationParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters(
            global::G.PromptVersionInvocationParametersDiscriminatorType? type,
            global::G.PromptOpenAIInvocationParameters? openai,
            global::G.PromptAzureOpenAIInvocationParameters? azureOpenai,
            global::G.PromptAnthropicInvocationParameters? anthropic,
            global::G.PromptGoogleInvocationParameters? google,
            global::G.PromptDeepSeekInvocationParameters? deepseek,
            global::G.PromptXAIInvocationParameters? xai,
            global::G.PromptOllamaInvocationParameters? ollama,
            global::G.PromptAwsInvocationParameters? aws,
            global::G.PromptCerebrasInvocationParameters? cerebras,
            global::G.PromptFireworksInvocationParameters? fireworks,
            global::G.PromptGroqInvocationParameters? groq,
            global::G.PromptMoonshotInvocationParameters? moonshot,
            global::G.PromptPerplexityInvocationParameters? perplexity,
            global::G.PromptTogetherInvocationParameters? together
            )
        {
            Type = type;

            Openai = openai;
            AzureOpenai = azureOpenai;
            Anthropic = anthropic;
            Google = google;
            Deepseek = deepseek;
            Xai = xai;
            Ollama = ollama;
            Aws = aws;
            Cerebras = cerebras;
            Fireworks = fireworks;
            Groq = groq;
            Moonshot = moonshot;
            Perplexity = perplexity;
            Together = together;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Together as object ??
            Perplexity as object ??
            Moonshot as object ??
            Groq as object ??
            Fireworks as object ??
            Cerebras as object ??
            Aws as object ??
            Ollama as object ??
            Xai as object ??
            Deepseek as object ??
            Google as object ??
            Anthropic as object ??
            AzureOpenai as object ??
            Openai as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Openai?.ToString() ??
            AzureOpenai?.ToString() ??
            Anthropic?.ToString() ??
            Google?.ToString() ??
            Deepseek?.ToString() ??
            Xai?.ToString() ??
            Ollama?.ToString() ??
            Aws?.ToString() ??
            Cerebras?.ToString() ??
            Fireworks?.ToString() ??
            Groq?.ToString() ??
            Moonshot?.ToString() ??
            Perplexity?.ToString() ??
            Together?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && IsGroq && !IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && IsMoonshot && !IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && IsPerplexity && !IsTogether || !IsOpenai && !IsAzureOpenai && !IsAnthropic && !IsGoogle && !IsDeepseek && !IsXai && !IsOllama && !IsAws && !IsCerebras && !IsFireworks && !IsGroq && !IsMoonshot && !IsPerplexity && IsTogether;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PromptOpenAIInvocationParameters, TResult>? openai = null,
            global::System.Func<global::G.PromptAzureOpenAIInvocationParameters, TResult>? azureOpenai = null,
            global::System.Func<global::G.PromptAnthropicInvocationParameters, TResult>? anthropic = null,
            global::System.Func<global::G.PromptGoogleInvocationParameters, TResult>? google = null,
            global::System.Func<global::G.PromptDeepSeekInvocationParameters, TResult>? deepseek = null,
            global::System.Func<global::G.PromptXAIInvocationParameters, TResult>? xai = null,
            global::System.Func<global::G.PromptOllamaInvocationParameters, TResult>? ollama = null,
            global::System.Func<global::G.PromptAwsInvocationParameters, TResult>? aws = null,
            global::System.Func<global::G.PromptCerebrasInvocationParameters, TResult>? cerebras = null,
            global::System.Func<global::G.PromptFireworksInvocationParameters, TResult>? fireworks = null,
            global::System.Func<global::G.PromptGroqInvocationParameters, TResult>? groq = null,
            global::System.Func<global::G.PromptMoonshotInvocationParameters, TResult>? moonshot = null,
            global::System.Func<global::G.PromptPerplexityInvocationParameters, TResult>? perplexity = null,
            global::System.Func<global::G.PromptTogetherInvocationParameters, TResult>? together = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Openai is { } __value0 && openai != null)
            {
                return openai(__value0);
            }
            else if (AzureOpenai is { } __value1 && azureOpenai != null)
            {
                return azureOpenai(__value1);
            }
            else if (Anthropic is { } __value2 && anthropic != null)
            {
                return anthropic(__value2);
            }
            else if (Google is { } __value3 && google != null)
            {
                return google(__value3);
            }
            else if (Deepseek is { } __value4 && deepseek != null)
            {
                return deepseek(__value4);
            }
            else if (Xai is { } __value5 && xai != null)
            {
                return xai(__value5);
            }
            else if (Ollama is { } __value6 && ollama != null)
            {
                return ollama(__value6);
            }
            else if (Aws is { } __value7 && aws != null)
            {
                return aws(__value7);
            }
            else if (Cerebras is { } __value8 && cerebras != null)
            {
                return cerebras(__value8);
            }
            else if (Fireworks is { } __value9 && fireworks != null)
            {
                return fireworks(__value9);
            }
            else if (Groq is { } __value10 && groq != null)
            {
                return groq(__value10);
            }
            else if (Moonshot is { } __value11 && moonshot != null)
            {
                return moonshot(__value11);
            }
            else if (Perplexity is { } __value12 && perplexity != null)
            {
                return perplexity(__value12);
            }
            else if (Together is { } __value13 && together != null)
            {
                return together(__value13);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PromptOpenAIInvocationParameters>? openai = null,

            global::System.Action<global::G.PromptAzureOpenAIInvocationParameters>? azureOpenai = null,

            global::System.Action<global::G.PromptAnthropicInvocationParameters>? anthropic = null,

            global::System.Action<global::G.PromptGoogleInvocationParameters>? google = null,

            global::System.Action<global::G.PromptDeepSeekInvocationParameters>? deepseek = null,

            global::System.Action<global::G.PromptXAIInvocationParameters>? xai = null,

            global::System.Action<global::G.PromptOllamaInvocationParameters>? ollama = null,

            global::System.Action<global::G.PromptAwsInvocationParameters>? aws = null,

            global::System.Action<global::G.PromptCerebrasInvocationParameters>? cerebras = null,

            global::System.Action<global::G.PromptFireworksInvocationParameters>? fireworks = null,

            global::System.Action<global::G.PromptGroqInvocationParameters>? groq = null,

            global::System.Action<global::G.PromptMoonshotInvocationParameters>? moonshot = null,

            global::System.Action<global::G.PromptPerplexityInvocationParameters>? perplexity = null,

            global::System.Action<global::G.PromptTogetherInvocationParameters>? together = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Openai is { } __value0)
            {
                openai?.Invoke(__value0);
            }
            else if (AzureOpenai is { } __value1)
            {
                azureOpenai?.Invoke(__value1);
            }
            else if (Anthropic is { } __value2)
            {
                anthropic?.Invoke(__value2);
            }
            else if (Google is { } __value3)
            {
                google?.Invoke(__value3);
            }
            else if (Deepseek is { } __value4)
            {
                deepseek?.Invoke(__value4);
            }
            else if (Xai is { } __value5)
            {
                xai?.Invoke(__value5);
            }
            else if (Ollama is { } __value6)
            {
                ollama?.Invoke(__value6);
            }
            else if (Aws is { } __value7)
            {
                aws?.Invoke(__value7);
            }
            else if (Cerebras is { } __value8)
            {
                cerebras?.Invoke(__value8);
            }
            else if (Fireworks is { } __value9)
            {
                fireworks?.Invoke(__value9);
            }
            else if (Groq is { } __value10)
            {
                groq?.Invoke(__value10);
            }
            else if (Moonshot is { } __value11)
            {
                moonshot?.Invoke(__value11);
            }
            else if (Perplexity is { } __value12)
            {
                perplexity?.Invoke(__value12);
            }
            else if (Together is { } __value13)
            {
                together?.Invoke(__value13);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.PromptOpenAIInvocationParameters>? openai = null,
            global::System.Action<global::G.PromptAzureOpenAIInvocationParameters>? azureOpenai = null,
            global::System.Action<global::G.PromptAnthropicInvocationParameters>? anthropic = null,
            global::System.Action<global::G.PromptGoogleInvocationParameters>? google = null,
            global::System.Action<global::G.PromptDeepSeekInvocationParameters>? deepseek = null,
            global::System.Action<global::G.PromptXAIInvocationParameters>? xai = null,
            global::System.Action<global::G.PromptOllamaInvocationParameters>? ollama = null,
            global::System.Action<global::G.PromptAwsInvocationParameters>? aws = null,
            global::System.Action<global::G.PromptCerebrasInvocationParameters>? cerebras = null,
            global::System.Action<global::G.PromptFireworksInvocationParameters>? fireworks = null,
            global::System.Action<global::G.PromptGroqInvocationParameters>? groq = null,
            global::System.Action<global::G.PromptMoonshotInvocationParameters>? moonshot = null,
            global::System.Action<global::G.PromptPerplexityInvocationParameters>? perplexity = null,
            global::System.Action<global::G.PromptTogetherInvocationParameters>? together = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Openai is { } __value0)
            {
                openai?.Invoke(__value0);
            }
            else if (AzureOpenai is { } __value1)
            {
                azureOpenai?.Invoke(__value1);
            }
            else if (Anthropic is { } __value2)
            {
                anthropic?.Invoke(__value2);
            }
            else if (Google is { } __value3)
            {
                google?.Invoke(__value3);
            }
            else if (Deepseek is { } __value4)
            {
                deepseek?.Invoke(__value4);
            }
            else if (Xai is { } __value5)
            {
                xai?.Invoke(__value5);
            }
            else if (Ollama is { } __value6)
            {
                ollama?.Invoke(__value6);
            }
            else if (Aws is { } __value7)
            {
                aws?.Invoke(__value7);
            }
            else if (Cerebras is { } __value8)
            {
                cerebras?.Invoke(__value8);
            }
            else if (Fireworks is { } __value9)
            {
                fireworks?.Invoke(__value9);
            }
            else if (Groq is { } __value10)
            {
                groq?.Invoke(__value10);
            }
            else if (Moonshot is { } __value11)
            {
                moonshot?.Invoke(__value11);
            }
            else if (Perplexity is { } __value12)
            {
                perplexity?.Invoke(__value12);
            }
            else if (Together is { } __value13)
            {
                together?.Invoke(__value13);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Openai,
                typeof(global::G.PromptOpenAIInvocationParameters),
                AzureOpenai,
                typeof(global::G.PromptAzureOpenAIInvocationParameters),
                Anthropic,
                typeof(global::G.PromptAnthropicInvocationParameters),
                Google,
                typeof(global::G.PromptGoogleInvocationParameters),
                Deepseek,
                typeof(global::G.PromptDeepSeekInvocationParameters),
                Xai,
                typeof(global::G.PromptXAIInvocationParameters),
                Ollama,
                typeof(global::G.PromptOllamaInvocationParameters),
                Aws,
                typeof(global::G.PromptAwsInvocationParameters),
                Cerebras,
                typeof(global::G.PromptCerebrasInvocationParameters),
                Fireworks,
                typeof(global::G.PromptFireworksInvocationParameters),
                Groq,
                typeof(global::G.PromptGroqInvocationParameters),
                Moonshot,
                typeof(global::G.PromptMoonshotInvocationParameters),
                Perplexity,
                typeof(global::G.PromptPerplexityInvocationParameters),
                Together,
                typeof(global::G.PromptTogetherInvocationParameters),
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
        public bool Equals(InvocationParameters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PromptOpenAIInvocationParameters?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptAzureOpenAIInvocationParameters?>.Default.Equals(AzureOpenai, other.AzureOpenai) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptAnthropicInvocationParameters?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptGoogleInvocationParameters?>.Default.Equals(Google, other.Google) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptDeepSeekInvocationParameters?>.Default.Equals(Deepseek, other.Deepseek) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptXAIInvocationParameters?>.Default.Equals(Xai, other.Xai) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptOllamaInvocationParameters?>.Default.Equals(Ollama, other.Ollama) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptAwsInvocationParameters?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptCerebrasInvocationParameters?>.Default.Equals(Cerebras, other.Cerebras) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptFireworksInvocationParameters?>.Default.Equals(Fireworks, other.Fireworks) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptGroqInvocationParameters?>.Default.Equals(Groq, other.Groq) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptMoonshotInvocationParameters?>.Default.Equals(Moonshot, other.Moonshot) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptPerplexityInvocationParameters?>.Default.Equals(Perplexity, other.Perplexity) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptTogetherInvocationParameters?>.Default.Equals(Together, other.Together) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InvocationParameters obj1, InvocationParameters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InvocationParameters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InvocationParameters obj1, InvocationParameters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InvocationParameters o && Equals(o);
        }
    }
}
