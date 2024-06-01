//HintName: G.Models.ActionsGetActionsCacheListDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum ActionsGetActionsCacheListDirection
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
    public static class ActionsGetActionsCacheListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsGetActionsCacheListDirection value)
        {
            return value switch
            {
                ActionsGetActionsCacheListDirection.Asc => "asc",
                ActionsGetActionsCacheListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsGetActionsCacheListDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => ActionsGetActionsCacheListDirection.Asc,
                "desc" => ActionsGetActionsCacheListDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}