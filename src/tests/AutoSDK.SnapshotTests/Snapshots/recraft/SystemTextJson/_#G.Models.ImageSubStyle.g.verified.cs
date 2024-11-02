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
        x3d,
        /// <summary>
        /// 
        /// </summary>
        x80s,
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
        InfantileSketch,
        /// <summary>
        /// 
        /// </summary>
        Kawaii,
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
        Voxel,
        /// <summary>
        /// 
        /// </summary>
        Watercolor,
        /// <summary>
        /// 
        /// </summary>
        BrokenLine,
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
        DoodleOffsetFill,
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
        UnevenFill,
        /// <summary>
        /// 
        /// </summary>
        x70s,
        /// <summary>
        /// 
        /// </summary>
        Cartoon,
        /// <summary>
        /// 
        /// </summary>
        DoodleLineArt,
        /// <summary>
        /// 
        /// </summary>
        Engraving,
        /// <summary>
        /// 
        /// </summary>
        Flat2,
        /// <summary>
        /// 
        /// </summary>
        LineArt,
        /// <summary>
        /// 
        /// </summary>
        Linocut,
        /// <summary>
        /// 
        /// </summary>
        BAndW,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
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
        MotionBlur,
        /// <summary>
        /// 
        /// </summary>
        NaturalLight,
        /// <summary>
        /// 
        /// </summary>
        StudioPortrait,
        /// <summary>
        /// 
        /// </summary>
        LineCircuit,
        /// <summary>
        /// 
        /// </summary>
        x2dArtPoster2,
        /// <summary>
        /// 
        /// </summary>
        EngravingColor,
        /// <summary>
        /// 
        /// </summary>
        FlatAirArt,
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
        StickersDrawings,
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
                ImageSubStyle.x3d => "3d",
                ImageSubStyle.x80s => "80s",
                ImageSubStyle.Glow => "glow",
                ImageSubStyle.Grain => "grain",
                ImageSubStyle.HandDrawn => "hand_drawn",
                ImageSubStyle.InfantileSketch => "infantile_sketch",
                ImageSubStyle.Kawaii => "kawaii",
                ImageSubStyle.PixelArt => "pixel_art",
                ImageSubStyle.Psychedelic => "psychedelic",
                ImageSubStyle.Seamless => "seamless",
                ImageSubStyle.Voxel => "voxel",
                ImageSubStyle.Watercolor => "watercolor",
                ImageSubStyle.BrokenLine => "broken_line",
                ImageSubStyle.ColoredOutline => "colored_outline",
                ImageSubStyle.ColoredShapes => "colored_shapes",
                ImageSubStyle.ColoredShapesGradient => "colored_shapes_gradient",
                ImageSubStyle.DoodleFill => "doodle_fill",
                ImageSubStyle.DoodleOffsetFill => "doodle_offset_fill",
                ImageSubStyle.OffsetFill => "offset_fill",
                ImageSubStyle.Outline => "outline",
                ImageSubStyle.OutlineGradient => "outline_gradient",
                ImageSubStyle.UnevenFill => "uneven_fill",
                ImageSubStyle.x70s => "70s",
                ImageSubStyle.Cartoon => "cartoon",
                ImageSubStyle.DoodleLineArt => "doodle_line_art",
                ImageSubStyle.Engraving => "engraving",
                ImageSubStyle.Flat2 => "flat_2",
                ImageSubStyle.LineArt => "line_art",
                ImageSubStyle.Linocut => "linocut",
                ImageSubStyle.BAndW => "b_and_w",
                ImageSubStyle.Enterprise => "enterprise",
                ImageSubStyle.HardFlash => "hard_flash",
                ImageSubStyle.Hdr => "hdr",
                ImageSubStyle.MotionBlur => "motion_blur",
                ImageSubStyle.NaturalLight => "natural_light",
                ImageSubStyle.StudioPortrait => "studio_portrait",
                ImageSubStyle.LineCircuit => "line_circuit",
                ImageSubStyle.x2dArtPoster2 => "2d_art_poster_2",
                ImageSubStyle.EngravingColor => "engraving_color",
                ImageSubStyle.FlatAirArt => "flat_air_art",
                ImageSubStyle.HandDrawnOutline => "hand_drawn_outline",
                ImageSubStyle.Handmade3d => "handmade_3d",
                ImageSubStyle.StickersDrawings => "stickers_drawings",
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
                "3d" => ImageSubStyle.x3d,
                "80s" => ImageSubStyle.x80s,
                "glow" => ImageSubStyle.Glow,
                "grain" => ImageSubStyle.Grain,
                "hand_drawn" => ImageSubStyle.HandDrawn,
                "infantile_sketch" => ImageSubStyle.InfantileSketch,
                "kawaii" => ImageSubStyle.Kawaii,
                "pixel_art" => ImageSubStyle.PixelArt,
                "psychedelic" => ImageSubStyle.Psychedelic,
                "seamless" => ImageSubStyle.Seamless,
                "voxel" => ImageSubStyle.Voxel,
                "watercolor" => ImageSubStyle.Watercolor,
                "broken_line" => ImageSubStyle.BrokenLine,
                "colored_outline" => ImageSubStyle.ColoredOutline,
                "colored_shapes" => ImageSubStyle.ColoredShapes,
                "colored_shapes_gradient" => ImageSubStyle.ColoredShapesGradient,
                "doodle_fill" => ImageSubStyle.DoodleFill,
                "doodle_offset_fill" => ImageSubStyle.DoodleOffsetFill,
                "offset_fill" => ImageSubStyle.OffsetFill,
                "outline" => ImageSubStyle.Outline,
                "outline_gradient" => ImageSubStyle.OutlineGradient,
                "uneven_fill" => ImageSubStyle.UnevenFill,
                "70s" => ImageSubStyle.x70s,
                "cartoon" => ImageSubStyle.Cartoon,
                "doodle_line_art" => ImageSubStyle.DoodleLineArt,
                "engraving" => ImageSubStyle.Engraving,
                "flat_2" => ImageSubStyle.Flat2,
                "line_art" => ImageSubStyle.LineArt,
                "linocut" => ImageSubStyle.Linocut,
                "b_and_w" => ImageSubStyle.BAndW,
                "enterprise" => ImageSubStyle.Enterprise,
                "hard_flash" => ImageSubStyle.HardFlash,
                "hdr" => ImageSubStyle.Hdr,
                "motion_blur" => ImageSubStyle.MotionBlur,
                "natural_light" => ImageSubStyle.NaturalLight,
                "studio_portrait" => ImageSubStyle.StudioPortrait,
                "line_circuit" => ImageSubStyle.LineCircuit,
                "2d_art_poster_2" => ImageSubStyle.x2dArtPoster2,
                "engraving_color" => ImageSubStyle.EngravingColor,
                "flat_air_art" => ImageSubStyle.FlatAirArt,
                "hand_drawn_outline" => ImageSubStyle.HandDrawnOutline,
                "handmade_3d" => ImageSubStyle.Handmade3d,
                "stickers_drawings" => ImageSubStyle.StickersDrawings,
                _ => null,
            };
        }
    }
}