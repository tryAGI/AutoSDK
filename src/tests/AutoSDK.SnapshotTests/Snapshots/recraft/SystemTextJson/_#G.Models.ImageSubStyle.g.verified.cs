//HintName: G.Models.ImageSubStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageSubStyle
    {
        /// <summary>
        /// 
        /// </summary>
        x2dArtPoster,
        /// <summary>
        /// 
        /// </summary>
        x2dArtPoster2,
        /// <summary>
        /// 
        /// </summary>
        x3d,
        /// <summary>
        /// 
        /// </summary>
        x70s,
        /// <summary>
        /// 
        /// </summary>
        x80s,
        /// <summary>
        /// 
        /// </summary>
        BAndW,
        /// <summary>
        /// 
        /// </summary>
        BrokenLine,
        /// <summary>
        /// 
        /// </summary>
        Cartoon,
        /// <summary>
        /// 
        /// </summary>
        ColoredOutline,
        /// <summary>
        /// 
        /// </summary>
        ColoredShapes,
        /// <summary>
        /// 
        /// </summary>
        ColoredShapesGradient,
        /// <summary>
        /// 
        /// </summary>
        DoodleFill,
        /// <summary>
        /// 
        /// </summary>
        DoodleLineArt,
        /// <summary>
        /// 
        /// </summary>
        DoodleOffsetFill,
        /// <summary>
        /// 
        /// </summary>
        Engraving,
        /// <summary>
        /// 
        /// </summary>
        EngravingColor,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Flat2,
        /// <summary>
        /// 
        /// </summary>
        FlatAirArt,
        /// <summary>
        /// 
        /// </summary>
        Glow,
        /// <summary>
        /// 
        /// </summary>
        Grain,
        /// <summary>
        /// 
        /// </summary>
        HandDrawn,
        /// <summary>
        /// 
        /// </summary>
        HandDrawnOutline,
        /// <summary>
        /// 
        /// </summary>
        Handmade3d,
        /// <summary>
        /// 
        /// </summary>
        HardFlash,
        /// <summary>
        /// 
        /// </summary>
        Hdr,
        /// <summary>
        /// 
        /// </summary>
        InfantileSketch,
        /// <summary>
        /// 
        /// </summary>
        Kawaii,
        /// <summary>
        /// 
        /// </summary>
        LineArt,
        /// <summary>
        /// 
        /// </summary>
        LineCircuit,
        /// <summary>
        /// 
        /// </summary>
        Linocut,
        /// <summary>
        /// 
        /// </summary>
        MotionBlur,
        /// <summary>
        /// 
        /// </summary>
        NaturalLight,
        /// <summary>
        /// 
        /// </summary>
        OffsetFill,
        /// <summary>
        /// 
        /// </summary>
        Outline,
        /// <summary>
        /// 
        /// </summary>
        OutlineGradient,
        /// <summary>
        /// 
        /// </summary>
        PixelArt,
        /// <summary>
        /// 
        /// </summary>
        Psychedelic,
        /// <summary>
        /// 
        /// </summary>
        Seamless,
        /// <summary>
        /// 
        /// </summary>
        StickersDrawings,
        /// <summary>
        /// 
        /// </summary>
        StudioPortrait,
        /// <summary>
        /// 
        /// </summary>
        UnevenFill,
        /// <summary>
        /// 
        /// </summary>
        Voxel,
        /// <summary>
        /// 
        /// </summary>
        Watercolor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageSubStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageSubStyle value)
        {
            return value switch
            {
                ImageSubStyle.x2dArtPoster => "2d_art_poster",
                ImageSubStyle.x2dArtPoster2 => "2d_art_poster_2",
                ImageSubStyle.x3d => "3d",
                ImageSubStyle.x70s => "70s",
                ImageSubStyle.x80s => "80s",
                ImageSubStyle.BAndW => "b_and_w",
                ImageSubStyle.BrokenLine => "broken_line",
                ImageSubStyle.Cartoon => "cartoon",
                ImageSubStyle.ColoredOutline => "colored_outline",
                ImageSubStyle.ColoredShapes => "colored_shapes",
                ImageSubStyle.ColoredShapesGradient => "colored_shapes_gradient",
                ImageSubStyle.DoodleFill => "doodle_fill",
                ImageSubStyle.DoodleLineArt => "doodle_line_art",
                ImageSubStyle.DoodleOffsetFill => "doodle_offset_fill",
                ImageSubStyle.Engraving => "engraving",
                ImageSubStyle.EngravingColor => "engraving_color",
                ImageSubStyle.Enterprise => "enterprise",
                ImageSubStyle.Flat2 => "flat_2",
                ImageSubStyle.FlatAirArt => "flat_air_art",
                ImageSubStyle.Glow => "glow",
                ImageSubStyle.Grain => "grain",
                ImageSubStyle.HandDrawn => "hand_drawn",
                ImageSubStyle.HandDrawnOutline => "hand_drawn_outline",
                ImageSubStyle.Handmade3d => "handmade_3d",
                ImageSubStyle.HardFlash => "hard_flash",
                ImageSubStyle.Hdr => "hdr",
                ImageSubStyle.InfantileSketch => "infantile_sketch",
                ImageSubStyle.Kawaii => "kawaii",
                ImageSubStyle.LineArt => "line_art",
                ImageSubStyle.LineCircuit => "line_circuit",
                ImageSubStyle.Linocut => "linocut",
                ImageSubStyle.MotionBlur => "motion_blur",
                ImageSubStyle.NaturalLight => "natural_light",
                ImageSubStyle.OffsetFill => "offset_fill",
                ImageSubStyle.Outline => "outline",
                ImageSubStyle.OutlineGradient => "outline_gradient",
                ImageSubStyle.PixelArt => "pixel_art",
                ImageSubStyle.Psychedelic => "psychedelic",
                ImageSubStyle.Seamless => "seamless",
                ImageSubStyle.StickersDrawings => "stickers_drawings",
                ImageSubStyle.StudioPortrait => "studio_portrait",
                ImageSubStyle.UnevenFill => "uneven_fill",
                ImageSubStyle.Voxel => "voxel",
                ImageSubStyle.Watercolor => "watercolor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageSubStyle? ToEnum(string value)
        {
            return value switch
            {
                "2d_art_poster" => ImageSubStyle.x2dArtPoster,
                "2d_art_poster_2" => ImageSubStyle.x2dArtPoster2,
                "3d" => ImageSubStyle.x3d,
                "70s" => ImageSubStyle.x70s,
                "80s" => ImageSubStyle.x80s,
                "b_and_w" => ImageSubStyle.BAndW,
                "broken_line" => ImageSubStyle.BrokenLine,
                "cartoon" => ImageSubStyle.Cartoon,
                "colored_outline" => ImageSubStyle.ColoredOutline,
                "colored_shapes" => ImageSubStyle.ColoredShapes,
                "colored_shapes_gradient" => ImageSubStyle.ColoredShapesGradient,
                "doodle_fill" => ImageSubStyle.DoodleFill,
                "doodle_line_art" => ImageSubStyle.DoodleLineArt,
                "doodle_offset_fill" => ImageSubStyle.DoodleOffsetFill,
                "engraving" => ImageSubStyle.Engraving,
                "engraving_color" => ImageSubStyle.EngravingColor,
                "enterprise" => ImageSubStyle.Enterprise,
                "flat_2" => ImageSubStyle.Flat2,
                "flat_air_art" => ImageSubStyle.FlatAirArt,
                "glow" => ImageSubStyle.Glow,
                "grain" => ImageSubStyle.Grain,
                "hand_drawn" => ImageSubStyle.HandDrawn,
                "hand_drawn_outline" => ImageSubStyle.HandDrawnOutline,
                "handmade_3d" => ImageSubStyle.Handmade3d,
                "hard_flash" => ImageSubStyle.HardFlash,
                "hdr" => ImageSubStyle.Hdr,
                "infantile_sketch" => ImageSubStyle.InfantileSketch,
                "kawaii" => ImageSubStyle.Kawaii,
                "line_art" => ImageSubStyle.LineArt,
                "line_circuit" => ImageSubStyle.LineCircuit,
                "linocut" => ImageSubStyle.Linocut,
                "motion_blur" => ImageSubStyle.MotionBlur,
                "natural_light" => ImageSubStyle.NaturalLight,
                "offset_fill" => ImageSubStyle.OffsetFill,
                "outline" => ImageSubStyle.Outline,
                "outline_gradient" => ImageSubStyle.OutlineGradient,
                "pixel_art" => ImageSubStyle.PixelArt,
                "psychedelic" => ImageSubStyle.Psychedelic,
                "seamless" => ImageSubStyle.Seamless,
                "stickers_drawings" => ImageSubStyle.StickersDrawings,
                "studio_portrait" => ImageSubStyle.StudioPortrait,
                "uneven_fill" => ImageSubStyle.UnevenFill,
                "voxel" => ImageSubStyle.Voxel,
                "watercolor" => ImageSubStyle.Watercolor,
                _ => null,
            };
        }
    }
}