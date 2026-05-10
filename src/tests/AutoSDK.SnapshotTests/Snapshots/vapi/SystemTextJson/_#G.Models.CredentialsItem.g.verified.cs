//HintName: G.Models.CredentialsItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CredentialsItem : global::System.IEquatable<CredentialsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkflowUserEditableCredentialDiscriminatorProvider? Provider { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAnthropicCredentialDTO? Anthropic { get; init; }
#else
        public global::G.CreateAnthropicCredentialDTO? Anthropic { get; }
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
            out global::G.CreateAnthropicCredentialDTO? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAnthropicCredentialDTO PickAnthropic() => IsAnthropic
            ? Anthropic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAnthropicBedrockCredentialDTO? AnthropicBedrock { get; init; }
#else
        public global::G.CreateAnthropicBedrockCredentialDTO? AnthropicBedrock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicBedrock))]
#endif
        public bool IsAnthropicBedrock => AnthropicBedrock != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropicBedrock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateAnthropicBedrockCredentialDTO? value)
        {
            value = AnthropicBedrock;
            return IsAnthropicBedrock;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAnthropicBedrockCredentialDTO PickAnthropicBedrock() => IsAnthropicBedrock
            ? AnthropicBedrock!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicBedrock' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAnyscaleCredentialDTO? Anyscale { get; init; }
#else
        public global::G.CreateAnyscaleCredentialDTO? Anyscale { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anyscale))]
#endif
        public bool IsAnyscale => Anyscale != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnyscale(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateAnyscaleCredentialDTO? value)
        {
            value = Anyscale;
            return IsAnyscale;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAnyscaleCredentialDTO PickAnyscale() => IsAnyscale
            ? Anyscale!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anyscale' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAssemblyAICredentialDTO? AssemblyAi { get; init; }
#else
        public global::G.CreateAssemblyAICredentialDTO? AssemblyAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssemblyAi))]
#endif
        public bool IsAssemblyAi => AssemblyAi != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAssemblyAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateAssemblyAICredentialDTO? value)
        {
            value = AssemblyAi;
            return IsAssemblyAi;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssemblyAICredentialDTO PickAssemblyAi() => IsAssemblyAi
            ? AssemblyAi!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AssemblyAi' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAzureCredentialDTO? Azure { get; init; }
#else
        public global::G.CreateAzureCredentialDTO? Azure { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Azure))]
#endif
        public bool IsAzure => Azure != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAzure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateAzureCredentialDTO? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAzureCredentialDTO PickAzure() => IsAzure
            ? Azure!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAzureOpenAICredentialDTO? AzureOpenai { get; init; }
#else
        public global::G.CreateAzureOpenAICredentialDTO? AzureOpenai { get; }
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
            out global::G.CreateAzureOpenAICredentialDTO? value)
        {
            value = AzureOpenai;
            return IsAzureOpenai;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAzureOpenAICredentialDTO PickAzureOpenai() => IsAzureOpenai
            ? AzureOpenai!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AzureOpenai' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateByoSipTrunkCredentialDTO? ByoSipTrunk { get; init; }
#else
        public global::G.CreateByoSipTrunkCredentialDTO? ByoSipTrunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ByoSipTrunk))]
#endif
        public bool IsByoSipTrunk => ByoSipTrunk != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickByoSipTrunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateByoSipTrunkCredentialDTO? value)
        {
            value = ByoSipTrunk;
            return IsByoSipTrunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateByoSipTrunkCredentialDTO PickByoSipTrunk() => IsByoSipTrunk
            ? ByoSipTrunk!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ByoSipTrunk' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateCartesiaCredentialDTO? Cartesia { get; init; }
#else
        public global::G.CreateCartesiaCredentialDTO? Cartesia { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cartesia))]
#endif
        public bool IsCartesia => Cartesia != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCartesia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateCartesiaCredentialDTO? value)
        {
            value = Cartesia;
            return IsCartesia;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCartesiaCredentialDTO PickCartesia() => IsCartesia
            ? Cartesia!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cartesia' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateCerebrasCredentialDTO? Cerebras { get; init; }
#else
        public global::G.CreateCerebrasCredentialDTO? Cerebras { get; }
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
            out global::G.CreateCerebrasCredentialDTO? value)
        {
            value = Cerebras;
            return IsCerebras;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCerebrasCredentialDTO PickCerebras() => IsCerebras
            ? Cerebras!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cerebras' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateCloudflareCredentialDTO? Cloudflare { get; init; }
#else
        public global::G.CreateCloudflareCredentialDTO? Cloudflare { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cloudflare))]
#endif
        public bool IsCloudflare => Cloudflare != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCloudflare(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateCloudflareCredentialDTO? value)
        {
            value = Cloudflare;
            return IsCloudflare;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCloudflareCredentialDTO PickCloudflare() => IsCloudflare
            ? Cloudflare!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cloudflare' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateCustomLLMCredentialDTO? CustomLlm { get; init; }
#else
        public global::G.CreateCustomLLMCredentialDTO? CustomLlm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomLlm))]
#endif
        public bool IsCustomLlm => CustomLlm != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustomLlm(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateCustomLLMCredentialDTO? value)
        {
            value = CustomLlm;
            return IsCustomLlm;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCustomLLMCredentialDTO PickCustomLlm() => IsCustomLlm
            ? CustomLlm!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomLlm' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateDeepgramCredentialDTO? Deepgram { get; init; }
#else
        public global::G.CreateDeepgramCredentialDTO? Deepgram { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deepgram))]
#endif
        public bool IsDeepgram => Deepgram != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeepgram(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateDeepgramCredentialDTO? value)
        {
            value = Deepgram;
            return IsDeepgram;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateDeepgramCredentialDTO PickDeepgram() => IsDeepgram
            ? Deepgram!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Deepgram' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateDeepInfraCredentialDTO? Deepinfra { get; init; }
#else
        public global::G.CreateDeepInfraCredentialDTO? Deepinfra { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deepinfra))]
#endif
        public bool IsDeepinfra => Deepinfra != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeepinfra(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateDeepInfraCredentialDTO? value)
        {
            value = Deepinfra;
            return IsDeepinfra;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateDeepInfraCredentialDTO PickDeepinfra() => IsDeepinfra
            ? Deepinfra!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Deepinfra' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateDeepSeekCredentialDTO? DeepSeek { get; init; }
#else
        public global::G.CreateDeepSeekCredentialDTO? DeepSeek { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeepSeek))]
#endif
        public bool IsDeepSeek => DeepSeek != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeepSeek(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateDeepSeekCredentialDTO? value)
        {
            value = DeepSeek;
            return IsDeepSeek;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateDeepSeekCredentialDTO PickDeepSeek() => IsDeepSeek
            ? DeepSeek!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeepSeek' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateElevenLabsCredentialDTO? Elevenlabs { get; init; }
#else
        public global::G.CreateElevenLabsCredentialDTO? Elevenlabs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Elevenlabs))]
#endif
        public bool IsElevenlabs => Elevenlabs != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickElevenlabs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateElevenLabsCredentialDTO? value)
        {
            value = Elevenlabs;
            return IsElevenlabs;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateElevenLabsCredentialDTO PickElevenlabs() => IsElevenlabs
            ? Elevenlabs!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Elevenlabs' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGcpCredentialDTO? Gcp { get; init; }
#else
        public global::G.CreateGcpCredentialDTO? Gcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gcp))]
#endif
        public bool IsGcp => Gcp != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGcpCredentialDTO? value)
        {
            value = Gcp;
            return IsGcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGcpCredentialDTO PickGcp() => IsGcp
            ? Gcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGladiaCredentialDTO? Gladia { get; init; }
#else
        public global::G.CreateGladiaCredentialDTO? Gladia { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gladia))]
#endif
        public bool IsGladia => Gladia != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGladia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGladiaCredentialDTO? value)
        {
            value = Gladia;
            return IsGladia;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGladiaCredentialDTO PickGladia() => IsGladia
            ? Gladia!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gladia' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoHighLevelCredentialDTO? Gohighlevel { get; init; }
#else
        public global::G.CreateGoHighLevelCredentialDTO? Gohighlevel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gohighlevel))]
#endif
        public bool IsGohighlevel => Gohighlevel != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGohighlevel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoHighLevelCredentialDTO? value)
        {
            value = Gohighlevel;
            return IsGohighlevel;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoHighLevelCredentialDTO PickGohighlevel() => IsGohighlevel
            ? Gohighlevel!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gohighlevel' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoogleCredentialDTO? Google { get; init; }
#else
        public global::G.CreateGoogleCredentialDTO? Google { get; }
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
            out global::G.CreateGoogleCredentialDTO? value)
        {
            value = Google;
            return IsGoogle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoogleCredentialDTO PickGoogle() => IsGoogle
            ? Google!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Google' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGroqCredentialDTO? Groq { get; init; }
#else
        public global::G.CreateGroqCredentialDTO? Groq { get; }
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
            out global::G.CreateGroqCredentialDTO? value)
        {
            value = Groq;
            return IsGroq;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGroqCredentialDTO PickGroq() => IsGroq
            ? Groq!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Groq' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateHumeCredentialDTO? Hume { get; init; }
#else
        public global::G.CreateHumeCredentialDTO? Hume { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hume))]
#endif
        public bool IsHume => Hume != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHume(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateHumeCredentialDTO? value)
        {
            value = Hume;
            return IsHume;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateHumeCredentialDTO PickHume() => IsHume
            ? Hume!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hume' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateInflectionAICredentialDTO? InflectionAi { get; init; }
#else
        public global::G.CreateInflectionAICredentialDTO? InflectionAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InflectionAi))]
#endif
        public bool IsInflectionAi => InflectionAi != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInflectionAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateInflectionAICredentialDTO? value)
        {
            value = InflectionAi;
            return IsInflectionAi;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateInflectionAICredentialDTO PickInflectionAi() => IsInflectionAi
            ? InflectionAi!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InflectionAi' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateLangfuseCredentialDTO? Langfuse { get; init; }
#else
        public global::G.CreateLangfuseCredentialDTO? Langfuse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Langfuse))]
#endif
        public bool IsLangfuse => Langfuse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLangfuse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateLangfuseCredentialDTO? value)
        {
            value = Langfuse;
            return IsLangfuse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateLangfuseCredentialDTO PickLangfuse() => IsLangfuse
            ? Langfuse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Langfuse' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateLmntCredentialDTO? Lmnt { get; init; }
#else
        public global::G.CreateLmntCredentialDTO? Lmnt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lmnt))]
#endif
        public bool IsLmnt => Lmnt != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLmnt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateLmntCredentialDTO? value)
        {
            value = Lmnt;
            return IsLmnt;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateLmntCredentialDTO PickLmnt() => IsLmnt
            ? Lmnt!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Lmnt' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateMakeCredentialDTO? Make { get; init; }
#else
        public global::G.CreateMakeCredentialDTO? Make { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Make))]
#endif
        public bool IsMake => Make != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMake(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateMakeCredentialDTO? value)
        {
            value = Make;
            return IsMake;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMakeCredentialDTO PickMake() => IsMake
            ? Make!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Make' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateMistralCredentialDTO? Mistral { get; init; }
#else
        public global::G.CreateMistralCredentialDTO? Mistral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mistral))]
#endif
        public bool IsMistral => Mistral != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMistral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateMistralCredentialDTO? value)
        {
            value = Mistral;
            return IsMistral;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMistralCredentialDTO PickMistral() => IsMistral
            ? Mistral!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mistral' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateNeuphonicCredentialDTO? Neuphonic { get; init; }
#else
        public global::G.CreateNeuphonicCredentialDTO? Neuphonic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Neuphonic))]
