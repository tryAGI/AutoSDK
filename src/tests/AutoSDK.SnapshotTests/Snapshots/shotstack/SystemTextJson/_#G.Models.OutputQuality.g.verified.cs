//HintName: G.Models.OutputQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Adjust the output quality of the video, image or audio. Adjusting quality affects  render speed, download speeds and storage requirements due to file size. The default `medium` provides the most optimized choice for all three  factors. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`verylow` - reduced quality, smallest file size&lt;/li&gt;<br/>
    ///   &lt;li&gt;`low` - slightly reduced quality, smaller file size&lt;/li&gt;<br/>
    ///   &lt;li&gt;`medium` (default) - optimized quality, render speeds and file size&lt;/li&gt;<br/>
    ///   &lt;li&gt;`high` - slightly increased quality, larger file size&lt;/li&gt;<br/>
    ///   &lt;li&gt;`veryhigh` - highest quality, largest file size&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: medium
    /// </summary>
    public enum OutputQuality
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Veryhigh,
        /// <summary>
        /// 
        /// </summary>
        Verylow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputQuality value)
        {
            return value switch
            {
                OutputQuality.High => "high",
                OutputQuality.Low => "low",
                OutputQuality.Medium => "medium",
                OutputQuality.Veryhigh => "veryhigh",
                OutputQuality.Verylow => "verylow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => OutputQuality.High,
                "low" => OutputQuality.Low,
                "medium" => OutputQuality.Medium,
                "veryhigh" => OutputQuality.Veryhigh,
                "verylow" => OutputQuality.Verylow,
                _ => null,
            };
        }
    }
}