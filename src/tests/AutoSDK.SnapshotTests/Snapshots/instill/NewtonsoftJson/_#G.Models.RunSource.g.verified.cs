//HintName: G.Models.RunSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RunSource defines the source of a pipeline or model run.<br/>
    ///  - RUN_SOURCE_CONSOLE: Run from frontend UI.<br/>
    ///  - RUN_SOURCE_API: Run from API or SDK.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunSource
    {
        /// <summary>
        /// Run from frontend UI.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUN_SOURCE_CONSOLE")]
        CONSOLE,
        /// <summary>
        /// Run from API or SDK.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUN_SOURCE_API")]
        API,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunSource value)
        {
            return value switch
            {
                RunSource.CONSOLE => "RUN_SOURCE_CONSOLE",
                RunSource.API => "RUN_SOURCE_API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunSource? ToEnum(string value)
        {
            return value switch
            {
                "RUN_SOURCE_CONSOLE" => RunSource.CONSOLE,
                "RUN_SOURCE_API" => RunSource.API,
                _ => null,
            };
        }
    }
}