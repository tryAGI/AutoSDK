﻿//HintName: G.Models.EndPollBodyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status to set the poll to. Possible case-sensitive values are:  <br/>
    ///   <br/>
    /// * TERMINATED — Ends the poll before the poll is scheduled to end. The poll remains publicly visible.<br/>
    /// * ARCHIVED — Ends the poll before the poll is scheduled to end, and then archives it so it's no longer publicly visible.
    /// </summary>
    public enum EndPollBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        TERMINATED,
        /// <summary>
        /// 
        /// </summary>
        ARCHIVED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndPollBodyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndPollBodyStatus value)
        {
            return value switch
            {
                EndPollBodyStatus.TERMINATED => "TERMINATED",
                EndPollBodyStatus.ARCHIVED => "ARCHIVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndPollBodyStatus? ToEnum(string value)
        {
            return value switch
            {
                "TERMINATED" => EndPollBodyStatus.TERMINATED,
                "ARCHIVED" => EndPollBodyStatus.ARCHIVED,
                _ => null,
            };
        }
    }
}