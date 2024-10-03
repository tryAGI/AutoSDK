//HintName: G.Models.NodesGetClassOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: minimal
    /// </summary>
    public enum NodesGetClassOutput
    {
        /// <summary>
        /// 
        /// </summary>
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        Verbose,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodesGetClassOutputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodesGetClassOutput value)
        {
            return value switch
            {
                NodesGetClassOutput.Minimal => "minimal",
                NodesGetClassOutput.Verbose => "verbose",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodesGetClassOutput? ToEnum(string value)
        {
            return value switch
            {
                "minimal" => NodesGetClassOutput.Minimal,
                "verbose" => NodesGetClassOutput.Verbose,
                _ => null,
            };
        }
    }
}