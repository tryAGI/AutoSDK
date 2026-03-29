//HintName: G.Models.BashToolName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'bash'<br/>
    /// Default Value: bash
    /// </summary>
    public enum BashToolName
    {
        /// <summary>
        /// 
        /// </summary>
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashToolNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashToolName value)
        {
            return value switch
            {
                BashToolName.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashToolName? ToEnum(string value)
        {
            return value switch
            {
                "bash" => BashToolName.Bash,
                _ => null,
            };
        }
    }
}