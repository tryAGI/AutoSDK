//HintName: G.Models.OutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output format and type of media file to generate. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`mp4` - mp4 video file&lt;/li&gt;<br/>
    ///   &lt;li&gt;`gif` - animated gif&lt;/li&gt;<br/>
    ///   &lt;li&gt;`jpg` - jpg image file&lt;/li&gt;<br/>
    ///   &lt;li&gt;`png` - png image file&lt;/li&gt;<br/>
    ///   &lt;li&gt;`bmp` - bmp image file&lt;/li&gt;<br/>
    ///   &lt;li&gt;`mp3` - mp3 audio file (audio only)&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: mp4
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bmp")]
        Bmp,
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
        [global::System.Runtime.Serialization.EnumMember(Value="png")]
        Png,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat value)
        {
            return value switch
            {
                OutputFormat.Bmp => "bmp",
                OutputFormat.Gif => "gif",
                OutputFormat.Jpg => "jpg",
                OutputFormat.Mp3 => "mp3",
                OutputFormat.Mp4 => "mp4",
                OutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "bmp" => OutputFormat.Bmp,
                "gif" => OutputFormat.Gif,
                "jpg" => OutputFormat.Jpg,
                "mp3" => OutputFormat.Mp3,
                "mp4" => OutputFormat.Mp4,
                "png" => OutputFormat.Png,
                _ => null,
            };
        }
    }
}