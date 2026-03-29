//HintName: G.Models.OutputAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aspect ratio (shape) of the video or image. Useful for social media output formats. Options are: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`16:9` (default) - regular landscape/horizontal aspect ratio&lt;/li&gt;<br/>
    ///   &lt;li&gt;`9:16` - vertical/portrait aspect ratio&lt;/li&gt;<br/>
    ///   &lt;li&gt;`1:1` - square aspect ratio&lt;/li&gt;<br/>
    ///   &lt;li&gt;`4:5` - short vertical/portrait aspect ratio&lt;/li&gt;<br/>
    ///   &lt;li&gt;`4:3` - legacy TV aspect ratio&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: 16:9
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputAspectRatio
    {
        /// <summary>
        /// 9` (default) - regular landscape/horizontal aspect ratio&lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="16:9")]
        x16_9,
        /// <summary>
        /// 1` - square aspect ratio&lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1:1")]
        x1_1,
        /// <summary>
        /// 3` - legacy TV aspect ratio&lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="4:3")]
        x4_3,
        /// <summary>
        /// 5` - short vertical/portrait aspect ratio&lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="4:5")]
        x4_5,
        /// <summary>
        /// 16` - vertical/portrait aspect ratio&lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="9:16")]
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputAspectRatio value)
        {
            return value switch
            {
                OutputAspectRatio.x16_9 => "16:9",
                OutputAspectRatio.x1_1 => "1:1",
                OutputAspectRatio.x4_3 => "4:3",
                OutputAspectRatio.x4_5 => "4:5",
                OutputAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => OutputAspectRatio.x16_9,
                "1:1" => OutputAspectRatio.x1_1,
                "4:3" => OutputAspectRatio.x4_3,
                "4:5" => OutputAspectRatio.x4_5,
                "9:16" => OutputAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}