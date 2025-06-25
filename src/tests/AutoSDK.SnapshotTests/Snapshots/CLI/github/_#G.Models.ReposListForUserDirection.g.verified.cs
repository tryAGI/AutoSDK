﻿//HintName: G.Models.ReposListForUserDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReposListForUserDirection
    {
        /// <summary>
        /// `asc` when using `full_name`, otherwise `desc`.
        /// </summary>
        Asc,
        /// <summary>
        /// `asc` when using `full_name`, otherwise `desc`.
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListForUserDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForUserDirection value)
        {
            return value switch
            {
                ReposListForUserDirection.Asc => "asc",
                ReposListForUserDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForUserDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ReposListForUserDirection.Asc,
                "desc" => ReposListForUserDirection.Desc,
                _ => null,
            };
        }
    }
}