﻿//HintName: G.Models.View.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// View defines how a model definition is presented.<br/>
    ///  - VIEW_BASIC: Default view, only includes basic information (omits `model_spec`).<br/>
    ///  - VIEW_FULL: Full representation.
    /// </summary>
    public enum View
    {
        /// <summary>
        /// Default view, only includes basic information (omits `model_spec`).
        /// </summary>
        BASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        FULL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this View value)
        {
            return value switch
            {
                View.BASIC => "VIEW_BASIC",
                View.FULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static View? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => View.BASIC,
                "VIEW_FULL" => View.FULL,
                _ => null,
            };
        }
    }
}