//HintName: G.Models.ClipFit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set how the asset should be scaled to fit the viewport using one of the following options: <br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`crop` &lt;b&gt;(default)&lt;/b&gt; - scale the asset to fill the viewport while maintaining the aspect ratio. The asset will be cropped if it exceeds the bounds of the viewport.&lt;/li&gt;<br/>
    ///     &lt;li&gt;`cover` - stretch the asset to fill the viewport without maintaining the aspect ratio.&lt;/li&gt;<br/>
    ///     &lt;li&gt;`contain` - fit the entire asset within the viewport while maintaining the original aspect ratio.&lt;/li&gt;<br/>
    ///     &lt;li&gt;`none` - preserves the original asset dimensions and does not apply any scaling.&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipFit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contain")]
        Contain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cover")]
        Cover,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="crop")]
        Crop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipFitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipFit value)
        {
            return value switch
            {
                ClipFit.Contain => "contain",
                ClipFit.Cover => "cover",
                ClipFit.Crop => "crop",
                ClipFit.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipFit? ToEnum(string value)
        {
            return value switch
            {
                "contain" => ClipFit.Contain,
                "cover" => ClipFit.Cover,
                "crop" => ClipFit.Crop,
                "none" => ClipFit.None,
                _ => null,
            };
        }
    }
}