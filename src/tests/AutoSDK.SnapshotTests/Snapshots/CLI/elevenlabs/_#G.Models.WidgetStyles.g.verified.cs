//HintName: G.Models.WidgetStyles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetStyles
    {
        /// <summary>
        /// The base background color.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        public string? Base { get; set; }

        /// <summary>
        /// The color of the base background when hovered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_hover")]
        public string? BaseHover { get; set; }

        /// <summary>
        /// The color of the base background when active (clicked).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_active")]
        public string? BaseActive { get; set; }

        /// <summary>
        /// The color of the border against the base background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_border")]
        public string? BaseBorder { get; set; }

        /// <summary>
        /// The color of subtle text against the base background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_subtle")]
        public string? BaseSubtle { get; set; }

        /// <summary>
        /// The color of primary text against the base background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_primary")]
        public string? BasePrimary { get; set; }

        /// <summary>
        /// The color of error text against the base background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_error")]
        public string? BaseError { get; set; }

        /// <summary>
        /// The accent background color.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// The color of the accent background when hovered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent_hover")]
        public string? AccentHover { get; set; }

        /// <summary>
        /// The color of the accent background when active (clicked).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent_active")]
        public string? AccentActive { get; set; }

        /// <summary>
        /// The color of the border against the accent background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent_border")]
        public string? AccentBorder { get; set; }

        /// <summary>
        /// The color of subtle text against the accent background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent_subtle")]
        public string? AccentSubtle { get; set; }

        /// <summary>
        /// The color of primary text against the accent background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent_primary")]
        public string? AccentPrimary { get; set; }

        /// <summary>
        /// The padding around the edges of the viewport.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlay_padding")]
        public double? OverlayPadding { get; set; }

        /// <summary>
        /// The radius of the buttons.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("button_radius")]
        public double? ButtonRadius { get; set; }

        /// <summary>
        /// The radius of the input fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_radius")]
        public double? InputRadius { get; set; }

        /// <summary>
        /// The radius of the chat bubbles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bubble_radius")]
        public double? BubbleRadius { get; set; }

        /// <summary>
        /// The default radius of sheets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_radius")]
        public double? SheetRadius { get; set; }

        /// <summary>
        /// The radius of the sheet in compact mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compact_sheet_radius")]
        public double? CompactSheetRadius { get; set; }

        /// <summary>
        /// The radius of the dropdown sheet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dropdown_sheet_radius")]
        public double? DropdownSheetRadius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetStyles" /> class.
        /// </summary>
        /// <param name="base">
        /// The base background color.
        /// </param>
        /// <param name="baseHover">
        /// The color of the base background when hovered.
        /// </param>
        /// <param name="baseActive">
        /// The color of the base background when active (clicked).
        /// </param>
        /// <param name="baseBorder">
        /// The color of the border against the base background.
        /// </param>
        /// <param name="baseSubtle">
        /// The color of subtle text against the base background.
        /// </param>
        /// <param name="basePrimary">
        /// The color of primary text against the base background.
        /// </param>
        /// <param name="baseError">
        /// The color of error text against the base background.
        /// </param>
        /// <param name="accent">
        /// The accent background color.
        /// </param>
        /// <param name="accentHover">
        /// The color of the accent background when hovered.
        /// </param>
        /// <param name="accentActive">
        /// The color of the accent background when active (clicked).
        /// </param>
        /// <param name="accentBorder">
        /// The color of the border against the accent background.
        /// </param>
        /// <param name="accentSubtle">
        /// The color of subtle text against the accent background.
        /// </param>
        /// <param name="accentPrimary">
        /// The color of primary text against the accent background.
        /// </param>
        /// <param name="overlayPadding">
        /// The padding around the edges of the viewport.
        /// </param>
        /// <param name="buttonRadius">
        /// The radius of the buttons.
        /// </param>
        /// <param name="inputRadius">
        /// The radius of the input fields.
        /// </param>
        /// <param name="bubbleRadius">
        /// The radius of the chat bubbles.
        /// </param>
        /// <param name="sheetRadius">
        /// The default radius of sheets.
        /// </param>
        /// <param name="compactSheetRadius">
        /// The radius of the sheet in compact mode.
        /// </param>
        /// <param name="dropdownSheetRadius">
        /// The radius of the dropdown sheet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetStyles(
            string? @base,
            string? baseHover,
            string? baseActive,
            string? baseBorder,
            string? baseSubtle,
            string? basePrimary,
            string? baseError,
            string? accent,
            string? accentHover,
            string? accentActive,
            string? accentBorder,
            string? accentSubtle,
            string? accentPrimary,
            double? overlayPadding,
            double? buttonRadius,
            double? inputRadius,
            double? bubbleRadius,
            double? sheetRadius,
            double? compactSheetRadius,
            double? dropdownSheetRadius)
        {
            this.Base = @base;
            this.BaseHover = baseHover;
            this.BaseActive = baseActive;
            this.BaseBorder = baseBorder;
            this.BaseSubtle = baseSubtle;
            this.BasePrimary = basePrimary;
            this.BaseError = baseError;
            this.Accent = accent;
            this.AccentHover = accentHover;
            this.AccentActive = accentActive;
            this.AccentBorder = accentBorder;
            this.AccentSubtle = accentSubtle;
            this.AccentPrimary = accentPrimary;
            this.OverlayPadding = overlayPadding;
            this.ButtonRadius = buttonRadius;
            this.InputRadius = inputRadius;
            this.BubbleRadius = bubbleRadius;
            this.SheetRadius = sheetRadius;
            this.CompactSheetRadius = compactSheetRadius;
            this.DropdownSheetRadius = dropdownSheetRadius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetStyles" /> class.
        /// </summary>
        public WidgetStyles()
        {
        }
    }
}