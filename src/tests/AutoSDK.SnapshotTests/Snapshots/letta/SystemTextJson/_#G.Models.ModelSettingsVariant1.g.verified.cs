//HintName: G.Models.ModelSettingsVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ModelSettingsVariant1 : global::System.IEquatable<ModelSettingsVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentStateModelSettingsVariant1DiscriminatorProviderType? ProviderType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAIModelSettings? Openai { get; init; }
#else
        public global::G.OpenAIModelSettings? Openai { get; }
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
        public global::G.AnthropicModelSettings? Anthropic { get; init; }
#else
        public global::G.AnthropicModelSettings? Anthropic { get; }
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
        public global::G.GoogleAIModelSettings? GoogleAi { get; init; }
#else
        public global::G.GoogleAIModelSettings? GoogleAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleAi))]
#endif
        public bool IsGoogleAi => GoogleAi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GoogleVertexModelSettings? GoogleVertex { get; init; }
#else
        public global::G.GoogleVertexModelSettings? GoogleVertex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleVertex))]
#endif
        public bool IsGoogleVertex => GoogleVertex != null;

        /// <summary>
        /// Azure OpenAI model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AzureModelSettings? Azure { get; init; }
#else
        public global::G.AzureModelSettings? Azure { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Azure))]
#endif
        public bool IsAzure => Azure != null;

        /// <summary>
        /// xAI model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.XAIModelSettings? Xai { get; init; }
#else
        public global::G.XAIModelSettings? Xai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Xai))]
#endif
        public bool IsXai => Xai != null;

        /// <summary>
        /// Z.ai (ZhipuAI) model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ZAIModelSettings? Zai { get; init; }
#else
        public global::G.ZAIModelSettings? Zai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Zai))]
#endif
        public bool IsZai => Zai != null;

        /// <summary>
        /// Groq model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GroqModelSettings? Groq { get; init; }
#else
        public global::G.GroqModelSettings? Groq { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Groq))]
#endif
        public bool IsGroq => Groq != null;

        /// <summary>
        /// Deepseek model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DeepseekModelSettings? Deepseek { get; init; }
#else
        public global::G.DeepseekModelSettings? Deepseek { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deepseek))]
#endif
        public bool IsDeepseek => Deepseek != null;

        /// <summary>
        /// Together AI model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TogetherModelSettings? Together { get; init; }
#else
        public global::G.TogetherModelSettings? Together { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Together))]
#endif
        public bool IsTogether => Together != null;

        /// <summary>
        /// AWS Bedrock model configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BedrockModelSettings? Bedrock { get; init; }
#else
        public global::G.BedrockModelSettings? Bedrock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bedrock))]
#endif
        public bool IsBedrock => Bedrock != null;

        /// <summary>
        /// OpenRouter model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenRouterModelSettings? Openrouter { get; init; }
#else
        public global::G.OpenRouterModelSettings? Openrouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openrouter))]
#endif
        public bool IsOpenrouter => Openrouter != null;

        /// <summary>
        /// ChatGPT OAuth model configuration (uses ChatGPT backend API).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatGPTOAuthModelSettings? ChatgptOauth { get; init; }
#else
        public global::G.ChatGPTOAuthModelSettings? ChatgptOauth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatgptOauth))]
