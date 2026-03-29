//HintName: G.Models.TitleAssetSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set the relative size of the text using predefined sizes from xx-small to xx-large. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`xx-small`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`x-small`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`small`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`medium`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`large`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`x-large`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`xx-large`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public enum TitleAssetSize
    {
        /// <summary>
        /// 
        /// </summary>
        Large,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Small,
        /// <summary>
        /// 
        /// </summary>
        XLarge,
        /// <summary>
        /// 
        /// </summary>
        XSmall,
        /// <summary>
        /// 
        /// </summary>
        XxLarge,
        /// <summary>
        /// 
        /// </summary>
        XxSmall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TitleAssetSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TitleAssetSize value)
        {
            return value switch
            {
                TitleAssetSize.Large => "large",
                TitleAssetSize.Medium => "medium",
                TitleAssetSize.Small => "small",
                TitleAssetSize.XLarge => "x-large",
                TitleAssetSize.XSmall => "x-small",
                TitleAssetSize.XxLarge => "xx-large",
                TitleAssetSize.XxSmall => "xx-small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TitleAssetSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => TitleAssetSize.Large,
                "medium" => TitleAssetSize.Medium,
                "small" => TitleAssetSize.Small,
                "x-large" => TitleAssetSize.XLarge,
                "x-small" => TitleAssetSize.XSmall,
                "xx-large" => TitleAssetSize.XxLarge,
                "xx-small" => TitleAssetSize.XxSmall,
                _ => null,
            };
        }
    }
}