//HintName: G.Models.UpdateBashToolDTOName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'bash'<br/>
    /// Default Value: bash
    /// </summary>
    public enum UpdateBashToolDTOName
    {
        /// <summary>
        /// 
        /// </summary>
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateBashToolDTONameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBashToolDTOName value)
        {
            return value switch
            {
                UpdateBashToolDTOName.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBashToolDTOName? ToEnum(string value)
        {
            return value switch
            {
                "bash" => UpdateBashToolDTOName.Bash,
                _ => null,
            };
        }
    }
}