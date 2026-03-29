//HintName: G.Models.OutputScaleTo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Override the resolution and scale the video or image to render at a different size. When using scaleTo the asset should be edited at the resolution dimensions, i.e. use font sizes that look best at HD, then use scaleTo to output the file at SD and the text will be scaled to the correct size. This is useful if you want to create multiple asset sizes. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`preview` - 512px x 288px @ 15fps&lt;/li&gt;<br/>
    ///   &lt;li&gt;`mobile` - 640px x 360px @ 25fps&lt;/li&gt;<br/>
    ///   &lt;li&gt;`sd` - 1024px x 576px @25fps&lt;/li&gt;<br/>
    ///   &lt;li&gt;`hd` - 1280px x 720px @25fps&lt;/li&gt;<br/>
    ///   &lt;li&gt;`1080` - 1920px x 1080px @25fps&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputScaleTo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1080")]
        x1080,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="4k")]
        x4k,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hd")]
        Hd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mobile")]
        Mobile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="preview")]
        Preview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sd")]
        Sd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputScaleToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputScaleTo value)
        {
            return value switch
            {
                OutputScaleTo.x1080 => "1080",
                OutputScaleTo.x4k => "4k",
                OutputScaleTo.Hd => "hd",
                OutputScaleTo.Mobile => "mobile",
                OutputScaleTo.Preview => "preview",
                OutputScaleTo.Sd => "sd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputScaleTo? ToEnum(string value)
        {
            return value switch
            {
                "1080" => OutputScaleTo.x1080,
                "4k" => OutputScaleTo.x4k,
                "hd" => OutputScaleTo.Hd,
                "mobile" => OutputScaleTo.Mobile,
                "preview" => OutputScaleTo.Preview,
                "sd" => OutputScaleTo.Sd,
                _ => null,
            };
        }
    }
}