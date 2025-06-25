﻿//HintName: G.Models.DependencyRelationship.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency.<br/>
    /// Example: direct
    /// </summary>
    public enum DependencyRelationship
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Indirect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependencyRelationshipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependencyRelationship value)
        {
            return value switch
            {
                DependencyRelationship.Direct => "direct",
                DependencyRelationship.Indirect => "indirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependencyRelationship? ToEnum(string value)
        {
            return value switch
            {
                "direct" => DependencyRelationship.Direct,
                "indirect" => DependencyRelationship.Indirect,
                _ => null,
            };
        }
    }
}