//HintName: G.Models.EmbeddingConfig3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingConfig3 : global::System.IEquatable<EmbeddingConfig3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PipelineEmbeddingConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ManagedOpenAIEmbeddingConfig? ManagedOpenaiEmbedding { get; init; }
#else
        public global::G.ManagedOpenAIEmbeddingConfig? ManagedOpenaiEmbedding { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ManagedOpenaiEmbedding))]
#endif
        public bool IsManagedOpenaiEmbedding => ManagedOpenaiEmbedding != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickManagedOpenaiEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ManagedOpenAIEmbeddingConfig? value)
        {
            value = ManagedOpenaiEmbedding;
            return IsManagedOpenaiEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ManagedOpenAIEmbeddingConfig PickManagedOpenaiEmbedding() => ManagedOpenaiEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ManagedOpenaiEmbedding' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AzureOpenAIEmbeddingConfig? AzureEmbedding { get; init; }
#else
        public global::G.AzureOpenAIEmbeddingConfig? AzureEmbedding { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureEmbedding))]
#endif
        public bool IsAzureEmbedding => AzureEmbedding != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAzureEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.AzureOpenAIEmbeddingConfig? value)
        {
            value = AzureEmbedding;
            return IsAzureEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.AzureOpenAIEmbeddingConfig PickAzureEmbedding() => AzureEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AzureEmbedding' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CohereEmbeddingConfig? CohereEmbedding { get; init; }
#else
        public global::G.CohereEmbeddingConfig? CohereEmbedding { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CohereEmbedding))]
#endif
        public bool IsCohereEmbedding => CohereEmbedding != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCohereEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CohereEmbeddingConfig? value)
        {
            value = CohereEmbedding;
            return IsCohereEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CohereEmbeddingConfig PickCohereEmbedding() => CohereEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CohereEmbedding' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GeminiEmbeddingConfig? GeminiEmbedding { get; init; }
#else
        public global::G.GeminiEmbeddingConfig? GeminiEmbedding { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeminiEmbedding))]
#endif
        public bool IsGeminiEmbedding => GeminiEmbedding != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGeminiEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GeminiEmbeddingConfig? value)
        {
            value = GeminiEmbedding;
            return IsGeminiEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.GeminiEmbeddingConfig PickGeminiEmbedding() => GeminiEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiEmbedding' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HuggingFaceInferenceAPIEmbeddingConfig? HuggingfaceApiEmbedding { get; init; }
#else
        public global::G.HuggingFaceInferenceAPIEmbeddingConfig? HuggingfaceApiEmbedding { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HuggingfaceApiEmbedding))]
#endif
        public bool IsHuggingfaceApiEmbedding => HuggingfaceApiEmbedding != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHuggingfaceApiEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.HuggingFaceInferenceAPIEmbeddingConfig? value)
        {
            value = HuggingfaceApiEmbedding;
            return IsHuggingfaceApiEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.HuggingFaceInferenceAPIEmbeddingConfig PickHuggingfaceApiEmbedding() => HuggingfaceApiEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HuggingfaceApiEmbedding' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAIEmbeddingConfig? OpenaiEmbedding { get; init; }
#else
        public global::G.OpenAIEmbeddingConfig? OpenaiEmbedding { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiEmbedding))]
#endif
        public bool IsOpenaiEmbedding => OpenaiEmbedding != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenaiEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.OpenAIEmbeddingConfig? value)
        {
            value = OpenaiEmbedding;
            return IsOpenaiEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAIEmbeddingConfig PickOpenaiEmbedding() => OpenaiEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenaiEmbedding' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VertexAIEmbeddingConfig? VertexaiEmbedding { get; init; }
#else
        public global::G.VertexAIEmbeddingConfig? VertexaiEmbedding { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VertexaiEmbedding))]
#endif
        public bool IsVertexaiEmbedding => VertexaiEmbedding != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVertexaiEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.VertexAIEmbeddingConfig? value)
        {
            value = VertexaiEmbedding;
            return IsVertexaiEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.VertexAIEmbeddingConfig PickVertexaiEmbedding() => VertexaiEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VertexaiEmbedding' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BedrockEmbeddingConfig? BedrockEmbedding { get; init; }
#else
        public global::G.BedrockEmbeddingConfig? BedrockEmbedding { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BedrockEmbedding))]
