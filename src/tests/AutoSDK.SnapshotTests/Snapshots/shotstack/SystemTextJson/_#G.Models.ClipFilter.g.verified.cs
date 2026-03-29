//HintName: G.Models.ClipFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A filter effect to apply to the Clip. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`none` - no filter applied&lt;/li&gt;<br/>
    ///   &lt;li&gt;`blur` - blur the scene&lt;/li&gt;<br/>
    ///   &lt;li&gt;`boost` - boost contrast and saturation&lt;/li&gt;<br/>
    ///   &lt;li&gt;`contrast` - increase contrast&lt;/li&gt;<br/>
    ///   &lt;li&gt;`darken` - darken the scene&lt;/li&gt;<br/>
    ///   &lt;li&gt;`greyscale` - remove colour&lt;/li&gt;<br/>
    ///   &lt;li&gt;`lighten` - lighten the scene&lt;/li&gt;<br/>
    ///   &lt;li&gt;`muted` - reduce saturation and contrast&lt;/li&gt;<br/>
    ///   &lt;li&gt;`negative` - negative colors&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: greyscale
    /// </summary>
    public enum ClipFilter
    {
        /// <summary>
        /// 
        /// </summary>
        Blur,
        /// <summary>
        /// 
        /// </summary>
        Boost,
        /// <summary>
        /// 
        /// </summary>
        Contrast,
        /// <summary>
        /// 
        /// </summary>
        Darken,
        /// <summary>
        /// 
        /// </summary>
        Greyscale,
        /// <summary>
        /// 
        /// </summary>
        Lighten,
        /// <summary>
        /// 
        /// </summary>
        Muted,
        /// <summary>
        /// 
        /// </summary>
        Negative,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipFilter value)
        {
            return value switch
            {
                ClipFilter.Blur => "blur",
                ClipFilter.Boost => "boost",
                ClipFilter.Contrast => "contrast",
                ClipFilter.Darken => "darken",
                ClipFilter.Greyscale => "greyscale",
                ClipFilter.Lighten => "lighten",
                ClipFilter.Muted => "muted",
                ClipFilter.Negative => "negative",
                ClipFilter.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipFilter? ToEnum(string value)
        {
            return value switch
            {
                "blur" => ClipFilter.Blur,
                "boost" => ClipFilter.Boost,
                "contrast" => ClipFilter.Contrast,
                "darken" => ClipFilter.Darken,
                "greyscale" => ClipFilter.Greyscale,
                "lighten" => ClipFilter.Lighten,
                "muted" => ClipFilter.Muted,
                "negative" => ClipFilter.Negative,
                "none" => ClipFilter.None,
                _ => null,
            };
        }
    }
}