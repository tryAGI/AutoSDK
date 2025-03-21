﻿//HintName: G.Models.ObjectsClassHeadConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObjectsClassHeadConsistencyLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ONE")]
        ONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUORUM")]
        QUORUM,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALL")]
        ALL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectsClassHeadConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassHeadConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassHeadConsistencyLevel.ONE => "ONE",
                ObjectsClassHeadConsistencyLevel.QUORUM => "QUORUM",
                ObjectsClassHeadConsistencyLevel.ALL => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassHeadConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassHeadConsistencyLevel.ONE,
                "QUORUM" => ObjectsClassHeadConsistencyLevel.QUORUM,
                "ALL" => ObjectsClassHeadConsistencyLevel.ALL,
                _ => null,
            };
        }
    }
}