#endif
        public bool IsChatgptOauth => ChatgptOauth != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.OpenAIModelSettings value) => new ModelSettingsVariant1((global::G.OpenAIModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAIModelSettings?(ModelSettingsVariant1 @this) => @this.Openai;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.OpenAIModelSettings? value)
        {
            Openai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.AnthropicModelSettings value) => new ModelSettingsVariant1((global::G.AnthropicModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnthropicModelSettings?(ModelSettingsVariant1 @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.AnthropicModelSettings? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.GoogleAIModelSettings value) => new ModelSettingsVariant1((global::G.GoogleAIModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GoogleAIModelSettings?(ModelSettingsVariant1 @this) => @this.GoogleAi;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.GoogleAIModelSettings? value)
        {
            GoogleAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.GoogleVertexModelSettings value) => new ModelSettingsVariant1((global::G.GoogleVertexModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GoogleVertexModelSettings?(ModelSettingsVariant1 @this) => @this.GoogleVertex;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.GoogleVertexModelSettings? value)
        {
            GoogleVertex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.AzureModelSettings value) => new ModelSettingsVariant1((global::G.AzureModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AzureModelSettings?(ModelSettingsVariant1 @this) => @this.Azure;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.AzureModelSettings? value)
        {
            Azure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.XAIModelSettings value) => new ModelSettingsVariant1((global::G.XAIModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.XAIModelSettings?(ModelSettingsVariant1 @this) => @this.Xai;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.XAIModelSettings? value)
        {
            Xai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.ZAIModelSettings value) => new ModelSettingsVariant1((global::G.ZAIModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ZAIModelSettings?(ModelSettingsVariant1 @this) => @this.Zai;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.ZAIModelSettings? value)
        {
            Zai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.GroqModelSettings value) => new ModelSettingsVariant1((global::G.GroqModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GroqModelSettings?(ModelSettingsVariant1 @this) => @this.Groq;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.GroqModelSettings? value)
        {
            Groq = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.DeepseekModelSettings value) => new ModelSettingsVariant1((global::G.DeepseekModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DeepseekModelSettings?(ModelSettingsVariant1 @this) => @this.Deepseek;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.DeepseekModelSettings? value)
        {
            Deepseek = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.TogetherModelSettings value) => new ModelSettingsVariant1((global::G.TogetherModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TogetherModelSettings?(ModelSettingsVariant1 @this) => @this.Together;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.TogetherModelSettings? value)
        {
            Together = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.BedrockModelSettings value) => new ModelSettingsVariant1((global::G.BedrockModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BedrockModelSettings?(ModelSettingsVariant1 @this) => @this.Bedrock;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.BedrockModelSettings? value)
        {
            Bedrock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.OpenRouterModelSettings value) => new ModelSettingsVariant1((global::G.OpenRouterModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenRouterModelSettings?(ModelSettingsVariant1 @this) => @this.Openrouter;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.OpenRouterModelSettings? value)
        {
            Openrouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant1(global::G.ChatGPTOAuthModelSettings value) => new ModelSettingsVariant1((global::G.ChatGPTOAuthModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatGPTOAuthModelSettings?(ModelSettingsVariant1 @this) => @this.ChatgptOauth;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(global::G.ChatGPTOAuthModelSettings? value)
        {
            ChatgptOauth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant1(
            global::G.AgentStateModelSettingsVariant1DiscriminatorProviderType? providerType,
            global::G.OpenAIModelSettings? openai,
            global::G.AnthropicModelSettings? anthropic,
            global::G.GoogleAIModelSettings? googleAi,
            global::G.GoogleVertexModelSettings? googleVertex,
            global::G.AzureModelSettings? azure,
            global::G.XAIModelSettings? xai,
            global::G.ZAIModelSettings? zai,
            global::G.GroqModelSettings? groq,
            global::G.DeepseekModelSettings? deepseek,
            global::G.TogetherModelSettings? together,
            global::G.BedrockModelSettings? bedrock,
            global::G.OpenRouterModelSettings? openrouter,
            global::G.ChatGPTOAuthModelSettings? chatgptOauth
            )
        {
            ProviderType = providerType;

            Openai = openai;
            Anthropic = anthropic;
            GoogleAi = googleAi;
            GoogleVertex = googleVertex;
            Azure = azure;
            Xai = xai;
            Zai = zai;
            Groq = groq;
            Deepseek = deepseek;
            Together = together;
            Bedrock = bedrock;
            Openrouter = openrouter;
            ChatgptOauth = chatgptOauth;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatgptOauth as object ??
            Openrouter as object ??
            Bedrock as object ??
            Together as object ??
            Deepseek as object ??
            Groq as object ??
            Zai as object ??
            Xai as object ??
            Azure as object ??
            GoogleVertex as object ??
            GoogleAi as object ??
            Anthropic as object ??
            Openai as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Openai?.ToString() ??
            Anthropic?.ToString() ??
            GoogleAi?.ToString() ??
            GoogleVertex?.ToString() ??
            Azure?.ToString() ??
            Xai?.ToString() ??
            Zai?.ToString() ??
            Groq?.ToString() ??
            Deepseek?.ToString() ??
            Together?.ToString() ??
            Bedrock?.ToString() ??
            Openrouter?.ToString() ??
            ChatgptOauth?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenai && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && !IsGoogleAi && IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && IsDeepseek && !IsTogether && !IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && IsTogether && !IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && IsBedrock && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsOpenrouter && IsChatgptOauth;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OpenAIModelSettings?, TResult>? openai = null,
            global::System.Func<global::G.AnthropicModelSettings?, TResult>? anthropic = null,
            global::System.Func<global::G.GoogleAIModelSettings?, TResult>? googleAi = null,
            global::System.Func<global::G.GoogleVertexModelSettings?, TResult>? googleVertex = null,
            global::System.Func<global::G.AzureModelSettings?, TResult>? azure = null,
            global::System.Func<global::G.XAIModelSettings?, TResult>? xai = null,
            global::System.Func<global::G.ZAIModelSettings?, TResult>? zai = null,
            global::System.Func<global::G.GroqModelSettings?, TResult>? groq = null,
            global::System.Func<global::G.DeepseekModelSettings?, TResult>? deepseek = null,
            global::System.Func<global::G.TogetherModelSettings?, TResult>? together = null,
            global::System.Func<global::G.BedrockModelSettings?, TResult>? bedrock = null,
            global::System.Func<global::G.OpenRouterModelSettings?, TResult>? openrouter = null,
            global::System.Func<global::G.ChatGPTOAuthModelSettings?, TResult>? chatgptOauth = null,
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
            else if (IsAnthropic && anthropic != null)
            {
                return anthropic(Anthropic!);
            }
            else if (IsGoogleAi && googleAi != null)
            {
                return googleAi(GoogleAi!);
            }
            else if (IsGoogleVertex && googleVertex != null)
            {
                return googleVertex(GoogleVertex!);
            }
            else if (IsAzure && azure != null)
            {
                return azure(Azure!);
            }
            else if (IsXai && xai != null)
            {
                return xai(Xai!);
            }
            else if (IsZai && zai != null)
            {
                return zai(Zai!);
            }
            else if (IsGroq && groq != null)
            {
                return groq(Groq!);
            }
            else if (IsDeepseek && deepseek != null)
            {
                return deepseek(Deepseek!);
            }
            else if (IsTogether && together != null)
            {
                return together(Together!);
            }
            else if (IsBedrock && bedrock != null)
            {
                return bedrock(Bedrock!);
            }
            else if (IsOpenrouter && openrouter != null)
            {
                return openrouter(Openrouter!);
            }
            else if (IsChatgptOauth && chatgptOauth != null)
            {
                return chatgptOauth(ChatgptOauth!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OpenAIModelSettings?>? openai = null,
            global::System.Action<global::G.AnthropicModelSettings?>? anthropic = null,
            global::System.Action<global::G.GoogleAIModelSettings?>? googleAi = null,
            global::System.Action<global::G.GoogleVertexModelSettings?>? googleVertex = null,
            global::System.Action<global::G.AzureModelSettings?>? azure = null,
            global::System.Action<global::G.XAIModelSettings?>? xai = null,
            global::System.Action<global::G.ZAIModelSettings?>? zai = null,
            global::System.Action<global::G.GroqModelSettings?>? groq = null,
            global::System.Action<global::G.DeepseekModelSettings?>? deepseek = null,
            global::System.Action<global::G.TogetherModelSettings?>? together = null,
            global::System.Action<global::G.BedrockModelSettings?>? bedrock = null,
            global::System.Action<global::G.OpenRouterModelSettings?>? openrouter = null,
            global::System.Action<global::G.ChatGPTOAuthModelSettings?>? chatgptOauth = null,
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
            else if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
            else if (IsGoogleAi)
            {
                googleAi?.Invoke(GoogleAi!);
            }
            else if (IsGoogleVertex)
            {
                googleVertex?.Invoke(GoogleVertex!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
            }
            else if (IsXai)
            {
                xai?.Invoke(Xai!);
            }
            else if (IsZai)
            {
                zai?.Invoke(Zai!);
            }
            else if (IsGroq)
            {
                groq?.Invoke(Groq!);
            }
            else if (IsDeepseek)
            {
                deepseek?.Invoke(Deepseek!);
            }
            else if (IsTogether)
            {
                together?.Invoke(Together!);
            }
            else if (IsBedrock)
            {
                bedrock?.Invoke(Bedrock!);
            }
            else if (IsOpenrouter)
            {
                openrouter?.Invoke(Openrouter!);
            }
            else if (IsChatgptOauth)
            {
                chatgptOauth?.Invoke(ChatgptOauth!);
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
                typeof(global::G.OpenAIModelSettings),
                Anthropic,
                typeof(global::G.AnthropicModelSettings),
                GoogleAi,
                typeof(global::G.GoogleAIModelSettings),
                GoogleVertex,
                typeof(global::G.GoogleVertexModelSettings),
                Azure,
                typeof(global::G.AzureModelSettings),
                Xai,
                typeof(global::G.XAIModelSettings),
                Zai,
                typeof(global::G.ZAIModelSettings),
                Groq,
                typeof(global::G.GroqModelSettings),
                Deepseek,
                typeof(global::G.DeepseekModelSettings),
                Together,
                typeof(global::G.TogetherModelSettings),
                Bedrock,
                typeof(global::G.BedrockModelSettings),
                Openrouter,
                typeof(global::G.OpenRouterModelSettings),
                ChatgptOauth,
                typeof(global::G.ChatGPTOAuthModelSettings),
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
        public bool Equals(ModelSettingsVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAIModelSettings?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnthropicModelSettings?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GoogleAIModelSettings?>.Default.Equals(GoogleAi, other.GoogleAi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GoogleVertexModelSettings?>.Default.Equals(GoogleVertex, other.GoogleVertex) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AzureModelSettings?>.Default.Equals(Azure, other.Azure) &&
                global::System.Collections.Generic.EqualityComparer<global::G.XAIModelSettings?>.Default.Equals(Xai, other.Xai) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ZAIModelSettings?>.Default.Equals(Zai, other.Zai) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GroqModelSettings?>.Default.Equals(Groq, other.Groq) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DeepseekModelSettings?>.Default.Equals(Deepseek, other.Deepseek) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TogetherModelSettings?>.Default.Equals(Together, other.Together) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BedrockModelSettings?>.Default.Equals(Bedrock, other.Bedrock) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenRouterModelSettings?>.Default.Equals(Openrouter, other.Openrouter) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatGPTOAuthModelSettings?>.Default.Equals(ChatgptOauth, other.ChatgptOauth) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelSettingsVariant1 obj1, ModelSettingsVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelSettingsVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelSettingsVariant1 obj1, ModelSettingsVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelSettingsVariant1 o && Equals(o);
        }
    }
}
