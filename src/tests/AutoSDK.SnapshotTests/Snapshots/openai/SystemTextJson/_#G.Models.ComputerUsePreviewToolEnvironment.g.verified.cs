//HintName: G.Models.ComputerUsePreviewToolEnvironment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of computer environment to control.
    /// </summary>
    public enum ComputerUsePreviewToolEnvironment
    {
        /// <summary>
        /// 
        /// </summary>
        Windows,
        /// <summary>
        /// 
        /// </summary>
        Mac,
        /// <summary>
        /// 
        /// </summary>
        Linux,
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
    public static class ComputerUsePreviewToolEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUsePreviewToolEnvironment value)
        {
            return value switch
            {
                ComputerUsePreviewToolEnvironment.Windows => "windows",
                ComputerUsePreviewToolEnvironment.Mac => "mac",
                ComputerUsePreviewToolEnvironment.Linux => "linux",
                ComputerUsePreviewToolEnvironment.Ubuntu => "ubuntu",
                ComputerUsePreviewToolEnvironment.Browser => "browser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUsePreviewToolEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "windows" => ComputerUsePreviewToolEnvironment.Windows,
                "mac" => ComputerUsePreviewToolEnvironment.Mac,
                "linux" => ComputerUsePreviewToolEnvironment.Linux,
                "ubuntu" => ComputerUsePreviewToolEnvironment.Ubuntu,
                "browser" => ComputerUsePreviewToolEnvironment.Browser,
                _ => null,
            };
        }
    }
}