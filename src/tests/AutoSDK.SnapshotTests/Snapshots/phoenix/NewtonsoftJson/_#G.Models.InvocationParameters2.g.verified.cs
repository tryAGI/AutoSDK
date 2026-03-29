//HintName: G.Models.InvocationParameters2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InvocationParameters2 : global::System.IEquatable<InvocationParameters2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptVersionDataInvocationParametersDiscriminatorType? Type { get; }

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
        public static implicit operator InvocationParameters2(global::G.PromptOpenAIInvocationParameters value) => new InvocationParameters2((global::G.PromptOpenAIInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptOpenAIInvocationParameters?(InvocationParameters2 @this) => @this.Openai;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptOpenAIInvocationParameters? value)
        {
            Openai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptAzureOpenAIInvocationParameters value) => new InvocationParameters2((global::G.PromptAzureOpenAIInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptAzureOpenAIInvocationParameters?(InvocationParameters2 @this) => @this.AzureOpenai;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptAzureOpenAIInvocationParameters? value)
        {
            AzureOpenai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptAnthropicInvocationParameters value) => new InvocationParameters2((global::G.PromptAnthropicInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptAnthropicInvocationParameters?(InvocationParameters2 @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptAnthropicInvocationParameters? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptGoogleInvocationParameters value) => new InvocationParameters2((global::G.PromptGoogleInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptGoogleInvocationParameters?(InvocationParameters2 @this) => @this.Google;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptGoogleInvocationParameters? value)
        {
            Google = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptDeepSeekInvocationParameters value) => new InvocationParameters2((global::G.PromptDeepSeekInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptDeepSeekInvocationParameters?(InvocationParameters2 @this) => @this.Deepseek;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptDeepSeekInvocationParameters? value)
        {
            Deepseek = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptXAIInvocationParameters value) => new InvocationParameters2((global::G.PromptXAIInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptXAIInvocationParameters?(InvocationParameters2 @this) => @this.Xai;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptXAIInvocationParameters? value)
        {
            Xai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptOllamaInvocationParameters value) => new InvocationParameters2((global::G.PromptOllamaInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptOllamaInvocationParameters?(InvocationParameters2 @this) => @this.Ollama;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptOllamaInvocationParameters? value)
        {
            Ollama = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptAwsInvocationParameters value) => new InvocationParameters2((global::G.PromptAwsInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptAwsInvocationParameters?(InvocationParameters2 @this) => @this.Aws;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptAwsInvocationParameters? value)
        {
            Aws = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptCerebrasInvocationParameters value) => new InvocationParameters2((global::G.PromptCerebrasInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptCerebrasInvocationParameters?(InvocationParameters2 @this) => @this.Cerebras;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptCerebrasInvocationParameters? value)
        {
            Cerebras = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptFireworksInvocationParameters value) => new InvocationParameters2((global::G.PromptFireworksInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptFireworksInvocationParameters?(InvocationParameters2 @this) => @this.Fireworks;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptFireworksInvocationParameters? value)
        {
            Fireworks = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptGroqInvocationParameters value) => new InvocationParameters2((global::G.PromptGroqInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptGroqInvocationParameters?(InvocationParameters2 @this) => @this.Groq;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptGroqInvocationParameters? value)
        {
            Groq = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptMoonshotInvocationParameters value) => new InvocationParameters2((global::G.PromptMoonshotInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptMoonshotInvocationParameters?(InvocationParameters2 @this) => @this.Moonshot;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptMoonshotInvocationParameters? value)
        {
            Moonshot = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptPerplexityInvocationParameters value) => new InvocationParameters2((global::G.PromptPerplexityInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptPerplexityInvocationParameters?(InvocationParameters2 @this) => @this.Perplexity;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptPerplexityInvocationParameters? value)
        {
            Perplexity = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvocationParameters2(global::G.PromptTogetherInvocationParameters value) => new InvocationParameters2((global::G.PromptTogetherInvocationParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptTogetherInvocationParameters?(InvocationParameters2 @this) => @this.Together;

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(global::G.PromptTogetherInvocationParameters? value)
        {
            Together = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InvocationParameters2(
            global::G.PromptVersionDataInvocationParametersDiscriminatorType? type,
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
            global::System.Func<global::G.PromptOpenAIInvocationParameters?, TResult>? openai = null,
            global::System.Func<global::G.PromptAzureOpenAIInvocationParameters?, TResult>? azureOpenai = null,
            global::System.Func<global::G.PromptAnthropicInvocationParameters?, TResult>? anthropic = null,
            global::System.Func<global::G.PromptGoogleInvocationParameters?, TResult>? google = null,
            global::System.Func<global::G.PromptDeepSeekInvocationParameters?, TResult>? deepseek = null,
            global::System.Func<global::G.PromptXAIInvocationParameters?, TResult>? xai = null,
            global::System.Func<global::G.PromptOllamaInvocationParameters?, TResult>? ollama = null,
            global::System.Func<global::G.PromptAwsInvocationParameters?, TResult>? aws = null,
            global::System.Func<global::G.PromptCerebrasInvocationParameters?, TResult>? cerebras = null,
            global::System.Func<global::G.PromptFireworksInvocationParameters?, TResult>? fireworks = null,
            global::System.Func<global::G.PromptGroqInvocationParameters?, TResult>? groq = null,
            global::System.Func<global::G.PromptMoonshotInvocationParameters?, TResult>? moonshot = null,
            global::System.Func<global::G.PromptPerplexityInvocationParameters?, TResult>? perplexity = null,
            global::System.Func<global::G.PromptTogetherInvocationParameters?, TResult>? together = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenai && openai != null)
            {
                return openai(Openai!);
            }
            else if (IsAzureOpenai && azureOpenai != null)
            {
                return azureOpenai(AzureOpenai!);
            }
            else if (IsAnthropic && anthropic != null)
            {
                return anthropic(Anthropic!);
            }
            else if (IsGoogle && google != null)
            {
                return google(Google!);
            }
            else if (IsDeepseek && deepseek != null)
            {
                return deepseek(Deepseek!);
            }
            else if (IsXai && xai != null)
            {
                return xai(Xai!);
            }
            else if (IsOllama && ollama != null)
            {
                return ollama(Ollama!);
            }
            else if (IsAws && aws != null)
            {
                return aws(Aws!);
            }
            else if (IsCerebras && cerebras != null)
            {
                return cerebras(Cerebras!);
            }
            else if (IsFireworks && fireworks != null)
            {
                return fireworks(Fireworks!);
            }
            else if (IsGroq && groq != null)
            {
                return groq(Groq!);
            }
            else if (IsMoonshot && moonshot != null)
            {
                return moonshot(Moonshot!);
            }
            else if (IsPerplexity && perplexity != null)
            {
                return perplexity(Perplexity!);
            }
            else if (IsTogether && together != null)
            {
                return together(Together!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PromptOpenAIInvocationParameters?>? openai = null,
            global::System.Action<global::G.PromptAzureOpenAIInvocationParameters?>? azureOpenai = null,
            global::System.Action<global::G.PromptAnthropicInvocationParameters?>? anthropic = null,
            global::System.Action<global::G.PromptGoogleInvocationParameters?>? google = null,
            global::System.Action<global::G.PromptDeepSeekInvocationParameters?>? deepseek = null,
            global::System.Action<global::G.PromptXAIInvocationParameters?>? xai = null,
            global::System.Action<global::G.PromptOllamaInvocationParameters?>? ollama = null,
            global::System.Action<global::G.PromptAwsInvocationParameters?>? aws = null,
            global::System.Action<global::G.PromptCerebrasInvocationParameters?>? cerebras = null,
            global::System.Action<global::G.PromptFireworksInvocationParameters?>? fireworks = null,
            global::System.Action<global::G.PromptGroqInvocationParameters?>? groq = null,
            global::System.Action<global::G.PromptMoonshotInvocationParameters?>? moonshot = null,
            global::System.Action<global::G.PromptPerplexityInvocationParameters?>? perplexity = null,
            global::System.Action<global::G.PromptTogetherInvocationParameters?>? together = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenai)
            {
                openai?.Invoke(Openai!);
            }
            else if (IsAzureOpenai)
            {
                azureOpenai?.Invoke(AzureOpenai!);
            }
            else if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
            else if (IsGoogle)
            {
                google?.Invoke(Google!);
            }
            else if (IsDeepseek)
            {
                deepseek?.Invoke(Deepseek!);
            }
            else if (IsXai)
            {
                xai?.Invoke(Xai!);
            }
            else if (IsOllama)
            {
                ollama?.Invoke(Ollama!);
            }
            else if (IsAws)
            {
                aws?.Invoke(Aws!);
            }
            else if (IsCerebras)
            {
                cerebras?.Invoke(Cerebras!);
            }
            else if (IsFireworks)
            {
                fireworks?.Invoke(Fireworks!);
            }
            else if (IsGroq)
            {
                groq?.Invoke(Groq!);
            }
            else if (IsMoonshot)
            {
                moonshot?.Invoke(Moonshot!);
            }
            else if (IsPerplexity)
            {
                perplexity?.Invoke(Perplexity!);
            }
            else if (IsTogether)
            {
                together?.Invoke(Together!);
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
        public bool Equals(InvocationParameters2 other)
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
        public static bool operator ==(InvocationParameters2 obj1, InvocationParameters2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InvocationParameters2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InvocationParameters2 obj1, InvocationParameters2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InvocationParameters2 o && Equals(o);
        }
    }
}
