//HintName: G.Models.CreateBashToolDTOName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'bash'<br/>
    /// Default Value: bash
    /// </summary>
    public enum CreateBashToolDTOName
    {
        /// <summary>
        /// 
        /// </summary>
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBashToolDTONameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBashToolDTOName value)
        {
            return value switch
            {
                CreateBashToolDTOName.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBashToolDTOName? ToEnum(string value)
        {
            return value switch
            {
                "bash" => CreateBashToolDTOName.Bash,
                _ => null,
            };
        }
    }
}