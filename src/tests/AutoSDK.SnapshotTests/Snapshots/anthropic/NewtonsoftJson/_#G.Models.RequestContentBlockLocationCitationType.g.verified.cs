//HintName: G.Models.RequestContentBlockLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestContentBlockLocationCitationType
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
    public static class RequestContentBlockLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestContentBlockLocationCitationType value)
        {
            return value switch
            {
                RequestContentBlockLocationCitationType.ContentBlockLocation => "content_block_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestContentBlockLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_location" => RequestContentBlockLocationCitationType.ContentBlockLocation,
                _ => null,
            };
        }
    }
}