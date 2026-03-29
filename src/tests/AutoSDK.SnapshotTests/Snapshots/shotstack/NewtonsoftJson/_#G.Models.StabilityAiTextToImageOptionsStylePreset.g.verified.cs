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
    [global::System.Runtime.Serialization.DataContract]
    public enum StabilityAiTextToImageOptionsStylePreset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3d-model")]
        x3dModel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="analog-film")]
        AnalogFilm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anime")]
        Anime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cinematic")]
        Cinematic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="comic-book")]
        ComicBook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="digital-art")]
        DigitalArt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enhance")]
        Enhance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fantasy-art")]
        FantasyArt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="isometric")]
        Isometric,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line-art")]
        LineArt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low-poly")]
        LowPoly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="modeling-compound")]
        ModelingCompound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neon-punk")]
        NeonPunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="origami")]
        Origami,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="photographic")]
        Photographic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pixel-art")]
        PixelArt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tile-texture")]
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