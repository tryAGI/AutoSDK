//HintName: G.Models.BatchDeleteOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls the verbosity of the output.<br/>
    /// Default Value: minimal
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchDeleteOutput
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
    public static class BatchDeleteOutputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchDeleteOutput value)
        {
            return value switch
            {
                BatchDeleteOutput.Minimal => "minimal",
                BatchDeleteOutput.Verbose => "verbose",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchDeleteOutput? ToEnum(string value)
        {
            return value switch
            {
                "minimal" => BatchDeleteOutput.Minimal,
                "verbose" => BatchDeleteOutput.Verbose,
                _ => null,
            };
        }
    }
}