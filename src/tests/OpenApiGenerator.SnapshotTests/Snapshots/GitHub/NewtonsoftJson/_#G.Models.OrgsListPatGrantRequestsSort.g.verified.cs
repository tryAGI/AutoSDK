//HintName: G.Models.OrgsListPatGrantRequestsSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsListPatGrantRequestsSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsListPatGrantRequestsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListPatGrantRequestsSort value)
        {
            return value switch
            {
                OrgsListPatGrantRequestsSort.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListPatGrantRequestsSort? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => OrgsListPatGrantRequestsSort.CreatedAt,
                _ => null,
            };
        }
    }
}