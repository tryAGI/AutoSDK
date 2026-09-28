//HintName: G.Models.BaseResponsesResultToolsItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseResponsesResultToolsItems : global::System.IEquatable<BaseResponsesResultToolsItems>
    {
        /// <summary>
        /// Function tool definition
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseResponsesResultToolsItems0? BaseResponsesResultToolsItems0 { get; init; }
#else
        public global::G.BaseResponsesResultToolsItems0? BaseResponsesResultToolsItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseResponsesResultToolsItems0))]
#endif
        public bool IsBaseResponsesResultToolsItems0 => BaseResponsesResultToolsItems0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBaseResponsesResultToolsItems0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BaseResponsesResultToolsItems0? value)
        {
            value = BaseResponsesResultToolsItems0;
            return IsBaseResponsesResultToolsItems0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BaseResponsesResultToolsItems0 PickBaseResponsesResultToolsItems0() => BaseResponsesResultToolsItems0 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BaseResponsesResultToolsItems0' but the value was {ToString()}.");

        /// <summary>
        /// Web search preview tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PreviewWebSearchServerTool? PreviewWebSearchServerTool { get; init; }
#else
        public global::G.PreviewWebSearchServerTool? PreviewWebSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreviewWebSearchServerTool))]
#endif
        public bool IsPreviewWebSearchServerTool => PreviewWebSearchServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPreviewWebSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.PreviewWebSearchServerTool? value)
        {
            value = PreviewWebSearchServerTool;
            return IsPreviewWebSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.PreviewWebSearchServerTool PickPreviewWebSearchServerTool() => PreviewWebSearchServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreviewWebSearchServerTool' but the value was {ToString()}.");

        /// <summary>
        /// Web search preview tool configuration (2025-03-11 version)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Preview20250311WebSearchServerTool? Preview20250311WebSearchServerTool { get; init; }
#else
        public global::G.Preview20250311WebSearchServerTool? Preview20250311WebSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Preview20250311WebSearchServerTool))]
#endif
        public bool IsPreview20250311WebSearchServerTool => Preview20250311WebSearchServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPreview20250311WebSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.Preview20250311WebSearchServerTool? value)
        {
            value = Preview20250311WebSearchServerTool;
            return IsPreview20250311WebSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.Preview20250311WebSearchServerTool PickPreview20250311WebSearchServerTool() => Preview20250311WebSearchServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Preview20250311WebSearchServerTool' but the value was {ToString()}.");

        /// <summary>
        /// Web search tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LegacyWebSearchServerTool? LegacyWebSearchServerTool { get; init; }
#else
        public global::G.LegacyWebSearchServerTool? LegacyWebSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyWebSearchServerTool))]
#endif
        public bool IsLegacyWebSearchServerTool => LegacyWebSearchServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLegacyWebSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.LegacyWebSearchServerTool? value)
        {
            value = LegacyWebSearchServerTool;
            return IsLegacyWebSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.LegacyWebSearchServerTool PickLegacyWebSearchServerTool() => LegacyWebSearchServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LegacyWebSearchServerTool' but the value was {ToString()}.");

        /// <summary>
        /// Web search tool configuration (2025-08-26 version)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSearchServerTool? WebSearchServerTool { get; init; }
#else
        public global::G.WebSearchServerTool? WebSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchServerTool))]
#endif
        public bool IsWebSearchServerTool => WebSearchServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.WebSearchServerTool? value)
        {
            value = WebSearchServerTool;
            return IsWebSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.WebSearchServerTool PickWebSearchServerTool() => WebSearchServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchServerTool' but the value was {ToString()}.");

        /// <summary>
        /// File search tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FileSearchServerTool? FileSearchServerTool { get; init; }
#else
        public global::G.FileSearchServerTool? FileSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerTool))]
#endif
        public bool IsFileSearchServerTool => FileSearchServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.FileSearchServerTool? value)
        {
            value = FileSearchServerTool;
            return IsFileSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.FileSearchServerTool PickFileSearchServerTool() => FileSearchServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchServerTool' but the value was {ToString()}.");

        /// <summary>
        /// Computer use preview tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerUseServerTool? ComputerUseServerTool { get; init; }
#else
        public global::G.ComputerUseServerTool? ComputerUseServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUseServerTool))]
