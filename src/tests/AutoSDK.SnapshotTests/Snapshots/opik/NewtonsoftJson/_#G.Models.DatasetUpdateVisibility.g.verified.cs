//HintName: G.Models.DatasetUpdateVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetUpdateVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetUpdateVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetUpdateVisibility value)
        {
            return value switch
            {
                DatasetUpdateVisibility.Private => "private",
                DatasetUpdateVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetUpdateVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => DatasetUpdateVisibility.Private,
                "public" => DatasetUpdateVisibility.Public,
                _ => null,
            };
        }
    }
}