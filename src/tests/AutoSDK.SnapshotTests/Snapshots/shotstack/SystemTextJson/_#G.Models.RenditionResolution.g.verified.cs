//HintName: G.Models.RenditionResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The preset output resolution of the video or image. This is a convenience property that sets the width and height based on industry standard resolutions. The following resolutions are available: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`preview` - 512px x 288px&lt;/li&gt;<br/>
    ///   &lt;li&gt;`mobile` - 640px x 360px&lt;/li&gt;<br/>
    ///   &lt;li&gt;`sd` - 1024px x 576px&lt;/li&gt;<br/>
    ///   &lt;li&gt;`hd` - 1280px x 720px&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fhd` - 1920px x 1080px&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: hd
    /// </summary>
    public enum RenditionResolution
    {
        /// <summary>
        /// 
        /// </summary>
        Fhd,
        /// <summary>
        /// 
        /// </summary>
        Hd,
        /// <summary>
        /// 
        /// </summary>
        Mobile,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Sd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenditionResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenditionResolution value)
        {
            return value switch
            {
                RenditionResolution.Fhd => "fhd",
                RenditionResolution.Hd => "hd",
                RenditionResolution.Mobile => "mobile",
                RenditionResolution.Preview => "preview",
                RenditionResolution.Sd => "sd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenditionResolution? ToEnum(string value)
        {
            return value switch
            {
                "fhd" => RenditionResolution.Fhd,
                "hd" => RenditionResolution.Hd,
                "mobile" => RenditionResolution.Mobile,
                "preview" => RenditionResolution.Preview,
                "sd" => RenditionResolution.Sd,
                _ => null,
            };
        }
    }
}