#endif
        public bool IsComputerUseServerTool => ComputerUseServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputerUseServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ComputerUseServerTool? value)
        {
            value = ComputerUseServerTool;
            return IsComputerUseServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ComputerUseServerTool PickComputerUseServerTool() => ComputerUseServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerUseServerTool' but the value was {ToString()}.");

        /// <summary>
        /// Code interpreter tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeInterpreterServerTool? CodeInterpreterServerTool { get; init; }
#else
        public global::G.CodeInterpreterServerTool? CodeInterpreterServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterServerTool))]
#endif
        public bool IsCodeInterpreterServerTool => CodeInterpreterServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCodeInterpreterServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CodeInterpreterServerTool? value)
        {
            value = CodeInterpreterServerTool;
            return IsCodeInterpreterServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeInterpreterServerTool PickCodeInterpreterServerTool() => CodeInterpreterServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterServerTool' but the value was {ToString()}.");

        /// <summary>
        /// MCP (Model Context Protocol) tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.McpServerTool? McpServerTool { get; init; }
#else
        public global::G.McpServerTool? McpServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerTool))]
#endif
        public bool IsMcpServerTool => McpServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcpServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.McpServerTool? value)
        {
            value = McpServerTool;
            return IsMcpServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.McpServerTool PickMcpServerTool() => McpServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpServerTool' but the value was {ToString()}.");

        /// <summary>
        /// Image generation tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageGenerationServerTool? ImageGenerationServerTool { get; init; }
#else
        public global::G.ImageGenerationServerTool? ImageGenerationServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationServerTool))]
#endif
        public bool IsImageGenerationServerTool => ImageGenerationServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageGenerationServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ImageGenerationServerTool? value)
        {
            value = ImageGenerationServerTool;
            return IsImageGenerationServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ImageGenerationServerTool PickImageGenerationServerTool() => ImageGenerationServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationServerTool' but the value was {ToString()}.");

        /// <summary>
        /// Local shell tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodexLocalShellTool? CodexLocalShellTool { get; init; }
#else
        public global::G.CodexLocalShellTool? CodexLocalShellTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodexLocalShellTool))]
#endif
        public bool IsCodexLocalShellTool => CodexLocalShellTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCodexLocalShellTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CodexLocalShellTool? value)
        {
            value = CodexLocalShellTool;
            return IsCodexLocalShellTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CodexLocalShellTool PickCodexLocalShellTool() => CodexLocalShellTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodexLocalShellTool' but the value was {ToString()}.");

        /// <summary>
        /// Shell tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShellServerTool? ShellServerTool { get; init; }
#else
        public global::G.ShellServerTool? ShellServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellServerTool))]
#endif
        public bool IsShellServerTool => ShellServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickShellServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ShellServerTool? value)
        {
            value = ShellServerTool;
            return IsShellServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ShellServerTool PickShellServerTool() => ShellServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellServerTool' but the value was {ToString()}.");

        /// <summary>
        /// Apply patch tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ApplyPatchServerTool? ApplyPatchServerTool { get; init; }
#else
        public global::G.ApplyPatchServerTool? ApplyPatchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchServerTool))]
#endif
        public bool IsApplyPatchServerTool => ApplyPatchServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ApplyPatchServerTool? value)
        {
            value = ApplyPatchServerTool;
            return IsApplyPatchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ApplyPatchServerTool PickApplyPatchServerTool() => ApplyPatchServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchServerTool' but the value was {ToString()}.");

        /// <summary>
        /// Custom tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomTool? CustomTool { get; init; }
#else
        public global::G.CustomTool? CustomTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomTool))]
