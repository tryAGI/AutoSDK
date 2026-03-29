//HintName: G.Models.ComputerUseServerToolEnvironment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComputerUseServerToolEnvironment
    {
        /// <summary>
        /// 
        /// </summary>
        Browser,
        /// <summary>
        /// 
        /// </summary>
        Linux,
        /// <summary>
        /// 
        /// </summary>
        Mac,
        /// <summary>
        /// 
        /// </summary>
        Ubuntu,
        /// <summary>
        /// 
        /// </summary>
        Windows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseServerToolEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseServerToolEnvironment value)
        {
            return value switch
            {
                ComputerUseServerToolEnvironment.Browser => "browser",
                ComputerUseServerToolEnvironment.Linux => "linux",
                ComputerUseServerToolEnvironment.Mac => "mac",
                ComputerUseServerToolEnvironment.Ubuntu => "ubuntu",
                ComputerUseServerToolEnvironment.Windows => "windows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseServerToolEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "browser" => ComputerUseServerToolEnvironment.Browser,
                "linux" => ComputerUseServerToolEnvironment.Linux,
                "mac" => ComputerUseServerToolEnvironment.Mac,
                "ubuntu" => ComputerUseServerToolEnvironment.Ubuntu,
                "windows" => ComputerUseServerToolEnvironment.Windows,
                _ => null,
            };
        }
    }
}