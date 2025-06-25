﻿//HintName: G.Models.NodesGetOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: minimal
    /// </summary>
    public enum NodesGetOutput
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
    public static class NodesGetOutputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodesGetOutput value)
        {
            return value switch
            {
                NodesGetOutput.Minimal => "minimal",
                NodesGetOutput.Verbose => "verbose",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodesGetOutput? ToEnum(string value)
        {
            return value switch
            {
                "minimal" => NodesGetOutput.Minimal,
                "verbose" => NodesGetOutput.Verbose,
                _ => null,
            };
        }
    }
}