#endif
        public bool IsNeuphonic => Neuphonic != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNeuphonic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateNeuphonicCredentialDTO? value)
        {
            value = Neuphonic;
            return IsNeuphonic;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateNeuphonicCredentialDTO PickNeuphonic() => IsNeuphonic
            ? Neuphonic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Neuphonic' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateOpenAICredentialDTO? Openai { get; init; }
#else
        public global::G.CreateOpenAICredentialDTO? Openai { get; }
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
            out global::G.CreateOpenAICredentialDTO? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateOpenAICredentialDTO PickOpenai() => IsOpenai
            ? Openai!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateOpenRouterCredentialDTO? Openrouter { get; init; }
#else
        public global::G.CreateOpenRouterCredentialDTO? Openrouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openrouter))]
#endif
        public bool IsOpenrouter => Openrouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenrouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateOpenRouterCredentialDTO? value)
        {
            value = Openrouter;
            return IsOpenrouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateOpenRouterCredentialDTO PickOpenrouter() => IsOpenrouter
            ? Openrouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openrouter' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreatePerplexityAICredentialDTO? PerplexityAi { get; init; }
#else
        public global::G.CreatePerplexityAICredentialDTO? PerplexityAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PerplexityAi))]
#endif
        public bool IsPerplexityAi => PerplexityAi != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPerplexityAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreatePerplexityAICredentialDTO? value)
        {
            value = PerplexityAi;
            return IsPerplexityAi;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePerplexityAICredentialDTO PickPerplexityAi() => IsPerplexityAi
            ? PerplexityAi!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PerplexityAi' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreatePlayHTCredentialDTO? Playht { get; init; }
#else
        public global::G.CreatePlayHTCredentialDTO? Playht { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Playht))]
#endif
        public bool IsPlayht => Playht != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPlayht(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreatePlayHTCredentialDTO? value)
        {
            value = Playht;
            return IsPlayht;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreatePlayHTCredentialDTO PickPlayht() => IsPlayht
            ? Playht!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Playht' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateRimeAICredentialDTO? RimeAi { get; init; }
#else
        public global::G.CreateRimeAICredentialDTO? RimeAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RimeAi))]
#endif
        public bool IsRimeAi => RimeAi != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRimeAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateRimeAICredentialDTO? value)
        {
            value = RimeAi;
            return IsRimeAi;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateRimeAICredentialDTO PickRimeAi() => IsRimeAi
            ? RimeAi!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RimeAi' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateRunpodCredentialDTO? Runpod { get; init; }
#else
        public global::G.CreateRunpodCredentialDTO? Runpod { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Runpod))]
#endif
        public bool IsRunpod => Runpod != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunpod(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateRunpodCredentialDTO? value)
        {
            value = Runpod;
            return IsRunpod;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateRunpodCredentialDTO PickRunpod() => IsRunpod
            ? Runpod!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Runpod' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateS3CredentialDTO? S3 { get; init; }
#else
        public global::G.CreateS3CredentialDTO? S3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S3))]
#endif
        public bool IsS3 => S3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickS3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateS3CredentialDTO? value)
        {
            value = S3;
            return IsS3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateS3CredentialDTO PickS3() => IsS3
            ? S3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSmallestAICredentialDTO? SmallestAi { get; init; }
#else
        public global::G.CreateSmallestAICredentialDTO? SmallestAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmallestAi))]
#endif
        public bool IsSmallestAi => SmallestAi != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSmallestAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateSmallestAICredentialDTO? value)
        {
            value = SmallestAi;
            return IsSmallestAi;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSmallestAICredentialDTO PickSmallestAi() => IsSmallestAi
            ? SmallestAi!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SmallestAi' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSpeechmaticsCredentialDTO? Speechmatics { get; init; }
#else
        public global::G.CreateSpeechmaticsCredentialDTO? Speechmatics { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Speechmatics))]
#endif
        public bool IsSpeechmatics => Speechmatics != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeechmatics(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateSpeechmaticsCredentialDTO? value)
        {
            value = Speechmatics;
            return IsSpeechmatics;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSpeechmaticsCredentialDTO PickSpeechmatics() => IsSpeechmatics
            ? Speechmatics!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Speechmatics' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSonioxCredentialDTO? Soniox { get; init; }
#else
        public global::G.CreateSonioxCredentialDTO? Soniox { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Soniox))]
#endif
        public bool IsSoniox => Soniox != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSoniox(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateSonioxCredentialDTO? value)
        {
            value = Soniox;
            return IsSoniox;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSonioxCredentialDTO PickSoniox() => IsSoniox
            ? Soniox!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Soniox' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSupabaseCredentialDTO? Supabase { get; init; }
#else
        public global::G.CreateSupabaseCredentialDTO? Supabase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Supabase))]
#endif
        public bool IsSupabase => Supabase != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSupabase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateSupabaseCredentialDTO? value)
        {
            value = Supabase;
            return IsSupabase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSupabaseCredentialDTO PickSupabase() => IsSupabase
            ? Supabase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Supabase' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTavusCredentialDTO? Tavus { get; init; }
#else
        public global::G.CreateTavusCredentialDTO? Tavus { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tavus))]
#endif
        public bool IsTavus => Tavus != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTavus(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateTavusCredentialDTO? value)
        {
            value = Tavus;
            return IsTavus;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTavusCredentialDTO PickTavus() => IsTavus
            ? Tavus!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tavus' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTogetherAICredentialDTO? TogetherAi { get; init; }
#else
        public global::G.CreateTogetherAICredentialDTO? TogetherAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TogetherAi))]
#endif
        public bool IsTogetherAi => TogetherAi != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTogetherAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateTogetherAICredentialDTO? value)
        {
            value = TogetherAi;
            return IsTogetherAi;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTogetherAICredentialDTO PickTogetherAi() => IsTogetherAi
            ? TogetherAi!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TogetherAi' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTrieveCredentialDTO? Trieve { get; init; }
#else
        public global::G.CreateTrieveCredentialDTO? Trieve { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Trieve))]
#endif
        public bool IsTrieve => Trieve != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTrieve(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateTrieveCredentialDTO? value)
        {
            value = Trieve;
            return IsTrieve;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTrieveCredentialDTO PickTrieve() => IsTrieve
            ? Trieve!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Trieve' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTwilioCredentialDTO? Twilio { get; init; }
#else
        public global::G.CreateTwilioCredentialDTO? Twilio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Twilio))]
#endif
        public bool IsTwilio => Twilio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTwilio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateTwilioCredentialDTO? value)
        {
            value = Twilio;
            return IsTwilio;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTwilioCredentialDTO PickTwilio() => IsTwilio
            ? Twilio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Twilio' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateVonageCredentialDTO? Vonage { get; init; }
#else
        public global::G.CreateVonageCredentialDTO? Vonage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vonage))]
#endif
        public bool IsVonage => Vonage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVonage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateVonageCredentialDTO? value)
        {
            value = Vonage;
            return IsVonage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVonageCredentialDTO PickVonage() => IsVonage
            ? Vonage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Vonage' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateWebhookCredentialDTO? Webhook { get; init; }
#else
        public global::G.CreateWebhookCredentialDTO? Webhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateWebhookCredentialDTO? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateWebhookCredentialDTO PickWebhook() => IsWebhook
            ? Webhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateCustomCredentialDTO? CustomCredential { get; init; }
#else
        public global::G.CreateCustomCredentialDTO? CustomCredential { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomCredential))]
#endif
        public bool IsCustomCredential => CustomCredential != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustomCredential(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateCustomCredentialDTO? value)
        {
            value = CustomCredential;
            return IsCustomCredential;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCustomCredentialDTO PickCustomCredential() => IsCustomCredential
            ? CustomCredential!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomCredential' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateXAiCredentialDTO? Xai { get; init; }
#else
        public global::G.CreateXAiCredentialDTO? Xai { get; }
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
            out global::G.CreateXAiCredentialDTO? value)
        {
            value = Xai;
            return IsXai;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateXAiCredentialDTO PickXai() => IsXai
            ? Xai!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Xai' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO? GoogleCalendarOauth2Client { get; init; }
#else
        public global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO? GoogleCalendarOauth2Client { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleCalendarOauth2Client))]
#endif
        public bool IsGoogleCalendarOauth2Client => GoogleCalendarOauth2Client != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleCalendarOauth2Client(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO? value)
        {
            value = GoogleCalendarOauth2Client;
            return IsGoogleCalendarOauth2Client;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO PickGoogleCalendarOauth2Client() => IsGoogleCalendarOauth2Client
            ? GoogleCalendarOauth2Client!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleCalendarOauth2Client' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? GoogleCalendarOauth2Authorization { get; init; }
#else
        public global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? GoogleCalendarOauth2Authorization { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleCalendarOauth2Authorization))]
#endif
        public bool IsGoogleCalendarOauth2Authorization => GoogleCalendarOauth2Authorization != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleCalendarOauth2Authorization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? value)
        {
            value = GoogleCalendarOauth2Authorization;
            return IsGoogleCalendarOauth2Authorization;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO PickGoogleCalendarOauth2Authorization() => IsGoogleCalendarOauth2Authorization
            ? GoogleCalendarOauth2Authorization!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleCalendarOauth2Authorization' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? GoogleSheetsOauth2Authorization { get; init; }
#else
        public global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? GoogleSheetsOauth2Authorization { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleSheetsOauth2Authorization))]
#endif
        public bool IsGoogleSheetsOauth2Authorization => GoogleSheetsOauth2Authorization != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleSheetsOauth2Authorization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? value)
        {
            value = GoogleSheetsOauth2Authorization;
            return IsGoogleSheetsOauth2Authorization;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO PickGoogleSheetsOauth2Authorization() => IsGoogleSheetsOauth2Authorization
            ? GoogleSheetsOauth2Authorization!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleSheetsOauth2Authorization' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSlackOAuth2AuthorizationCredentialDTO? SlackOauth2Authorization { get; init; }
#else
        public global::G.CreateSlackOAuth2AuthorizationCredentialDTO? SlackOauth2Authorization { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackOauth2Authorization))]
#endif
        public bool IsSlackOauth2Authorization => SlackOauth2Authorization != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSlackOauth2Authorization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateSlackOAuth2AuthorizationCredentialDTO? value)
        {
            value = SlackOauth2Authorization;
            return IsSlackOauth2Authorization;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSlackOAuth2AuthorizationCredentialDTO PickSlackOauth2Authorization() => IsSlackOauth2Authorization
            ? SlackOauth2Authorization!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackOauth2Authorization' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoHighLevelMCPCredentialDTO? GhlOauth2Authorization { get; init; }
#else
        public global::G.CreateGoHighLevelMCPCredentialDTO? GhlOauth2Authorization { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GhlOauth2Authorization))]
#endif
        public bool IsGhlOauth2Authorization => GhlOauth2Authorization != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGhlOauth2Authorization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoHighLevelMCPCredentialDTO? value)
        {
            value = GhlOauth2Authorization;
            return IsGhlOauth2Authorization;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoHighLevelMCPCredentialDTO PickGhlOauth2Authorization() => IsGhlOauth2Authorization
            ? GhlOauth2Authorization!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GhlOauth2Authorization' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateInworldCredentialDTO? Inworld { get; init; }
#else
        public global::G.CreateInworldCredentialDTO? Inworld { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inworld))]
