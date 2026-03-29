//HintName: G.Models.Sort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The attribute to use to sort results
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Sort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sort value)
        {
            return value switch
            {
                Sort.Created => "created",
                Sort.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sort? ToEnum(string value)
        {
            return value switch
            {
                "created" => Sort.Created,
                "name" => Sort.Name,
                _ => null,
            };
        }
    }
}