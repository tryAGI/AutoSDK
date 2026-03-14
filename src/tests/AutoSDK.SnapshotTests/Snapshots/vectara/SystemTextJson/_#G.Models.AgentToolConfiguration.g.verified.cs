//HintName: G.Models.AgentToolConfiguration.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A tool configuration that can be used by an agent, defined inline with a specific configuration type.<br/>
    /// Example: [{"type":"web_search","argument_override":{"limit":5,"include_domains":["github.com","stackoverflow.com"],"exclude_domains":["spam.com"]}}]
    /// </summary>
    public readonly partial struct AgentToolConfiguration : global::System.IEquatable<AgentToolConfiguration>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentToolConfigurationDiscriminatorType? Type { get; }

        /// <summary>
        /// An inline configuration for built-in Vectara tools that have implementations within the platform but do not have a dedicated configuration type schema. Use the List Tools endpoint to discover available tools and obtain the `tool_id` required for this configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineDynamicVectaraToolConfiguration? DynamicVectara { get; init; }
#else
        public global::G.InlineDynamicVectaraToolConfiguration? DynamicVectara { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVectara))]
#endif
        public bool IsDynamicVectara => DynamicVectara != null;

        /// <summary>
        /// An MCP tool configuration defined inline in the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineMcpToolConfiguration? Mcp { get; init; }
#else
        public global::G.InlineMcpToolConfiguration? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// A corpora search tool configuration defined inline in the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineCorporaSearchToolConfiguration? CorporaSearch { get; init; }
#else
        public global::G.InlineCorporaSearchToolConfiguration? CorporaSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CorporaSearch))]
#endif
        public bool IsCorporaSearch => CorporaSearch != null;

        /// <summary>
        /// A web search tool configuration defined inline in the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineWebSearchToolConfiguration? WebSearch { get; init; }
#else
        public global::G.InlineWebSearchToolConfiguration? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        /// A web get tool configuration defined inline in the agent for fetching content from URLs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineWebGetToolConfiguration? WebGet { get; init; }
#else
        public global::G.InlineWebGetToolConfiguration? WebGet { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebGet))]
#endif
        public bool IsWebGet => WebGet != null;

        /// <summary>
        /// A lambda tool configuration defined inline in the agent for executing user-defined functions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineLambdaToolConfiguration? Lambda { get; init; }
#else
        public global::G.InlineLambdaToolConfiguration? Lambda { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lambda))]
#endif
        public bool IsLambda => Lambda != null;

        /// <summary>
        /// A structured indexing tool configuration defined inline in the agent for indexing into the Vectara platform.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineStructuredIndexingToolConfiguration? StructuredIndexing { get; init; }
#else
        public global::G.InlineStructuredIndexingToolConfiguration? StructuredIndexing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StructuredIndexing))]
#endif
        public bool IsStructuredIndexing => StructuredIndexing != null;

        /// <summary>
        /// A sub-agent tool configuration defined inline in the agent for invoking specialized sub-agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineSubAgentToolConfiguration? SubAgent { get; init; }
#else
        public global::G.InlineSubAgentToolConfiguration? SubAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubAgent))]
#endif
        public bool IsSubAgent => SubAgent != null;

        /// <summary>
        /// An artifact read tool configuration defined inline in the agent for reading artifacts from the session workspace.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineArtifactReadToolConfiguration? ArtifactRead { get; init; }
#else
        public global::G.InlineArtifactReadToolConfiguration? ArtifactRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactRead))]
#endif
        public bool IsArtifactRead => ArtifactRead != null;

        /// <summary>
        /// An artifact grep tool configuration defined inline in the agent for searching through artifact content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineArtifactGrepToolConfiguration? ArtifactGrep { get; init; }
#else
        public global::G.InlineArtifactGrepToolConfiguration? ArtifactGrep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactGrep))]
#endif
        public bool IsArtifactGrep => ArtifactGrep != null;

        /// <summary>
        /// An image read tool configuration defined inline in the agent for loading images into the conversation context.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineImageReadToolConfiguration? ImageRead { get; init; }
#else
        public global::G.InlineImageReadToolConfiguration? ImageRead { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageRead))]
#endif
        public bool IsImageRead => ImageRead != null;

        /// <summary>
        /// A document conversion tool configuration defined inline in the agent for converting document artifacts to various formats.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineDocumentConversionToolConfiguration? DocumentConversion { get; init; }
#else
        public global::G.InlineDocumentConversionToolConfiguration? DocumentConversion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentConversion))]
#endif
        public bool IsDocumentConversion => DocumentConversion != null;

        /// <summary>
        /// A get document text tool configuration defined inline in the agent for fetching document text content from a corpus.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineGetDocumentTextToolConfiguration? GetDocumentText { get; init; }