#endif
        public bool IsInworld => Inworld != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInworld(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateInworldCredentialDTO? value)
        {
            value = Inworld;
            return IsInworld;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateInworldCredentialDTO PickInworld() => IsInworld
            ? Inworld!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inworld' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateMinimaxCredentialDTO? Minimax { get; init; }
#else
        public global::G.CreateMinimaxCredentialDTO? Minimax { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Minimax))]
#endif
        public bool IsMinimax => Minimax != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMinimax(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateMinimaxCredentialDTO? value)
        {
            value = Minimax;
            return IsMinimax;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMinimaxCredentialDTO PickMinimax() => IsMinimax
            ? Minimax!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Minimax' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateWellSaidCredentialDTO? Wellsaid { get; init; }
#else
        public global::G.CreateWellSaidCredentialDTO? Wellsaid { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Wellsaid))]
#endif
        public bool IsWellsaid => Wellsaid != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWellsaid(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateWellSaidCredentialDTO? value)
        {
            value = Wellsaid;
            return IsWellsaid;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateWellSaidCredentialDTO PickWellsaid() => IsWellsaid
            ? Wellsaid!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wellsaid' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateEmailCredentialDTO? Email { get; init; }
#else
        public global::G.CreateEmailCredentialDTO? Email { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Email))]
#endif
        public bool IsEmail => Email != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEmail(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateEmailCredentialDTO? value)
        {
            value = Email;
            return IsEmail;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateEmailCredentialDTO PickEmail() => IsEmail
            ? Email!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Email' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSlackWebhookCredentialDTO? SlackWebhook { get; init; }
#else
        public global::G.CreateSlackWebhookCredentialDTO? SlackWebhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackWebhook))]
