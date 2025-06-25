﻿//HintName: G.Models.ListVectorStoresOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListVectorStoresOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVectorStoresOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVectorStoresOrder value)
        {
            return value switch
            {
                ListVectorStoresOrder.Asc => "asc",
                ListVectorStoresOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVectorStoresOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListVectorStoresOrder.Asc,
                "desc" => ListVectorStoresOrder.Desc,
                _ => null,
            };
        }
    }
}