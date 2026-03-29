//HintName: G.Models.TextAnimationPreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The animation preset to apply. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`typewriter` - typewriter effect where characters appear one at a time&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: typewriter
    /// </summary>
    public enum TextAnimationPreset
    {
        /// <summary>
        /// 
        /// </summary>
        Typewriter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextAnimationPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextAnimationPreset value)
        {
            return value switch
            {
                TextAnimationPreset.Typewriter => "typewriter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextAnimationPreset? ToEnum(string value)
        {
            return value switch
            {
                "typewriter" => TextAnimationPreset.Typewriter,
                _ => null,
            };
        }
    }
}