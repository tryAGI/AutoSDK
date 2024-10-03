//HintName: G.Models.NodesGetClassOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: minimal
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NodesGetClassOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimal")]
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="verbose")]
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