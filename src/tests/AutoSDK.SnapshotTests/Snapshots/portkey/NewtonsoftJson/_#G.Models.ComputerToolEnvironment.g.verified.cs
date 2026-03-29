//HintName: G.Models.ComputerToolEnvironment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of computer environment to control.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ComputerToolEnvironment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="browser")]
        Browser,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mac")]
        Mac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ubuntu")]
        Ubuntu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="windows")]
        Windows,
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
                ComputerToolEnvironment.Browser => "browser",
                ComputerToolEnvironment.Mac => "mac",
                ComputerToolEnvironment.Ubuntu => "ubuntu",
                ComputerToolEnvironment.Windows => "windows",
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
                "browser" => ComputerToolEnvironment.Browser,
                "mac" => ComputerToolEnvironment.Mac,
                "ubuntu" => ComputerToolEnvironment.Ubuntu,
                "windows" => ComputerToolEnvironment.Windows,
                _ => null,
            };
        }
    }
}