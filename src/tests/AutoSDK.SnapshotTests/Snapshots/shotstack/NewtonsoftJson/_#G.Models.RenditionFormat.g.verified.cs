//HintName: G.Models.RenditionFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output format to encode the file to. You can only encode a file to the same type, i.e. a video to a video or an image to an image. You can't encode a video as an image. The following formats are available: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`mp4` - mp4 video file (video only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`webm` - webm video file (video only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`mov` - mov video file (video only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`avi` - avi video file (video only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`mkv` - mkv video file (video only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`ogv` - ogv video file (video only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`wmv` - wmv video file (video only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`avif` - avif video file (video only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`gif` - animated gif file (video only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`jpg` - jpg image file (image only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`png` - png image file (image only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`webp` - webp image file (image only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`tif` - tif image file (image only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`mp3` - mp3 audio file (audio only)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`wav` - wav audio file (audio only)&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: mp4
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RenditionFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="avi")]
        Avi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="avif")]
        Avif,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gif")]
        Gif,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jpg")]
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mkv")]
        Mkv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mov")]
        Mov,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp4")]
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ogv")]
        Ogv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="png")]
        Png,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tif")]
        Tif,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webm")]
        Webm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webp")]
        Webp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wmv")]
        Wmv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenditionFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenditionFormat value)
        {
            return value switch
            {
                RenditionFormat.Avi => "avi",
                RenditionFormat.Avif => "avif",
                RenditionFormat.Gif => "gif",
                RenditionFormat.Jpg => "jpg",
                RenditionFormat.Mkv => "mkv",
                RenditionFormat.Mov => "mov",
                RenditionFormat.Mp3 => "mp3",
                RenditionFormat.Mp4 => "mp4",
                RenditionFormat.Ogv => "ogv",
                RenditionFormat.Png => "png",
                RenditionFormat.Tif => "tif",
                RenditionFormat.Wav => "wav",
                RenditionFormat.Webm => "webm",
                RenditionFormat.Webp => "webp",
                RenditionFormat.Wmv => "wmv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenditionFormat? ToEnum(string value)
        {
            return value switch
            {
                "avi" => RenditionFormat.Avi,
                "avif" => RenditionFormat.Avif,
                "gif" => RenditionFormat.Gif,
                "jpg" => RenditionFormat.Jpg,
                "mkv" => RenditionFormat.Mkv,
                "mov" => RenditionFormat.Mov,
                "mp3" => RenditionFormat.Mp3,
                "mp4" => RenditionFormat.Mp4,
                "ogv" => RenditionFormat.Ogv,
                "png" => RenditionFormat.Png,
                "tif" => RenditionFormat.Tif,
                "wav" => RenditionFormat.Wav,
                "webm" => RenditionFormat.Webm,
                "webp" => RenditionFormat.Webp,
                "wmv" => RenditionFormat.Wmv,
                _ => null,
            };
        }
    }
}