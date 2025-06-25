﻿//HintName: G.Models.BatchObjectsDeleteConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum BatchObjectsDeleteConsistencyLevel
    {
        /// <summary>
        /// 
        /// </summary>
        ONE,
        /// <summary>
        /// 
        /// </summary>
        QUORUM,
        /// <summary>
        /// 
        /// </summary>
        ALL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectsDeleteConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectsDeleteConsistencyLevel value)
        {
            return value switch
            {
                BatchObjectsDeleteConsistencyLevel.ONE => "ONE",
                BatchObjectsDeleteConsistencyLevel.QUORUM => "QUORUM",
                BatchObjectsDeleteConsistencyLevel.ALL => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectsDeleteConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => BatchObjectsDeleteConsistencyLevel.ONE,
                "QUORUM" => BatchObjectsDeleteConsistencyLevel.QUORUM,
                "ALL" => BatchObjectsDeleteConsistencyLevel.ALL,
                _ => null,
            };
        }
    }
}