#endif
        public bool IsBedrockEmbedding => BedrockEmbedding != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBedrockEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BedrockEmbeddingConfig? value)
        {
            value = BedrockEmbedding;
            return IsBedrockEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BedrockEmbeddingConfig PickBedrockEmbedding() => BedrockEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BedrockEmbedding' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig3(global::G.ManagedOpenAIEmbeddingConfig value) => new EmbeddingConfig3((global::G.ManagedOpenAIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ManagedOpenAIEmbeddingConfig?(EmbeddingConfig3 @this) => @this.ManagedOpenaiEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig3(global::G.ManagedOpenAIEmbeddingConfig? value)
        {
            ManagedOpenaiEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingConfig3 FromManagedOpenaiEmbedding(global::G.ManagedOpenAIEmbeddingConfig? value) => new EmbeddingConfig3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig3(global::G.AzureOpenAIEmbeddingConfig value) => new EmbeddingConfig3((global::G.AzureOpenAIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AzureOpenAIEmbeddingConfig?(EmbeddingConfig3 @this) => @this.AzureEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig3(global::G.AzureOpenAIEmbeddingConfig? value)
        {
            AzureEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingConfig3 FromAzureEmbedding(global::G.AzureOpenAIEmbeddingConfig? value) => new EmbeddingConfig3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig3(global::G.CohereEmbeddingConfig value) => new EmbeddingConfig3((global::G.CohereEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CohereEmbeddingConfig?(EmbeddingConfig3 @this) => @this.CohereEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig3(global::G.CohereEmbeddingConfig? value)
        {
            CohereEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingConfig3 FromCohereEmbedding(global::G.CohereEmbeddingConfig? value) => new EmbeddingConfig3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig3(global::G.GeminiEmbeddingConfig value) => new EmbeddingConfig3((global::G.GeminiEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GeminiEmbeddingConfig?(EmbeddingConfig3 @this) => @this.GeminiEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig3(global::G.GeminiEmbeddingConfig? value)
        {
            GeminiEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingConfig3 FromGeminiEmbedding(global::G.GeminiEmbeddingConfig? value) => new EmbeddingConfig3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig3(global::G.HuggingFaceInferenceAPIEmbeddingConfig value) => new EmbeddingConfig3((global::G.HuggingFaceInferenceAPIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HuggingFaceInferenceAPIEmbeddingConfig?(EmbeddingConfig3 @this) => @this.HuggingfaceApiEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig3(global::G.HuggingFaceInferenceAPIEmbeddingConfig? value)
        {
            HuggingfaceApiEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingConfig3 FromHuggingfaceApiEmbedding(global::G.HuggingFaceInferenceAPIEmbeddingConfig? value) => new EmbeddingConfig3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig3(global::G.OpenAIEmbeddingConfig value) => new EmbeddingConfig3((global::G.OpenAIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAIEmbeddingConfig?(EmbeddingConfig3 @this) => @this.OpenaiEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig3(global::G.OpenAIEmbeddingConfig? value)
        {
            OpenaiEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingConfig3 FromOpenaiEmbedding(global::G.OpenAIEmbeddingConfig? value) => new EmbeddingConfig3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig3(global::G.VertexAIEmbeddingConfig value) => new EmbeddingConfig3((global::G.VertexAIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VertexAIEmbeddingConfig?(EmbeddingConfig3 @this) => @this.VertexaiEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig3(global::G.VertexAIEmbeddingConfig? value)
        {
            VertexaiEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingConfig3 FromVertexaiEmbedding(global::G.VertexAIEmbeddingConfig? value) => new EmbeddingConfig3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig3(global::G.BedrockEmbeddingConfig value) => new EmbeddingConfig3((global::G.BedrockEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BedrockEmbeddingConfig?(EmbeddingConfig3 @this) => @this.BedrockEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig3(global::G.BedrockEmbeddingConfig? value)
        {
            BedrockEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingConfig3 FromBedrockEmbedding(global::G.BedrockEmbeddingConfig? value) => new EmbeddingConfig3(value);

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig3(
            global::G.PipelineEmbeddingConfigDiscriminatorType? type,
            global::G.ManagedOpenAIEmbeddingConfig? managedOpenaiEmbedding,
            global::G.AzureOpenAIEmbeddingConfig? azureEmbedding,
            global::G.CohereEmbeddingConfig? cohereEmbedding,
            global::G.GeminiEmbeddingConfig? geminiEmbedding,
            global::G.HuggingFaceInferenceAPIEmbeddingConfig? huggingfaceApiEmbedding,
            global::G.OpenAIEmbeddingConfig? openaiEmbedding,
            global::G.VertexAIEmbeddingConfig? vertexaiEmbedding,
            global::G.BedrockEmbeddingConfig? bedrockEmbedding
            )
        {
            Type = type;

            ManagedOpenaiEmbedding = managedOpenaiEmbedding;
            AzureEmbedding = azureEmbedding;
            CohereEmbedding = cohereEmbedding;
            GeminiEmbedding = geminiEmbedding;
            HuggingfaceApiEmbedding = huggingfaceApiEmbedding;
            OpenaiEmbedding = openaiEmbedding;
            VertexaiEmbedding = vertexaiEmbedding;
            BedrockEmbedding = bedrockEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BedrockEmbedding as object ??
            VertexaiEmbedding as object ??
            OpenaiEmbedding as object ??
            HuggingfaceApiEmbedding as object ??
            GeminiEmbedding as object ??
            CohereEmbedding as object ??
            AzureEmbedding as object ??
            ManagedOpenaiEmbedding as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ManagedOpenaiEmbedding?.ToString() ??
            AzureEmbedding?.ToString() ??
            CohereEmbedding?.ToString() ??
            GeminiEmbedding?.ToString() ??
            HuggingfaceApiEmbedding?.ToString() ??
            OpenaiEmbedding?.ToString() ??
            VertexaiEmbedding?.ToString() ??
            BedrockEmbedding?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && IsBedrockEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ManagedOpenAIEmbeddingConfig, TResult>? managedOpenaiEmbedding = null,
            global::System.Func<global::G.AzureOpenAIEmbeddingConfig, TResult>? azureEmbedding = null,
            global::System.Func<global::G.CohereEmbeddingConfig, TResult>? cohereEmbedding = null,
            global::System.Func<global::G.GeminiEmbeddingConfig, TResult>? geminiEmbedding = null,
            global::System.Func<global::G.HuggingFaceInferenceAPIEmbeddingConfig, TResult>? huggingfaceApiEmbedding = null,
            global::System.Func<global::G.OpenAIEmbeddingConfig, TResult>? openaiEmbedding = null,
            global::System.Func<global::G.VertexAIEmbeddingConfig, TResult>? vertexaiEmbedding = null,
            global::System.Func<global::G.BedrockEmbeddingConfig, TResult>? bedrockEmbedding = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ManagedOpenaiEmbedding is { } __value0 && managedOpenaiEmbedding != null)
            {
                return managedOpenaiEmbedding(__value0);
            }
            else if (AzureEmbedding is { } __value1 && azureEmbedding != null)
            {
                return azureEmbedding(__value1);
            }
            else if (CohereEmbedding is { } __value2 && cohereEmbedding != null)
            {
                return cohereEmbedding(__value2);
            }
            else if (GeminiEmbedding is { } __value3 && geminiEmbedding != null)
            {
                return geminiEmbedding(__value3);
            }
            else if (HuggingfaceApiEmbedding is { } __value4 && huggingfaceApiEmbedding != null)
            {
                return huggingfaceApiEmbedding(__value4);
            }
            else if (OpenaiEmbedding is { } __value5 && openaiEmbedding != null)
            {
                return openaiEmbedding(__value5);
            }
            else if (VertexaiEmbedding is { } __value6 && vertexaiEmbedding != null)
            {
                return vertexaiEmbedding(__value6);
            }
            else if (BedrockEmbedding is { } __value7 && bedrockEmbedding != null)
            {
                return bedrockEmbedding(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ManagedOpenAIEmbeddingConfig>? managedOpenaiEmbedding = null,

            global::System.Action<global::G.AzureOpenAIEmbeddingConfig>? azureEmbedding = null,

            global::System.Action<global::G.CohereEmbeddingConfig>? cohereEmbedding = null,

            global::System.Action<global::G.GeminiEmbeddingConfig>? geminiEmbedding = null,

            global::System.Action<global::G.HuggingFaceInferenceAPIEmbeddingConfig>? huggingfaceApiEmbedding = null,

            global::System.Action<global::G.OpenAIEmbeddingConfig>? openaiEmbedding = null,

            global::System.Action<global::G.VertexAIEmbeddingConfig>? vertexaiEmbedding = null,

            global::System.Action<global::G.BedrockEmbeddingConfig>? bedrockEmbedding = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ManagedOpenaiEmbedding is { } __value0)
            {
                managedOpenaiEmbedding?.Invoke(__value0);
            }
            else if (AzureEmbedding is { } __value1)
            {
                azureEmbedding?.Invoke(__value1);
            }
            else if (CohereEmbedding is { } __value2)
            {
                cohereEmbedding?.Invoke(__value2);
            }
            else if (GeminiEmbedding is { } __value3)
            {
                geminiEmbedding?.Invoke(__value3);
            }
            else if (HuggingfaceApiEmbedding is { } __value4)
            {
                huggingfaceApiEmbedding?.Invoke(__value4);
            }
            else if (OpenaiEmbedding is { } __value5)
            {
                openaiEmbedding?.Invoke(__value5);
            }
            else if (VertexaiEmbedding is { } __value6)
            {
                vertexaiEmbedding?.Invoke(__value6);
            }
            else if (BedrockEmbedding is { } __value7)
            {
                bedrockEmbedding?.Invoke(__value7);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ManagedOpenAIEmbeddingConfig>? managedOpenaiEmbedding = null,
            global::System.Action<global::G.AzureOpenAIEmbeddingConfig>? azureEmbedding = null,
            global::System.Action<global::G.CohereEmbeddingConfig>? cohereEmbedding = null,
            global::System.Action<global::G.GeminiEmbeddingConfig>? geminiEmbedding = null,
            global::System.Action<global::G.HuggingFaceInferenceAPIEmbeddingConfig>? huggingfaceApiEmbedding = null,
            global::System.Action<global::G.OpenAIEmbeddingConfig>? openaiEmbedding = null,
            global::System.Action<global::G.VertexAIEmbeddingConfig>? vertexaiEmbedding = null,
            global::System.Action<global::G.BedrockEmbeddingConfig>? bedrockEmbedding = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ManagedOpenaiEmbedding is { } __value0)
            {
                managedOpenaiEmbedding?.Invoke(__value0);
            }
            else if (AzureEmbedding is { } __value1)
            {
                azureEmbedding?.Invoke(__value1);
            }
            else if (CohereEmbedding is { } __value2)
            {
                cohereEmbedding?.Invoke(__value2);
            }
            else if (GeminiEmbedding is { } __value3)
            {
                geminiEmbedding?.Invoke(__value3);
            }
            else if (HuggingfaceApiEmbedding is { } __value4)
            {
                huggingfaceApiEmbedding?.Invoke(__value4);
            }
            else if (OpenaiEmbedding is { } __value5)
            {
                openaiEmbedding?.Invoke(__value5);
            }
            else if (VertexaiEmbedding is { } __value6)
            {
                vertexaiEmbedding?.Invoke(__value6);
            }
            else if (BedrockEmbedding is { } __value7)
            {
                bedrockEmbedding?.Invoke(__value7);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ManagedOpenaiEmbedding,
                typeof(global::G.ManagedOpenAIEmbeddingConfig),
                AzureEmbedding,
                typeof(global::G.AzureOpenAIEmbeddingConfig),
                CohereEmbedding,
                typeof(global::G.CohereEmbeddingConfig),
                GeminiEmbedding,
                typeof(global::G.GeminiEmbeddingConfig),
                HuggingfaceApiEmbedding,
                typeof(global::G.HuggingFaceInferenceAPIEmbeddingConfig),
                OpenaiEmbedding,
                typeof(global::G.OpenAIEmbeddingConfig),
                VertexaiEmbedding,
                typeof(global::G.VertexAIEmbeddingConfig),
                BedrockEmbedding,
                typeof(global::G.BedrockEmbeddingConfig),
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
        public bool Equals(EmbeddingConfig3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ManagedOpenAIEmbeddingConfig?>.Default.Equals(ManagedOpenaiEmbedding, other.ManagedOpenaiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AzureOpenAIEmbeddingConfig?>.Default.Equals(AzureEmbedding, other.AzureEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CohereEmbeddingConfig?>.Default.Equals(CohereEmbedding, other.CohereEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GeminiEmbeddingConfig?>.Default.Equals(GeminiEmbedding, other.GeminiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HuggingFaceInferenceAPIEmbeddingConfig?>.Default.Equals(HuggingfaceApiEmbedding, other.HuggingfaceApiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAIEmbeddingConfig?>.Default.Equals(OpenaiEmbedding, other.OpenaiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VertexAIEmbeddingConfig?>.Default.Equals(VertexaiEmbedding, other.VertexaiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BedrockEmbeddingConfig?>.Default.Equals(BedrockEmbedding, other.BedrockEmbedding) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingConfig3 obj1, EmbeddingConfig3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingConfig3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingConfig3 obj1, EmbeddingConfig3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingConfig3 o && Equals(o);
        }
    }
}
