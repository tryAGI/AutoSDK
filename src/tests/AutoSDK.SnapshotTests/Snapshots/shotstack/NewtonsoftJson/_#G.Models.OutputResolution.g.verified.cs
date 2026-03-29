//HintName: G.Models.OutputResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The preset output resolution of the video or image. For custom sizes use the `size` property. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`preview` - 512px x 288px @ 15fps&lt;/li&gt;<br/>
    ///   &lt;li&gt;`mobile` - 640px x 360px @ 25fps&lt;/li&gt;<br/>
    ///   &lt;li&gt;`sd` - 1024px x 576px @ 25fps&lt;/li&gt;<br/>
    ///   &lt;li&gt;`hd` - 1280px x 720px @ 25fps&lt;/li&gt;<br/>
    ///   &lt;li&gt;`1080` - 1920px x 1080px @ 25fps&lt;/li&gt;<br/>
    ///   &lt;li&gt;`4k` - 3840px x 2160px @ 25fps&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: hd
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputResolution
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
    public static class OutputResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputResolution value)
        {
            return value switch
            {
                OutputResolution.x1080 => "1080",
                OutputResolution.x4k => "4k",
                OutputResolution.Hd => "hd",
                OutputResolution.Mobile => "mobile",
                OutputResolution.Preview => "preview",
                OutputResolution.Sd => "sd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080" => OutputResolution.x1080,
                "4k" => OutputResolution.x4k,
                "hd" => OutputResolution.Hd,
                "mobile" => OutputResolution.Mobile,
                "preview" => OutputResolution.Preview,
                "sd" => OutputResolution.Sd,
                _ => null,
            };
        }
    }
}