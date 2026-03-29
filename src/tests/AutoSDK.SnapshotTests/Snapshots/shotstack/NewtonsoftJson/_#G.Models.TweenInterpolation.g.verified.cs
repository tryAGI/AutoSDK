//HintName: G.Models.TweenInterpolation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The interpolation method to use for the animation. Available options are: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`linear` - a linear interpolation between the start and end values.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`bezier` - a bezier curve interpolation between the start and end values.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`constant` - an interpolation where the property instantly jumps from the start to the end value, without any gradual transition.&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: bezier
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TweenInterpolation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bezier")]
        Bezier,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="constant")]
        Constant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="linear")]
        Linear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TweenInterpolationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TweenInterpolation value)
        {
            return value switch
            {
                TweenInterpolation.Bezier => "bezier",
                TweenInterpolation.Constant => "constant",
                TweenInterpolation.Linear => "linear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TweenInterpolation? ToEnum(string value)
        {
            return value switch
            {
                "bezier" => TweenInterpolation.Bezier,
                "constant" => TweenInterpolation.Constant,
                "linear" => TweenInterpolation.Linear,
                _ => null,
            };
        }
    }
}