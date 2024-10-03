//HintName: G.Models.BatchDeleteResponseOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls the verbosity of the output.<br/>
    /// Default Value: minimal
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchDeleteResponseOutput
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
    public static class BatchDeleteResponseOutputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchDeleteResponseOutput value)
        {
            return value switch
            {
                BatchDeleteResponseOutput.Minimal => "minimal",
                BatchDeleteResponseOutput.Verbose => "verbose",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchDeleteResponseOutput? ToEnum(string value)
        {
            return value switch
            {
                "minimal" => BatchDeleteResponseOutput.Minimal,
                "verbose" => BatchDeleteResponseOutput.Verbose,
                _ => null,
            };
        }
    }
}