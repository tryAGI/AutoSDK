//HintName: G.Models.RenditionFit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set how the rendition should be scaled and cropped when using a size with an aspect ratio that is different from the source. Fit applies to both videos and images. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`crop` &lt;b&gt;(default)&lt;/b&gt; - scale the rendition to fill the output area while maintaining the aspect ratio. The rendition will be cropped if it exceeds the bounds of the output.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`cover` - stretch the rendition to fill the output without maintaining the aspect ratio.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`contain` - fit the entire rendition within the output while maintaining the original aspect ratio.&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: crop
    /// </summary>
    public enum RenditionFit
    {
        /// <summary>
        /// 
        /// </summary>
        Contain,
        /// <summary>
        /// 
        /// </summary>
        Cover,
        /// <summary>
        /// 
        /// </summary>
        Crop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenditionFitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenditionFit value)
        {
            return value switch
            {
                RenditionFit.Contain => "contain",
                RenditionFit.Cover => "cover",
                RenditionFit.Crop => "crop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenditionFit? ToEnum(string value)
        {
            return value switch
            {
                "contain" => RenditionFit.Contain,
                "cover" => RenditionFit.Cover,
                "crop" => RenditionFit.Crop,
                _ => null,
            };
        }
    }
}