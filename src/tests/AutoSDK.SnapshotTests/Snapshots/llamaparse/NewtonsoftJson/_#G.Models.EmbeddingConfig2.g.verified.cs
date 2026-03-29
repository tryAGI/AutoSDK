//HintName: G.Models.EmbeddingConfig2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The embedding configuration for the embedding model config.
    /// </summary>
    public readonly partial struct EmbeddingConfig2 : global::System.IEquatable<EmbeddingConfig2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AzureOpenAIEmbeddingConfig? AzureEmbedding1 { get; init; }
#else
        public global::G.AzureOpenAIEmbeddingConfig? AzureEmbedding1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureEmbedding1))]
#endif
        public bool IsAzureEmbedding1 => AzureEmbedding1 != null;

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
#if NET6_0_OR_GREATER
        public global::G.OpenAIEmbeddingConfig? AzureEmbedding2 { get; init; }
#else
        public global::G.OpenAIEmbeddingConfig? AzureEmbedding2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureEmbedding2))]
#endif
        public bool IsAzureEmbedding2 => AzureEmbedding2 != null;

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
        public static implicit operator EmbeddingConfig2(global::G.AzureOpenAIEmbeddingConfig value) => new EmbeddingConfig2((global::G.AzureOpenAIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AzureOpenAIEmbeddingConfig?(EmbeddingConfig2 @this) => @this.AzureEmbedding1;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig2(global::G.AzureOpenAIEmbeddingConfig? value)
        {
            AzureEmbedding1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig2(global::G.CohereEmbeddingConfig value) => new EmbeddingConfig2((global::G.CohereEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CohereEmbeddingConfig?(EmbeddingConfig2 @this) => @this.CohereEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig2(global::G.CohereEmbeddingConfig? value)
        {
            CohereEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig2(global::G.GeminiEmbeddingConfig value) => new EmbeddingConfig2((global::G.GeminiEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GeminiEmbeddingConfig?(EmbeddingConfig2 @this) => @this.GeminiEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig2(global::G.GeminiEmbeddingConfig? value)
        {
            GeminiEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig2(global::G.HuggingFaceInferenceAPIEmbeddingConfig value) => new EmbeddingConfig2((global::G.HuggingFaceInferenceAPIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HuggingFaceInferenceAPIEmbeddingConfig?(EmbeddingConfig2 @this) => @this.HuggingfaceApiEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig2(global::G.HuggingFaceInferenceAPIEmbeddingConfig? value)
        {
            HuggingfaceApiEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig2(global::G.OpenAIEmbeddingConfig value) => new EmbeddingConfig2((global::G.OpenAIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAIEmbeddingConfig?(EmbeddingConfig2 @this) => @this.AzureEmbedding2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig2(global::G.OpenAIEmbeddingConfig? value)
        {
            AzureEmbedding2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig2(global::G.VertexAIEmbeddingConfig value) => new EmbeddingConfig2((global::G.VertexAIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VertexAIEmbeddingConfig?(EmbeddingConfig2 @this) => @this.VertexaiEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig2(global::G.VertexAIEmbeddingConfig? value)
        {
            VertexaiEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingConfig2(global::G.BedrockEmbeddingConfig value) => new EmbeddingConfig2((global::G.BedrockEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BedrockEmbeddingConfig?(EmbeddingConfig2 @this) => @this.BedrockEmbedding;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig2(global::G.BedrockEmbeddingConfig? value)
        {
            BedrockEmbedding = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfig2(
            global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType? type,
            global::G.AzureOpenAIEmbeddingConfig? azureEmbedding1,
            global::G.CohereEmbeddingConfig? cohereEmbedding,
            global::G.GeminiEmbeddingConfig? geminiEmbedding,
            global::G.HuggingFaceInferenceAPIEmbeddingConfig? huggingfaceApiEmbedding,
            global::G.OpenAIEmbeddingConfig? azureEmbedding2,
            global::G.VertexAIEmbeddingConfig? vertexaiEmbedding,
            global::G.BedrockEmbeddingConfig? bedrockEmbedding
            )
        {
            Type = type;

            AzureEmbedding1 = azureEmbedding1;
            CohereEmbedding = cohereEmbedding;
            GeminiEmbedding = geminiEmbedding;
            HuggingfaceApiEmbedding = huggingfaceApiEmbedding;
            AzureEmbedding2 = azureEmbedding2;
            VertexaiEmbedding = vertexaiEmbedding;
            BedrockEmbedding = bedrockEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BedrockEmbedding as object ??
            VertexaiEmbedding as object ??
            AzureEmbedding2 as object ??
            HuggingfaceApiEmbedding as object ??
            GeminiEmbedding as object ??
            CohereEmbedding as object ??
            AzureEmbedding1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AzureEmbedding1?.ToString() ??
            CohereEmbedding?.ToString() ??
            GeminiEmbedding?.ToString() ??
            HuggingfaceApiEmbedding?.ToString() ??
            AzureEmbedding2?.ToString() ??
            VertexaiEmbedding?.ToString() ??
            BedrockEmbedding?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAzureEmbedding1 && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && !IsCohereEmbedding && IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && !IsCohereEmbedding && !IsGeminiEmbedding && IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && IsAzureEmbedding2 && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && !IsVertexaiEmbedding && IsBedrockEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AzureOpenAIEmbeddingConfig?, TResult>? azureEmbedding1 = null,
            global::System.Func<global::G.CohereEmbeddingConfig?, TResult>? cohereEmbedding = null,
            global::System.Func<global::G.GeminiEmbeddingConfig?, TResult>? geminiEmbedding = null,
            global::System.Func<global::G.HuggingFaceInferenceAPIEmbeddingConfig?, TResult>? huggingfaceApiEmbedding = null,
            global::System.Func<global::G.OpenAIEmbeddingConfig?, TResult>? azureEmbedding2 = null,
            global::System.Func<global::G.VertexAIEmbeddingConfig?, TResult>? vertexaiEmbedding = null,
            global::System.Func<global::G.BedrockEmbeddingConfig?, TResult>? bedrockEmbedding = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAzureEmbedding1 && azureEmbedding1 != null)
            {
                return azureEmbedding1(AzureEmbedding1!);
            }
            else if (IsCohereEmbedding && cohereEmbedding != null)
            {
                return cohereEmbedding(CohereEmbedding!);
            }
            else if (IsGeminiEmbedding && geminiEmbedding != null)
            {
                return geminiEmbedding(GeminiEmbedding!);
            }
            else if (IsHuggingfaceApiEmbedding && huggingfaceApiEmbedding != null)
            {
                return huggingfaceApiEmbedding(HuggingfaceApiEmbedding!);
            }
            else if (IsAzureEmbedding2 && azureEmbedding2 != null)
            {
                return azureEmbedding2(AzureEmbedding2!);
            }
            else if (IsVertexaiEmbedding && vertexaiEmbedding != null)
            {
                return vertexaiEmbedding(VertexaiEmbedding!);
            }
            else if (IsBedrockEmbedding && bedrockEmbedding != null)
            {
                return bedrockEmbedding(BedrockEmbedding!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AzureOpenAIEmbeddingConfig?>? azureEmbedding1 = null,
            global::System.Action<global::G.CohereEmbeddingConfig?>? cohereEmbedding = null,
            global::System.Action<global::G.GeminiEmbeddingConfig?>? geminiEmbedding = null,
            global::System.Action<global::G.HuggingFaceInferenceAPIEmbeddingConfig?>? huggingfaceApiEmbedding = null,
            global::System.Action<global::G.OpenAIEmbeddingConfig?>? azureEmbedding2 = null,
            global::System.Action<global::G.VertexAIEmbeddingConfig?>? vertexaiEmbedding = null,
            global::System.Action<global::G.BedrockEmbeddingConfig?>? bedrockEmbedding = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAzureEmbedding1)
            {
                azureEmbedding1?.Invoke(AzureEmbedding1!);
            }
            else if (IsCohereEmbedding)
            {
                cohereEmbedding?.Invoke(CohereEmbedding!);
            }
            else if (IsGeminiEmbedding)
            {
                geminiEmbedding?.Invoke(GeminiEmbedding!);
            }
            else if (IsHuggingfaceApiEmbedding)
            {
                huggingfaceApiEmbedding?.Invoke(HuggingfaceApiEmbedding!);
            }
            else if (IsAzureEmbedding2)
            {
                azureEmbedding2?.Invoke(AzureEmbedding2!);
            }
            else if (IsVertexaiEmbedding)
            {
                vertexaiEmbedding?.Invoke(VertexaiEmbedding!);
            }
            else if (IsBedrockEmbedding)
            {
                bedrockEmbedding?.Invoke(BedrockEmbedding!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AzureEmbedding1,
                typeof(global::G.AzureOpenAIEmbeddingConfig),
                CohereEmbedding,
                typeof(global::G.CohereEmbeddingConfig),
                GeminiEmbedding,
                typeof(global::G.GeminiEmbeddingConfig),
                HuggingfaceApiEmbedding,
                typeof(global::G.HuggingFaceInferenceAPIEmbeddingConfig),
                AzureEmbedding2,
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
        public bool Equals(EmbeddingConfig2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AzureOpenAIEmbeddingConfig?>.Default.Equals(AzureEmbedding1, other.AzureEmbedding1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CohereEmbeddingConfig?>.Default.Equals(CohereEmbedding, other.CohereEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GeminiEmbeddingConfig?>.Default.Equals(GeminiEmbedding, other.GeminiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HuggingFaceInferenceAPIEmbeddingConfig?>.Default.Equals(HuggingfaceApiEmbedding, other.HuggingfaceApiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAIEmbeddingConfig?>.Default.Equals(AzureEmbedding2, other.AzureEmbedding2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VertexAIEmbeddingConfig?>.Default.Equals(VertexaiEmbedding, other.VertexaiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BedrockEmbeddingConfig?>.Default.Equals(BedrockEmbedding, other.BedrockEmbedding) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingConfig2 obj1, EmbeddingConfig2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingConfig2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingConfig2 obj1, EmbeddingConfig2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingConfig2 o && Equals(o);
        }
    }
}
