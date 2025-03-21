//HintName: G.Models.ComputerToolEnvironment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of computer environment to control.
    /// </summary>
    public enum ComputerToolEnvironment
    {
        /// <summary>
        /// 
        /// </summary>
        Mac,
        /// <summary>
        /// 
        /// </summary>
        Windows,
        /// <summary>
        /// 
        /// </summary>
        Ubuntu,
        /// <summary>
        /// 
        /// </summary>
        Browser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerToolEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerToolEnvironment value)
        {
            return value switch
            {
                ComputerToolEnvironment.Mac => "mac",
                ComputerToolEnvironment.Windows => "windows",
                ComputerToolEnvironment.Ubuntu => "ubuntu",
                ComputerToolEnvironment.Browser => "browser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerToolEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "mac" => ComputerToolEnvironment.Mac,
                "windows" => ComputerToolEnvironment.Windows,
                "ubuntu" => ComputerToolEnvironment.Ubuntu,
                "browser" => ComputerToolEnvironment.Browser,
                _ => null,
            };
        }
    }
}