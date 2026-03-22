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
    public static class ComputerUsePreviewToolEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUsePreviewToolEnvironment value)
        {
            return value switch
            {
                ComputerUsePreviewToolEnvironment.Browser => "browser",
                ComputerUsePreviewToolEnvironment.Linux => "linux",
                ComputerUsePreviewToolEnvironment.Mac => "mac",
                ComputerUsePreviewToolEnvironment.Ubuntu => "ubuntu",
                ComputerUsePreviewToolEnvironment.Windows => "windows",
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
                "browser" => ComputerUsePreviewToolEnvironment.Browser,
                "linux" => ComputerUsePreviewToolEnvironment.Linux,
                "mac" => ComputerUsePreviewToolEnvironment.Mac,
                "ubuntu" => ComputerUsePreviewToolEnvironment.Ubuntu,
                "windows" => ComputerUsePreviewToolEnvironment.Windows,
                _ => null,
            };
        }
    }
}