#endif
        public bool IsSlackWebhook => SlackWebhook != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSlackWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateSlackWebhookCredentialDTO? value)
        {
            value = SlackWebhook;
            return IsSlackWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSlackWebhookCredentialDTO PickSlackWebhook() => IsSlackWebhook
            ? SlackWebhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackWebhook' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateAnthropicCredentialDTO value) => new CredentialsItem((global::G.CreateAnthropicCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAnthropicCredentialDTO?(CredentialsItem @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateAnthropicCredentialDTO? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromAnthropic(global::G.CreateAnthropicCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateAnthropicBedrockCredentialDTO value) => new CredentialsItem((global::G.CreateAnthropicBedrockCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAnthropicBedrockCredentialDTO?(CredentialsItem @this) => @this.AnthropicBedrock;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateAnthropicBedrockCredentialDTO? value)
        {
            AnthropicBedrock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromAnthropicBedrock(global::G.CreateAnthropicBedrockCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateAnyscaleCredentialDTO value) => new CredentialsItem((global::G.CreateAnyscaleCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAnyscaleCredentialDTO?(CredentialsItem @this) => @this.Anyscale;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateAnyscaleCredentialDTO? value)
        {
            Anyscale = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromAnyscale(global::G.CreateAnyscaleCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateAssemblyAICredentialDTO value) => new CredentialsItem((global::G.CreateAssemblyAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAssemblyAICredentialDTO?(CredentialsItem @this) => @this.AssemblyAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateAssemblyAICredentialDTO? value)
        {
            AssemblyAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromAssemblyAi(global::G.CreateAssemblyAICredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateAzureCredentialDTO value) => new CredentialsItem((global::G.CreateAzureCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAzureCredentialDTO?(CredentialsItem @this) => @this.Azure;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateAzureCredentialDTO? value)
        {
            Azure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromAzure(global::G.CreateAzureCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateAzureOpenAICredentialDTO value) => new CredentialsItem((global::G.CreateAzureOpenAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAzureOpenAICredentialDTO?(CredentialsItem @this) => @this.AzureOpenai;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateAzureOpenAICredentialDTO? value)
        {
            AzureOpenai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromAzureOpenai(global::G.CreateAzureOpenAICredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateByoSipTrunkCredentialDTO value) => new CredentialsItem((global::G.CreateByoSipTrunkCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateByoSipTrunkCredentialDTO?(CredentialsItem @this) => @this.ByoSipTrunk;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateByoSipTrunkCredentialDTO? value)
        {
            ByoSipTrunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromByoSipTrunk(global::G.CreateByoSipTrunkCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateCartesiaCredentialDTO value) => new CredentialsItem((global::G.CreateCartesiaCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateCartesiaCredentialDTO?(CredentialsItem @this) => @this.Cartesia;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateCartesiaCredentialDTO? value)
        {
            Cartesia = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromCartesia(global::G.CreateCartesiaCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateCerebrasCredentialDTO value) => new CredentialsItem((global::G.CreateCerebrasCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateCerebrasCredentialDTO?(CredentialsItem @this) => @this.Cerebras;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateCerebrasCredentialDTO? value)
        {
            Cerebras = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromCerebras(global::G.CreateCerebrasCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateCloudflareCredentialDTO value) => new CredentialsItem((global::G.CreateCloudflareCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateCloudflareCredentialDTO?(CredentialsItem @this) => @this.Cloudflare;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateCloudflareCredentialDTO? value)
        {
            Cloudflare = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromCloudflare(global::G.CreateCloudflareCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateCustomLLMCredentialDTO value) => new CredentialsItem((global::G.CreateCustomLLMCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateCustomLLMCredentialDTO?(CredentialsItem @this) => @this.CustomLlm;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateCustomLLMCredentialDTO? value)
        {
            CustomLlm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromCustomLlm(global::G.CreateCustomLLMCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateDeepgramCredentialDTO value) => new CredentialsItem((global::G.CreateDeepgramCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateDeepgramCredentialDTO?(CredentialsItem @this) => @this.Deepgram;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateDeepgramCredentialDTO? value)
        {
            Deepgram = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromDeepgram(global::G.CreateDeepgramCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateDeepInfraCredentialDTO value) => new CredentialsItem((global::G.CreateDeepInfraCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateDeepInfraCredentialDTO?(CredentialsItem @this) => @this.Deepinfra;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateDeepInfraCredentialDTO? value)
        {
            Deepinfra = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromDeepinfra(global::G.CreateDeepInfraCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateDeepSeekCredentialDTO value) => new CredentialsItem((global::G.CreateDeepSeekCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateDeepSeekCredentialDTO?(CredentialsItem @this) => @this.DeepSeek;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateDeepSeekCredentialDTO? value)
        {
            DeepSeek = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromDeepSeek(global::G.CreateDeepSeekCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateElevenLabsCredentialDTO value) => new CredentialsItem((global::G.CreateElevenLabsCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateElevenLabsCredentialDTO?(CredentialsItem @this) => @this.Elevenlabs;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateElevenLabsCredentialDTO? value)
        {
            Elevenlabs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromElevenlabs(global::G.CreateElevenLabsCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateGcpCredentialDTO value) => new CredentialsItem((global::G.CreateGcpCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGcpCredentialDTO?(CredentialsItem @this) => @this.Gcp;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateGcpCredentialDTO? value)
        {
            Gcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromGcp(global::G.CreateGcpCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateGladiaCredentialDTO value) => new CredentialsItem((global::G.CreateGladiaCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGladiaCredentialDTO?(CredentialsItem @this) => @this.Gladia;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateGladiaCredentialDTO? value)
        {
            Gladia = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromGladia(global::G.CreateGladiaCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateGoHighLevelCredentialDTO value) => new CredentialsItem((global::G.CreateGoHighLevelCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoHighLevelCredentialDTO?(CredentialsItem @this) => @this.Gohighlevel;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateGoHighLevelCredentialDTO? value)
        {
            Gohighlevel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromGohighlevel(global::G.CreateGoHighLevelCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateGoogleCredentialDTO value) => new CredentialsItem((global::G.CreateGoogleCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoogleCredentialDTO?(CredentialsItem @this) => @this.Google;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateGoogleCredentialDTO? value)
        {
            Google = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromGoogle(global::G.CreateGoogleCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateGroqCredentialDTO value) => new CredentialsItem((global::G.CreateGroqCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGroqCredentialDTO?(CredentialsItem @this) => @this.Groq;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateGroqCredentialDTO? value)
        {
            Groq = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromGroq(global::G.CreateGroqCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateHumeCredentialDTO value) => new CredentialsItem((global::G.CreateHumeCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateHumeCredentialDTO?(CredentialsItem @this) => @this.Hume;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateHumeCredentialDTO? value)
        {
            Hume = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromHume(global::G.CreateHumeCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateInflectionAICredentialDTO value) => new CredentialsItem((global::G.CreateInflectionAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateInflectionAICredentialDTO?(CredentialsItem @this) => @this.InflectionAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateInflectionAICredentialDTO? value)
        {
            InflectionAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromInflectionAi(global::G.CreateInflectionAICredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateLangfuseCredentialDTO value) => new CredentialsItem((global::G.CreateLangfuseCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateLangfuseCredentialDTO?(CredentialsItem @this) => @this.Langfuse;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateLangfuseCredentialDTO? value)
        {
            Langfuse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromLangfuse(global::G.CreateLangfuseCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateLmntCredentialDTO value) => new CredentialsItem((global::G.CreateLmntCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateLmntCredentialDTO?(CredentialsItem @this) => @this.Lmnt;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateLmntCredentialDTO? value)
        {
            Lmnt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromLmnt(global::G.CreateLmntCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateMakeCredentialDTO value) => new CredentialsItem((global::G.CreateMakeCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateMakeCredentialDTO?(CredentialsItem @this) => @this.Make;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateMakeCredentialDTO? value)
        {
            Make = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromMake(global::G.CreateMakeCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateMistralCredentialDTO value) => new CredentialsItem((global::G.CreateMistralCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateMistralCredentialDTO?(CredentialsItem @this) => @this.Mistral;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateMistralCredentialDTO? value)
        {
            Mistral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromMistral(global::G.CreateMistralCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateNeuphonicCredentialDTO value) => new CredentialsItem((global::G.CreateNeuphonicCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateNeuphonicCredentialDTO?(CredentialsItem @this) => @this.Neuphonic;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateNeuphonicCredentialDTO? value)
        {
            Neuphonic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromNeuphonic(global::G.CreateNeuphonicCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateOpenAICredentialDTO value) => new CredentialsItem((global::G.CreateOpenAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateOpenAICredentialDTO?(CredentialsItem @this) => @this.Openai;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateOpenAICredentialDTO? value)
        {
            Openai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromOpenai(global::G.CreateOpenAICredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateOpenRouterCredentialDTO value) => new CredentialsItem((global::G.CreateOpenRouterCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateOpenRouterCredentialDTO?(CredentialsItem @this) => @this.Openrouter;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateOpenRouterCredentialDTO? value)
        {
            Openrouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromOpenrouter(global::G.CreateOpenRouterCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreatePerplexityAICredentialDTO value) => new CredentialsItem((global::G.CreatePerplexityAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreatePerplexityAICredentialDTO?(CredentialsItem @this) => @this.PerplexityAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreatePerplexityAICredentialDTO? value)
        {
            PerplexityAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromPerplexityAi(global::G.CreatePerplexityAICredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreatePlayHTCredentialDTO value) => new CredentialsItem((global::G.CreatePlayHTCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreatePlayHTCredentialDTO?(CredentialsItem @this) => @this.Playht;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreatePlayHTCredentialDTO? value)
        {
            Playht = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromPlayht(global::G.CreatePlayHTCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateRimeAICredentialDTO value) => new CredentialsItem((global::G.CreateRimeAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateRimeAICredentialDTO?(CredentialsItem @this) => @this.RimeAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateRimeAICredentialDTO? value)
        {
            RimeAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromRimeAi(global::G.CreateRimeAICredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateRunpodCredentialDTO value) => new CredentialsItem((global::G.CreateRunpodCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateRunpodCredentialDTO?(CredentialsItem @this) => @this.Runpod;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateRunpodCredentialDTO? value)
        {
            Runpod = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromRunpod(global::G.CreateRunpodCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateS3CredentialDTO value) => new CredentialsItem((global::G.CreateS3CredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateS3CredentialDTO?(CredentialsItem @this) => @this.S3;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateS3CredentialDTO? value)
        {
            S3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromS3(global::G.CreateS3CredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateSmallestAICredentialDTO value) => new CredentialsItem((global::G.CreateSmallestAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSmallestAICredentialDTO?(CredentialsItem @this) => @this.SmallestAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateSmallestAICredentialDTO? value)
        {
            SmallestAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromSmallestAi(global::G.CreateSmallestAICredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateSpeechmaticsCredentialDTO value) => new CredentialsItem((global::G.CreateSpeechmaticsCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSpeechmaticsCredentialDTO?(CredentialsItem @this) => @this.Speechmatics;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateSpeechmaticsCredentialDTO? value)
        {
            Speechmatics = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromSpeechmatics(global::G.CreateSpeechmaticsCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateSonioxCredentialDTO value) => new CredentialsItem((global::G.CreateSonioxCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSonioxCredentialDTO?(CredentialsItem @this) => @this.Soniox;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateSonioxCredentialDTO? value)
        {
            Soniox = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromSoniox(global::G.CreateSonioxCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateSupabaseCredentialDTO value) => new CredentialsItem((global::G.CreateSupabaseCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSupabaseCredentialDTO?(CredentialsItem @this) => @this.Supabase;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateSupabaseCredentialDTO? value)
        {
            Supabase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromSupabase(global::G.CreateSupabaseCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateTavusCredentialDTO value) => new CredentialsItem((global::G.CreateTavusCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTavusCredentialDTO?(CredentialsItem @this) => @this.Tavus;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateTavusCredentialDTO? value)
        {
            Tavus = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromTavus(global::G.CreateTavusCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateTogetherAICredentialDTO value) => new CredentialsItem((global::G.CreateTogetherAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTogetherAICredentialDTO?(CredentialsItem @this) => @this.TogetherAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateTogetherAICredentialDTO? value)
        {
            TogetherAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromTogetherAi(global::G.CreateTogetherAICredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateTrieveCredentialDTO value) => new CredentialsItem((global::G.CreateTrieveCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTrieveCredentialDTO?(CredentialsItem @this) => @this.Trieve;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateTrieveCredentialDTO? value)
        {
            Trieve = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromTrieve(global::G.CreateTrieveCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateTwilioCredentialDTO value) => new CredentialsItem((global::G.CreateTwilioCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTwilioCredentialDTO?(CredentialsItem @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateTwilioCredentialDTO? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromTwilio(global::G.CreateTwilioCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateVonageCredentialDTO value) => new CredentialsItem((global::G.CreateVonageCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateVonageCredentialDTO?(CredentialsItem @this) => @this.Vonage;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateVonageCredentialDTO? value)
        {
            Vonage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromVonage(global::G.CreateVonageCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateWebhookCredentialDTO value) => new CredentialsItem((global::G.CreateWebhookCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateWebhookCredentialDTO?(CredentialsItem @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateWebhookCredentialDTO? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromWebhook(global::G.CreateWebhookCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateCustomCredentialDTO value) => new CredentialsItem((global::G.CreateCustomCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateCustomCredentialDTO?(CredentialsItem @this) => @this.CustomCredential;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateCustomCredentialDTO? value)
        {
            CustomCredential = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromCustomCredential(global::G.CreateCustomCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateXAiCredentialDTO value) => new CredentialsItem((global::G.CreateXAiCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateXAiCredentialDTO?(CredentialsItem @this) => @this.Xai;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateXAiCredentialDTO? value)
        {
            Xai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromXai(global::G.CreateXAiCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO value) => new CredentialsItem((global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO?(CredentialsItem @this) => @this.GoogleCalendarOauth2Client;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO? value)
        {
            GoogleCalendarOauth2Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromGoogleCalendarOauth2Client(global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO value) => new CredentialsItem((global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?(CredentialsItem @this) => @this.GoogleCalendarOauth2Authorization;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? value)
        {
            GoogleCalendarOauth2Authorization = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromGoogleCalendarOauth2Authorization(global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO value) => new CredentialsItem((global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?(CredentialsItem @this) => @this.GoogleSheetsOauth2Authorization;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? value)
        {
            GoogleSheetsOauth2Authorization = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromGoogleSheetsOauth2Authorization(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateSlackOAuth2AuthorizationCredentialDTO value) => new CredentialsItem((global::G.CreateSlackOAuth2AuthorizationCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSlackOAuth2AuthorizationCredentialDTO?(CredentialsItem @this) => @this.SlackOauth2Authorization;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateSlackOAuth2AuthorizationCredentialDTO? value)
        {
            SlackOauth2Authorization = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromSlackOauth2Authorization(global::G.CreateSlackOAuth2AuthorizationCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateGoHighLevelMCPCredentialDTO value) => new CredentialsItem((global::G.CreateGoHighLevelMCPCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoHighLevelMCPCredentialDTO?(CredentialsItem @this) => @this.GhlOauth2Authorization;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateGoHighLevelMCPCredentialDTO? value)
        {
            GhlOauth2Authorization = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromGhlOauth2Authorization(global::G.CreateGoHighLevelMCPCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateInworldCredentialDTO value) => new CredentialsItem((global::G.CreateInworldCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateInworldCredentialDTO?(CredentialsItem @this) => @this.Inworld;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateInworldCredentialDTO? value)
        {
            Inworld = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromInworld(global::G.CreateInworldCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateMinimaxCredentialDTO value) => new CredentialsItem((global::G.CreateMinimaxCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateMinimaxCredentialDTO?(CredentialsItem @this) => @this.Minimax;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateMinimaxCredentialDTO? value)
        {
            Minimax = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromMinimax(global::G.CreateMinimaxCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateWellSaidCredentialDTO value) => new CredentialsItem((global::G.CreateWellSaidCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateWellSaidCredentialDTO?(CredentialsItem @this) => @this.Wellsaid;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateWellSaidCredentialDTO? value)
        {
            Wellsaid = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromWellsaid(global::G.CreateWellSaidCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateEmailCredentialDTO value) => new CredentialsItem((global::G.CreateEmailCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateEmailCredentialDTO?(CredentialsItem @this) => @this.Email;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateEmailCredentialDTO? value)
        {
            Email = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromEmail(global::G.CreateEmailCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem(global::G.CreateSlackWebhookCredentialDTO value) => new CredentialsItem((global::G.CreateSlackWebhookCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSlackWebhookCredentialDTO?(CredentialsItem @this) => @this.SlackWebhook;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(global::G.CreateSlackWebhookCredentialDTO? value)
        {
            SlackWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CredentialsItem FromSlackWebhook(global::G.CreateSlackWebhookCredentialDTO? value) => new CredentialsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem(
            global::G.WorkflowUserEditableCredentialDiscriminatorProvider? provider,
            global::G.CreateAnthropicCredentialDTO? anthropic,
            global::G.CreateAnthropicBedrockCredentialDTO? anthropicBedrock,
            global::G.CreateAnyscaleCredentialDTO? anyscale,
            global::G.CreateAssemblyAICredentialDTO? assemblyAi,
            global::G.CreateAzureCredentialDTO? azure,
            global::G.CreateAzureOpenAICredentialDTO? azureOpenai,
            global::G.CreateByoSipTrunkCredentialDTO? byoSipTrunk,
            global::G.CreateCartesiaCredentialDTO? cartesia,
            global::G.CreateCerebrasCredentialDTO? cerebras,
            global::G.CreateCloudflareCredentialDTO? cloudflare,
            global::G.CreateCustomLLMCredentialDTO? customLlm,
            global::G.CreateDeepgramCredentialDTO? deepgram,
            global::G.CreateDeepInfraCredentialDTO? deepinfra,
            global::G.CreateDeepSeekCredentialDTO? deepSeek,
            global::G.CreateElevenLabsCredentialDTO? elevenlabs,
            global::G.CreateGcpCredentialDTO? gcp,
            global::G.CreateGladiaCredentialDTO? gladia,
            global::G.CreateGoHighLevelCredentialDTO? gohighlevel,
            global::G.CreateGoogleCredentialDTO? google,
            global::G.CreateGroqCredentialDTO? groq,
            global::G.CreateHumeCredentialDTO? hume,
            global::G.CreateInflectionAICredentialDTO? inflectionAi,
            global::G.CreateLangfuseCredentialDTO? langfuse,
            global::G.CreateLmntCredentialDTO? lmnt,
            global::G.CreateMakeCredentialDTO? make,
            global::G.CreateMistralCredentialDTO? mistral,
            global::G.CreateNeuphonicCredentialDTO? neuphonic,
            global::G.CreateOpenAICredentialDTO? openai,
            global::G.CreateOpenRouterCredentialDTO? openrouter,
            global::G.CreatePerplexityAICredentialDTO? perplexityAi,
            global::G.CreatePlayHTCredentialDTO? playht,
            global::G.CreateRimeAICredentialDTO? rimeAi,
            global::G.CreateRunpodCredentialDTO? runpod,
            global::G.CreateS3CredentialDTO? s3,
            global::G.CreateSmallestAICredentialDTO? smallestAi,
            global::G.CreateSpeechmaticsCredentialDTO? speechmatics,
            global::G.CreateSonioxCredentialDTO? soniox,
            global::G.CreateSupabaseCredentialDTO? supabase,
            global::G.CreateTavusCredentialDTO? tavus,
            global::G.CreateTogetherAICredentialDTO? togetherAi,
            global::G.CreateTrieveCredentialDTO? trieve,
            global::G.CreateTwilioCredentialDTO? twilio,
            global::G.CreateVonageCredentialDTO? vonage,
            global::G.CreateWebhookCredentialDTO? webhook,
            global::G.CreateCustomCredentialDTO? customCredential,
            global::G.CreateXAiCredentialDTO? xai,
            global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO? googleCalendarOauth2Client,
            global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? googleCalendarOauth2Authorization,
            global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? googleSheetsOauth2Authorization,
            global::G.CreateSlackOAuth2AuthorizationCredentialDTO? slackOauth2Authorization,
            global::G.CreateGoHighLevelMCPCredentialDTO? ghlOauth2Authorization,
            global::G.CreateInworldCredentialDTO? inworld,
            global::G.CreateMinimaxCredentialDTO? minimax,
            global::G.CreateWellSaidCredentialDTO? wellsaid,
            global::G.CreateEmailCredentialDTO? email,
            global::G.CreateSlackWebhookCredentialDTO? slackWebhook
            )
        {
            Provider = provider;

            Anthropic = anthropic;
            AnthropicBedrock = anthropicBedrock;
            Anyscale = anyscale;
            AssemblyAi = assemblyAi;
            Azure = azure;
            AzureOpenai = azureOpenai;
            ByoSipTrunk = byoSipTrunk;
            Cartesia = cartesia;
            Cerebras = cerebras;
            Cloudflare = cloudflare;
            CustomLlm = customLlm;
            Deepgram = deepgram;
            Deepinfra = deepinfra;
            DeepSeek = deepSeek;
            Elevenlabs = elevenlabs;
            Gcp = gcp;
            Gladia = gladia;
            Gohighlevel = gohighlevel;
            Google = google;
            Groq = groq;
            Hume = hume;
            InflectionAi = inflectionAi;
            Langfuse = langfuse;
            Lmnt = lmnt;
            Make = make;
            Mistral = mistral;
            Neuphonic = neuphonic;
            Openai = openai;
            Openrouter = openrouter;
            PerplexityAi = perplexityAi;
            Playht = playht;
            RimeAi = rimeAi;
            Runpod = runpod;
            S3 = s3;
            SmallestAi = smallestAi;
            Speechmatics = speechmatics;
            Soniox = soniox;
            Supabase = supabase;
            Tavus = tavus;
            TogetherAi = togetherAi;
            Trieve = trieve;
            Twilio = twilio;
            Vonage = vonage;
            Webhook = webhook;
            CustomCredential = customCredential;
            Xai = xai;
            GoogleCalendarOauth2Client = googleCalendarOauth2Client;
            GoogleCalendarOauth2Authorization = googleCalendarOauth2Authorization;
            GoogleSheetsOauth2Authorization = googleSheetsOauth2Authorization;
            SlackOauth2Authorization = slackOauth2Authorization;
            GhlOauth2Authorization = ghlOauth2Authorization;
            Inworld = inworld;
            Minimax = minimax;
            Wellsaid = wellsaid;
            Email = email;
            SlackWebhook = slackWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SlackWebhook as object ??
            Email as object ??
            Wellsaid as object ??
            Minimax as object ??
            Inworld as object ??
            GhlOauth2Authorization as object ??
            SlackOauth2Authorization as object ??
            GoogleSheetsOauth2Authorization as object ??
            GoogleCalendarOauth2Authorization as object ??
            GoogleCalendarOauth2Client as object ??
            Xai as object ??
            CustomCredential as object ??
            Webhook as object ??
            Vonage as object ??
            Twilio as object ??
            Trieve as object ??
            TogetherAi as object ??
            Tavus as object ??
            Supabase as object ??
            Soniox as object ??
            Speechmatics as object ??
            SmallestAi as object ??
            S3 as object ??
            Runpod as object ??
            RimeAi as object ??
            Playht as object ??
            PerplexityAi as object ??
            Openrouter as object ??
            Openai as object ??
            Neuphonic as object ??
            Mistral as object ??
            Make as object ??
            Lmnt as object ??
            Langfuse as object ??
            InflectionAi as object ??
            Hume as object ??
            Groq as object ??
            Google as object ??
            Gohighlevel as object ??
            Gladia as object ??
            Gcp as object ??
            Elevenlabs as object ??
            DeepSeek as object ??
            Deepinfra as object ??
            Deepgram as object ??
            CustomLlm as object ??
            Cloudflare as object ??
            Cerebras as object ??
            Cartesia as object ??
            ByoSipTrunk as object ??
            AzureOpenai as object ??
            Azure as object ??
            AssemblyAi as object ??
            Anyscale as object ??
            AnthropicBedrock as object ??
            Anthropic as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Anthropic?.ToString() ??
            AnthropicBedrock?.ToString() ??
            Anyscale?.ToString() ??
            AssemblyAi?.ToString() ??
            Azure?.ToString() ??
            AzureOpenai?.ToString() ??
            ByoSipTrunk?.ToString() ??
            Cartesia?.ToString() ??
            Cerebras?.ToString() ??
            Cloudflare?.ToString() ??
            CustomLlm?.ToString() ??
            Deepgram?.ToString() ??
            Deepinfra?.ToString() ??
            DeepSeek?.ToString() ??
            Elevenlabs?.ToString() ??
            Gcp?.ToString() ??
            Gladia?.ToString() ??
            Gohighlevel?.ToString() ??
            Google?.ToString() ??
            Groq?.ToString() ??
            Hume?.ToString() ??
            InflectionAi?.ToString() ??
            Langfuse?.ToString() ??
            Lmnt?.ToString() ??
            Make?.ToString() ??
            Mistral?.ToString() ??
            Neuphonic?.ToString() ??
            Openai?.ToString() ??
            Openrouter?.ToString() ??
            PerplexityAi?.ToString() ??
            Playht?.ToString() ??
            RimeAi?.ToString() ??
            Runpod?.ToString() ??
            S3?.ToString() ??
            SmallestAi?.ToString() ??
            Speechmatics?.ToString() ??
            Soniox?.ToString() ??
            Supabase?.ToString() ??
            Tavus?.ToString() ??
            TogetherAi?.ToString() ??
            Trieve?.ToString() ??
            Twilio?.ToString() ??
            Vonage?.ToString() ??
            Webhook?.ToString() ??
            CustomCredential?.ToString() ??
            Xai?.ToString() ??
            GoogleCalendarOauth2Client?.ToString() ??
            GoogleCalendarOauth2Authorization?.ToString() ??
            GoogleSheetsOauth2Authorization?.ToString() ??
            SlackOauth2Authorization?.ToString() ??
            GhlOauth2Authorization?.ToString() ??
            Inworld?.ToString() ??
            Minimax?.ToString() ??
            Wellsaid?.ToString() ??
            Email?.ToString() ??
            SlackWebhook?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTrieve && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && IsSlackWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateAnthropicCredentialDTO, TResult>? anthropic = null,
            global::System.Func<global::G.CreateAnthropicBedrockCredentialDTO, TResult>? anthropicBedrock = null,
            global::System.Func<global::G.CreateAnyscaleCredentialDTO, TResult>? anyscale = null,
            global::System.Func<global::G.CreateAssemblyAICredentialDTO, TResult>? assemblyAi = null,
            global::System.Func<global::G.CreateAzureCredentialDTO, TResult>? azure = null,
            global::System.Func<global::G.CreateAzureOpenAICredentialDTO, TResult>? azureOpenai = null,
            global::System.Func<global::G.CreateByoSipTrunkCredentialDTO, TResult>? byoSipTrunk = null,
            global::System.Func<global::G.CreateCartesiaCredentialDTO, TResult>? cartesia = null,
            global::System.Func<global::G.CreateCerebrasCredentialDTO, TResult>? cerebras = null,
            global::System.Func<global::G.CreateCloudflareCredentialDTO, TResult>? cloudflare = null,
            global::System.Func<global::G.CreateCustomLLMCredentialDTO, TResult>? customLlm = null,
            global::System.Func<global::G.CreateDeepgramCredentialDTO, TResult>? deepgram = null,
            global::System.Func<global::G.CreateDeepInfraCredentialDTO, TResult>? deepinfra = null,
            global::System.Func<global::G.CreateDeepSeekCredentialDTO, TResult>? deepSeek = null,
            global::System.Func<global::G.CreateElevenLabsCredentialDTO, TResult>? elevenlabs = null,
            global::System.Func<global::G.CreateGcpCredentialDTO, TResult>? gcp = null,
            global::System.Func<global::G.CreateGladiaCredentialDTO, TResult>? gladia = null,
            global::System.Func<global::G.CreateGoHighLevelCredentialDTO, TResult>? gohighlevel = null,
            global::System.Func<global::G.CreateGoogleCredentialDTO, TResult>? google = null,
            global::System.Func<global::G.CreateGroqCredentialDTO, TResult>? groq = null,
            global::System.Func<global::G.CreateHumeCredentialDTO, TResult>? hume = null,
            global::System.Func<global::G.CreateInflectionAICredentialDTO, TResult>? inflectionAi = null,
            global::System.Func<global::G.CreateLangfuseCredentialDTO, TResult>? langfuse = null,
            global::System.Func<global::G.CreateLmntCredentialDTO, TResult>? lmnt = null,
            global::System.Func<global::G.CreateMakeCredentialDTO, TResult>? make = null,
            global::System.Func<global::G.CreateMistralCredentialDTO, TResult>? mistral = null,
            global::System.Func<global::G.CreateNeuphonicCredentialDTO, TResult>? neuphonic = null,
            global::System.Func<global::G.CreateOpenAICredentialDTO, TResult>? openai = null,
            global::System.Func<global::G.CreateOpenRouterCredentialDTO, TResult>? openrouter = null,
            global::System.Func<global::G.CreatePerplexityAICredentialDTO, TResult>? perplexityAi = null,
            global::System.Func<global::G.CreatePlayHTCredentialDTO, TResult>? playht = null,
            global::System.Func<global::G.CreateRimeAICredentialDTO, TResult>? rimeAi = null,
            global::System.Func<global::G.CreateRunpodCredentialDTO, TResult>? runpod = null,
            global::System.Func<global::G.CreateS3CredentialDTO, TResult>? s3 = null,
            global::System.Func<global::G.CreateSmallestAICredentialDTO, TResult>? smallestAi = null,
            global::System.Func<global::G.CreateSpeechmaticsCredentialDTO, TResult>? speechmatics = null,
            global::System.Func<global::G.CreateSonioxCredentialDTO, TResult>? soniox = null,
            global::System.Func<global::G.CreateSupabaseCredentialDTO, TResult>? supabase = null,
            global::System.Func<global::G.CreateTavusCredentialDTO, TResult>? tavus = null,
            global::System.Func<global::G.CreateTogetherAICredentialDTO, TResult>? togetherAi = null,
            global::System.Func<global::G.CreateTrieveCredentialDTO, TResult>? trieve = null,
            global::System.Func<global::G.CreateTwilioCredentialDTO, TResult>? twilio = null,
            global::System.Func<global::G.CreateVonageCredentialDTO, TResult>? vonage = null,
            global::System.Func<global::G.CreateWebhookCredentialDTO, TResult>? webhook = null,
            global::System.Func<global::G.CreateCustomCredentialDTO, TResult>? customCredential = null,
            global::System.Func<global::G.CreateXAiCredentialDTO, TResult>? xai = null,
            global::System.Func<global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO, TResult>? googleCalendarOauth2Client = null,
            global::System.Func<global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO, TResult>? googleCalendarOauth2Authorization = null,
            global::System.Func<global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO, TResult>? googleSheetsOauth2Authorization = null,
            global::System.Func<global::G.CreateSlackOAuth2AuthorizationCredentialDTO, TResult>? slackOauth2Authorization = null,
            global::System.Func<global::G.CreateGoHighLevelMCPCredentialDTO, TResult>? ghlOauth2Authorization = null,
            global::System.Func<global::G.CreateInworldCredentialDTO, TResult>? inworld = null,
            global::System.Func<global::G.CreateMinimaxCredentialDTO, TResult>? minimax = null,
            global::System.Func<global::G.CreateWellSaidCredentialDTO, TResult>? wellsaid = null,
            global::System.Func<global::G.CreateEmailCredentialDTO, TResult>? email = null,
            global::System.Func<global::G.CreateSlackWebhookCredentialDTO, TResult>? slackWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropic && anthropic != null)
            {
                return anthropic(Anthropic!);
            }
            else if (IsAnthropicBedrock && anthropicBedrock != null)
            {
                return anthropicBedrock(AnthropicBedrock!);
            }
            else if (IsAnyscale && anyscale != null)
            {
                return anyscale(Anyscale!);
            }
            else if (IsAssemblyAi && assemblyAi != null)
            {
                return assemblyAi(AssemblyAi!);
            }
            else if (IsAzure && azure != null)
            {
                return azure(Azure!);
            }
            else if (IsAzureOpenai && azureOpenai != null)
            {
                return azureOpenai(AzureOpenai!);
            }
            else if (IsByoSipTrunk && byoSipTrunk != null)
            {
                return byoSipTrunk(ByoSipTrunk!);
            }
            else if (IsCartesia && cartesia != null)
            {
                return cartesia(Cartesia!);
            }
            else if (IsCerebras && cerebras != null)
            {
                return cerebras(Cerebras!);
            }
            else if (IsCloudflare && cloudflare != null)
            {
                return cloudflare(Cloudflare!);
            }
            else if (IsCustomLlm && customLlm != null)
            {
                return customLlm(CustomLlm!);
            }
            else if (IsDeepgram && deepgram != null)
            {
                return deepgram(Deepgram!);
            }
            else if (IsDeepinfra && deepinfra != null)
            {
                return deepinfra(Deepinfra!);
            }
            else if (IsDeepSeek && deepSeek != null)
            {
                return deepSeek(DeepSeek!);
            }
            else if (IsElevenlabs && elevenlabs != null)
            {
                return elevenlabs(Elevenlabs!);
            }
            else if (IsGcp && gcp != null)
            {
                return gcp(Gcp!);
            }
            else if (IsGladia && gladia != null)
            {
                return gladia(Gladia!);
            }
            else if (IsGohighlevel && gohighlevel != null)
            {
                return gohighlevel(Gohighlevel!);
            }
            else if (IsGoogle && google != null)
            {
                return google(Google!);
            }
            else if (IsGroq && groq != null)
            {
                return groq(Groq!);
            }
            else if (IsHume && hume != null)
            {
                return hume(Hume!);
            }
            else if (IsInflectionAi && inflectionAi != null)
            {
                return inflectionAi(InflectionAi!);
            }
            else if (IsLangfuse && langfuse != null)
            {
                return langfuse(Langfuse!);
            }
            else if (IsLmnt && lmnt != null)
            {
                return lmnt(Lmnt!);
            }
            else if (IsMake && make != null)
            {
                return make(Make!);
            }
            else if (IsMistral && mistral != null)
            {
                return mistral(Mistral!);
            }
            else if (IsNeuphonic && neuphonic != null)
            {
                return neuphonic(Neuphonic!);
            }
            else if (IsOpenai && openai != null)
            {
                return openai(Openai!);
            }
            else if (IsOpenrouter && openrouter != null)
            {
                return openrouter(Openrouter!);
            }
            else if (IsPerplexityAi && perplexityAi != null)
            {
                return perplexityAi(PerplexityAi!);
            }
            else if (IsPlayht && playht != null)
            {
                return playht(Playht!);
            }
            else if (IsRimeAi && rimeAi != null)
            {
                return rimeAi(RimeAi!);
            }
            else if (IsRunpod && runpod != null)
            {
                return runpod(Runpod!);
            }
            else if (IsS3 && s3 != null)
            {
                return s3(S3!);
            }
            else if (IsSmallestAi && smallestAi != null)
            {
                return smallestAi(SmallestAi!);
            }
            else if (IsSpeechmatics && speechmatics != null)
            {
                return speechmatics(Speechmatics!);
            }
            else if (IsSoniox && soniox != null)
            {
                return soniox(Soniox!);
            }
            else if (IsSupabase && supabase != null)
            {
                return supabase(Supabase!);
            }
            else if (IsTavus && tavus != null)
            {
                return tavus(Tavus!);
            }
            else if (IsTogetherAi && togetherAi != null)
            {
                return togetherAi(TogetherAi!);
            }
            else if (IsTrieve && trieve != null)
            {
                return trieve(Trieve!);
            }
            else if (IsTwilio && twilio != null)
            {
                return twilio(Twilio!);
            }
            else if (IsVonage && vonage != null)
            {
                return vonage(Vonage!);
            }
            else if (IsWebhook && webhook != null)
            {
                return webhook(Webhook!);
            }
            else if (IsCustomCredential && customCredential != null)
            {
                return customCredential(CustomCredential!);
            }
            else if (IsXai && xai != null)
            {
                return xai(Xai!);
            }
            else if (IsGoogleCalendarOauth2Client && googleCalendarOauth2Client != null)
            {
                return googleCalendarOauth2Client(GoogleCalendarOauth2Client!);
            }
            else if (IsGoogleCalendarOauth2Authorization && googleCalendarOauth2Authorization != null)
            {
                return googleCalendarOauth2Authorization(GoogleCalendarOauth2Authorization!);
            }
            else if (IsGoogleSheetsOauth2Authorization && googleSheetsOauth2Authorization != null)
            {
                return googleSheetsOauth2Authorization(GoogleSheetsOauth2Authorization!);
            }
            else if (IsSlackOauth2Authorization && slackOauth2Authorization != null)
            {
                return slackOauth2Authorization(SlackOauth2Authorization!);
            }
            else if (IsGhlOauth2Authorization && ghlOauth2Authorization != null)
            {
                return ghlOauth2Authorization(GhlOauth2Authorization!);
            }
            else if (IsInworld && inworld != null)
            {
                return inworld(Inworld!);
            }
            else if (IsMinimax && minimax != null)
            {
                return minimax(Minimax!);
            }
            else if (IsWellsaid && wellsaid != null)
            {
                return wellsaid(Wellsaid!);
            }
            else if (IsEmail && email != null)
            {
                return email(Email!);
            }
            else if (IsSlackWebhook && slackWebhook != null)
            {
                return slackWebhook(SlackWebhook!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateAnthropicCredentialDTO>? anthropic = null,

            global::System.Action<global::G.CreateAnthropicBedrockCredentialDTO>? anthropicBedrock = null,

            global::System.Action<global::G.CreateAnyscaleCredentialDTO>? anyscale = null,

            global::System.Action<global::G.CreateAssemblyAICredentialDTO>? assemblyAi = null,

            global::System.Action<global::G.CreateAzureCredentialDTO>? azure = null,

            global::System.Action<global::G.CreateAzureOpenAICredentialDTO>? azureOpenai = null,

            global::System.Action<global::G.CreateByoSipTrunkCredentialDTO>? byoSipTrunk = null,

            global::System.Action<global::G.CreateCartesiaCredentialDTO>? cartesia = null,

            global::System.Action<global::G.CreateCerebrasCredentialDTO>? cerebras = null,

            global::System.Action<global::G.CreateCloudflareCredentialDTO>? cloudflare = null,

            global::System.Action<global::G.CreateCustomLLMCredentialDTO>? customLlm = null,

            global::System.Action<global::G.CreateDeepgramCredentialDTO>? deepgram = null,

            global::System.Action<global::G.CreateDeepInfraCredentialDTO>? deepinfra = null,

            global::System.Action<global::G.CreateDeepSeekCredentialDTO>? deepSeek = null,

            global::System.Action<global::G.CreateElevenLabsCredentialDTO>? elevenlabs = null,

            global::System.Action<global::G.CreateGcpCredentialDTO>? gcp = null,

            global::System.Action<global::G.CreateGladiaCredentialDTO>? gladia = null,

            global::System.Action<global::G.CreateGoHighLevelCredentialDTO>? gohighlevel = null,

            global::System.Action<global::G.CreateGoogleCredentialDTO>? google = null,

            global::System.Action<global::G.CreateGroqCredentialDTO>? groq = null,

            global::System.Action<global::G.CreateHumeCredentialDTO>? hume = null,

            global::System.Action<global::G.CreateInflectionAICredentialDTO>? inflectionAi = null,

            global::System.Action<global::G.CreateLangfuseCredentialDTO>? langfuse = null,

            global::System.Action<global::G.CreateLmntCredentialDTO>? lmnt = null,

            global::System.Action<global::G.CreateMakeCredentialDTO>? make = null,

            global::System.Action<global::G.CreateMistralCredentialDTO>? mistral = null,

            global::System.Action<global::G.CreateNeuphonicCredentialDTO>? neuphonic = null,

            global::System.Action<global::G.CreateOpenAICredentialDTO>? openai = null,

            global::System.Action<global::G.CreateOpenRouterCredentialDTO>? openrouter = null,

            global::System.Action<global::G.CreatePerplexityAICredentialDTO>? perplexityAi = null,

            global::System.Action<global::G.CreatePlayHTCredentialDTO>? playht = null,

            global::System.Action<global::G.CreateRimeAICredentialDTO>? rimeAi = null,

            global::System.Action<global::G.CreateRunpodCredentialDTO>? runpod = null,

            global::System.Action<global::G.CreateS3CredentialDTO>? s3 = null,

            global::System.Action<global::G.CreateSmallestAICredentialDTO>? smallestAi = null,

            global::System.Action<global::G.CreateSpeechmaticsCredentialDTO>? speechmatics = null,

            global::System.Action<global::G.CreateSonioxCredentialDTO>? soniox = null,

            global::System.Action<global::G.CreateSupabaseCredentialDTO>? supabase = null,

            global::System.Action<global::G.CreateTavusCredentialDTO>? tavus = null,

            global::System.Action<global::G.CreateTogetherAICredentialDTO>? togetherAi = null,

            global::System.Action<global::G.CreateTrieveCredentialDTO>? trieve = null,

            global::System.Action<global::G.CreateTwilioCredentialDTO>? twilio = null,

            global::System.Action<global::G.CreateVonageCredentialDTO>? vonage = null,

            global::System.Action<global::G.CreateWebhookCredentialDTO>? webhook = null,

            global::System.Action<global::G.CreateCustomCredentialDTO>? customCredential = null,

            global::System.Action<global::G.CreateXAiCredentialDTO>? xai = null,

            global::System.Action<global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO>? googleCalendarOauth2Client = null,

            global::System.Action<global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO>? googleCalendarOauth2Authorization = null,

            global::System.Action<global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO>? googleSheetsOauth2Authorization = null,

            global::System.Action<global::G.CreateSlackOAuth2AuthorizationCredentialDTO>? slackOauth2Authorization = null,

            global::System.Action<global::G.CreateGoHighLevelMCPCredentialDTO>? ghlOauth2Authorization = null,

            global::System.Action<global::G.CreateInworldCredentialDTO>? inworld = null,

            global::System.Action<global::G.CreateMinimaxCredentialDTO>? minimax = null,

            global::System.Action<global::G.CreateWellSaidCredentialDTO>? wellsaid = null,

            global::System.Action<global::G.CreateEmailCredentialDTO>? email = null,

            global::System.Action<global::G.CreateSlackWebhookCredentialDTO>? slackWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
            else if (IsAnthropicBedrock)
            {
                anthropicBedrock?.Invoke(AnthropicBedrock!);
            }
            else if (IsAnyscale)
            {
                anyscale?.Invoke(Anyscale!);
            }
            else if (IsAssemblyAi)
            {
                assemblyAi?.Invoke(AssemblyAi!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
            }
            else if (IsAzureOpenai)
            {
                azureOpenai?.Invoke(AzureOpenai!);
            }
            else if (IsByoSipTrunk)
            {
                byoSipTrunk?.Invoke(ByoSipTrunk!);
            }
            else if (IsCartesia)
            {
                cartesia?.Invoke(Cartesia!);
            }
            else if (IsCerebras)
            {
                cerebras?.Invoke(Cerebras!);
            }
            else if (IsCloudflare)
            {
                cloudflare?.Invoke(Cloudflare!);
            }
            else if (IsCustomLlm)
            {
                customLlm?.Invoke(CustomLlm!);
            }
            else if (IsDeepgram)
            {
                deepgram?.Invoke(Deepgram!);
            }
            else if (IsDeepinfra)
            {
                deepinfra?.Invoke(Deepinfra!);
            }
            else if (IsDeepSeek)
            {
                deepSeek?.Invoke(DeepSeek!);
            }
            else if (IsElevenlabs)
            {
                elevenlabs?.Invoke(Elevenlabs!);
            }
            else if (IsGcp)
            {
                gcp?.Invoke(Gcp!);
            }
            else if (IsGladia)
            {
                gladia?.Invoke(Gladia!);
            }
            else if (IsGohighlevel)
            {
                gohighlevel?.Invoke(Gohighlevel!);
            }
            else if (IsGoogle)
            {
                google?.Invoke(Google!);
            }
            else if (IsGroq)
            {
                groq?.Invoke(Groq!);
            }
            else if (IsHume)
            {
                hume?.Invoke(Hume!);
            }
            else if (IsInflectionAi)
            {
                inflectionAi?.Invoke(InflectionAi!);
            }
            else if (IsLangfuse)
            {
                langfuse?.Invoke(Langfuse!);
            }
            else if (IsLmnt)
            {
                lmnt?.Invoke(Lmnt!);
            }
            else if (IsMake)
            {
                make?.Invoke(Make!);
            }
            else if (IsMistral)
            {
                mistral?.Invoke(Mistral!);
            }
            else if (IsNeuphonic)
            {
                neuphonic?.Invoke(Neuphonic!);
            }
            else if (IsOpenai)
            {
                openai?.Invoke(Openai!);
            }
            else if (IsOpenrouter)
            {
                openrouter?.Invoke(Openrouter!);
            }
            else if (IsPerplexityAi)
            {
                perplexityAi?.Invoke(PerplexityAi!);
            }
            else if (IsPlayht)
            {
                playht?.Invoke(Playht!);
            }
            else if (IsRimeAi)
            {
                rimeAi?.Invoke(RimeAi!);
            }
            else if (IsRunpod)
            {
                runpod?.Invoke(Runpod!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsSmallestAi)
            {
                smallestAi?.Invoke(SmallestAi!);
            }
            else if (IsSpeechmatics)
            {
                speechmatics?.Invoke(Speechmatics!);
            }
            else if (IsSoniox)
            {
                soniox?.Invoke(Soniox!);
            }
            else if (IsSupabase)
            {
                supabase?.Invoke(Supabase!);
            }
            else if (IsTavus)
            {
                tavus?.Invoke(Tavus!);
            }
            else if (IsTogetherAi)
            {
                togetherAi?.Invoke(TogetherAi!);
            }
            else if (IsTrieve)
            {
                trieve?.Invoke(Trieve!);
            }
            else if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsVonage)
            {
                vonage?.Invoke(Vonage!);
            }
            else if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsCustomCredential)
            {
                customCredential?.Invoke(CustomCredential!);
            }
            else if (IsXai)
            {
                xai?.Invoke(Xai!);
            }
            else if (IsGoogleCalendarOauth2Client)
            {
                googleCalendarOauth2Client?.Invoke(GoogleCalendarOauth2Client!);
            }
            else if (IsGoogleCalendarOauth2Authorization)
            {
                googleCalendarOauth2Authorization?.Invoke(GoogleCalendarOauth2Authorization!);
            }
            else if (IsGoogleSheetsOauth2Authorization)
            {
                googleSheetsOauth2Authorization?.Invoke(GoogleSheetsOauth2Authorization!);
            }
            else if (IsSlackOauth2Authorization)
            {
                slackOauth2Authorization?.Invoke(SlackOauth2Authorization!);
            }
            else if (IsGhlOauth2Authorization)
            {
                ghlOauth2Authorization?.Invoke(GhlOauth2Authorization!);
            }
            else if (IsInworld)
            {
                inworld?.Invoke(Inworld!);
            }
            else if (IsMinimax)
            {
                minimax?.Invoke(Minimax!);
            }
            else if (IsWellsaid)
            {
                wellsaid?.Invoke(Wellsaid!);
            }
            else if (IsEmail)
            {
                email?.Invoke(Email!);
            }
            else if (IsSlackWebhook)
            {
                slackWebhook?.Invoke(SlackWebhook!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.CreateAnthropicCredentialDTO>? anthropic = null,
            global::System.Action<global::G.CreateAnthropicBedrockCredentialDTO>? anthropicBedrock = null,
            global::System.Action<global::G.CreateAnyscaleCredentialDTO>? anyscale = null,
            global::System.Action<global::G.CreateAssemblyAICredentialDTO>? assemblyAi = null,
            global::System.Action<global::G.CreateAzureCredentialDTO>? azure = null,
            global::System.Action<global::G.CreateAzureOpenAICredentialDTO>? azureOpenai = null,
            global::System.Action<global::G.CreateByoSipTrunkCredentialDTO>? byoSipTrunk = null,
            global::System.Action<global::G.CreateCartesiaCredentialDTO>? cartesia = null,
            global::System.Action<global::G.CreateCerebrasCredentialDTO>? cerebras = null,
            global::System.Action<global::G.CreateCloudflareCredentialDTO>? cloudflare = null,
            global::System.Action<global::G.CreateCustomLLMCredentialDTO>? customLlm = null,
            global::System.Action<global::G.CreateDeepgramCredentialDTO>? deepgram = null,
            global::System.Action<global::G.CreateDeepInfraCredentialDTO>? deepinfra = null,
            global::System.Action<global::G.CreateDeepSeekCredentialDTO>? deepSeek = null,
            global::System.Action<global::G.CreateElevenLabsCredentialDTO>? elevenlabs = null,
            global::System.Action<global::G.CreateGcpCredentialDTO>? gcp = null,
            global::System.Action<global::G.CreateGladiaCredentialDTO>? gladia = null,
            global::System.Action<global::G.CreateGoHighLevelCredentialDTO>? gohighlevel = null,
            global::System.Action<global::G.CreateGoogleCredentialDTO>? google = null,
            global::System.Action<global::G.CreateGroqCredentialDTO>? groq = null,
            global::System.Action<global::G.CreateHumeCredentialDTO>? hume = null,
            global::System.Action<global::G.CreateInflectionAICredentialDTO>? inflectionAi = null,
            global::System.Action<global::G.CreateLangfuseCredentialDTO>? langfuse = null,
            global::System.Action<global::G.CreateLmntCredentialDTO>? lmnt = null,
            global::System.Action<global::G.CreateMakeCredentialDTO>? make = null,
            global::System.Action<global::G.CreateMistralCredentialDTO>? mistral = null,
            global::System.Action<global::G.CreateNeuphonicCredentialDTO>? neuphonic = null,
            global::System.Action<global::G.CreateOpenAICredentialDTO>? openai = null,
            global::System.Action<global::G.CreateOpenRouterCredentialDTO>? openrouter = null,
            global::System.Action<global::G.CreatePerplexityAICredentialDTO>? perplexityAi = null,
            global::System.Action<global::G.CreatePlayHTCredentialDTO>? playht = null,
            global::System.Action<global::G.CreateRimeAICredentialDTO>? rimeAi = null,
            global::System.Action<global::G.CreateRunpodCredentialDTO>? runpod = null,
            global::System.Action<global::G.CreateS3CredentialDTO>? s3 = null,
            global::System.Action<global::G.CreateSmallestAICredentialDTO>? smallestAi = null,
            global::System.Action<global::G.CreateSpeechmaticsCredentialDTO>? speechmatics = null,
            global::System.Action<global::G.CreateSonioxCredentialDTO>? soniox = null,
            global::System.Action<global::G.CreateSupabaseCredentialDTO>? supabase = null,
            global::System.Action<global::G.CreateTavusCredentialDTO>? tavus = null,
            global::System.Action<global::G.CreateTogetherAICredentialDTO>? togetherAi = null,
            global::System.Action<global::G.CreateTrieveCredentialDTO>? trieve = null,
            global::System.Action<global::G.CreateTwilioCredentialDTO>? twilio = null,
            global::System.Action<global::G.CreateVonageCredentialDTO>? vonage = null,
            global::System.Action<global::G.CreateWebhookCredentialDTO>? webhook = null,
            global::System.Action<global::G.CreateCustomCredentialDTO>? customCredential = null,
            global::System.Action<global::G.CreateXAiCredentialDTO>? xai = null,
            global::System.Action<global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO>? googleCalendarOauth2Client = null,
            global::System.Action<global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO>? googleCalendarOauth2Authorization = null,
            global::System.Action<global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO>? googleSheetsOauth2Authorization = null,
            global::System.Action<global::G.CreateSlackOAuth2AuthorizationCredentialDTO>? slackOauth2Authorization = null,
            global::System.Action<global::G.CreateGoHighLevelMCPCredentialDTO>? ghlOauth2Authorization = null,
            global::System.Action<global::G.CreateInworldCredentialDTO>? inworld = null,
            global::System.Action<global::G.CreateMinimaxCredentialDTO>? minimax = null,
            global::System.Action<global::G.CreateWellSaidCredentialDTO>? wellsaid = null,
            global::System.Action<global::G.CreateEmailCredentialDTO>? email = null,
            global::System.Action<global::G.CreateSlackWebhookCredentialDTO>? slackWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
            else if (IsAnthropicBedrock)
            {
                anthropicBedrock?.Invoke(AnthropicBedrock!);
            }
            else if (IsAnyscale)
            {
                anyscale?.Invoke(Anyscale!);
            }
            else if (IsAssemblyAi)
            {
                assemblyAi?.Invoke(AssemblyAi!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
            }
            else if (IsAzureOpenai)
            {
                azureOpenai?.Invoke(AzureOpenai!);
            }
            else if (IsByoSipTrunk)
            {
                byoSipTrunk?.Invoke(ByoSipTrunk!);
            }
            else if (IsCartesia)
            {
                cartesia?.Invoke(Cartesia!);
            }
            else if (IsCerebras)
            {
                cerebras?.Invoke(Cerebras!);
            }
            else if (IsCloudflare)
            {
                cloudflare?.Invoke(Cloudflare!);
            }
            else if (IsCustomLlm)
            {
                customLlm?.Invoke(CustomLlm!);
            }
            else if (IsDeepgram)
            {
                deepgram?.Invoke(Deepgram!);
            }
            else if (IsDeepinfra)
            {
                deepinfra?.Invoke(Deepinfra!);
            }
            else if (IsDeepSeek)
            {
                deepSeek?.Invoke(DeepSeek!);
            }
            else if (IsElevenlabs)
            {
                elevenlabs?.Invoke(Elevenlabs!);
            }
            else if (IsGcp)
            {
                gcp?.Invoke(Gcp!);
            }
            else if (IsGladia)
            {
                gladia?.Invoke(Gladia!);
            }
            else if (IsGohighlevel)
            {
                gohighlevel?.Invoke(Gohighlevel!);
            }
            else if (IsGoogle)
            {
                google?.Invoke(Google!);
            }
            else if (IsGroq)
            {
                groq?.Invoke(Groq!);
            }
            else if (IsHume)
            {
                hume?.Invoke(Hume!);
            }
            else if (IsInflectionAi)
            {
                inflectionAi?.Invoke(InflectionAi!);
            }
            else if (IsLangfuse)
            {
                langfuse?.Invoke(Langfuse!);
            }
            else if (IsLmnt)
            {
                lmnt?.Invoke(Lmnt!);
            }
            else if (IsMake)
            {
                make?.Invoke(Make!);
            }
            else if (IsMistral)
            {
                mistral?.Invoke(Mistral!);
            }
            else if (IsNeuphonic)
            {
                neuphonic?.Invoke(Neuphonic!);
            }
            else if (IsOpenai)
            {
                openai?.Invoke(Openai!);
            }
            else if (IsOpenrouter)
            {
                openrouter?.Invoke(Openrouter!);
            }
            else if (IsPerplexityAi)
            {
                perplexityAi?.Invoke(PerplexityAi!);
            }
            else if (IsPlayht)
            {
                playht?.Invoke(Playht!);
            }
            else if (IsRimeAi)
            {
                rimeAi?.Invoke(RimeAi!);
            }
            else if (IsRunpod)
            {
                runpod?.Invoke(Runpod!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsSmallestAi)
            {
                smallestAi?.Invoke(SmallestAi!);
            }
            else if (IsSpeechmatics)
            {
                speechmatics?.Invoke(Speechmatics!);
            }
            else if (IsSoniox)
            {
                soniox?.Invoke(Soniox!);
            }
            else if (IsSupabase)
            {
                supabase?.Invoke(Supabase!);
            }
            else if (IsTavus)
            {
                tavus?.Invoke(Tavus!);
            }
            else if (IsTogetherAi)
            {
                togetherAi?.Invoke(TogetherAi!);
            }
            else if (IsTrieve)
            {
                trieve?.Invoke(Trieve!);
            }
            else if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsVonage)
            {
                vonage?.Invoke(Vonage!);
            }
            else if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsCustomCredential)
            {
                customCredential?.Invoke(CustomCredential!);
            }
            else if (IsXai)
            {
                xai?.Invoke(Xai!);
            }
            else if (IsGoogleCalendarOauth2Client)
            {
                googleCalendarOauth2Client?.Invoke(GoogleCalendarOauth2Client!);
            }
            else if (IsGoogleCalendarOauth2Authorization)
            {
                googleCalendarOauth2Authorization?.Invoke(GoogleCalendarOauth2Authorization!);
            }
            else if (IsGoogleSheetsOauth2Authorization)
            {
                googleSheetsOauth2Authorization?.Invoke(GoogleSheetsOauth2Authorization!);
            }
            else if (IsSlackOauth2Authorization)
            {
                slackOauth2Authorization?.Invoke(SlackOauth2Authorization!);
            }
            else if (IsGhlOauth2Authorization)
            {
                ghlOauth2Authorization?.Invoke(GhlOauth2Authorization!);
            }
            else if (IsInworld)
            {
                inworld?.Invoke(Inworld!);
            }
            else if (IsMinimax)
            {
                minimax?.Invoke(Minimax!);
            }
            else if (IsWellsaid)
            {
                wellsaid?.Invoke(Wellsaid!);
            }
            else if (IsEmail)
            {
                email?.Invoke(Email!);
            }
            else if (IsSlackWebhook)
            {
                slackWebhook?.Invoke(SlackWebhook!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Anthropic,
                typeof(global::G.CreateAnthropicCredentialDTO),
                AnthropicBedrock,
                typeof(global::G.CreateAnthropicBedrockCredentialDTO),
                Anyscale,
                typeof(global::G.CreateAnyscaleCredentialDTO),
                AssemblyAi,
                typeof(global::G.CreateAssemblyAICredentialDTO),
                Azure,
                typeof(global::G.CreateAzureCredentialDTO),
                AzureOpenai,
                typeof(global::G.CreateAzureOpenAICredentialDTO),
                ByoSipTrunk,
                typeof(global::G.CreateByoSipTrunkCredentialDTO),
                Cartesia,
                typeof(global::G.CreateCartesiaCredentialDTO),
                Cerebras,
                typeof(global::G.CreateCerebrasCredentialDTO),
                Cloudflare,
                typeof(global::G.CreateCloudflareCredentialDTO),
                CustomLlm,
                typeof(global::G.CreateCustomLLMCredentialDTO),
                Deepgram,
                typeof(global::G.CreateDeepgramCredentialDTO),
                Deepinfra,
                typeof(global::G.CreateDeepInfraCredentialDTO),
                DeepSeek,
                typeof(global::G.CreateDeepSeekCredentialDTO),
                Elevenlabs,
                typeof(global::G.CreateElevenLabsCredentialDTO),
                Gcp,
                typeof(global::G.CreateGcpCredentialDTO),
                Gladia,
                typeof(global::G.CreateGladiaCredentialDTO),
                Gohighlevel,
                typeof(global::G.CreateGoHighLevelCredentialDTO),
                Google,
                typeof(global::G.CreateGoogleCredentialDTO),
                Groq,
                typeof(global::G.CreateGroqCredentialDTO),
                Hume,
                typeof(global::G.CreateHumeCredentialDTO),
                InflectionAi,
                typeof(global::G.CreateInflectionAICredentialDTO),
                Langfuse,
                typeof(global::G.CreateLangfuseCredentialDTO),
                Lmnt,
                typeof(global::G.CreateLmntCredentialDTO),
                Make,
                typeof(global::G.CreateMakeCredentialDTO),
                Mistral,
                typeof(global::G.CreateMistralCredentialDTO),
                Neuphonic,
                typeof(global::G.CreateNeuphonicCredentialDTO),
                Openai,
                typeof(global::G.CreateOpenAICredentialDTO),
                Openrouter,
                typeof(global::G.CreateOpenRouterCredentialDTO),
                PerplexityAi,
                typeof(global::G.CreatePerplexityAICredentialDTO),
                Playht,
                typeof(global::G.CreatePlayHTCredentialDTO),
                RimeAi,
                typeof(global::G.CreateRimeAICredentialDTO),
                Runpod,
                typeof(global::G.CreateRunpodCredentialDTO),
                S3,
                typeof(global::G.CreateS3CredentialDTO),
                SmallestAi,
                typeof(global::G.CreateSmallestAICredentialDTO),
                Speechmatics,
                typeof(global::G.CreateSpeechmaticsCredentialDTO),
                Soniox,
                typeof(global::G.CreateSonioxCredentialDTO),
                Supabase,
                typeof(global::G.CreateSupabaseCredentialDTO),
                Tavus,
                typeof(global::G.CreateTavusCredentialDTO),
                TogetherAi,
                typeof(global::G.CreateTogetherAICredentialDTO),
                Trieve,
                typeof(global::G.CreateTrieveCredentialDTO),
                Twilio,
                typeof(global::G.CreateTwilioCredentialDTO),
                Vonage,
                typeof(global::G.CreateVonageCredentialDTO),
                Webhook,
                typeof(global::G.CreateWebhookCredentialDTO),
                CustomCredential,
                typeof(global::G.CreateCustomCredentialDTO),
                Xai,
                typeof(global::G.CreateXAiCredentialDTO),
                GoogleCalendarOauth2Client,
                typeof(global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO),
                GoogleCalendarOauth2Authorization,
                typeof(global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO),
                GoogleSheetsOauth2Authorization,
                typeof(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO),
                SlackOauth2Authorization,
                typeof(global::G.CreateSlackOAuth2AuthorizationCredentialDTO),
                GhlOauth2Authorization,
                typeof(global::G.CreateGoHighLevelMCPCredentialDTO),
                Inworld,
                typeof(global::G.CreateInworldCredentialDTO),
                Minimax,
                typeof(global::G.CreateMinimaxCredentialDTO),
                Wellsaid,
                typeof(global::G.CreateWellSaidCredentialDTO),
                Email,
                typeof(global::G.CreateEmailCredentialDTO),
                SlackWebhook,
                typeof(global::G.CreateSlackWebhookCredentialDTO),
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
        public bool Equals(CredentialsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAnthropicCredentialDTO?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAnthropicBedrockCredentialDTO?>.Default.Equals(AnthropicBedrock, other.AnthropicBedrock) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAnyscaleCredentialDTO?>.Default.Equals(Anyscale, other.Anyscale) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAssemblyAICredentialDTO?>.Default.Equals(AssemblyAi, other.AssemblyAi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAzureCredentialDTO?>.Default.Equals(Azure, other.Azure) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAzureOpenAICredentialDTO?>.Default.Equals(AzureOpenai, other.AzureOpenai) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateByoSipTrunkCredentialDTO?>.Default.Equals(ByoSipTrunk, other.ByoSipTrunk) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateCartesiaCredentialDTO?>.Default.Equals(Cartesia, other.Cartesia) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateCerebrasCredentialDTO?>.Default.Equals(Cerebras, other.Cerebras) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateCloudflareCredentialDTO?>.Default.Equals(Cloudflare, other.Cloudflare) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateCustomLLMCredentialDTO?>.Default.Equals(CustomLlm, other.CustomLlm) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateDeepgramCredentialDTO?>.Default.Equals(Deepgram, other.Deepgram) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateDeepInfraCredentialDTO?>.Default.Equals(Deepinfra, other.Deepinfra) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateDeepSeekCredentialDTO?>.Default.Equals(DeepSeek, other.DeepSeek) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateElevenLabsCredentialDTO?>.Default.Equals(Elevenlabs, other.Elevenlabs) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGcpCredentialDTO?>.Default.Equals(Gcp, other.Gcp) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGladiaCredentialDTO?>.Default.Equals(Gladia, other.Gladia) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoHighLevelCredentialDTO?>.Default.Equals(Gohighlevel, other.Gohighlevel) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoogleCredentialDTO?>.Default.Equals(Google, other.Google) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGroqCredentialDTO?>.Default.Equals(Groq, other.Groq) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateHumeCredentialDTO?>.Default.Equals(Hume, other.Hume) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateInflectionAICredentialDTO?>.Default.Equals(InflectionAi, other.InflectionAi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateLangfuseCredentialDTO?>.Default.Equals(Langfuse, other.Langfuse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateLmntCredentialDTO?>.Default.Equals(Lmnt, other.Lmnt) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateMakeCredentialDTO?>.Default.Equals(Make, other.Make) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateMistralCredentialDTO?>.Default.Equals(Mistral, other.Mistral) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateNeuphonicCredentialDTO?>.Default.Equals(Neuphonic, other.Neuphonic) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateOpenAICredentialDTO?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateOpenRouterCredentialDTO?>.Default.Equals(Openrouter, other.Openrouter) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreatePerplexityAICredentialDTO?>.Default.Equals(PerplexityAi, other.PerplexityAi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreatePlayHTCredentialDTO?>.Default.Equals(Playht, other.Playht) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateRimeAICredentialDTO?>.Default.Equals(RimeAi, other.RimeAi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateRunpodCredentialDTO?>.Default.Equals(Runpod, other.Runpod) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateS3CredentialDTO?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSmallestAICredentialDTO?>.Default.Equals(SmallestAi, other.SmallestAi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSpeechmaticsCredentialDTO?>.Default.Equals(Speechmatics, other.Speechmatics) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSonioxCredentialDTO?>.Default.Equals(Soniox, other.Soniox) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSupabaseCredentialDTO?>.Default.Equals(Supabase, other.Supabase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTavusCredentialDTO?>.Default.Equals(Tavus, other.Tavus) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTogetherAICredentialDTO?>.Default.Equals(TogetherAi, other.TogetherAi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTrieveCredentialDTO?>.Default.Equals(Trieve, other.Trieve) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTwilioCredentialDTO?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateVonageCredentialDTO?>.Default.Equals(Vonage, other.Vonage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateWebhookCredentialDTO?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateCustomCredentialDTO?>.Default.Equals(CustomCredential, other.CustomCredential) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateXAiCredentialDTO?>.Default.Equals(Xai, other.Xai) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO?>.Default.Equals(GoogleCalendarOauth2Client, other.GoogleCalendarOauth2Client) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?>.Default.Equals(GoogleCalendarOauth2Authorization, other.GoogleCalendarOauth2Authorization) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?>.Default.Equals(GoogleSheetsOauth2Authorization, other.GoogleSheetsOauth2Authorization) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSlackOAuth2AuthorizationCredentialDTO?>.Default.Equals(SlackOauth2Authorization, other.SlackOauth2Authorization) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoHighLevelMCPCredentialDTO?>.Default.Equals(GhlOauth2Authorization, other.GhlOauth2Authorization) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateInworldCredentialDTO?>.Default.Equals(Inworld, other.Inworld) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateMinimaxCredentialDTO?>.Default.Equals(Minimax, other.Minimax) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateWellSaidCredentialDTO?>.Default.Equals(Wellsaid, other.Wellsaid) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateEmailCredentialDTO?>.Default.Equals(Email, other.Email) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSlackWebhookCredentialDTO?>.Default.Equals(SlackWebhook, other.SlackWebhook) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CredentialsItem obj1, CredentialsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CredentialsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CredentialsItem obj1, CredentialsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CredentialsItem o && Equals(o);
        }
    }
}
