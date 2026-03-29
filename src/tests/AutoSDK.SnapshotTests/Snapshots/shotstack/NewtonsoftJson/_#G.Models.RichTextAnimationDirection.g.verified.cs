//HintName: G.Models.RichTextAnimationDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Direction for directional animations. Required for slideIn, ascend, shift, and movingLetters presets. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`ascend` - supports: up, down&lt;/li&gt;<br/>
    ///   &lt;li&gt;`shift` - supports: left, right, up, down&lt;/li&gt;<br/>
    ///   &lt;li&gt;`slideIn` - supports: left, right, up, down&lt;/li&gt;<br/>
    ///   &lt;li&gt;`movingLetters` - supports: left, right, up, down&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: up
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RichTextAnimationDirection
    {
        /// <summary>
        /// up, down&lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="down")]
        Down,
        /// <summary>
        /// left, right, up, down&lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="left")]
        Left,
        /// <summary>
        /// left, right, up, down&lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="right")]
        Right,
        /// <summary>
        /// up, down&lt;/li&gt;
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="up")]
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichTextAnimationDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextAnimationDirection value)
        {
            return value switch
            {
                RichTextAnimationDirection.Down => "down",
                RichTextAnimationDirection.Left => "left",
                RichTextAnimationDirection.Right => "right",
                RichTextAnimationDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextAnimationDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => RichTextAnimationDirection.Down,
                "left" => RichTextAnimationDirection.Left,
                "right" => RichTextAnimationDirection.Right,
                "up" => RichTextAnimationDirection.Up,
                _ => null,
            };
        }
    }
}