#else
        public global::G.InlineGetDocumentTextToolConfiguration? GetDocumentText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetDocumentText))]
#endif
        public bool IsGetDocumentText => GetDocumentText != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineDynamicVectaraToolConfiguration value) => new AgentToolConfiguration((global::G.InlineDynamicVectaraToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineDynamicVectaraToolConfiguration?(AgentToolConfiguration @this) => @this.DynamicVectara;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineDynamicVectaraToolConfiguration? value)
        {
            DynamicVectara = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineMcpToolConfiguration value) => new AgentToolConfiguration((global::G.InlineMcpToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineMcpToolConfiguration?(AgentToolConfiguration @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineMcpToolConfiguration? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineCorporaSearchToolConfiguration value) => new AgentToolConfiguration((global::G.InlineCorporaSearchToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineCorporaSearchToolConfiguration?(AgentToolConfiguration @this) => @this.CorporaSearch;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineCorporaSearchToolConfiguration? value)
        {
            CorporaSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineWebSearchToolConfiguration value) => new AgentToolConfiguration((global::G.InlineWebSearchToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineWebSearchToolConfiguration?(AgentToolConfiguration @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineWebSearchToolConfiguration? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineWebGetToolConfiguration value) => new AgentToolConfiguration((global::G.InlineWebGetToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineWebGetToolConfiguration?(AgentToolConfiguration @this) => @this.WebGet;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineWebGetToolConfiguration? value)
        {
            WebGet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineLambdaToolConfiguration value) => new AgentToolConfiguration((global::G.InlineLambdaToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineLambdaToolConfiguration?(AgentToolConfiguration @this) => @this.Lambda;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineLambdaToolConfiguration? value)
        {
            Lambda = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineStructuredIndexingToolConfiguration value) => new AgentToolConfiguration((global::G.InlineStructuredIndexingToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineStructuredIndexingToolConfiguration?(AgentToolConfiguration @this) => @this.StructuredIndexing;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineStructuredIndexingToolConfiguration? value)
        {
            StructuredIndexing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineSubAgentToolConfiguration value) => new AgentToolConfiguration((global::G.InlineSubAgentToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineSubAgentToolConfiguration?(AgentToolConfiguration @this) => @this.SubAgent;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineSubAgentToolConfiguration? value)
        {
            SubAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineArtifactReadToolConfiguration value) => new AgentToolConfiguration((global::G.InlineArtifactReadToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineArtifactReadToolConfiguration?(AgentToolConfiguration @this) => @this.ArtifactRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineArtifactReadToolConfiguration? value)
        {
            ArtifactRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineArtifactGrepToolConfiguration value) => new AgentToolConfiguration((global::G.InlineArtifactGrepToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineArtifactGrepToolConfiguration?(AgentToolConfiguration @this) => @this.ArtifactGrep;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineArtifactGrepToolConfiguration? value)
        {
            ArtifactGrep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineImageReadToolConfiguration value) => new AgentToolConfiguration((global::G.InlineImageReadToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineImageReadToolConfiguration?(AgentToolConfiguration @this) => @this.ImageRead;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineImageReadToolConfiguration? value)
        {
            ImageRead = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineDocumentConversionToolConfiguration value) => new AgentToolConfiguration((global::G.InlineDocumentConversionToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineDocumentConversionToolConfiguration?(AgentToolConfiguration @this) => @this.DocumentConversion;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineDocumentConversionToolConfiguration? value)
        {
            DocumentConversion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentToolConfiguration(global::G.InlineGetDocumentTextToolConfiguration value) => new AgentToolConfiguration((global::G.InlineGetDocumentTextToolConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineGetDocumentTextToolConfiguration?(AgentToolConfiguration @this) => @this.GetDocumentText;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(global::G.InlineGetDocumentTextToolConfiguration? value)
        {
            GetDocumentText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentToolConfiguration(
            global::G.AgentToolConfigurationDiscriminatorType? type,
            global::G.InlineDynamicVectaraToolConfiguration? dynamicVectara,
            global::G.InlineMcpToolConfiguration? mcp,
            global::G.InlineCorporaSearchToolConfiguration? corporaSearch,
            global::G.InlineWebSearchToolConfiguration? webSearch,
            global::G.InlineWebGetToolConfiguration? webGet,
            global::G.InlineLambdaToolConfiguration? lambda,
            global::G.InlineStructuredIndexingToolConfiguration? structuredIndexing,
            global::G.InlineSubAgentToolConfiguration? subAgent,
            global::G.InlineArtifactReadToolConfiguration? artifactRead,
            global::G.InlineArtifactGrepToolConfiguration? artifactGrep,
            global::G.InlineImageReadToolConfiguration? imageRead,
            global::G.InlineDocumentConversionToolConfiguration? documentConversion,
            global::G.InlineGetDocumentTextToolConfiguration? getDocumentText
            )
        {
            Type = type;

            DynamicVectara = dynamicVectara;
            Mcp = mcp;
            CorporaSearch = corporaSearch;
            WebSearch = webSearch;
            WebGet = webGet;
            Lambda = lambda;
            StructuredIndexing = structuredIndexing;
            SubAgent = subAgent;
            ArtifactRead = artifactRead;
            ArtifactGrep = artifactGrep;
            ImageRead = imageRead;
            DocumentConversion = documentConversion;
            GetDocumentText = getDocumentText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetDocumentText as object ??
            DocumentConversion as object ??
            ImageRead as object ??
            ArtifactGrep as object ??
            ArtifactRead as object ??
            SubAgent as object ??
            StructuredIndexing as object ??
            Lambda as object ??
            WebGet as object ??
            WebSearch as object ??
            CorporaSearch as object ??
            Mcp as object ??
            DynamicVectara as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DynamicVectara?.ToString() ??
            Mcp?.ToString() ??
            CorporaSearch?.ToString() ??
            WebSearch?.ToString() ??
            WebGet?.ToString() ??
            Lambda?.ToString() ??
            StructuredIndexing?.ToString() ??
            SubAgent?.ToString() ??
            ArtifactRead?.ToString() ??
            ArtifactGrep?.ToString() ??
            ImageRead?.ToString() ??
            DocumentConversion?.ToString() ??
            GetDocumentText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && IsArtifactGrep && !IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && IsImageRead && !IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && IsDocumentConversion && !IsGetDocumentText || !IsDynamicVectara && !IsMcp && !IsCorporaSearch && !IsWebSearch && !IsWebGet && !IsLambda && !IsStructuredIndexing && !IsSubAgent && !IsArtifactRead && !IsArtifactGrep && !IsImageRead && !IsDocumentConversion && IsGetDocumentText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InlineDynamicVectaraToolConfiguration?, TResult>? dynamicVectara = null,
            global::System.Func<global::G.InlineMcpToolConfiguration?, TResult>? mcp = null,
            global::System.Func<global::G.InlineCorporaSearchToolConfiguration?, TResult>? corporaSearch = null,
            global::System.Func<global::G.InlineWebSearchToolConfiguration?, TResult>? webSearch = null,
            global::System.Func<global::G.InlineWebGetToolConfiguration?, TResult>? webGet = null,
            global::System.Func<global::G.InlineLambdaToolConfiguration?, TResult>? lambda = null,
            global::System.Func<global::G.InlineStructuredIndexingToolConfiguration?, TResult>? structuredIndexing = null,
            global::System.Func<global::G.InlineSubAgentToolConfiguration?, TResult>? subAgent = null,
            global::System.Func<global::G.InlineArtifactReadToolConfiguration?, TResult>? artifactRead = null,
            global::System.Func<global::G.InlineArtifactGrepToolConfiguration?, TResult>? artifactGrep = null,
            global::System.Func<global::G.InlineImageReadToolConfiguration?, TResult>? imageRead = null,
            global::System.Func<global::G.InlineDocumentConversionToolConfiguration?, TResult>? documentConversion = null,
            global::System.Func<global::G.InlineGetDocumentTextToolConfiguration?, TResult>? getDocumentText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVectara && dynamicVectara != null)
            {
                return dynamicVectara(DynamicVectara!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsCorporaSearch && corporaSearch != null)
            {
                return corporaSearch(CorporaSearch!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }
            else if (IsWebGet && webGet != null)
            {
                return webGet(WebGet!);
            }
            else if (IsLambda && lambda != null)
            {
                return lambda(Lambda!);
            }
            else if (IsStructuredIndexing && structuredIndexing != null)
            {
                return structuredIndexing(StructuredIndexing!);
            }
            else if (IsSubAgent && subAgent != null)
            {
                return subAgent(SubAgent!);
            }
            else if (IsArtifactRead && artifactRead != null)
            {
                return artifactRead(ArtifactRead!);
            }
            else if (IsArtifactGrep && artifactGrep != null)
            {
                return artifactGrep(ArtifactGrep!);
            }
            else if (IsImageRead && imageRead != null)
            {
                return imageRead(ImageRead!);
            }
            else if (IsDocumentConversion && documentConversion != null)
            {
                return documentConversion(DocumentConversion!);
            }
            else if (IsGetDocumentText && getDocumentText != null)
            {
                return getDocumentText(GetDocumentText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InlineDynamicVectaraToolConfiguration?>? dynamicVectara = null,
            global::System.Action<global::G.InlineMcpToolConfiguration?>? mcp = null,
            global::System.Action<global::G.InlineCorporaSearchToolConfiguration?>? corporaSearch = null,
            global::System.Action<global::G.InlineWebSearchToolConfiguration?>? webSearch = null,
            global::System.Action<global::G.InlineWebGetToolConfiguration?>? webGet = null,
            global::System.Action<global::G.InlineLambdaToolConfiguration?>? lambda = null,
            global::System.Action<global::G.InlineStructuredIndexingToolConfiguration?>? structuredIndexing = null,
            global::System.Action<global::G.InlineSubAgentToolConfiguration?>? subAgent = null,
            global::System.Action<global::G.InlineArtifactReadToolConfiguration?>? artifactRead = null,
            global::System.Action<global::G.InlineArtifactGrepToolConfiguration?>? artifactGrep = null,
            global::System.Action<global::G.InlineImageReadToolConfiguration?>? imageRead = null,
            global::System.Action<global::G.InlineDocumentConversionToolConfiguration?>? documentConversion = null,
            global::System.Action<global::G.InlineGetDocumentTextToolConfiguration?>? getDocumentText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamicVectara)
            {
                dynamicVectara?.Invoke(DynamicVectara!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsCorporaSearch)
            {
                corporaSearch?.Invoke(CorporaSearch!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
            else if (IsWebGet)
            {
                webGet?.Invoke(WebGet!);
            }
            else if (IsLambda)
            {
                lambda?.Invoke(Lambda!);
            }
            else if (IsStructuredIndexing)
            {
                structuredIndexing?.Invoke(StructuredIndexing!);
            }
            else if (IsSubAgent)
            {
                subAgent?.Invoke(SubAgent!);
            }
            else if (IsArtifactRead)
            {
                artifactRead?.Invoke(ArtifactRead!);
            }
            else if (IsArtifactGrep)
            {
                artifactGrep?.Invoke(ArtifactGrep!);
            }
            else if (IsImageRead)
            {
                imageRead?.Invoke(ImageRead!);
            }
            else if (IsDocumentConversion)
            {
                documentConversion?.Invoke(DocumentConversion!);
            }
            else if (IsGetDocumentText)
            {
                getDocumentText?.Invoke(GetDocumentText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DynamicVectara,
                typeof(global::G.InlineDynamicVectaraToolConfiguration),
                Mcp,
                typeof(global::G.InlineMcpToolConfiguration),
                CorporaSearch,
                typeof(global::G.InlineCorporaSearchToolConfiguration),
                WebSearch,
                typeof(global::G.InlineWebSearchToolConfiguration),
                WebGet,
                typeof(global::G.InlineWebGetToolConfiguration),
                Lambda,
                typeof(global::G.InlineLambdaToolConfiguration),
                StructuredIndexing,
                typeof(global::G.InlineStructuredIndexingToolConfiguration),
                SubAgent,
                typeof(global::G.InlineSubAgentToolConfiguration),
                ArtifactRead,
                typeof(global::G.InlineArtifactReadToolConfiguration),
                ArtifactGrep,
                typeof(global::G.InlineArtifactGrepToolConfiguration),
                ImageRead,
                typeof(global::G.InlineImageReadToolConfiguration),
                DocumentConversion,
                typeof(global::G.InlineDocumentConversionToolConfiguration),
                GetDocumentText,
                typeof(global::G.InlineGetDocumentTextToolConfiguration),
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
        public bool Equals(AgentToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InlineDynamicVectaraToolConfiguration?>.Default.Equals(DynamicVectara, other.DynamicVectara) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineMcpToolConfiguration?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineCorporaSearchToolConfiguration?>.Default.Equals(CorporaSearch, other.CorporaSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineWebSearchToolConfiguration?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineWebGetToolConfiguration?>.Default.Equals(WebGet, other.WebGet) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineLambdaToolConfiguration?>.Default.Equals(Lambda, other.Lambda) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineStructuredIndexingToolConfiguration?>.Default.Equals(StructuredIndexing, other.StructuredIndexing) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineSubAgentToolConfiguration?>.Default.Equals(SubAgent, other.SubAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineArtifactReadToolConfiguration?>.Default.Equals(ArtifactRead, other.ArtifactRead) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineArtifactGrepToolConfiguration?>.Default.Equals(ArtifactGrep, other.ArtifactGrep) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineImageReadToolConfiguration?>.Default.Equals(ImageRead, other.ImageRead) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineDocumentConversionToolConfiguration?>.Default.Equals(DocumentConversion, other.DocumentConversion) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineGetDocumentTextToolConfiguration?>.Default.Equals(GetDocumentText, other.GetDocumentText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentToolConfiguration obj1, AgentToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentToolConfiguration obj1, AgentToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentToolConfiguration o && Equals(o);
        }
    }
}