#endif
        public bool IsCustomTool => CustomTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustomTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CustomTool? value)
        {
            value = CustomTool;
            return IsCustomTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CustomTool PickCustomTool() => CustomTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomTool' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.BaseResponsesResultToolsItems0 value) => new BaseResponsesResultToolsItems((global::G.BaseResponsesResultToolsItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseResponsesResultToolsItems0?(BaseResponsesResultToolsItems @this) => @this.BaseResponsesResultToolsItems0;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.BaseResponsesResultToolsItems0? value)
        {
            BaseResponsesResultToolsItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromBaseResponsesResultToolsItems0(global::G.BaseResponsesResultToolsItems0? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.PreviewWebSearchServerTool value) => new BaseResponsesResultToolsItems((global::G.PreviewWebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PreviewWebSearchServerTool?(BaseResponsesResultToolsItems @this) => @this.PreviewWebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.PreviewWebSearchServerTool? value)
        {
            PreviewWebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromPreviewWebSearchServerTool(global::G.PreviewWebSearchServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.Preview20250311WebSearchServerTool value) => new BaseResponsesResultToolsItems((global::G.Preview20250311WebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Preview20250311WebSearchServerTool?(BaseResponsesResultToolsItems @this) => @this.Preview20250311WebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.Preview20250311WebSearchServerTool? value)
        {
            Preview20250311WebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromPreview20250311WebSearchServerTool(global::G.Preview20250311WebSearchServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.LegacyWebSearchServerTool value) => new BaseResponsesResultToolsItems((global::G.LegacyWebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LegacyWebSearchServerTool?(BaseResponsesResultToolsItems @this) => @this.LegacyWebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.LegacyWebSearchServerTool? value)
        {
            LegacyWebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromLegacyWebSearchServerTool(global::G.LegacyWebSearchServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.WebSearchServerTool value) => new BaseResponsesResultToolsItems((global::G.WebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchServerTool?(BaseResponsesResultToolsItems @this) => @this.WebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.WebSearchServerTool? value)
        {
            WebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromWebSearchServerTool(global::G.WebSearchServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.FileSearchServerTool value) => new BaseResponsesResultToolsItems((global::G.FileSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSearchServerTool?(BaseResponsesResultToolsItems @this) => @this.FileSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.FileSearchServerTool? value)
        {
            FileSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromFileSearchServerTool(global::G.FileSearchServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.ComputerUseServerTool value) => new BaseResponsesResultToolsItems((global::G.ComputerUseServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerUseServerTool?(BaseResponsesResultToolsItems @this) => @this.ComputerUseServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.ComputerUseServerTool? value)
        {
            ComputerUseServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromComputerUseServerTool(global::G.ComputerUseServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.CodeInterpreterServerTool value) => new BaseResponsesResultToolsItems((global::G.CodeInterpreterServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterServerTool?(BaseResponsesResultToolsItems @this) => @this.CodeInterpreterServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.CodeInterpreterServerTool? value)
        {
            CodeInterpreterServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromCodeInterpreterServerTool(global::G.CodeInterpreterServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.McpServerTool value) => new BaseResponsesResultToolsItems((global::G.McpServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpServerTool?(BaseResponsesResultToolsItems @this) => @this.McpServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.McpServerTool? value)
        {
            McpServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromMcpServerTool(global::G.McpServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.ImageGenerationServerTool value) => new BaseResponsesResultToolsItems((global::G.ImageGenerationServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageGenerationServerTool?(BaseResponsesResultToolsItems @this) => @this.ImageGenerationServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.ImageGenerationServerTool? value)
        {
            ImageGenerationServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromImageGenerationServerTool(global::G.ImageGenerationServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.CodexLocalShellTool value) => new BaseResponsesResultToolsItems((global::G.CodexLocalShellTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodexLocalShellTool?(BaseResponsesResultToolsItems @this) => @this.CodexLocalShellTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.CodexLocalShellTool? value)
        {
            CodexLocalShellTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromCodexLocalShellTool(global::G.CodexLocalShellTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.ShellServerTool value) => new BaseResponsesResultToolsItems((global::G.ShellServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShellServerTool?(BaseResponsesResultToolsItems @this) => @this.ShellServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.ShellServerTool? value)
        {
            ShellServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromShellServerTool(global::G.ShellServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.ApplyPatchServerTool value) => new BaseResponsesResultToolsItems((global::G.ApplyPatchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApplyPatchServerTool?(BaseResponsesResultToolsItems @this) => @this.ApplyPatchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.ApplyPatchServerTool? value)
        {
            ApplyPatchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromApplyPatchServerTool(global::G.ApplyPatchServerTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseResponsesResultToolsItems(global::G.CustomTool value) => new BaseResponsesResultToolsItems((global::G.CustomTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomTool?(BaseResponsesResultToolsItems @this) => @this.CustomTool;

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(global::G.CustomTool? value)
        {
            CustomTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BaseResponsesResultToolsItems FromCustomTool(global::G.CustomTool? value) => new BaseResponsesResultToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public BaseResponsesResultToolsItems(
            global::G.BaseResponsesResultToolsItems0? baseResponsesResultToolsItems0,
            global::G.PreviewWebSearchServerTool? previewWebSearchServerTool,
            global::G.Preview20250311WebSearchServerTool? preview20250311WebSearchServerTool,
            global::G.LegacyWebSearchServerTool? legacyWebSearchServerTool,
            global::G.WebSearchServerTool? webSearchServerTool,
            global::G.FileSearchServerTool? fileSearchServerTool,
            global::G.ComputerUseServerTool? computerUseServerTool,
            global::G.CodeInterpreterServerTool? codeInterpreterServerTool,
            global::G.McpServerTool? mcpServerTool,
            global::G.ImageGenerationServerTool? imageGenerationServerTool,
            global::G.CodexLocalShellTool? codexLocalShellTool,
            global::G.ShellServerTool? shellServerTool,
            global::G.ApplyPatchServerTool? applyPatchServerTool,
            global::G.CustomTool? customTool
            )
        {
            BaseResponsesResultToolsItems0 = baseResponsesResultToolsItems0;
            PreviewWebSearchServerTool = previewWebSearchServerTool;
            Preview20250311WebSearchServerTool = preview20250311WebSearchServerTool;
            LegacyWebSearchServerTool = legacyWebSearchServerTool;
            WebSearchServerTool = webSearchServerTool;
            FileSearchServerTool = fileSearchServerTool;
            ComputerUseServerTool = computerUseServerTool;
            CodeInterpreterServerTool = codeInterpreterServerTool;
            McpServerTool = mcpServerTool;
            ImageGenerationServerTool = imageGenerationServerTool;
            CodexLocalShellTool = codexLocalShellTool;
            ShellServerTool = shellServerTool;
            ApplyPatchServerTool = applyPatchServerTool;
            CustomTool = customTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomTool as object ??
            ApplyPatchServerTool as object ??
            ShellServerTool as object ??
            CodexLocalShellTool as object ??
            ImageGenerationServerTool as object ??
            McpServerTool as object ??
            CodeInterpreterServerTool as object ??
            ComputerUseServerTool as object ??
            FileSearchServerTool as object ??
            WebSearchServerTool as object ??
            LegacyWebSearchServerTool as object ??
            Preview20250311WebSearchServerTool as object ??
            PreviewWebSearchServerTool as object ??
            BaseResponsesResultToolsItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseResponsesResultToolsItems0?.ToString() ??
            PreviewWebSearchServerTool?.ToString() ??
            Preview20250311WebSearchServerTool?.ToString() ??
            LegacyWebSearchServerTool?.ToString() ??
            WebSearchServerTool?.ToString() ??
            FileSearchServerTool?.ToString() ??
            ComputerUseServerTool?.ToString() ??
            CodeInterpreterServerTool?.ToString() ??
            McpServerTool?.ToString() ??
            ImageGenerationServerTool?.ToString() ??
            CodexLocalShellTool?.ToString() ??
            ShellServerTool?.ToString() ??
            ApplyPatchServerTool?.ToString() ??
            CustomTool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && IsApplyPatchServerTool && !IsCustomTool || !IsBaseResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && IsCustomTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseResponsesResultToolsItems0, TResult>? baseResponsesResultToolsItems0 = null,
            global::System.Func<global::G.PreviewWebSearchServerTool, TResult>? previewWebSearchServerTool = null,
            global::System.Func<global::G.Preview20250311WebSearchServerTool, TResult>? preview20250311WebSearchServerTool = null,
            global::System.Func<global::G.LegacyWebSearchServerTool, TResult>? legacyWebSearchServerTool = null,
            global::System.Func<global::G.WebSearchServerTool, TResult>? webSearchServerTool = null,
            global::System.Func<global::G.FileSearchServerTool, TResult>? fileSearchServerTool = null,
            global::System.Func<global::G.ComputerUseServerTool, TResult>? computerUseServerTool = null,
            global::System.Func<global::G.CodeInterpreterServerTool, TResult>? codeInterpreterServerTool = null,
            global::System.Func<global::G.McpServerTool, TResult>? mcpServerTool = null,
            global::System.Func<global::G.ImageGenerationServerTool, TResult>? imageGenerationServerTool = null,
            global::System.Func<global::G.CodexLocalShellTool, TResult>? codexLocalShellTool = null,
            global::System.Func<global::G.ShellServerTool, TResult>? shellServerTool = null,
            global::System.Func<global::G.ApplyPatchServerTool, TResult>? applyPatchServerTool = null,
            global::System.Func<global::G.CustomTool, TResult>? customTool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BaseResponsesResultToolsItems0 is { } __value0 && baseResponsesResultToolsItems0 != null)
            {
                return baseResponsesResultToolsItems0(__value0);
            }
            else if (PreviewWebSearchServerTool is { } __value1 && previewWebSearchServerTool != null)
            {
                return previewWebSearchServerTool(__value1);
            }
            else if (Preview20250311WebSearchServerTool is { } __value2 && preview20250311WebSearchServerTool != null)
            {
                return preview20250311WebSearchServerTool(__value2);
            }
            else if (LegacyWebSearchServerTool is { } __value3 && legacyWebSearchServerTool != null)
            {
                return legacyWebSearchServerTool(__value3);
            }
            else if (WebSearchServerTool is { } __value4 && webSearchServerTool != null)
            {
                return webSearchServerTool(__value4);
            }
            else if (FileSearchServerTool is { } __value5 && fileSearchServerTool != null)
            {
                return fileSearchServerTool(__value5);
            }
            else if (ComputerUseServerTool is { } __value6 && computerUseServerTool != null)
            {
                return computerUseServerTool(__value6);
            }
            else if (CodeInterpreterServerTool is { } __value7 && codeInterpreterServerTool != null)
            {
                return codeInterpreterServerTool(__value7);
            }
            else if (McpServerTool is { } __value8 && mcpServerTool != null)
            {
                return mcpServerTool(__value8);
            }
            else if (ImageGenerationServerTool is { } __value9 && imageGenerationServerTool != null)
            {
                return imageGenerationServerTool(__value9);
            }
            else if (CodexLocalShellTool is { } __value10 && codexLocalShellTool != null)
            {
                return codexLocalShellTool(__value10);
            }
            else if (ShellServerTool is { } __value11 && shellServerTool != null)
            {
                return shellServerTool(__value11);
            }
            else if (ApplyPatchServerTool is { } __value12 && applyPatchServerTool != null)
            {
                return applyPatchServerTool(__value12);
            }
            else if (CustomTool is { } __value13 && customTool != null)
            {
                return customTool(__value13);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseResponsesResultToolsItems0>? baseResponsesResultToolsItems0 = null,

            global::System.Action<global::G.PreviewWebSearchServerTool>? previewWebSearchServerTool = null,

            global::System.Action<global::G.Preview20250311WebSearchServerTool>? preview20250311WebSearchServerTool = null,

            global::System.Action<global::G.LegacyWebSearchServerTool>? legacyWebSearchServerTool = null,

            global::System.Action<global::G.WebSearchServerTool>? webSearchServerTool = null,

            global::System.Action<global::G.FileSearchServerTool>? fileSearchServerTool = null,

            global::System.Action<global::G.ComputerUseServerTool>? computerUseServerTool = null,

            global::System.Action<global::G.CodeInterpreterServerTool>? codeInterpreterServerTool = null,

            global::System.Action<global::G.McpServerTool>? mcpServerTool = null,

            global::System.Action<global::G.ImageGenerationServerTool>? imageGenerationServerTool = null,

            global::System.Action<global::G.CodexLocalShellTool>? codexLocalShellTool = null,

            global::System.Action<global::G.ShellServerTool>? shellServerTool = null,

            global::System.Action<global::G.ApplyPatchServerTool>? applyPatchServerTool = null,

            global::System.Action<global::G.CustomTool>? customTool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BaseResponsesResultToolsItems0 is { } __value0)
            {
                baseResponsesResultToolsItems0?.Invoke(__value0);
            }
            else if (PreviewWebSearchServerTool is { } __value1)
            {
                previewWebSearchServerTool?.Invoke(__value1);
            }
            else if (Preview20250311WebSearchServerTool is { } __value2)
            {
                preview20250311WebSearchServerTool?.Invoke(__value2);
            }
            else if (LegacyWebSearchServerTool is { } __value3)
            {
                legacyWebSearchServerTool?.Invoke(__value3);
            }
            else if (WebSearchServerTool is { } __value4)
            {
                webSearchServerTool?.Invoke(__value4);
            }
            else if (FileSearchServerTool is { } __value5)
            {
                fileSearchServerTool?.Invoke(__value5);
            }
            else if (ComputerUseServerTool is { } __value6)
            {
                computerUseServerTool?.Invoke(__value6);
            }
            else if (CodeInterpreterServerTool is { } __value7)
            {
                codeInterpreterServerTool?.Invoke(__value7);
            }
            else if (McpServerTool is { } __value8)
            {
                mcpServerTool?.Invoke(__value8);
            }
            else if (ImageGenerationServerTool is { } __value9)
            {
                imageGenerationServerTool?.Invoke(__value9);
            }
            else if (CodexLocalShellTool is { } __value10)
            {
                codexLocalShellTool?.Invoke(__value10);
            }
            else if (ShellServerTool is { } __value11)
            {
                shellServerTool?.Invoke(__value11);
            }
            else if (ApplyPatchServerTool is { } __value12)
            {
                applyPatchServerTool?.Invoke(__value12);
            }
            else if (CustomTool is { } __value13)
            {
                customTool?.Invoke(__value13);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.BaseResponsesResultToolsItems0>? baseResponsesResultToolsItems0 = null,
            global::System.Action<global::G.PreviewWebSearchServerTool>? previewWebSearchServerTool = null,
            global::System.Action<global::G.Preview20250311WebSearchServerTool>? preview20250311WebSearchServerTool = null,
            global::System.Action<global::G.LegacyWebSearchServerTool>? legacyWebSearchServerTool = null,
            global::System.Action<global::G.WebSearchServerTool>? webSearchServerTool = null,
            global::System.Action<global::G.FileSearchServerTool>? fileSearchServerTool = null,
            global::System.Action<global::G.ComputerUseServerTool>? computerUseServerTool = null,
            global::System.Action<global::G.CodeInterpreterServerTool>? codeInterpreterServerTool = null,
            global::System.Action<global::G.McpServerTool>? mcpServerTool = null,
            global::System.Action<global::G.ImageGenerationServerTool>? imageGenerationServerTool = null,
            global::System.Action<global::G.CodexLocalShellTool>? codexLocalShellTool = null,
            global::System.Action<global::G.ShellServerTool>? shellServerTool = null,
            global::System.Action<global::G.ApplyPatchServerTool>? applyPatchServerTool = null,
            global::System.Action<global::G.CustomTool>? customTool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BaseResponsesResultToolsItems0 is { } __value0)
            {
                baseResponsesResultToolsItems0?.Invoke(__value0);
            }
            else if (PreviewWebSearchServerTool is { } __value1)
            {
                previewWebSearchServerTool?.Invoke(__value1);
            }
            else if (Preview20250311WebSearchServerTool is { } __value2)
            {
                preview20250311WebSearchServerTool?.Invoke(__value2);
            }
            else if (LegacyWebSearchServerTool is { } __value3)
            {
                legacyWebSearchServerTool?.Invoke(__value3);
            }
            else if (WebSearchServerTool is { } __value4)
            {
                webSearchServerTool?.Invoke(__value4);
            }
            else if (FileSearchServerTool is { } __value5)
            {
                fileSearchServerTool?.Invoke(__value5);
            }
            else if (ComputerUseServerTool is { } __value6)
            {
                computerUseServerTool?.Invoke(__value6);
            }
            else if (CodeInterpreterServerTool is { } __value7)
            {
                codeInterpreterServerTool?.Invoke(__value7);
            }
            else if (McpServerTool is { } __value8)
            {
                mcpServerTool?.Invoke(__value8);
            }
            else if (ImageGenerationServerTool is { } __value9)
            {
                imageGenerationServerTool?.Invoke(__value9);
            }
            else if (CodexLocalShellTool is { } __value10)
            {
                codexLocalShellTool?.Invoke(__value10);
            }
            else if (ShellServerTool is { } __value11)
            {
                shellServerTool?.Invoke(__value11);
            }
            else if (ApplyPatchServerTool is { } __value12)
            {
                applyPatchServerTool?.Invoke(__value12);
            }
            else if (CustomTool is { } __value13)
            {
                customTool?.Invoke(__value13);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseResponsesResultToolsItems0,
                typeof(global::G.BaseResponsesResultToolsItems0),
                PreviewWebSearchServerTool,
                typeof(global::G.PreviewWebSearchServerTool),
                Preview20250311WebSearchServerTool,
                typeof(global::G.Preview20250311WebSearchServerTool),
                LegacyWebSearchServerTool,
                typeof(global::G.LegacyWebSearchServerTool),
                WebSearchServerTool,
                typeof(global::G.WebSearchServerTool),
                FileSearchServerTool,
                typeof(global::G.FileSearchServerTool),
                ComputerUseServerTool,
                typeof(global::G.ComputerUseServerTool),
                CodeInterpreterServerTool,
                typeof(global::G.CodeInterpreterServerTool),
                McpServerTool,
                typeof(global::G.McpServerTool),
                ImageGenerationServerTool,
                typeof(global::G.ImageGenerationServerTool),
                CodexLocalShellTool,
                typeof(global::G.CodexLocalShellTool),
                ShellServerTool,
                typeof(global::G.ShellServerTool),
                ApplyPatchServerTool,
                typeof(global::G.ApplyPatchServerTool),
                CustomTool,
                typeof(global::G.CustomTool),
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
        public bool Equals(BaseResponsesResultToolsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseResponsesResultToolsItems0?>.Default.Equals(BaseResponsesResultToolsItems0, other.BaseResponsesResultToolsItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PreviewWebSearchServerTool?>.Default.Equals(PreviewWebSearchServerTool, other.PreviewWebSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Preview20250311WebSearchServerTool?>.Default.Equals(Preview20250311WebSearchServerTool, other.Preview20250311WebSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LegacyWebSearchServerTool?>.Default.Equals(LegacyWebSearchServerTool, other.LegacyWebSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchServerTool?>.Default.Equals(WebSearchServerTool, other.WebSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchServerTool?>.Default.Equals(FileSearchServerTool, other.FileSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerUseServerTool?>.Default.Equals(ComputerUseServerTool, other.ComputerUseServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterServerTool?>.Default.Equals(CodeInterpreterServerTool, other.CodeInterpreterServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpServerTool?>.Default.Equals(McpServerTool, other.McpServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageGenerationServerTool?>.Default.Equals(ImageGenerationServerTool, other.ImageGenerationServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodexLocalShellTool?>.Default.Equals(CodexLocalShellTool, other.CodexLocalShellTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ShellServerTool?>.Default.Equals(ShellServerTool, other.ShellServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ApplyPatchServerTool?>.Default.Equals(ApplyPatchServerTool, other.ApplyPatchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CustomTool?>.Default.Equals(CustomTool, other.CustomTool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseResponsesResultToolsItems obj1, BaseResponsesResultToolsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseResponsesResultToolsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseResponsesResultToolsItems obj1, BaseResponsesResultToolsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseResponsesResultToolsItems o && Equals(o);
        }
    }
}
