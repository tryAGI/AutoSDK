//HintName: G.Models.BashToolWithToolCallName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'bash'<br/>
    /// Default Value: bash
    /// </summary>
    public enum BashToolWithToolCallName
    {
        /// <summary>
        /// 
        /// </summary>
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashToolWithToolCallNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashToolWithToolCallName value)
        {
            return value switch
            {
                BashToolWithToolCallName.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashToolWithToolCallName? ToEnum(string value)
        {
            return value switch
            {
                "bash" => BashToolWithToolCallName.Bash,
                _ => null,
            };
        }
    }
}