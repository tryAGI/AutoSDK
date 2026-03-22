//HintName: G.Models.MagicPromptOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Determine if MagicPrompt should be used in generating the request or not<br/>
    /// Default Value: AUTO<br/>
    /// Example: ON
    /// </summary>
    public enum MagicPromptOption
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MagicPromptOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MagicPromptOption value)
        {
            return value switch
            {
                MagicPromptOption.Auto => "AUTO",
                MagicPromptOption.Off => "OFF",
                MagicPromptOption.On => "ON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MagicPromptOption? ToEnum(string value)
        {
            return value switch
            {
                "AUTO" => MagicPromptOption.Auto,
                "OFF" => MagicPromptOption.Off,
                "ON" => MagicPromptOption.On,
                _ => null,
            };
        }
    }
}