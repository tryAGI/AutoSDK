//HintName: G.Models.SvgStrokeLineJoin.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape at the corners where two lines meet.<br/>
    /// &lt;ul&gt;<br/>
    ///   &lt;li&gt;`miter` - sharp corner (default)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`round` - rounded corner&lt;/li&gt;<br/>
    ///   &lt;li&gt;`bevel` - flattened corner&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Default Value: miter<br/>
    /// Example: round
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SvgStrokeLineJoin
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bevel")]
        Bevel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="miter")]
        Miter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="round")]
        Round,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgStrokeLineJoinExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgStrokeLineJoin value)
        {
            return value switch
            {
                SvgStrokeLineJoin.Bevel => "bevel",
                SvgStrokeLineJoin.Miter => "miter",
                SvgStrokeLineJoin.Round => "round",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgStrokeLineJoin? ToEnum(string value)
        {
            return value switch
            {
                "bevel" => SvgStrokeLineJoin.Bevel,
                "miter" => SvgStrokeLineJoin.Miter,
                "round" => SvgStrokeLineJoin.Round,
                _ => null,
            };
        }
    }
}