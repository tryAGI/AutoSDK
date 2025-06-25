﻿//HintName: G.Models.ObjectsClassDeleteConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsClassDeleteConsistencyLevel
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
    public static class ObjectsClassDeleteConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassDeleteConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassDeleteConsistencyLevel.ONE => "ONE",
                ObjectsClassDeleteConsistencyLevel.QUORUM => "QUORUM",
                ObjectsClassDeleteConsistencyLevel.ALL => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassDeleteConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassDeleteConsistencyLevel.ONE,
                "QUORUM" => ObjectsClassDeleteConsistencyLevel.QUORUM,
                "ALL" => ObjectsClassDeleteConsistencyLevel.ALL,
                _ => null,
            };
        }
    }
}