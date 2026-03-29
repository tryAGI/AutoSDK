//HintName: G.Models.VariableChannel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VariableChannel
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Feishu,
        /// <summary>
        /// 
        /// </summary>
        Location,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VariableChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VariableChannel value)
        {
            return value switch
            {
                VariableChannel.App => "app",
                VariableChannel.Custom => "custom",
                VariableChannel.Feishu => "feishu",
                VariableChannel.Location => "location",
                VariableChannel.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VariableChannel? ToEnum(string value)
        {
            return value switch
            {
                "app" => VariableChannel.App,
                "custom" => VariableChannel.Custom,
                "feishu" => VariableChannel.Feishu,
                "location" => VariableChannel.Location,
                "system" => VariableChannel.System,
                _ => null,
            };
        }
    }
}