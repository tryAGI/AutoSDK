//HintName: G.Models.TitleAssetStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Uses a preset to apply font properties and styling to the title. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`minimal`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`blockbuster`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`vogue`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`sketchy`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`skinny`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`chunk`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`chunkLight`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`marker`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`future`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`subtitle`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TitleAssetStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blockbuster")]
        Blockbuster,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chunk")]
        Chunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chunkLight")]
        ChunkLight,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="future")]
        Future,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marker")]
        Marker,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimal")]
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sketchy")]
        Sketchy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skinny")]
        Skinny,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subtitle")]
        Subtitle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vogue")]
        Vogue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TitleAssetStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TitleAssetStyle value)
        {
            return value switch
            {
                TitleAssetStyle.Blockbuster => "blockbuster",
                TitleAssetStyle.Chunk => "chunk",
                TitleAssetStyle.ChunkLight => "chunkLight",
                TitleAssetStyle.Future => "future",
                TitleAssetStyle.Marker => "marker",
                TitleAssetStyle.Minimal => "minimal",
                TitleAssetStyle.Sketchy => "sketchy",
                TitleAssetStyle.Skinny => "skinny",
                TitleAssetStyle.Subtitle => "subtitle",
                TitleAssetStyle.Vogue => "vogue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TitleAssetStyle? ToEnum(string value)
        {
            return value switch
            {
                "blockbuster" => TitleAssetStyle.Blockbuster,
                "chunk" => TitleAssetStyle.Chunk,
                "chunkLight" => TitleAssetStyle.ChunkLight,
                "future" => TitleAssetStyle.Future,
                "marker" => TitleAssetStyle.Marker,
                "minimal" => TitleAssetStyle.Minimal,
                "sketchy" => TitleAssetStyle.Sketchy,
                "skinny" => TitleAssetStyle.Skinny,
                "subtitle" => TitleAssetStyle.Subtitle,
                "vogue" => TitleAssetStyle.Vogue,
                _ => null,
            };
        }
    }
}