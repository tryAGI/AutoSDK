//HintName: G.Models.StabilityAiTextToImageOptionsStylePreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Apply a preset to generate an image in a particular style. Select from the list of available presets: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`3d-model`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`analog-film`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`anime`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`cinematic`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`comic-book`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`digital-art`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`enhance`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fantasy-art`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`isometric`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`line-art`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`low-poly`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`modeling-compound`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`neon-punk`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`origami`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`photographic`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`pixel-art`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`tile-texture`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: photographic
    /// </summary>
    public enum StabilityAiTextToImageOptionsStylePreset
    {
        /// <summary>
        /// 
        /// </summary>
        x3dModel,
        /// <summary>
        /// 
        /// </summary>
        AnalogFilm,
        /// <summary>
        /// 
        /// </summary>
        Anime,
        /// <summary>
        /// 
        /// </summary>
        Cinematic,
        /// <summary>
        /// 
        /// </summary>
        ComicBook,
        /// <summary>
        /// 
        /// </summary>
        DigitalArt,
        /// <summary>
        /// 
        /// </summary>
        Enhance,
        /// <summary>
        /// 
        /// </summary>
        FantasyArt,
        /// <summary>
        /// 
        /// </summary>
        Isometric,
        /// <summary>
        /// 
        /// </summary>
        LineArt,
        /// <summary>
        /// 
        /// </summary>
        LowPoly,
        /// <summary>
        /// 
        /// </summary>
        ModelingCompound,
        /// <summary>
        /// 
        /// </summary>
        NeonPunk,
        /// <summary>
        /// 
        /// </summary>
        Origami,
        /// <summary>
        /// 
        /// </summary>
        Photographic,
        /// <summary>
        /// 
        /// </summary>
        PixelArt,
        /// <summary>
        /// 
        /// </summary>
        TileTexture,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StabilityAiTextToImageOptionsStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StabilityAiTextToImageOptionsStylePreset value)
        {
            return value switch
            {
                StabilityAiTextToImageOptionsStylePreset.x3dModel => "3d-model",
                StabilityAiTextToImageOptionsStylePreset.AnalogFilm => "analog-film",
                StabilityAiTextToImageOptionsStylePreset.Anime => "anime",
                StabilityAiTextToImageOptionsStylePreset.Cinematic => "cinematic",
                StabilityAiTextToImageOptionsStylePreset.ComicBook => "comic-book",
                StabilityAiTextToImageOptionsStylePreset.DigitalArt => "digital-art",
                StabilityAiTextToImageOptionsStylePreset.Enhance => "enhance",
                StabilityAiTextToImageOptionsStylePreset.FantasyArt => "fantasy-art",
                StabilityAiTextToImageOptionsStylePreset.Isometric => "isometric",
                StabilityAiTextToImageOptionsStylePreset.LineArt => "line-art",
                StabilityAiTextToImageOptionsStylePreset.LowPoly => "low-poly",
                StabilityAiTextToImageOptionsStylePreset.ModelingCompound => "modeling-compound",
                StabilityAiTextToImageOptionsStylePreset.NeonPunk => "neon-punk",
                StabilityAiTextToImageOptionsStylePreset.Origami => "origami",
                StabilityAiTextToImageOptionsStylePreset.Photographic => "photographic",
                StabilityAiTextToImageOptionsStylePreset.PixelArt => "pixel-art",
                StabilityAiTextToImageOptionsStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StabilityAiTextToImageOptionsStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => StabilityAiTextToImageOptionsStylePreset.x3dModel,
                "analog-film" => StabilityAiTextToImageOptionsStylePreset.AnalogFilm,
                "anime" => StabilityAiTextToImageOptionsStylePreset.Anime,
                "cinematic" => StabilityAiTextToImageOptionsStylePreset.Cinematic,
                "comic-book" => StabilityAiTextToImageOptionsStylePreset.ComicBook,
                "digital-art" => StabilityAiTextToImageOptionsStylePreset.DigitalArt,
                "enhance" => StabilityAiTextToImageOptionsStylePreset.Enhance,
                "fantasy-art" => StabilityAiTextToImageOptionsStylePreset.FantasyArt,
                "isometric" => StabilityAiTextToImageOptionsStylePreset.Isometric,
                "line-art" => StabilityAiTextToImageOptionsStylePreset.LineArt,
                "low-poly" => StabilityAiTextToImageOptionsStylePreset.LowPoly,
                "modeling-compound" => StabilityAiTextToImageOptionsStylePreset.ModelingCompound,
                "neon-punk" => StabilityAiTextToImageOptionsStylePreset.NeonPunk,
                "origami" => StabilityAiTextToImageOptionsStylePreset.Origami,
                "photographic" => StabilityAiTextToImageOptionsStylePreset.Photographic,
                "pixel-art" => StabilityAiTextToImageOptionsStylePreset.PixelArt,
                "tile-texture" => StabilityAiTextToImageOptionsStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}