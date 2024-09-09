//HintName: G.Models.OrgsListPatGrantsDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum OrgsListPatGrantsDirection
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
    public static class OrgsListPatGrantsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListPatGrantsDirection value)
        {
            return value switch
            {
                OrgsListPatGrantsDirection.Asc => "asc",
                OrgsListPatGrantsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListPatGrantsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => OrgsListPatGrantsDirection.Asc,
                "desc" => OrgsListPatGrantsDirection.Desc,
                _ => null,
            };
        }
    }
}