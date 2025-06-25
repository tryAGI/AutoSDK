﻿//HintName: G.Models.RunObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `thread.run`.
    /// </summary>
    public enum RunObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunObjectObject value)
        {
            return value switch
            {
                RunObjectObject.ThreadRun => "thread.run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "thread.run" => RunObjectObject.ThreadRun,
                _ => null,
            };
        }
    }
}