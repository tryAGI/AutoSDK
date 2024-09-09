//HintName: G.Models.OrgsListPatGrantRequestsDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum OrgsListPatGrantRequestsDirection
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
    public static class OrgsListPatGrantRequestsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListPatGrantRequestsDirection value)
        {
            return value switch
            {
                OrgsListPatGrantRequestsDirection.Asc => "asc",
                OrgsListPatGrantRequestsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListPatGrantRequestsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => OrgsListPatGrantRequestsDirection.Asc,
                "desc" => OrgsListPatGrantRequestsDirection.Desc,
                _ => null,
            };
        }
    }
}