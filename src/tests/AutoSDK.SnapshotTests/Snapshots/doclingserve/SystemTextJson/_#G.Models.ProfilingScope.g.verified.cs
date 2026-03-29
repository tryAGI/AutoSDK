//HintName: G.Models.ProfilingScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilingScope
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Page,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilingScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilingScope value)
        {
            return value switch
            {
                ProfilingScope.Document => "document",
                ProfilingScope.Page => "page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilingScope? ToEnum(string value)
        {
            return value switch
            {
                "document" => ProfilingScope.Document,
                "page" => ProfilingScope.Page,
                _ => null,
            };
        }
    }
}