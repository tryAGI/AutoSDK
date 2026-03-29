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
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blur")]
        Blur,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boost")]
        Boost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contrast")]
        Contrast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="darken")]
        Darken,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="greyscale")]
        Greyscale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lighten")]
        Lighten,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="muted")]
        Muted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="negative")]
        Negative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
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