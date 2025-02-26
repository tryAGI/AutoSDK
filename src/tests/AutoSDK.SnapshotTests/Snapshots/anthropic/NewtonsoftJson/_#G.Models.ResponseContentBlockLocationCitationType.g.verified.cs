//HintName: G.Models.ResponseContentBlockLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: content_block_location
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseContentBlockLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_location")]
        ContentBlockLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseContentBlockLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseContentBlockLocationCitationType value)
        {
            return value switch
            {
                ResponseContentBlockLocationCitationType.ContentBlockLocation => "content_block_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseContentBlockLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_location" => ResponseContentBlockLocationCitationType.ContentBlockLocation,
                _ => null,
            };
        }
    }
}